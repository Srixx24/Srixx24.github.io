@font-face {
	font-family: 'Pacifico';
	font-style: normal;
	font-weight: 400;
	src: local('Pacifico Regular'), local('Pacifico-Regular'), url("../fonts/pacifico.woff") format('woff');
}

html, body {
	margin: 0; 
	padding: 0;
}

::selection {
	background-color: #35405f;
	color: #fff;
}

*, *:active, *:focus, *:hover {
	outline: none;
}

h1, h2, h3, h4, h5,h6 {
	margin-top: 0;
}

body {
	font: 15px/23px "Lucida Sans","Liberation Sans","Lucida Sans Unicode","Lucida Grande",Verdana,Arial,Helvetica,sans-serif;
	background-color: rgb(224, 247, 246);

}

.btn {
	transition: 0.4s background linear;
}

.btn:focus
{
	color: #fff;
}

.block-heading {
	margin-bottom: 60px;
}

.block-heading p {
    font-size: 18px;
}

/* Header */

#header {
	background: url(../Images/Banner.png) no-repeat center top fixed;
	background-size: cover;
}

#site-header {
	position: fixed;
	width: 100%;
	/* background-color: #35405f; */
	background-color: rgba(144, 146, 153, 0.94);
	/* background-color: rgba(32, 178, 170, 0.86); */
	padding: 0 30px;
	z-index: 100;
}

#site-header h1 {
	margin: 0;
	font-family: 'Oswald', sans-serif;
	margin-top: 11px;
	font-size: 26px;
	font-weight: 300;
	letter-spacing: 2px;
}

#site-header h1 a:focus {
    text-decoration: none;
}

#site-header h1 a {
	color: #fff;
}

#site-header h1 a:hover {
	text-decoration: none;
}

/* Navigation */

.navbar {
	border-radius: 0;
	margin: 0;
	border: none;
}

.navbar-toggle {
	padding: 0;
	border: 0;
	color: #fff;
	margin-top: 13px;
}

.site-nav ul li a {
	color: #fff;
	font-size: 15px;
	font-family: 'Open Sans', sans-serif;
	position: relative;
	transition: 0.5s background linear;
}

.site-nav ul li a:hover, .site-nav ul li a:focus
{
	background-color: rgba(0, 255, 255, 0.58);
}

/* Blur styles */

#overlay-1 {
	/* background-color: rgba(32, 30, 30, 0.52); */
	background-color: rgba(33, 32, 42, 0.44);
	background: url(../Images/Banner.png) no-repeat center top fixed;
	/* background-color: rgba(17, 55, 46, 0.75); */
	position: relative;
}

.overlay-2 {
	padding: 60px 0;
	background-color: rgba(50, 81, 121, 0.6);
}

.overlay-3 {
	padding: 60px 0;
	/* background-color: rgba(9, 20, 39, 0.83); */
	/* background-color: rgba(24, 77, 77, 0.93); */
	background-color: rgba(33, 103, 88, 0.9);
}

.overlay {
    background: none repeat scroll 0 0 rgba(115, 224, 179, 0.72);
    width: 100%;
    height: 100%;
}


/* Home */

.middle {
	padding-top: 200px;
}

.pro-name {
    font-size: 100px;
    margin: 0;
    margin-bottom: 15px;  
    font-weight: 400;
    font-family: 'Rouge Script', cursive;
    line-height: 90px;
    color: #fff;
    letter-spacing: 1px;
    word-spacing: 6px;
    text-shadow: -2px -2px #000;
}

.tagline {
	font-size: 27px;
	margin-bottom: 60px;
	color: #fff;
	font-family: 'Roboto', sans-serif;
	font-weight: 300;
	line-height: 56px;
	word-spacing: 2px;
	text-shadow: 2px 2px #1C2725;
	letter-spacing: 2px;
	text-transform: capitalize;
}

.bottom {
	position: absolute;
	width: 100%;
	bottom: 4%;
}

.bottom a {
	color: #fff;
	display: inline-block;
	position: relative;
	top: 0px;
}

