# ROTPC website prototype

## Installation

- Clone the repo and open it with Visual Studio and install dependencies
- Set up the relevant secrets in Visual studio and in the solution files (google apis and google authentication)
- Set up a local SQL server
- Restore the local SQL database and adjust the connection string in the application file
- Run the application

## Pages screenshots - Public interface

<details>
<summary>Landing Page / Home page</summary>
<description>General intro text, with helpful sections such as: link to our online booking website, contact form, explore section for easy links to the most visited pages. To do: swap the upcoming meeting cards with an integrated calendar or pull the next few meetings using google calendar api in some ways.</description>

![landing-page](screenshots/landing-page.png)

</details>

### Menu sections

The council

<details>
<summary>The council - Responsibilities</summary>
<description>Description of the parish council responsibilities and what falls under the borough or county council.</description>

![council-responsibilities-page](screenshots/council-responsibilities.png)

</details>

<details>
<summary>The council - Assets</summary>
<description>View of our assets. To add: a map with pins for our assets, a link to parish online.</description>

![council-assets-page](screenshots/council-assets.png)

</details>

<details>
<summary>The council - Councillors</summary>
<description>View of our wards and list of councillors. Using Google drive api and the current councillor pics are dropped in the folder and named appropriately with firstname-lastname.jpg</description>

![council-councillors-page](screenshots/council-councillors.png)

</details>

<details>
<summary>The council - Meeting Schedule</summary>
<description>General description of our meeting schedule. To add: calendar integration with the public meeting calendar.</description>

![council-meeting-schedule-page](screenshots/council-meeting-schedule.png)

</details>

<details>
<summary>The council - Meeting documents</summary>
<description>List of meeting agendas and approved minutes. Using Google drive api and the files are dropped in the folder and named appropriately with {{date}}-{{committee}}-{{other}}.{{pdf or docx}}. Can also display additional lists from manually added links.</description>

![council-meeting-documents-page](screenshots/council-meeting-documents.png)

</details>

<details>
<summary>The council - Policies</summary>
<description>List of policies and other long standing council documents. Using Google drive api and the files are dropped in the folder and named appropriately with {{date}}-{{committee}}-{{other}}.{{pdf or docx}}. Can also display additional lists from manually added links.</description>

![council-policies-page](screenshots/council-policies.png)

</details>

Local information

<details>
<summary>Local information - Village History</summary>
<description>Paragraphs about the history of RoT. Static texts which doesn't normally change. Could add a few pictures.</description>

![local-info-history-page](screenshots/local-info-history.png)

</details>
<details>
<summary>Local information - Community groups</summary>
<description>List of community groups with general information and contact details for each groups. Edited periodically by staff.</description>

![local-info-community-groups-page](screenshots/local-info-community-groups.png)

</details>

<details>
<summary>Local information - RoT Cemetery</summary>
<description>General information about the cemerery rules and fees. To add: cemetery prices, as link or as table.</description>

![local-info-cemetery-page](screenshots/local-info-cemetery.png)

</details>

Our activities

<details>
<summary>Activities/News corner - Events</summary>
<description>General details about yearly events taking place in RoT, with council-led events and privately run events. Occasionally updated by staff. To add: a picture and a paragraph for each event</description>

![activities-events-page](screenshots/activities-events.png)

</details>
<details>
<summary>Activities/News corner - Village news</summary>
<description>List of posts about village news and events. This is the summary page and they can open each post to see the full content. To do: expand the post template to be able to add pictures and links properly.</description>

![activities-village-news-page](screenshots/activities-village-news.png)

</details>
<details>
<summary>Activities/News corner - Parish news</summary>
<description>List of posts about the parish council news. This is the summary page and they can open each post to see the full content. To do: expand the post template to be able to add pictures and links properly.</description>

![activities-parish-news-page](screenshots/activities-parish-news.png)

</details>
<details>
<summary>Activities/News corner - Public notices</summary>
<description>List of files that relate to works happeing in RoT. Received from the bourough council as PDF and shared with the public for information. using google drive api to render the list from a google drive folder, with the files named appropriately.Or can also add links manually in the back office and give them a clearer title.</description>

![activities-public-notices-page](screenshots/activities-public-notices.png)

</details>

## Pages screenshots - Back office

<details>
<summary>Back office - login</summary>
<description>Standard login page, with the ability to log in using google credentials.</description>

![backoffice-login-page](screenshots/backoffice-login.png)

</details>

<details>
<summary>Back office - Main page</summary>
<description>Standard view of the various pages, with the ability to browse page struture and reorganise sections.</description>

![backoffice-pages-page](screenshots/backoffice-pages.png)

</details>

<details>
<summary>Back office - News page layout</summary>
<description>Clean view of the news posts, with date and author, sorted by last created/amended.</description>

![backoffice-posts-page-page](screenshots/backoffice-posts-page.png)

</details>
<details>
<summary>Back office - News article form</summary>
<description>Fields included in a news article: rich text, image, link(s). Staff may use a mixture of these.</description>

![backoffice-posts-page-page](screenshots/backoffice-posts-fields.png)

</details>
