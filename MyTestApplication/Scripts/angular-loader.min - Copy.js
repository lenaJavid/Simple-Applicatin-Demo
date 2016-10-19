﻿/**
 * @license AngularJS v1.5.8
 * (c) 2010-2016 Google, Inc. http://angularjs.org
 * License: MIT
 */
(function(){"use strict";function i(n){return typeof n=="function"}function r(n){var t=[];return JSON.stringify(n,function(n,i){if(i=toJsonReplacer(n,i),isObject(i)){if(t.indexOf(i)>=0)return"...";t.push(i)}return i})}function t(n){return typeof n=="function"?n.toString().replace(/ \{[\s\S]*$/,""):isUndefined(n)?"undefined":typeof n!="string"?r(n):n}function n(n,i){return i=i||Error,function(){var e=2,r=arguments,s=r[0],f="["+(n?n+":":"")+s+"] ",h=r[1],o,u;for(f+=h.replace(/\{\d+\}/g,function(n){var u=+n.slice(1,-1),i=u+e;return i<r.length?t(r[i]):n}),f+="\nhttp://errors.angularjs.org/1.5.8/"+(n?n+"/":"")+s,u=e,o="?";u<r.length;u++,o="&")f+=o+"p"+(u-e)+"="+encodeURIComponent(t(r[u]));return new i(f)}}function u(t){function r(n,t,i){return n[t]||(n[t]=i())}var f=n("$injector"),e=n("ng"),u=r(t,"angular",Object);return u.$$minErr=u.$$minErr||n,r(u,"module",function(){var n={};return function(t,u,o){var s=function(n,t){if(n==="hasOwnProperty")throw e("badname","hasOwnProperty is not a valid {0} name",t);};return s(t,"module"),u&&n.hasOwnProperty(t)&&(n[t]=null),r(n,t,function(){function s(n,t,i,u){return u||(u=r),function(){return u[i||"push"]([n,t,arguments]),e}}function n(n,u){return function(f,o){return o&&i(o)&&(o.$$moduleName=t),r.push([n,u,arguments]),e}}if(!u)throw f("nomod","Module '{0}' is not available! You either misspelled the module name or forgot to load it. If registering a module ensure that you specify the dependencies as the second argument.",t);var r=[],h=[],c=[],l=s("$injector","invoke","push",h),e={_invokeQueue:r,_configBlocks:h,_runBlocks:c,requires:u,name:t,provider:n("$provide","provider"),factory:n("$provide","factory"),service:n("$provide","service"),value:s("$provide","value"),constant:s("$provide","constant","unshift"),decorator:n("$provide","decorator"),animation:n("$animateProvider","register"),filter:n("$filterProvider","register"),controller:n("$controllerProvider","register"),directive:n("$compileProvider","directive"),component:n("$compileProvider","component"),config:l,run:function(n){return c.push(n),this}};return o&&l(o),e})}})}u(window)})(window);angular.Module;
//# sourceMappingURL=angular-loader.min.js.map