.btn-hire {
	text-transform: uppercase;
	color: #111;
	border: 1px solid rgb(136, 138, 145);
	font-family: 'Oxygen', sans-serif;
	font-weight: 300;
	word-spacing: 5px;
	letter-spacing: 1px;
	box-shadow: 0 3px 1px 0 rgba(20, 20, 26, 0.55);
	border-radius: 0;
	font-size: 18px;
	background-color: rgba(247, 255, 248, 1);
	padding: 16px 48px;
}

.btn-hire:hover {
	color: #fff;
	border: 1px solid #878A91;
	background-color: rgba(32, 36, 47, 0.94);
}

/* Projects */

#portfolio {
	padding: 60px 0;
}

#portfolio .block-heading h1 {
    color: rgb(0, 129, 129);
	
	font-weight: 400;
	
    font-size: 55px;
    font-family: 'Milonga', cursive;
}

.portfolio-item img {
	width: 100%;
}

.portfolio-items {
	margin-bottom: 60px;
}

.portfolio-item {
	position: relative;
}

.isotope:after {
  content: '';
  display: block;
  clear: both;
}

.element-item {
  position: relative;
  float: left;
  width: 25%;
  color: #262524;
}

.element-item > * {
  margin: 0;
  padding: 0;
}

.btn-view {
	/* border: 1px solid #35405f;
	color: #35405f;
	border-radius: 0; */
	text-transform: uppercase;
	color: lightseagreen;
	border: 1px solid rgba(32, 178, 170, 0.86);
	font-family: 'Oxygen', sans-serif;
	font-weight: 300;
	word-spacing: 5px;
	letter-spacing: 1px;
	border-radius: 0;
	font-size: 18px;
	padding: 16px 48px;
}

.btn-view:hover {
	color: #fff;
	border: 1px solid lightseagreen;
	background-color: rgba(32, 178, 170, 0.86);
}


/*  Image hover effect */


.effect-zoe:hover figcaption, 
.effect-zoe:hover h2, 
.effect-zoe:hover p.icon-links a{
	-webkit-transform: translate3d(0,0,0);
	transform: translate3d(0,0,0);
}
.effect-zoe h2 {
	display: inline-block;
}
.effect-zoe figcaption{
	top: auto;
	bottom: 0;
	padding: 1em;
	height: 3.75em;
	background: rgba(0,0,0,0.75);
	color: #3c4a50;
	-webkit-transition: -webkit-transform 0.35s;
	transition: transform 0.35s;
	-webkit-transform: translate3d(0,100%,0);
	transform: translate3d(0,100%,0);
}
.grid  figcaption, .grid  figcaption > a{
	position: absolute;
	top: 0;
	left: 0;
	width: 100%;
	height: 100%;
}
.grid  figcaption{
	padding: 2em;
	color: #fff;
	text-transform: uppercase;
	font-size: 1.25em;
	-webkit-backface-visibility: hidden;
	backface-visibility: hidden;
}
.grid .effect-zoe{
	position: relative;
	float: left;
	overflow: hidden;
	background: #3085a3;
	text-align: center;
	cursor: pointer;
}
.effect-zoe p.icon-links a i
{
	display: inline-block;
	padding: 30px 10px;
	color: cyan;
	font-size: 22px;
}

/* More About Me */

/* #resume {
	background: url(Images/.png) no-repeat center center fixed;
	background-size: cover;
	color: #fff;
}

.pro-stat {
	font-size: 20px;
	text-transform: uppercase;
	text-align: center;
	font-style: italic;
}

.proj-name {
	font-family: Pacifico;
	font-size: 150px;
	text-align: center;
	line-height: 90%;
	margin-bottom: 80px;
} */
#resume .block-heading h1 {
    color: #fff;
	
    font-family: 'Milonga', cursive;
	font-weight: 400;
	
    font-size: 55px;
	word-spacing: 5px;
}


/* Links */

#links {
    padding: 60px 0;
}

#links .block-heading{
	margin-bottom: 0px;
}

.links p {
    line-height: 34px;
    margin-top: 20px;
}

#links .block-heading h1
{
	color: rgb(0, 129, 129);
	font-family: 'Milonga', cursive;
	font-weight: 400;
	font-size: 55px;
}

#links .links {
	padding: 25px;
	cursor: -webkit-grab;
}

#links .links > img {
	border-radius: 100%;
	margin-bottom: 15px;
}

.social-box {
    list-style-type: none;
    padding-left: 71px;
    margin-top: 30px;
}

