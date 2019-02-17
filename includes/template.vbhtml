<!DOCTYPE html>

<!--[if IE 9]><html class="lt-ie10" lang="en"><![endif]-->
<html class="js flexbox flexboxlegacy canvas canvastext webgl no-touch geolocation postmessage no-websqldatabase indexeddb hashchange history draganddrop websockets rgba hsla multiplebgs backgroundsize borderimage borderradius boxshadow textshadow opacity cssanimations csscolumns cssgradients no-cssreflections csstransforms csstransforms3d csstransitions fontface generatedcontent video audio localstorage sessionstorage webworkers applicationcache svg inlinesvg smil svgclippaths"
 lang="en">

<head>
	<%= ../includes/head.vbhtml %>
</head>

<body>

	<div id="main-wrapper">
		<%= ../includes/header-nav.vbhtml %>

		$content

		<!-- 添加上这个<div>标签之后可以防止在高度比较低的时候出现错位的现象 -->
		<!--
			2018-1-1
			原来的标签数据为
			<div id="push"></div>
			
			在这里将push字符串替换为一个变量来进行内容格式的控制
		-->
		<div id="$div_push"></div>

	</div>

	<footer>
		<%= ../includes/footer.vbhtml %>
	</footer>

	<%= ../includes/script-includes.vbhtml %>

</body>

</html>