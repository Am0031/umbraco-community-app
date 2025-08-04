namespace MyCustomUmbracoProject.ExternalUserLogin.GoogleAuthentication;

public static class GoogleAuthenticationExtensions
{
    public static IUmbracoBuilder AddGoogleAuthentication(this IUmbracoBuilder builder)
    {
        // Register ProviderBackOfficeExternalLoginProviderOptions here rather than require it in startup
        builder.Services.ConfigureOptions<GoogleBackOfficeExternalLoginProviderOptions>();

        builder.AddBackOfficeExternalLogins(logins =>
        {
            logins.AddBackOfficeLogin(
                backOfficeAuthenticationBuilder =>
                {
                    // The scheme must be set with this method to work for the back office
                    var schemeName =
                        backOfficeAuthenticationBuilder.SchemeForBackOffice(GoogleBackOfficeExternalLoginProviderOptions
                            .SchemeName);

                    ArgumentNullException.ThrowIfNull(schemeName);

                    backOfficeAuthenticationBuilder.AddGoogle(
                        schemeName,
                        options =>
                        {
                            // Callback path: Represents the URL to which the browser should be redirected to.
                            // The default value is '/signin-google'.
                            // The value here should match what you have configured in you external login provider.
                            // The value needs to be unique.
                            options.CallbackPath = "/umbraco-google-signin";
                            // Add options . Client Id here
                            //Add options . Client Secret here
                      //These are from my Google Project details generated while creating OAuth client ID
                        });
                });
        });
        return builder;
    }

}