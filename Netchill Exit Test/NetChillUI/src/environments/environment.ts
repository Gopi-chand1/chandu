// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  apiURL:"http://localhost:41743/api/",
  production: false,
   firebaseConfig : {
    apiKey: "AIzaSyBrM3Oo4exm6NjZvkj_3njAZQc5xJDV_FI",
    authDomain: "netchill-ott.firebaseapp.com",
    projectId: "netchill-ott",
    storageBucket: "netchill-ott.appspot.com",
    messagingSenderId: "1080524481997",
    appId: "1:1080524481997:web:e8b11561c2a5710b791084"
  }


};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/plugins/zone-error';  // Included with Angular CLI.
