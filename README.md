# Vidly

## Running the Application

* Create AppSettings.config on Vidly folder.
* Add the following code: 
  ```html
  <appSettings>
  <add key="FacebookAppId" value="INSERT_FACEBOOK_APP_ID_HERE"/>
  <add key="FacebookAppSecret" value="INSERT_FACEBOOK_APP_SECRET_HERE"/>
  <add key="webpages:Version" value="3.0.0.0" />
  <add key="webpages:Enabled" value="false" />
  <add key="ClientValidationEnabled" value="true" />
  <add key="UnobtrusiveJavaScriptEnabled" value="true" />
  </appSettings>
  ```
* Create a App at [Facebook](https://developers.facebook.com) and add Facebook login to your products.
* Replace FacebookAppId and FacebookAppSecret values with your new Apps values.
* Run the Application.