.social-box li {
    display: inline-block;
    margin-right: 10px;
}

.social-box li a {
	transition: 0.5s background linear;
	color: #fff;
}

.github-icon {
    padding: 10px 17px;
    border: 1px solid #44619D;
    background-color: #44619D;
}

.github-icon:hover {
    background-color: transparent;
    color: #fff;
}

.g-plus-icon {
	padding: 10px 15px;
	border: 1px solid #DD4C39;
	background-color: #DD4C39;
}

.g-plus-icon:hover {
	background-color: transparent;
	color: #fff;
}

.linkedin-icon {
	padding: 10px 15px;
	border: 1px solid #1B86BD;
	background-color: #1B86BD;
}

.linkedin-icon:hover {
	background-color: transparent;
	color: #fff;
}

/* Contact */

#contact {
	background: url(../Images/FooterImage.png) no-repeat center center fixed;
	background-size: cover;
	color: #000000;
}

#contact .block-heading h1
{
	color: #fff;
	font-family: 'Milonga', cursive;
	font-weight: 400;
	font-size: 55px;
}

.contact-info {
    padding: 16px 62px;
    text-align: left;
    font-size: 18px;
    line-height: 36px;
    margin-top: 25px;
}
.
.contact-info i {
    width: 40px;
	height: 40px;
	color: white;
	padding-top: 7px;
	font-size: 25px;
	border: 1px solid #fff;
	text-align: center;
	-webkit-transform: rotate(-45deg);
	transform: rotate(-45deg);
	-ms-transform: rotate(-45deg);
	-moz-transform: rotate(-45deg);
}

.contact-info p {
    padding: 27px 10px;
}

.contact-info span {
    padding-left: 20px;
}

input[type="text"],
input[type="email"],
textarea {
	display: block;
	margin: 0 auto;
	width: 100%;
	background: transparent;
	border: 1px solid #fff;
	padding: 12px 15px;
	margin-bottom: 30px;
}

input[type="submit"] {
	background: transparent;
	border: 1px solid #fff;
	width: 100%;
	padding: 10px;
	transition: 0.5s background linear;
	font-weight: bold;
}

input[type="submit"]:hover {
	background: #fff;
	border-color: #fff;
	transition: 0.5s background linear;
	color: #333;
}

::-webkit-input-placeholder {
   color: #fff;
}

::-moz-placeholder {
   color: #fff;  
}

:-ms-input-placeholder {  
   color: #fff;  
}

/* Footer */

#site-footer {
    background-color: rgba(32, 178, 170, 0.86);
    color: #fff;
    padding: 14px;
    font-size: 14px;
}

.grad {
	text-align: right;
}

.grad a {
	color: #fff;
}
.sqaure-nebir {
    height: 45px;
    width: 45px;
    border: 3px double #fff;
    transform: rotate(-45deg);
    position: absolute;
}

.rotated-icon {
    position: relative;
    display: inline-block;
    float: left;
    width: 50px;
}

.rotated-icon i {
    position: absolute;
    top: 1.3rem;
    left: 1.5rem;
    font-size: 22px;
}

i.fa.fa-envelope-o {
    left: 12px;
}

.contact-info p{
	margin-left: 70px;
	display: inline-block;
	float: left;
	width: auto;
	line-height: 43px;
	margin-top: -22px;
}
/* Responsive styles */

@media (max-width: 991px) {
	.element-item {
		width: 33.33%;
	}
}

@media (max-width: 767px) {
	.element-item {
		width: 50%;
	}

	#site-header .pull-right {
		float: none !important;
	}

	.copyright, .designed-by {
		text-align: center;
	}
}

@media (max-width: 500px) {
	.contact-info {
		padding: 30px 10px;
	}
}

@media only screen and (max-width : 640px) {
    .parallax{
    background: url(../Images/Banner) no-repeat center center fixed #444;
    background-attachment: fixed !important;
    -webkit-background-size: 100%;
    -moz-background-size: 100%;
    -o-background-size: 100%;
    background-size: 100%;
    -webkit-background-size: cover;
    -moz-background-size: cover;
    -o-background-size: cover;
    background-size: cover;
    }
}

/*
License: GNU General Public License v3
License URI: http://www.gnu.org/licenses/gpl-3.0.txt
*/