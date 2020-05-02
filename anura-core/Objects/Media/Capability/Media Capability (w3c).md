<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <title>Media Capabilities</title>
<style data-fill-with="stylesheet">/******************************************************************************
 *                   Style sheet for the W3C specifications                   *
 *
 * Special classes handled by this style sheet include:
 *
 * Indices
 *   - .toc for the Table of Contents (<ol class="toc">)
 *     + <span class="secno"> for the section numbers
 *   - #toc for the Table of Contents (<nav id="toc">)
 *   - ul.index for Indices (<a href="#ref">term</a><span>, in §N.M</span>)
 *   - table.index for Index Tables (e.g. for properties or elements)
 *
 * Structural Markup
 *   - table.data for general data tables
 *     -> use 'scope' attribute, <colgroup>, <thead>, and <tbody> for best results !
 *     -> use <table class='complex data'> for extra-complex tables
 *     -> use <td class='long'> for paragraph-length cell content
 *     -> use <td class='pre'> when manual line breaks/indentation would help readability
 *   - dl.switch for switch statements
 *   - ol.algorithm for algorithms (helps to visualize nesting)
 *   - .figure and .caption (HTML4) and figure and figcaption (HTML5)
 *     -> .sidefigure for right-floated figures
 *   - ins/del
 *
 * Code
 *   - pre and code
 *
 * Special Sections
 *   - .note       for informative notes             (div, p, span, aside, details)
 *   - .example    for informative examples          (div, p, pre, span)
 *   - .issue      for issues                        (div, p, span)
 *   - .assertion  for assertions                    (div, p, span)
 *   - .advisement for loud normative statements     (div, p, strong)
 *   - .annoying-warning for spec obsoletion notices (div, aside, details)
 *
 * Definition Boxes
 *   - pre.def   for WebIDL definitions
 *   - table.def for tables that define other entities (e.g. CSS properties)
 *   - dl.def    for definition lists that define other entitles (e.g. HTML elements)
 *
 * Numbering
 *   - .secno for section numbers in .toc and headings (<span class='secno'>3.2</span>)
 *   - .marker for source-inserted example/figure/issue numbers (<span class='marker'>Issue 4</span>)
 *   - ::before styled for CSS-generated issue/example/figure numbers:
 *     -> Documents wishing to use this only need to add
 *        figcaption::before,
 *        .caption::before { content: "Figure "  counter(figure) " ";  }
 *        .example::before { content: "Example " counter(example) " "; }
 *        .issue::before   { content: "Issue "   counter(issue) " ";   }
 *
 * Header Stuff (ignore, just don't conflict with these classes)
 *   - .head for the header
 *   - .copyright for the copyright
 *
 * Miscellaneous
 *   - .overlarge for things that should be as wide as possible, even if
 *     that overflows the body text area. This can be used on an item or
 *     on its container, depending on the effect desired.
 *     Note that this styling basically doesn't help at all when printing,
 *     since A4 paper isn't much wider than the max-width here.
 *     It's better to design things to fit into a narrower measure if possible.
 *   - js-added ToC jump links (see fixup.js)
 *
 ******************************************************************************/

/******************************************************************************/
/*                                   Body                                     */
/******************************************************************************/

	body {
		counter-reset: example figure issue;

		/* Layout */
		max-width: 50em;               /* limit line length to 50em for readability   */
		margin: 0 auto;                /* center text within page                     */
		padding: 1.6em 1.5em 2em 50px; /* assume 16px font size for downlevel clients */
		padding: 1.6em 1.5em 2em calc(26px + 1.5em); /* leave space for status flag     */

		/* Typography */
		line-height: 1.5;
		font-family: sans-serif;
		widows: 2;
		orphans: 2;
		word-wrap: break-word;
		overflow-wrap: break-word;
		hyphens: auto;

		/* Colors */
		color: black;
		background: white top left fixed no-repeat;
		background-size: 25px auto;
	}


/******************************************************************************/
/*                         Front Matter & Navigation                          */
/******************************************************************************/

/** Header ********************************************************************/

	div.head { margin-bottom: 1em }
	div.head hr { border-style: solid; }

	div.head h1 {
		font-weight: bold;
		margin: 0 0 .1em;
		font-size: 220%;
	}

	div.head h2 { margin-bottom: 1.5em;}

/** W3C Logo ******************************************************************/

	.head .logo {
		float: right;
		margin: 0.4rem 0 0.2rem .4rem;
	}

	.head img[src*="logos/W3C"] {
		display: block;
		border: solid #1a5e9a;
		border-width: .65rem .7rem .6rem;
		border-radius: .4rem;
		background: #1a5e9a;
		color: white;
		font-weight: bold;
	}

	.head a:hover > img[src*="logos/W3C"],
	.head a:focus > img[src*="logos/W3C"] {
		opacity: .8;
	}

	.head a:active > img[src*="logos/W3C"] {
		background: #c00;
		border-color: #c00;
	}

	/* see also additional rules in Link Styling section */

/** Copyright *****************************************************************/

	p.copyright,
	p.copyright small { font-size: small }

/** Back to Top / ToC Toggle **************************************************/

	@media print {
		#toc-nav {
			display: none;
		}
	}
	@media not print {
		#toc-nav {
			position: fixed;
			z-index: 2;
			bottom: 0; left: 0;
			margin: 0;
			min-width: 1.33em;
			border-top-right-radius: 2rem;
			box-shadow: 0 0 2px;
			font-size: 1.5em;
			color: black;
		}
		#toc-nav > a {
			display: block;
			white-space: nowrap;

			height: 1.33em;
			padding: .1em 0.3em;
			margin: 0;

			background: white;
			box-shadow: 0 0 2px;
			border: none;
			border-top-right-radius: 1.33em;
			background: white;
		}
		#toc-nav > #toc-jump {
			padding-bottom: 2em;
			margin-bottom: -1.9em;
		}

		#toc-nav > a:hover,
		#toc-nav > a:focus {
			background: #f8f8f8;
		}
		#toc-nav > a:not(:hover):not(:focus) {
			color: #707070;
		}

		/* statusbar gets in the way on keyboard focus; remove once browsers fix */
		#toc-nav > a[href="#toc"]:not(:hover):focus:last-child {
			padding-bottom: 1.5rem;
		}

		#toc-nav:not(:hover) > a:not(:focus) > span + span {
			/* Ideally this uses :focus-within on #toc-nav */
			display: none;
		}
		#toc-nav > a > span + span {
			padding-right: 0.2em;
		}

		#toc-toggle-inline {
			vertical-align: 0.05em;
			font-size: 80%;
			color: gray;
			color: hsla(203,20%,40%,.7);
			border-style: none;
			background: transparent;
			position: relative;
		}
		#toc-toggle-inline:hover:not(:active),
		#toc-toggle-inline:focus:not(:active) {
			text-shadow: 1px 1px silver;
			top: -1px;
			left: -1px;
		}

		#toc-nav :active {
			color: #C00;
		}
	}

/** ToC Sidebar ***************************************************************/

	/* Floating sidebar */
	@media screen {
		body.toc-sidebar #toc {
			position: fixed;
			top: 0; bottom: 0;
			left: 0;
			width: 23.5em;
			max-width: 80%;
			max-width: calc(100% - 2em - 26px);
			overflow: auto;
			padding: 0 1em;
			padding-left: 42px;
			padding-left: calc(1em + 26px);
			background: inherit;
			background-color: #f7f8f9;
			z-index: 1;
			box-shadow: -.1em 0 .25em rgba(0,0,0,.1) inset;
		}
		body.toc-sidebar #toc h2 {
			margin-top: .8rem;
			font-variant: small-caps;
			font-variant: all-small-caps;
			text-transform: lowercase;
			font-weight: bold;
			color: gray;
			color: hsla(203,20%,40%,.7);
		}
		body.toc-sidebar #toc-jump:not(:focus) {
			width: 0;
			height: 0;
			padding: 0;
			position: absolute;
			overflow: hidden;
		}
	}
	/* Hide main scroller when only the ToC is visible anyway */
	@media screen and (max-width: 28em) {
		body.toc-sidebar {
			overflow: hidden;
		}
	}

	/* Sidebar with its own space */
	@media screen and (min-width: 78em) {
		body:not(.toc-inline) #toc {
			position: fixed;
			top: 0; bottom: 0;
			left: 0;
			width: 23.5em;
			overflow: auto;
			padding: 0 1em;
			padding-left: 42px;
			padding-left: calc(1em + 26px);
			background: inherit;
			background-color: #f7f8f9;
			z-index: 1;
			box-shadow: -.1em 0 .25em rgba(0,0,0,.1) inset;
		}
		body:not(.toc-inline) #toc h2 {
			margin-top: .8rem;
			font-variant: small-caps;
			font-variant: all-small-caps;
			text-transform: lowercase;
			font-weight: bold;
			color: gray;
			color: hsla(203,20%,40%,.7);
		}

		body:not(.toc-inline) {
			padding-left: 29em;
		}
		/* See also Overflow section at the bottom */

		body:not(.toc-inline) #toc-jump:not(:focus) {
			width: 0;
			height: 0;
			padding: 0;
			position: absolute;
			overflow: hidden;
		}
	}
	@media screen and (min-width: 90em) {
		body:not(.toc-inline) {
			margin: 0 4em;
		}
	}

/******************************************************************************/
/*                                Sectioning                                  */
/******************************************************************************/

/** Headings ******************************************************************/

	h1, h2, h3, h4, h5, h6, dt {
		page-break-after: avoid;
		page-break-inside: avoid;
		font: 100% sans-serif;   /* Reset all font styling to clear out UA styles */
		font-family: inherit;    /* Inherit the font family. */
		line-height: 1.2;        /* Keep wrapped headings compact */
		hyphens: manual;         /* Hyphenated headings look weird */
	}

	h2, h3, h4, h5, h6 {
		margin-top: 3rem;
	}

	h1, h2, h3 {
		color: #005A9C;
		background: transparent;
	}

	h1 { font-size: 170%; }
	h2 { font-size: 140%; }
	h3 { font-size: 120%; }
	h4 { font-weight: bold; }
	h5 { font-style: italic; }
	h6 { font-variant: small-caps; }
	dt { font-weight: bold; }

/** Subheadings ***************************************************************/

	h1 + h2,
	#subtitle {
		/* #subtitle is a subtitle in an H2 under the H1 */
		margin-top: 0;
	}
	h2 + h3,
	h3 + h4,
	h4 + h5,
	h5 + h6 {
		margin-top: 1.2em; /* = 1 x line-height */
	}

/** Section divider ***********************************************************/

	:not(.head) > hr {
		font-size: 1.5em;
		text-align: center;
		margin: 1em auto;
		height: auto;
		border: transparent solid 0;
		background: transparent;
	}
	:not(.head) > hr::before {
		content: "\2727\2003\2003\2727\2003\2003\2727";
	}

/******************************************************************************/
/*                            Paragraphs and Lists                            */
/******************************************************************************/

	p {
		margin: 1em 0;
	}

	dd > p:first-child,
	li > p:first-child {
		margin-top: 0;
	}

	ul, ol {
		margin-left: 0;
		padding-left: 2em;
	}

	li {
		margin: 0.25em 0 0.5em;
		padding: 0;
	}

	dl dd {
		margin: 0 0 .5em 2em;
	}

	.head dd + dd { /* compact for header */
		margin-top: -.5em;
	}

	/* Style for algorithms */
	ol.algorithm ol:not(.algorithm),
	.algorithm > ol ol:not(.algorithm) {
	 border-left: 0.5em solid #DEF;
	}

	/* Put nice boxes around each algorithm. */
	[data-algorithm]:not(.heading) {
	  padding: .5em;
	  border: thin solid #ddd; border-radius: .5em;
	  margin: .5em calc(-0.5em - 1px);
	}
	[data-algorithm]:not(.heading) > :first-child {
	  margin-top: 0;
	}
	[data-algorithm]:not(.heading) > :last-child {
	  margin-bottom: 0;
	}

	/* Style for switch/case <dl>s */
	dl.switch > dd > ol.only,
	dl.switch > dd > .only > ol {
	 margin-left: 0;
	}
	dl.switch > dd > ol.algorithm,
	dl.switch > dd > .algorithm > ol {
	 margin-left: -2em;
	}
	dl.switch {
	 padding-left: 2em;
	}
	dl.switch > dt {
	 text-indent: -1.5em;
	 margin-top: 1em;
	}
	dl.switch > dt + dt {
	 margin-top: 0;
	}
	dl.switch > dt::before {
	 content: '\21AA';
	 padding: 0 0.5em 0 0;
	 display: inline-block;
	 width: 1em;
	 text-align: right;
	 line-height: 0.5em;
	}

/** Terminology Markup ********************************************************/


/******************************************************************************/
/*                                 Inline Markup                              */
/******************************************************************************/

/** Terminology Markup ********************************************************/
	dfn   { /* Defining instance */
		font-weight: bolder;
	}
	a > i { /* Instance of term */
		font-style: normal;
	}
	dt dfn code, code.idl {
		font-size: medium;
	}
	dfn var {
		font-style: normal;
	}

/** Change Marking ************************************************************/

	del { color: red;  text-decoration: line-through; }
	ins { color: #080; text-decoration: underline;    }

/** Miscellaneous improvements to inline formatting ***************************/

	sup {
		vertical-align: super;
		font-size: 80%
	}

/******************************************************************************/
/*                                    Code                                    */
/******************************************************************************/

/** General monospace/pre rules ***********************************************/

	pre, code, samp {
		font-family: Menlo, Consolas, "DejaVu Sans Mono", Monaco, monospace;
		font-size: .9em;
		page-break-inside: avoid;
		hyphens: none;
		text-transform: none;
	}
	pre code,
	code code {
		font-size: 100%;
	}

	pre {
		margin-top: 1em;
		margin-bottom: 1em;
		overflow: auto;
	}

/** Inline Code fragments *****************************************************/

  /* Do something nice. */

/******************************************************************************/
/*                                    Links                                   */
/******************************************************************************/

/** General Hyperlinks ********************************************************/

	/* We hyperlink a lot, so make it less intrusive */
	a[href] {
		color: #034575;
		text-decoration: none;
		border-bottom: 1px solid #707070;
		/* Need a bit of extending for it to look okay */
		padding: 0 1px 0;
		margin: 0 -1px 0;
	}
	a:visited {
		border-bottom-color: #BBB;
	}

	/* Use distinguishing colors when user is interacting with the link */
	a[href]:focus,
	a[href]:hover {
		background: #f8f8f8;
		background: rgba(75%, 75%, 75%, .25);
		border-bottom-width: 3px;
		margin-bottom: -2px;
	}
	a[href]:active {
		color: #C00;
		border-color: #C00;
	}

	/* Backout above styling for W3C logo */
	.head .logo,
	.head .logo a {
		border: none;
		text-decoration: none;
		background: transparent;
	}

/******************************************************************************/
/*                                    Images                                  */
/******************************************************************************/

	img {
		border-style: none;
	}

	/* For autogen numbers, add
	   .caption::before, figcaption::before { content: "Figure " counter(figure) ". "; }
	*/

	figure, .figure, .sidefigure {
		page-break-inside: avoid;
		text-align: center;
		margin: 2.5em 0;
	}
	.figure img,    .sidefigure img,    figure img,
	.figure object, .sidefigure object, figure object {
		max-width: 100%;
		margin: auto;
	}
	.figure pre, .sidefigure pre, figure pre {
		text-align: left;
		display: table;
		margin: 1em auto;
	}
	.figure table, figure table {
		margin: auto;
	}
	@media screen and (min-width: 20em) {
		.sidefigure {
			float: right;
			width: 50%;
			margin: 0 0 0.5em 0.5em
		}
	}
	.caption, figcaption, caption {
		font-style: italic;
		font-size: 90%;
	}
	.caption::before, figcaption::before, figcaption > .marker {
		font-weight: bold;
	}
	.caption, figcaption {
		counter-increment: figure;
	}

	/* DL list is indented 2em, but figure inside it is not */
	dd > .figure, dd > figure { margin-left: -2em }

/******************************************************************************/
/*                             Colored Boxes                                  */
/******************************************************************************/

	.issue, .note, .example, .assertion, .advisement, blockquote {
		padding: .5em;
		border: .5em;
		border-left-style: solid;
		page-break-inside: avoid;
	}
	span.issue, span.note {
		padding: .1em .5em .15em;
		border-right-style: solid;
	}

	.issue,
	.note,
	.example,
	.advisement,
	.assertion,
	blockquote {
		margin: 1em auto;
	}
	.note  > p:first-child,
	.issue > p:first-child,
	blockquote > :first-child {
		margin-top: 0;
	}
	blockquote > :last-child {
		margin-bottom: 0;
	}

/** Blockquotes ***************************************************************/

	blockquote {
		border-color: silver;
	}

/** Open issue ****************************************************************/

	.issue {
		border-color: #E05252;
		background: #FBE9E9;
		counter-increment: issue;
		overflow: auto;
	}
	.issue::before, .issue > .marker {
		text-transform: uppercase;
		color: #AE1E1E;
		padding-right: 1em;
		text-transform: uppercase;
	}
	/* Add .issue::before { content: "Issue " counter(issue) " "; } for autogen numbers,
	   or use class="marker" to mark up the issue number in source. */

/** Example *******************************************************************/

	.example {
		border-color: #E0CB52;
		background: #FCFAEE;
		counter-increment: example;
		overflow: auto;
		clear: both;
	}
	.example::before, .example > .marker {
		text-transform: uppercase;
		color: #827017;
		min-width: 7.5em;
		display: block;
	}
	/* Add .example::before { content: "Example " counter(example) " "; } for autogen numbers,
	   or use class="marker" to mark up the example number in source. */

/** Non-normative Note ********************************************************/

	.note {
		border-color: #52E052;
		background: #E9FBE9;
		overflow: auto;
	}

	.note::before, .note > .marker,
	details.note > summary::before,
	details.note > summary > .marker {
		text-transform: uppercase;
		display: block;
		color: hsl(120, 70%, 30%);
	}
	/* Add .note::before { content: "Note"; } for autogen label,
	   or use class="marker" to mark up the label in source. */

	details.note > summary {
		display: block;
		color: hsl(120, 70%, 30%);
	}
	details.note[open] > summary {
		border-bottom: 1px silver solid;
	}

/** Assertion Box *************************************************************/
	/*  for assertions in algorithms */

	.assertion {
		border-color: #AAA;
		background: #EEE;
	}

/** Advisement Box ************************************************************/
	/*  for attention-grabbing normative statements */

	.advisement {
		border-color: orange;
		border-style: none solid;
		background: #FFEECC;
	}
	strong.advisement {
		display: block;
		text-align: center;
	}
	.advisement > .marker {
		color: #B35F00;
	}

/** Spec Obsoletion Notice ****************************************************/
	/* obnoxious obsoletion notice for older/abandoned specs. */

	details {
		display: block;
	}
	summary {
		font-weight: bolder;
	}

	.annoying-warning:not(details),
	details.annoying-warning:not([open]) > summary,
	details.annoying-warning[open] {
		background: #fdd;
		color: red;
		font-weight: bold;
		padding: .75em 1em;
		border: thick red;
		border-style: solid;
		border-radius: 1em;
	}
	.annoying-warning :last-child {
		margin-bottom: 0;
	}

@media not print {
	details.annoying-warning[open] {
		position: fixed;
		left: 1em;
		right: 1em;
		bottom: 1em;
		z-index: 1000;
	}
}

	details.annoying-warning:not([open]) > summary {
		text-align: center;
	}

/** Entity Definition Boxes ***************************************************/

	.def {
		padding: .5em 1em;
		background: #DEF;
		margin: 1.2em 0;
		border-left: 0.5em solid #8CCBF2;
	}

/******************************************************************************/
/*                                    Tables                                  */
/******************************************************************************/

	th, td {
		text-align: left;
		text-align: start;
	}

/** Property/Descriptor Definition Tables *************************************/

	table.def {
		/* inherits .def box styling, see above */
		width: 100%;
		border-spacing: 0;
	}

	table.def td,
	table.def th {
		padding: 0.5em;
		vertical-align: baseline;
		border-bottom: 1px solid #bbd7e9;
	}

	table.def > tbody > tr:last-child th,
	table.def > tbody > tr:last-child td {
		border-bottom: 0;
	}

	table.def th {
		font-style: italic;
		font-weight: normal;
		padding-left: 1em;
		width: 3em;
	}

	/* For when values are extra-complex and need formatting for readability */
	table td.pre {
		white-space: pre-wrap;
	}

	/* A footnote at the bottom of a def table */
	table.def           td.footnote {
		padding-top: 0.6em;
	}
	table.def           td.footnote::before {
		content: " ";
		display: block;
		height: 0.6em;
		width: 4em;
		border-top: thin solid;
	}

/** Data tables (and properly marked-up index tables) *************************/
	/*
		 <table class="data"> highlights structural relationships in a table
		 when correct markup is used (e.g. thead/tbody, th vs. td, scope attribute)

		 Use class="complex data" for particularly complicated tables --
		 (This will draw more lines: busier, but clearer.)

		 Use class="long" on table cells with paragraph-like contents
		 (This will adjust text alignment accordingly.)
		 Alternately use class="longlastcol" on tables, to have the last column assume "long".
	*/

	table {
		word-wrap: normal;
		overflow-wrap: normal;
		hyphens: manual;
	}

	table.data,
	table.index {
		margin: 1em auto;
		border-collapse: collapse;
		border: hidden;
		width: 100%;
	}
	table.data caption,
	table.index caption {
		max-width: 50em;
		margin: 0 auto 1em;
	}

	table.data td,  table.data th,
	table.index td, table.index th {
		padding: 0.5em 1em;
		border-width: 1px;
		border-color: silver;
		border-top-style: solid;
	}

	table.data thead td:empty {
		padding: 0;
		border: 0;
	}

	table.data  thead,
	table.index thead,
	table.data  tbody,
	table.index tbody {
		border-bottom: 2px solid;
	}

	table.data colgroup,
	table.index colgroup {
		border-left: 2px solid;
	}

	table.data  tbody th:first-child,
	table.index tbody th:first-child  {
		border-right: 2px solid;
		border-top: 1px solid silver;
		padding-right: 1em;
	}

	table.data th[colspan],
	table.data td[colspan] {
		text-align: center;
	}

	table.complex.data th,
	table.complex.data td {
		border: 1px solid silver;
		text-align: center;
	}

	table.data.longlastcol td:last-child,
	table.data td.long {
	 vertical-align: baseline;
	 text-align: left;
	}

	table.data img {
		vertical-align: middle;
	}


/*
Alternate table alignment rules

	table.data,
	table.index {
		text-align: center;
	}

	table.data  thead th[scope="row"],
	table.index thead th[scope="row"] {
		text-align: right;
	}

	table.data  tbody th:first-child,
	table.index tbody th:first-child  {
		text-align: right;
	}

Possible extra rowspan handling

	table.data  tbody th[rowspan]:not([rowspan='1']),
	table.index tbody th[rowspan]:not([rowspan='1']),
	table.data  tbody td[rowspan]:not([rowspan='1']),
	table.index tbody td[rowspan]:not([rowspan='1']) {
		border-left: 1px solid silver;
	}

	table.data  tbody th[rowspan]:first-child,
	table.index tbody th[rowspan]:first-child,
	table.data  tbody td[rowspan]:first-child,
	table.index tbody td[rowspan]:first-child{
		border-left: 0;
		border-right: 1px solid silver;
	}
*/

/******************************************************************************/
/*                                  Indices                                   */
/******************************************************************************/


/** Table of Contents *********************************************************/

	.toc a {
		/* More spacing; use padding to make it part of the click target. */
		padding-top: 0.1rem;
		/* Larger, more consistently-sized click target */
		display: block;
		/* Reverse color scheme */
		color: black;
		border-color: #3980B5;
		border-bottom-width: 3px !important;
		margin-bottom: 0px !important;
	}
	.toc a:visited {
		border-color: #054572;
	}
	.toc a:not(:focus):not(:hover) {
		/* Allow colors to cascade through from link styling */
		border-bottom-color: transparent;
	}

	.toc, .toc ol, .toc ul, .toc li {
		list-style: none; /* Numbers must be inlined into source */
		/* because generated content isn't search/selectable and markers can't do multilevel yet */
		margin:  0;
		padding: 0;
		line-height: 1.1rem; /* consistent spacing */
	}

	/* ToC not indented until third level, but font style & margins show hierarchy */
	.toc > li             { font-weight: bold;   }
	.toc > li li          { font-weight: normal; }
	.toc > li li li       { font-size:   95%;    }
	.toc > li li li li    { font-size:   90%;    }
	.toc > li li li li .secno { font-size: 85%; }
	.toc > li li li li li { font-size:   85%;    }
	.toc > li li li li li .secno { font-size: 100%; }

	/* @supports not (display:grid) { */
		.toc > li             { margin: 1.5rem 0;    }
		.toc > li li          { margin: 0.3rem 0;    }
		.toc > li li li       { margin-left: 2rem;   }

		/* Section numbers in a column of their own */
		.toc .secno {
			float: left;
			width: 4rem;
			white-space: nowrap;
		}

		.toc li {
			clear: both;
		}

		:not(li) > .toc              { margin-left:  5rem; }
		.toc .secno                  { margin-left: -5rem; }
		.toc > li li li .secno       { margin-left: -7rem; }
		.toc > li li li li .secno    { margin-left: -9rem; }
		.toc > li li li li li .secno { margin-left: -11rem; }

		/* Tighten up indentation in narrow ToCs */
		@media (max-width: 30em) {
			:not(li) > .toc              { margin-left:  4rem; }
			.toc .secno                  { margin-left: -4rem; }
			.toc > li li li              { margin-left:  1rem; }
			.toc > li li li .secno       { margin-left: -5rem; }
			.toc > li li li li .secno    { margin-left: -6rem; }
			.toc > li li li li li .secno { margin-left: -7rem; }
		}
	/* } */

	@supports (display:grid) and (display:contents) {
		/* Use #toc over .toc to override non-@supports rules. */
		#toc {
			display: grid;
			align-content: start;
			grid-template-columns: auto 1fr;
			grid-column-gap: 1rem;
			column-gap: 1rem;
			grid-row-gap: .6rem;
			row-gap: .6rem;
		}
		#toc h2 {
			grid-column: 1 / -1;
			margin-bottom: 0;
		}
		#toc ol,
		#toc li,
		#toc a {
			display: contents;
			/* Switch <a> to subgrid when supported */
		}
		#toc span {
			margin: 0;
		}
		#toc > .toc > li > a > span {
			/* The spans of the top-level list,
			   comprising the first items of each top-level section. */
			margin-top: 1.1rem;
		}
		#toc#toc .secno { /* Ugh, need more specificity to override base.css */
			grid-column: 1;
			width: auto;
			margin-left: 0;
		}
		#toc .content {
			grid-column: 2;
			width: auto;
			margin-right: 1rem;
		}
		#toc .content:hover {
			background: rgba(75%, 75%, 75%, .25);
			border-bottom: 3px solid #054572;
			margin-bottom: -3px;
		}
		#toc li li li .content {
			margin-left: 1rem;
		}
		#toc li li li li .content {
			margin-left: 2rem;
		}
	}


/** Index *********************************************************************/

	/* Index Lists: Layout */
	ul.index       { margin-left: 0; columns: 15em; text-indent: 1em hanging; }
	ul.index li    { margin-left: 0; list-style: none; break-inside: avoid; }
	ul.index li li { margin-left: 1em }
	ul.index dl    { margin-top: 0; }
	ul.index dt    { margin: .2em 0 .2em 20px;}
	ul.index dd    { margin: .2em 0 .2em 40px;}
	/* Index Lists: Typography */
	ul.index ul,
	ul.index dl { font-size: smaller; }
	@media not print {
		ul.index li span {
			white-space: nowrap;
			color: transparent; }
		ul.index li a:hover + span,
		ul.index li a:focus + span {
			color: #707070;
		}
	}

/** Index Tables *****************************************************/
	/* See also the data table styling section, which this effectively subclasses */

	table.index {
		font-size: small;
		border-collapse: collapse;
		border-spacing: 0;
		text-align: left;
		margin: 1em 0;
	}

	table.index td,
	table.index th {
		padding: 0.4em;
	}

	table.index tr:hover td:not([rowspan]),
	table.index tr:hover th:not([rowspan]) {
		background: #f7f8f9;
	}

	/* The link in the first column in the property table (formerly a TD) */
	table.index th:first-child a {
		font-weight: bold;
	}

/******************************************************************************/
/*                                    Print                                   */
/******************************************************************************/

	@media print {
		/* Pages have their own margins. */
		html {
			margin: 0;
		}
		/* Serif for print. */
		body {
			font-family: serif;
		}
	}
	@page {
		margin: 1.5cm 1.1cm;
	}

/******************************************************************************/
/*                                    Legacy                                  */
/******************************************************************************/

	/* This rule is inherited from past style sheets. No idea what it's for. */
	.hide { display: none }



/******************************************************************************/
/*                             Overflow Control                               */
/******************************************************************************/

	.figure .caption, .sidefigure .caption, figcaption {
		/* in case figure is overlarge, limit caption to 50em */
		max-width: 50rem;
		margin-left: auto;
		margin-right: auto;
	}
	.overlarge {
		/* Magic to create good table positioning:
		   "content column" is 50ems wide at max; less on smaller screens.
		   Extra space (after ToC + content) is empty on the right.

		   1. When table < content column, centers table in column.
		   2. When content < table < available, left-aligns.
		   3. When table > available, fills available + scroll bar.
		*/ 
		display: grid;
		grid-template-columns: minmax(0, 50em);
	}
	.overlarge > table {
		/* limit preferred width of table */
		max-width: 50em;
		margin-left: auto;
		margin-right: auto;
	}

	@media (min-width: 55em) {
		.overlarge {
			margin-right: calc(13px + 26.5rem - 50vw);
			max-width: none;
		}
	}
	@media screen and (min-width: 78em) {
		body:not(.toc-inline) .overlarge {
			/* 30.5em body padding 50em content area */
			margin-right: calc(40em - 50vw) !important;
		}
	}
	@media screen and (min-width: 90em) {
		body:not(.toc-inline) .overlarge {
			/* 4em html margin 30.5em body padding 50em content area */
			margin-right: calc(84.5em - 100vw) !important;
		}
	}

	@media not print {
		.overlarge {
			overflow-x: auto;
			/* See Lea Verou's explanation background-attachment:
			 * http://lea.verou.me/2012/04/background-attachment-local/
			 *
			background: top left  / 4em 100% linear-gradient(to right,  #ffffff, rgba(255, 255, 255, 0)) local,
			            top right / 4em 100% linear-gradient(to left, #ffffff, rgba(255, 255, 255, 0)) local,
			            top left  / 1em 100% linear-gradient(to right,  #c3c3c5, rgba(195, 195, 197, 0)) scroll,
			            top right / 1em 100% linear-gradient(to left, #c3c3c5, rgba(195, 195, 197, 0)) scroll,
			            white;
			background-repeat: no-repeat;
			*/
		}
	}
</style>
  <link href="https://www.w3.org/StyleSheets/TR/2016/W3C-ED" rel="stylesheet" type="text/css">
  <meta content="Bikeshed version 7dd49ddf2b095c0a9accc859934f2349a4fb5d3c" name="generator">
  <link href="https://w3c.github.io/media-capabilities/" rel="canonical">
<style>/* style-md-lists */

/* This is a weird hack for me not yet following the commonmark spec
   regarding paragraph and lists. */
[data-md] > :first-child {
    margin-top: 0;
}
[data-md] > :last-child {
    margin-bottom: 0;
}</style>
<style>/* style-selflinks */

.heading, .issue, .note, .example, li, dt {
    position: relative;
}
a.self-link {
    position: absolute;
    top: 0;
    left: calc(-1 * (3.5rem - 26px));
    width: calc(3.5rem - 26px);
    height: 2em;
    text-align: center;
    border: none;
    transition: opacity .2s;
    opacity: .5;
}
a.self-link:hover {
    opacity: 1;
}
.heading > a.self-link {
    font-size: 83%;
}
li > a.self-link {
    left: calc(-1 * (3.5rem - 26px) - 2em);
}
dfn > a.self-link {
    top: auto;
    left: auto;
    opacity: 0;
    width: 1.5em;
    height: 1.5em;
    background: gray;
    color: white;
    font-style: normal;
    transition: opacity .2s, background-color .2s, color .2s;
}
dfn:hover > a.self-link {
    opacity: 1;
}
dfn > a.self-link:hover {
    color: black;
}

a.self-link::before            { content: "¶"; }
.heading > a.self-link::before { content: "§"; }
dfn > a.self-link::before      { content: "#"; }</style>
<style>/* style-counters */

body {
    counter-reset: example figure issue;
}
.issue {
    counter-increment: issue;
}
.issue:not(.no-marker)::before {
    content: "Issue " counter(issue);
}

.example {
    counter-increment: example;
}
.example:not(.no-marker)::before {
    content: "Example " counter(example);
}
.invalid.example:not(.no-marker)::before,
.illegal.example:not(.no-marker)::before {
    content: "Invalid Example" counter(example);
}

figcaption {
    counter-increment: figure;
}
figcaption:not(.no-marker)::before {
    content: "Figure " counter(figure) " ";
}</style>
<style>/* style-autolinks */

.css.css, .property.property, .descriptor.descriptor {
    color: #005a9c;
    font-size: inherit;
    font-family: inherit;
}
.css::before, .property::before, .descriptor::before {
    content: "‘";
}
.css::after, .property::after, .descriptor::after {
    content: "’";
}
.property, .descriptor {
    /* Don't wrap property and descriptor names */
    white-space: nowrap;
}
.type { /* CSS value <type> */
    font-style: italic;
}
pre .property::before, pre .property::after {
    content: "";
}
[data-link-type="property"]::before,
[data-link-type="propdesc"]::before,
[data-link-type="descriptor"]::before,
[data-link-type="value"]::before,
[data-link-type="function"]::before,
[data-link-type="at-rule"]::before,
[data-link-type="selector"]::before,
[data-link-type="maybe"]::before {
    content: "‘";
}
[data-link-type="property"]::after,
[data-link-type="propdesc"]::after,
[data-link-type="descriptor"]::after,
[data-link-type="value"]::after,
[data-link-type="function"]::after,
[data-link-type="at-rule"]::after,
[data-link-type="selector"]::after,
[data-link-type="maybe"]::after {
    content: "’";
}

[data-link-type].production::before,
[data-link-type].production::after,
.prod [data-link-type]::before,
.prod [data-link-type]::after {
    content: "";
}

[data-link-type=element],
[data-link-type=element-attr] {
    font-family: Menlo, Consolas, "DejaVu Sans Mono", monospace;
    font-size: .9em;
}
[data-link-type=element]::before { content: "<" }
[data-link-type=element]::after  { content: ">" }

[data-link-type=biblio] {
    white-space: pre;
}</style>
<style>/* style-dfn-panel */

.dfn-panel {
    position: absolute;
    z-index: 35;
    height: auto;
    width: -webkit-fit-content;
    width: fit-content;
    max-width: 300px;
    max-height: 500px;
    overflow: auto;
    padding: 0.5em 0.75em;
    font: small Helvetica Neue, sans-serif, Droid Sans Fallback;
    background: #DDDDDD;
    color: black;
    border: outset 0.2em;
}
.dfn-panel:not(.on) { display: none; }
.dfn-panel * { margin: 0; padding: 0; text-indent: 0; }
.dfn-panel > b { display: block; }
.dfn-panel a { color: black; }
.dfn-panel a:not(:hover) { text-decoration: none !important; border-bottom: none !important; }
.dfn-panel > b + b { margin-top: 0.25em; }
.dfn-panel ul { padding: 0; }
.dfn-panel li { list-style: inside; }
.dfn-panel.activated {
    display: inline-block;
    position: fixed;
    left: .5em;
    bottom: 2em;
    margin: 0 auto;
    max-width: calc(100vw - 1.5em - .4em - .5em);
    max-height: 30vh;
}

.dfn-paneled { cursor: pointer; }
</style>
<style>/* style-syntax-highlighting */
pre.idl.highlight { color: #708090; }
.highlight:not(.idl) { background: hsl(24, 20%, 95%); }
code.highlight { padding: .1em; border-radius: .3em; }
pre.highlight, pre > code.highlight { display: block; padding: 1em; margin: .5em 0; overflow: auto; border-radius: 0; }
c-[a] { color: #990055 } /* Keyword.Declaration */
c-[b] { color: #990055 } /* Keyword.Type */
c-[c] { color: #708090 } /* Comment */
c-[d] { color: #708090 } /* Comment.Multiline */
c-[e] { color: #0077aa } /* Name.Attribute */
c-[f] { color: #669900 } /* Name.Tag */
c-[g] { color: #222222 } /* Name.Variable */
c-[k] { color: #990055 } /* Keyword */
c-[l] { color: #000000 } /* Literal */
c-[m] { color: #000000 } /* Literal.Number */
c-[n] { color: #0077aa } /* Name */
c-[o] { color: #999999 } /* Operator */
c-[p] { color: #999999 } /* Punctuation */
c-[s] { color: #a67f59 } /* Literal.String */
c-[t] { color: #a67f59 } /* Literal.String.Single */
c-[u] { color: #a67f59 } /* Literal.String.Double */
c-[cp] { color: #708090 } /* Comment.Preproc */
c-[c1] { color: #708090 } /* Comment.Single */
c-[cs] { color: #708090 } /* Comment.Special */
c-[kc] { color: #990055 } /* Keyword.Constant */
c-[kn] { color: #990055 } /* Keyword.Namespace */
c-[kp] { color: #990055 } /* Keyword.Pseudo */
c-[kr] { color: #990055 } /* Keyword.Reserved */
c-[ld] { color: #000000 } /* Literal.Date */
c-[nc] { color: #0077aa } /* Name.Class */
c-[no] { color: #0077aa } /* Name.Constant */
c-[nd] { color: #0077aa } /* Name.Decorator */
c-[ni] { color: #0077aa } /* Name.Entity */
c-[ne] { color: #0077aa } /* Name.Exception */
c-[nf] { color: #0077aa } /* Name.Function */
c-[nl] { color: #0077aa } /* Name.Label */
c-[nn] { color: #0077aa } /* Name.Namespace */
c-[py] { color: #0077aa } /* Name.Property */
c-[ow] { color: #999999 } /* Operator.Word */
c-[mb] { color: #000000 } /* Literal.Number.Bin */
c-[mf] { color: #000000 } /* Literal.Number.Float */
c-[mh] { color: #000000 } /* Literal.Number.Hex */
c-[mi] { color: #000000 } /* Literal.Number.Integer */
c-[mo] { color: #000000 } /* Literal.Number.Oct */
c-[sb] { color: #a67f59 } /* Literal.String.Backtick */
c-[sc] { color: #a67f59 } /* Literal.String.Char */
c-[sd] { color: #a67f59 } /* Literal.String.Doc */
c-[se] { color: #a67f59 } /* Literal.String.Escape */
c-[sh] { color: #a67f59 } /* Literal.String.Heredoc */
c-[si] { color: #a67f59 } /* Literal.String.Interpol */
c-[sx] { color: #a67f59 } /* Literal.String.Other */
c-[sr] { color: #a67f59 } /* Literal.String.Regex */
c-[ss] { color: #a67f59 } /* Literal.String.Symbol */
c-[vc] { color: #0077aa } /* Name.Variable.Class */
c-[vg] { color: #0077aa } /* Name.Variable.Global */
c-[vi] { color: #0077aa } /* Name.Variable.Instance */
c-[il] { color: #000000 } /* Literal.Number.Integer.Long */
</style>
 <body class="h-entry">
  <div class="head">
   <p data-fill-with="logo"><a class="logo" href="https://www.w3.org/"> <img alt="W3C" height="48" src="https://www.w3.org/StyleSheets/TR/2016/logos/W3C" width="72"> </a> </p>
   <h1 class="p-name no-ref" id="title">Media Capabilities</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2020-03-13">13 March 2020</time></span></h2>
   <div data-fill-with="spec-metadata">
    <dl>
     <dt>This version:
     <dd><a class="u-url" href="https://w3c.github.io/media-capabilities/">https://w3c.github.io/media-capabilities/</a>
     <dt>Issue Tracking:
     <dd><a href="https://github.com/w3c/media-capabilities/issues/">GitHub</a>
     <dd><a href="#issues-index">Inline In Spec</a>
     <dt class="editor">Editors:
     <dd class="editor p-author h-card vcard" data-editor-id="45389"><span class="p-name fn">Mounir Lamouri</span> (<a class="p-org org" href="https://www.google.com/">Google Inc.</a>)
     <dd class="editor p-author h-card vcard" data-editor-id="114832"><span class="p-name fn">Chris Cunningham</span> (<a class="p-org org" href="https://www.google.com/">Google Inc.</a>)
     <dd class="editor p-author h-card vcard" data-editor-id="116349"><span class="p-name fn">Vi Nguyen</span> (<a class="p-org org" href="https://www.microsoft.com/">Microsoft Corporation</a>)
     <dd class="editor p-author h-card vcard"><span class="p-name fn"></span>
     <dt>Participate:
     <dd><a href="https://github.com/w3c/media-capabilities">Git Repository.</a>
     <dd><a href="https://github.com/w3c/media-capabilities/issues/new">File an issue.</a>
     <dt>Version History:
     <dd><a href="https://github.com/w3c/media-capabilities/commits">https://github.com/w3c/media-capabilities/commits</a>
    </dl>
   </div>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2020 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document" rel="license">permissive document license</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>This specification intends to provide APIs to allow websites to make

an optimal decision when picking media content for the user. The APIs
will expose information about the decoding and encoding capabilities
for a given format but also output capabilities to find the best match
based on the device’s display.</p>
  </div>
  <h2 class="no-num no-toc no-ref heading settled" id="status"><span class="content">Status of this document</span></h2>
  <div data-fill-with="status">
   <p> <em>This section describes the status of this document at the time of its publication. Other
    documents may supersede this document. A list of current <abbr title="World Wide Web Consortium">W3C</abbr> publications and the latest revision of this
    technical report can be found in the <a href="http://www.w3.org/TR/"><abbr title="World Wide Web Consortium">W3C</abbr> technical
    reports index</a> at http://www.w3.org/TR/.</em> </p>
   <p> This document was published by the <a href="https://www.w3.org/media-wg/">Media Working Group</a> as an Editors' Draft. This document is intended to become a W3C Recommendation.

    Feedback and comments on this specification are welcome. Please use <a href="https://github.com/w3c/media-capabilities/issues">Github issues</a>.
    Discussions may also be found in the <a href="http://lists.w3.org/Archives/Public/public-media-wg/">public-media-wg@w3.org archives</a>. </p>
   <p> Publication as an Editors' Draft does not imply endorsement by the <abbr title="World Wide Web Consortium">W3C</abbr> Membership. This is a draft document and may
    be updated, replaced or obsoleted by other documents at any time. It is inappropriate to cite
    this document as other than work in progress. </p>
   <p> This document was produced by a group operating under the <a href="http://www.w3.org/Consortium/Patent-Policy/"> <abbr title="World Wide Web Consortium">W3C</abbr> Patent Policy</a>. <abbr title="World Wide Web Consortium">W3C</abbr> maintains a <a href="https://www.w3.org/2004/01/pp-impl/115198/status" rel="disclosure">public list of any
    patent disclosures</a> made in connection with the deliverables of the group; that page also
    includes instructions for disclosing a patent. An individual who has actual knowledge of a
    patent which the individual believes contains <a href="http://www.w3.org/Consortium/Patent-Policy/#def-essential">Essential
    Claim(s)</a> must disclose the information in accordance with <a href="http://www.w3.org/Consortium/Patent-Policy/#sec-Disclosure">section 6 of the <abbr title="World Wide Web Consortium">W3C</abbr> Patent Policy</a>. </p>
   <p> This document is governed by the <a href="https://www.w3.org/2019/Process-20190301/" id="w3c_process_revision">1 March 2019 W3C Process Document</a>. </p>
   <p></p>
  </div>
  <div data-fill-with="at-risk"></div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li><a href="#introduction"><span class="secno">1</span> <span class="content">Introduction</span></a>
    <li>
     <a href="#decoding-encoding-capabilities"><span class="secno">2</span> <span class="content">Decoding and Encoding Capabilities</span></a>
     <ol class="toc">
      <li>
       <a href="#media-configurations"><span class="secno">2.1</span> <span class="content">Media Configurations</span></a>
       <ol class="toc">
        <li><a href="#mediaconfiguration"><span class="secno">2.1.1</span> <span class="content">MediaConfiguration</span></a>
        <li><a href="#mediadecodingtype"><span class="secno">2.1.2</span> <span class="content">MediaDecodingType</span></a>
        <li><a href="#mediaencodingtype"><span class="secno">2.1.3</span> <span class="content">MediaEncodingType</span></a>
        <li><a href="#mime-type"><span class="secno">2.1.4</span> <span class="content">MIME types</span></a>
        <li><a href="#videoconfiguration"><span class="secno">2.1.5</span> <span class="content">VideoConfiguration</span></a>
        <li><a href="#hdrmetadatatype"><span class="secno">2.1.6</span> <span class="content">HdrMetadataType</span></a>
        <li><a href="#colorgamut"><span class="secno">2.1.7</span> <span class="content">ColorGamut</span></a>
        <li><a href="#transferfunction"><span class="secno">2.1.8</span> <span class="content">TransferFunction</span></a>
        <li><a href="#audioconfiguration"><span class="secno">2.1.9</span> <span class="content">AudioConfiguration</span></a>
        <li><a href="#mediacapabilitieskeysystemconfiguration"><span class="secno">2.1.10</span> <span class="content"> MediaCapabilitiesKeySystemConfiguration </span></a>
        <li><a href="#keysystemtrackconfiguration"><span class="secno">2.1.11</span> <span class="content"> KeySystemTrackConfiguration </span></a>
       </ol>
      <li><a href="#media-capabilities-info"><span class="secno">2.2</span> <span class="content">Media Capabilities Information</span></a>
      <li>
       <a href="#info-algorithms"><span class="secno">2.3</span> <span class="content">Algorithms</span></a>
       <ol class="toc">
        <li><a href="#create-media-capabilities-encoding-info"><span class="secno">2.3.1</span> <span class="content"> <span>Create a MediaCapabilitiesEncodingInfo</span> </span></a>
        <li><a href="#create-media-capabilities-decoding-info"><span class="secno">2.3.2</span> <span class="content"> <span>Create a MediaCapabilitiesDecodingInfo</span> </span></a>
        <li><a href="#is-encrypted-decode-supported"><span class="secno">2.3.3</span> <span class="content"> <span>Check Encrypted Decoding Support</span> </span></a>
       </ol>
      <li><a href="#navigators-extensions"><span class="secno">2.4</span> <span class="content">Navigator and WorkerNavigator extension</span></a>
      <li><a href="#media-capabilities-interface"><span class="secno">2.5</span> <span class="content">Media Capabilities Interface</span></a>
     </ol>
    <li>
     <a href="#security-privacy-considerations"><span class="secno">3</span> <span class="content"> Security and Privacy Considerations </span></a>
     <ol class="toc">
      <li><a href="#decoding-encoding-fingerprinting"><span class="secno">3.1</span> <span class="content"> Decoding/Encoding and Fingerprinting </span></a>
      <li><a href="#display-fingerprinting"><span class="secno">3.2</span> <span class="content">Display and Fingerprinting</span></a>
     </ol>
    <li>
     <a href="#examples"><span class="secno">4</span> <span class="content">Examples</span></a>
     <ol class="toc">
      <li><a href="#example1"><span class="secno">4.1</span> <span class="content">Query playback capabilities with <code class="idl"><span>decodingInfo()</span></code></span></a>
      <li><a href="#example2"><span class="secno">4.2</span> <span class="content">Query recording capabilities with <code class="idl"><span>encodingInfo()</span></code></span></a>
     </ol>
    <li>
     <a href="#index"><span class="secno"></span> <span class="content">Index</span></a>
     <ol class="toc">
      <li><a href="#index-defined-here"><span class="secno"></span> <span class="content">Terms defined by this specification</span></a>
      <li><a href="#index-defined-elsewhere"><span class="secno"></span> <span class="content">Terms defined by reference</span></a>
     </ol>
    <li>
     <a href="#references"><span class="secno"></span> <span class="content">References</span></a>
     <ol class="toc">
      <li><a href="#normative"><span class="secno"></span> <span class="content">Normative References</span></a>
      <li><a href="#informative"><span class="secno"></span> <span class="content">Informative References</span></a>
     </ol>
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
    <li><a href="#issues-index"><span class="secno"></span> <span class="content">Issues Index</span></a>
   </ol>
  </nav>
  <main>
   <section class="non-normative">
    <h2 class="heading settled" data-level="1" id="introduction"><span class="secno">1. </span><span class="content">Introduction</span><a class="self-link" href="#introduction"></a></h2>
     <em>This section is non-normative</em> 
    <p> This specification relies on exposing the following sets of properties: </p>
    <ul>
     <li>
      <p> An API to query the user agent with regards to the decoding and
          encoding abilities of the device based on information such as the
          codecs, profile, resolution, bitrates, etc. The API exposes
          information such as whether the playback should be smooth and power
          efficient. </p>
      <p> The intent of purposes of the decoding capabilities API is to provide
          a powerful replacement to API such as <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/media-source/#dom-mediasource-istypesupported" id="ref-for-dom-mediasource-istypesupported">isTypeSupported()</a></code> or <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/#dom-navigator-canplaytype" id="ref-for-dom-navigator-canplaytype">canPlayType()</a></code> which are vague and mostly help the
          callers to know if something can not be decoded but not how well it
          should perform. </p>
     <li>
      <p> Better information about the display properties such as supported
          color gamut or dynamic range abilities in order to pick the right
          content for the display and avoid providing HDR content to an SDR
          display. </p>
     <li>
      <p> Real time feedback about the playback so an adaptative streaming can
          alter the quality of the content based on actual user perceived
          quality. Such information will allow websites to react to a pick of
          CPU/GPU usage in real time. It is expected that this will be tackled
          as part of the <a data-link-type="biblio" href="#biblio-media-playback-quality">[media-playback-quality]</a> specification. </p>
    </ul>
    <p></p>
   </section>
   <section>
    <h2 class="heading settled" data-level="2" id="decoding-encoding-capabilities"><span class="secno">2. </span><span class="content">Decoding and Encoding Capabilities</span><a class="self-link" href="#decoding-encoding-capabilities"></a></h2>
    <section>
     <h3 class="heading settled" data-level="2.1" id="media-configurations"><span class="secno">2.1. </span><span class="content">Media Configurations</span><a class="self-link" href="#media-configurations"></a></h3>
     <section>
      <h4 class="heading settled" data-level="2.1.1" id="mediaconfiguration"><span class="secno">2.1.1. </span><span class="content">MediaConfiguration</span><a class="self-link" href="#mediaconfiguration"></a></h4>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-mediaconfiguration"><code><c- g>MediaConfiguration</c-></code></dfn> {
  <a class="n" data-link-type="idl-name" href="#dictdef-videoconfiguration" id="ref-for-dictdef-videoconfiguration"><c- n>VideoConfiguration</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="MediaConfiguration" data-dfn-type="dict-member" data-export data-type="VideoConfiguration " id="dom-mediaconfiguration-video"><code><c- g>video</c-></code></dfn>;
  <a class="n" data-link-type="idl-name" href="#dictdef-audioconfiguration" id="ref-for-dictdef-audioconfiguration"><c- n>AudioConfiguration</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="MediaConfiguration" data-dfn-type="dict-member" data-export data-type="AudioConfiguration " id="dom-mediaconfiguration-audio"><code><c- g>audio</c-></code></dfn>;
};
</pre>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-mediadecodingconfiguration"><code><c- g>MediaDecodingConfiguration</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#dictdef-mediaconfiguration" id="ref-for-dictdef-mediaconfiguration"><c- n>MediaConfiguration</c-></a> {
  <c- b>required</c-> <a class="n" data-link-type="idl-name" href="#enumdef-mediadecodingtype" id="ref-for-enumdef-mediadecodingtype"><c- n>MediaDecodingType</c-></a> <dfn class="idl-code" data-dfn-for="MediaDecodingConfiguration" data-dfn-type="dict-member" data-export data-type="MediaDecodingType " id="dom-mediadecodingconfiguration-type"><code><c- g>type</c-></code><a class="self-link" href="#dom-mediadecodingconfiguration-type"></a></dfn>;
  <a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitieskeysystemconfiguration" id="ref-for-dictdef-mediacapabilitieskeysystemconfiguration"><c- n>MediaCapabilitiesKeySystemConfiguration</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="MediaDecodingConfiguration" data-dfn-type="dict-member" data-export data-type="MediaCapabilitiesKeySystemConfiguration " id="dom-mediadecodingconfiguration-keysystemconfiguration"><code><c- g>keySystemConfiguration</c-></code></dfn>;
};
</pre>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-mediaencodingconfiguration"><code><c- g>MediaEncodingConfiguration</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#dictdef-mediaconfiguration" id="ref-for-dictdef-mediaconfiguration①"><c- n>MediaConfiguration</c-></a> {
  <c- b>required</c-> <a class="n" data-link-type="idl-name" href="#enumdef-mediaencodingtype" id="ref-for-enumdef-mediaencodingtype"><c- n>MediaEncodingType</c-></a> <dfn class="idl-code" data-dfn-for="MediaEncodingConfiguration" data-dfn-type="dict-member" data-export data-type="MediaEncodingType " id="dom-mediaencodingconfiguration-type"><code><c- g>type</c-></code><a class="self-link" href="#dom-mediaencodingconfiguration-type"></a></dfn>;
};
</pre>
      <p> The input to the decoding capabilities is represented by a <code class="idl"><a data-link-type="idl" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration">MediaDecodingConfiguration</a></code> dictionary and the input of the encoding
        capabilities by a <code class="idl"><a data-link-type="idl" href="#dictdef-mediaencodingconfiguration" id="ref-for-dictdef-mediaencodingconfiguration">MediaEncodingConfiguration</a></code> dictionary. </p>
      <p> For a <code class="idl"><a data-link-type="idl" href="#dictdef-mediaconfiguration" id="ref-for-dictdef-mediaconfiguration②">MediaConfiguration</a></code> to be a <dfn class="dfn-paneled" data-dfn-type="dfn" data-lt="valid MediaConfiguration" data-noexport id="valid-mediaconfiguration">valid 
        MediaConfiguration</dfn>, all of the following conditions MUST be true: </p>
      <ol>
       <li> <code>audio</code> and/or <code>video</code> MUST be <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present">present</a>. 
       <li> <code>audio</code> MUST be a <a data-link-type="dfn" href="#valid-audio-configuration" id="ref-for-valid-audio-configuration">valid audio configuration</a> if <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present①">present</a>. 
       <li> <code>video</code> MUST be a <a data-link-type="dfn" href="#valid-video-configuration" id="ref-for-valid-video-configuration">valid video configuration</a> if <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present②">present</a>. 
      </ol>
      <p></p>
      <p> For a <code class="idl"><a data-link-type="idl" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration①">MediaDecodingConfiguration</a></code> to be a <dfn class="dfn-paneled" data-dfn-type="dfn" data-lt="valid MediaDecodingConfiguration" data-noexport id="valid-mediadecodingconfiguration">valid 
        MediaDecodingConfiguration</dfn>, all of the following conditions MUST
        be true: </p>
      <ol>
       <li> It MUST be a <a data-link-type="dfn" href="#valid-mediaconfiguration" id="ref-for-valid-mediaconfiguration">valid MediaConfiguration</a>. 
       <li>
         If <code>keySystemConfiguration</code> is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present③">present</a>: 
        <ol>
         <li> If <code>keySystemConfiguration.audio</code> is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present④">present</a>, <code>audio</code> MUST also be <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present⑤">present</a>. 
         <li> If <code>keySystemConfiguration.video</code> is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present⑥">present</a>, <code>video</code> MUST also be <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present⑦">present</a>. 
        </ol>
      </ol>
      <p></p>
      <p> For a <code class="idl"><a data-link-type="idl" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration②">MediaDecodingConfiguration</a></code> to describe <a data-link-type="biblio" href="#biblio-encrypted-media">[ENCRYPTED-MEDIA]</a>, a <code class="idl"><a data-link-type="idl" href="#dom-mediadecodingconfiguration-keysystemconfiguration" id="ref-for-dom-mediadecodingconfiguration-keysystemconfiguration">keySystemConfiguration</a></code> MUST be <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present⑧">present</a>. </p>
     </section>
     <section>
      <h4 class="heading settled" data-level="2.1.2" id="mediadecodingtype"><span class="secno">2.1.2. </span><span class="content">MediaDecodingType</span><a class="self-link" href="#mediadecodingtype"></a></h4>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-mediadecodingtype"><code><c- g>MediaDecodingType</c-></code></dfn> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-mediadecodingtype-file" id="ref-for-dom-mediadecodingtype-file"><c- s>"file"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-mediadecodingtype-media-source" id="ref-for-dom-mediadecodingtype-media-source"><c- s>"media-source"</c-></a>,
};
</pre>
      <p> A <code class="idl"><a data-link-type="idl" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration③">MediaDecodingConfiguration</a></code> has two types: </p>
      <ul>
       <li><dfn class="dfn-paneled idl-code" data-dfn-for="MediaDecodingType" data-dfn-type="enum-value" data-export data-lt="&quot;file&quot;|file" id="dom-mediadecodingtype-file"><code>file</code></dfn> is used to
          represent a configuration that is meant to be used for a plain file
          playback.
       <li><dfn class="dfn-paneled idl-code" data-dfn-for="MediaDecodingType" data-dfn-type="enum-value" data-export data-lt="&quot;media-source&quot;|media-source" id="dom-mediadecodingtype-media-source"><code>media-source</code></dfn> is used
          to represent a configuration that is meant to be used for playback of
          a <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/media-source/#mediasource" id="ref-for-mediasource">MediaSource</a></code> as defined in the <a data-link-type="biblio" href="#biblio-media-source">[media-source]</a> specification.
      </ul>
      <p></p>
     </section>
     <section>
      <h4 class="heading settled" data-level="2.1.3" id="mediaencodingtype"><span class="secno">2.1.3. </span><span class="content">MediaEncodingType</span><a class="self-link" href="#mediaencodingtype"></a></h4>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-mediaencodingtype"><code><c- g>MediaEncodingType</c-></code></dfn> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-mediaencodingtype-record" id="ref-for-dom-mediaencodingtype-record"><c- s>"record"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-mediaencodingtype-transmission" id="ref-for-dom-mediaencodingtype-transmission"><c- s>"transmission"</c-></a>
};
</pre>
      <p> A <code class="idl"><a data-link-type="idl" href="#dictdef-mediaencodingconfiguration" id="ref-for-dictdef-mediaencodingconfiguration①">MediaEncodingConfiguration</a></code> can have one of two types: </p>
      <ul>
       <li><dfn class="dfn-paneled idl-code" data-dfn-for="MediaEncodingType" data-dfn-type="enum-value" data-export data-lt="&quot;record&quot;|record" id="dom-mediaencodingtype-record"><code>record</code></dfn> is used to
          represent a configuration for recording of media, <span class="informative">e.g. using <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/mediastream-recording/#mediarecorder" id="ref-for-mediarecorder">MediaRecorder</a></code> as defined in <a data-link-type="biblio" href="#biblio-mediastream-recording">[mediastream-recording]</a></span>.
       <li><dfn class="dfn-paneled idl-code" data-dfn-for="MediaEncodingType" data-dfn-type="enum-value" data-export data-lt="&quot;transmission&quot;|transmission" id="dom-mediaencodingtype-transmission"><code>transmission</code></dfn> is used
          to represent a configuration meant to be transmitted over electronic
          means (<span class="informative">e.g. using <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/webrtc/#interface-definition" id="ref-for-interface-definition">RTCPeerConnection</a></code> as
          defined in <a data-link-type="biblio" href="#biblio-webrtc">[webrtc]</a></span>).
      </ul>
      <p></p>
     </section>
     <section>
      <h4 class="heading settled" data-level="2.1.4" id="mime-type"><span class="secno">2.1.4. </span><span class="content">MIME types</span><a class="self-link" href="#mime-type"></a></h4>
      <p> In the context of this specification, a MIME type is also called content
        type. A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="valid-media-mime-type">valid media MIME type</dfn> is a string that is a <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#valid-mime-type" id="ref-for-valid-mime-type">valid
        MIME type</a> per <a data-link-type="biblio" href="#biblio-mimesniff">[mimesniff]</a>. If the MIME type does not imply a
        codec, the string MUST also have one and only one parameter that is
        named <code>codecs</code> with a value describing a single media codec.
        Otherwise, it MUST contain no parameters. </p>
      <p> A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="valid-audio-mime-type">valid audio MIME type</dfn> is a string that is <a data-link-type="dfn" href="#valid-media-mime-type" id="ref-for-valid-media-mime-type">valid media
        MIME type</a> and for which the <code>type</code> per <a data-link-type="biblio" href="#biblio-rfc7231">[RFC7231]</a> is
        either <code>audio</code> or <code>application</code>. </p>
      <p> A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="valid-video-mime-type">valid video MIME type</dfn> is a string that is a <a data-link-type="dfn" href="#valid-media-mime-type" id="ref-for-valid-media-mime-type①">valid media
        MIME type</a> and for which the <code>type</code> per <a data-link-type="biblio" href="#biblio-rfc7231">[RFC7231]</a> is
        either <code>video</code> or <code>application</code>. </p>
     </section>
     <section>
      <h4 class="heading settled" data-level="2.1.5" id="videoconfiguration"><span class="secno">2.1.5. </span><span class="content">VideoConfiguration</span><a class="self-link" href="#videoconfiguration"></a></h4>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-videoconfiguration"><code><c- g>VideoConfiguration</c-></code></dfn> {
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="DOMString " href="#dom-videoconfiguration-contenttype" id="ref-for-dom-videoconfiguration-contenttype"><c- g>contentType</c-></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long " href="#dom-videoconfiguration-width" id="ref-for-dom-videoconfiguration-width"><c- g>width</c-></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long " href="#dom-videoconfiguration-height" id="ref-for-dom-videoconfiguration-height"><c- g>height</c-></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long-long" id="ref-for-idl-unsigned-long-long"><c- b>unsigned</c-> <c- b>long</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long long " href="#dom-videoconfiguration-bitrate" id="ref-for-dom-videoconfiguration-bitrate"><c- g>bitrate</c-></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="double " href="#dom-videoconfiguration-framerate" id="ref-for-dom-videoconfiguration-framerate"><c- g>framerate</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="boolean " href="#dom-videoconfiguration-hasalphachannel" id="ref-for-dom-videoconfiguration-hasalphachannel"><c- g>hasAlphaChannel</c-></a>;
  <a class="n" data-link-type="idl-name" href="#enumdef-hdrmetadatatype" id="ref-for-enumdef-hdrmetadatatype"><c- n>HdrMetadataType</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="HdrMetadataType " href="#dom-videoconfiguration-hdrmetadatatype" id="ref-for-dom-videoconfiguration-hdrmetadatatype"><c- g>hdrMetadataType</c-></a>;
  <a class="n" data-link-type="idl-name" href="#enumdef-colorgamut" id="ref-for-enumdef-colorgamut"><c- n>ColorGamut</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="ColorGamut " href="#dom-videoconfiguration-colorgamut" id="ref-for-dom-videoconfiguration-colorgamut"><c- g>colorGamut</c-></a>;
  <a class="n" data-link-type="idl-name" href="#enumdef-transferfunction" id="ref-for-enumdef-transferfunction"><c- n>TransferFunction</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="TransferFunction " href="#dom-videoconfiguration-transferfunction" id="ref-for-dom-videoconfiguration-transferfunction"><c- g>transferFunction</c-></a>;
};
</pre>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="VideoConfiguration" data-dfn-type="dict-member" data-export id="dom-videoconfiguration-contenttype"><code>contentType</code></dfn> member
        represents the MIME type of the video track. </p>
      <p> To check if a <code class="idl"><a data-link-type="idl" href="#dictdef-videoconfiguration" id="ref-for-dictdef-videoconfiguration①">VideoConfiguration</a></code> <var>configuration</var> is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="valid-video-configuration">valid video configuration</dfn>, the following steps MUST be run: </p>
      <ol>
       <li> If <var>configuration</var>’s <code class="idl"><a data-link-type="idl" href="#dom-videoconfiguration-contenttype" id="ref-for-dom-videoconfiguration-contenttype①">contentType</a></code> is
            not a <a data-link-type="dfn" href="#valid-video-mime-type" id="ref-for-valid-video-mime-type">valid video MIME type</a>, return <code>false</code> and
            abort these steps. 
       <li> If <code class="idl"><a data-link-type="idl" href="#dom-videoconfiguration-framerate" id="ref-for-dom-videoconfiguration-framerate①">framerate</a></code> is not finite or is not greater
            than 0, return <code>false</code> and abort these steps. 
       <li> Return <code>true</code>. 
      </ol>
      <p></p>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="VideoConfiguration" data-dfn-type="dict-member" data-export id="dom-videoconfiguration-width"><code>width</code></dfn> and <dfn class="dfn-paneled idl-code" data-dfn-for="VideoConfiguration" data-dfn-type="dict-member" data-export id="dom-videoconfiguration-height"><code>height</code></dfn> members represent
        respectively the visible horizontal and vertical encoded pixels in the
        encoded video frames. </p>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="VideoConfiguration" data-dfn-type="dict-member" data-export id="dom-videoconfiguration-bitrate"><code>bitrate</code></dfn> member
        represents the average bitrate of the video track given in units of bits
        per second. In the case of a video stream encoded at a constant bit rate
        (CBR) this value should be accurate over a short term window. For the
        case of variable bit rate (VBR) encoding, this value should be usable to
        allocate any necessary buffering and throughput capability to
        provide for the un-interrupted decoding of the video stream over the
        long-term based on the indicated <code class="idl"><a data-link-type="idl" href="#dom-videoconfiguration-contenttype" id="ref-for-dom-videoconfiguration-contenttype②">contentType</a></code>. </p>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="VideoConfiguration" data-dfn-type="dict-member" data-export id="dom-videoconfiguration-framerate"><code>framerate</code></dfn> member
        represents the framerate of the video track. The framerate is the number
        of frames used in one second (frames per second). It is represented as a
        double. </p>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="VideoConfiguration" data-dfn-type="dict-member" data-export id="dom-videoconfiguration-hasalphachannel"><code>hasAlphaChannel</code></dfn> member
        represents whether the video track contains alpha channel information. If
        true, the encoded video stream can produce per-pixel alpha channel information
        when decoded. If false, the video stream cannot produce per-pixel alpha channel
        information when decoded. If undefined, the UA should determine whether the
        video stream encodes alpha channel information based on the indicated <code class="idl"><a data-link-type="idl" href="#dom-videoconfiguration-contenttype" id="ref-for-dom-videoconfiguration-contenttype③">contentType</a></code>, if possible. Otherwise, the UA should
        presume that the video stream cannot produce alpha channel information. </p>
      <p> If present, the <dfn class="dfn-paneled idl-code" data-dfn-for="VideoConfiguration" data-dfn-type="dict-member" data-export id="dom-videoconfiguration-hdrmetadatatype"><code>hdrMetadataType</code></dfn> member represents that the video track includes the specified HDR
        metadata type, which the UA needs to be capable of interpreting for tone
        mapping the HDR content to a color volume and luminance of the output
        device. Valid inputs are defined by <code class="idl"><a data-link-type="idl" href="#enumdef-hdrmetadatatype" id="ref-for-enumdef-hdrmetadatatype①">HdrMetadataType</a></code>. </p>
      <p> If present, the <dfn class="dfn-paneled idl-code" data-dfn-for="VideoConfiguration" data-dfn-type="dict-member" data-export id="dom-videoconfiguration-colorgamut"><code>colorGamut</code></dfn> member represents that the video track is delivered in the specified
        color gamut, which describes a set of colors in which the content is
        intended to be displayed. If the attached output device also supports
        the specified color, the UA needs to be able to cause the output device
        to render the appropriate color, or something close enough. If the
        attached output device does not support the specified color, the UA
        needs to be capable of mapping the specified color to a color supported
        by the output device. Valid inputs are defined by <code class="idl"><a data-link-type="idl" href="#enumdef-colorgamut" id="ref-for-enumdef-colorgamut①">ColorGamut</a></code>. </p>
      <p> If present, the <dfn class="dfn-paneled idl-code" data-dfn-for="VideoConfiguration" data-dfn-type="dict-member" data-export id="dom-videoconfiguration-transferfunction"><code>transferFunction</code></dfn> member represents that the video track requires the specified transfer
        function to be understood by the UA. Transfer function describes the
        electro-optical algorithm supported by the rendering capabilities of a
        user agent, independent of the display, to map the source colors in the
        decoded media into the colors to be displayed. Valid inputs are defined
        by <code class="idl"><a data-link-type="idl" href="#enumdef-transferfunction" id="ref-for-enumdef-transferfunction①">TransferFunction</a></code>. </p>
     </section>
     <section>
      <h4 class="heading settled" data-level="2.1.6" id="hdrmetadatatype"><span class="secno">2.1.6. </span><span class="content">HdrMetadataType</span><a class="self-link" href="#hdrmetadatatype"></a></h4>
      <p></p>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-hdrmetadatatype"><code><c- g>HdrMetadataType</c-></code></dfn> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-hdrmetadatatype-smptest2086" id="ref-for-dom-hdrmetadatatype-smptest2086"><c- s>"smpteSt2086"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-hdrmetadatatype-smptest2094-10" id="ref-for-dom-hdrmetadatatype-smptest2094-10"><c- s>"smpteSt2094-10"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-hdrmetadatatype-smptest2094-40" id="ref-for-dom-hdrmetadatatype-smptest2094-40"><c- s>"smpteSt2094-40"</c-></a>
};
</pre>
      <p> If present, <code class="idl"><a data-link-type="idl" href="#enumdef-hdrmetadatatype" id="ref-for-enumdef-hdrmetadatatype②">HdrMetadataType</a></code> describes the capability to interpret HDR metadata
          of the specified type. </p>
      <p> The <code class="idl"><a data-link-type="idl" href="#dictdef-videoconfiguration" id="ref-for-dictdef-videoconfiguration②">VideoConfiguration</a></code> may contain one of the following types: </p>
      <ul>
       <li> <dfn class="dfn-paneled idl-code" data-dfn-for="HdrMetadataType" data-dfn-type="enum-value" data-export data-lt="&quot;smpteSt2086&quot;|smpteSt2086" id="dom-hdrmetadatatype-smptest2086"><code>smpteSt2086</code></dfn>,
              representing the static metadata type defined by <a data-link-type="biblio" href="#biblio-smpte-st-2086">[SMPTE-ST-2086]</a>. 
       <li> <dfn class="dfn-paneled idl-code" data-dfn-for="HdrMetadataType" data-dfn-type="enum-value" data-export data-lt="&quot;smpteSt2094-10&quot;|smpteSt2094-10" id="dom-hdrmetadatatype-smptest2094-10"><code>smpteSt2094-10</code></dfn>,
              representing the dynamic metadata type defined by <a data-link-type="biblio" href="#biblio-smpte-st-2094">[SMPTE-ST-2094]</a>. 
       <li> <dfn class="dfn-paneled idl-code" data-dfn-for="HdrMetadataType" data-dfn-type="enum-value" data-export data-lt="&quot;smpteSt2094-40&quot;|smpteSt2094-40" id="dom-hdrmetadatatype-smptest2094-40"><code>smpteSt2094-40</code></dfn>,
              representing the dynamic metadata type defined by <a data-link-type="biblio" href="#biblio-smpte-st-2094">[SMPTE-ST-2094]</a>. 
      </ul>
      <p></p>
      <p></p>
     </section>
     <section>
      <h4 class="heading settled" data-level="2.1.7" id="colorgamut"><span class="secno">2.1.7. </span><span class="content">ColorGamut</span><a class="self-link" href="#colorgamut"></a></h4>
      <p></p>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-colorgamut"><code><c- g>ColorGamut</c-></code></dfn> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-colorgamut-srgb" id="ref-for-dom-colorgamut-srgb"><c- s>"srgb"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-colorgamut-p3" id="ref-for-dom-colorgamut-p3"><c- s>"p3"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-colorgamut-rec2020" id="ref-for-dom-colorgamut-rec2020"><c- s>"rec2020"</c-></a>
};
</pre>
      <p> The <code class="idl"><a data-link-type="idl" href="#dictdef-videoconfiguration" id="ref-for-dictdef-videoconfiguration③">VideoConfiguration</a></code> may contain one of the following types: </p>
      <ul>
       <li> <dfn class="dfn-paneled idl-code" data-dfn-for="ColorGamut" data-dfn-type="enum-value" data-export data-lt="&quot;srgb&quot;|srgb" id="dom-colorgamut-srgb"><code>srgb</code></dfn>, representing the <a data-link-type="biblio" href="#biblio-srgb">[sRGB]</a> color gamut. 
       <li> <dfn class="dfn-paneled idl-code" data-dfn-for="ColorGamut" data-dfn-type="enum-value" data-export data-lt="&quot;p3&quot;|p3" id="dom-colorgamut-p3"><code>p3</code></dfn>, representing the DCI
              P3 Color Space color gamut. This color gamut includes the <code class="idl"><a data-link-type="idl" href="#dom-colorgamut-srgb" id="ref-for-dom-colorgamut-srgb①">srgb</a></code> gamut. 
       <li> <dfn class="dfn-paneled idl-code" data-dfn-for="ColorGamut" data-dfn-type="enum-value" data-export data-lt="&quot;rec2020&quot;|rec2020" id="dom-colorgamut-rec2020"><code>rec2020</code></dfn>, representing
              the ITU-R Recommendation BT.2020 color gamut. This color gamut
              includes the <code class="idl"><a data-link-type="idl" href="#dom-colorgamut-p3" id="ref-for-dom-colorgamut-p3①">p3</a></code> gamut. 
      </ul>
      <p></p>
      <p></p>
     </section>
     <section>
      <h4 class="heading settled" data-level="2.1.8" id="transferfunction"><span class="secno">2.1.8. </span><span class="content">TransferFunction</span><a class="self-link" href="#transferfunction"></a></h4>
      <p></p>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-transferfunction"><code><c- g>TransferFunction</c-></code></dfn> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-transferfunction-srgb" id="ref-for-dom-transferfunction-srgb"><c- s>"srgb"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-transferfunction-pq" id="ref-for-dom-transferfunction-pq"><c- s>"pq"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-transferfunction-hlg" id="ref-for-dom-transferfunction-hlg"><c- s>"hlg"</c-></a>
};
</pre>
      <p> The <code class="idl"><a data-link-type="idl" href="#dictdef-videoconfiguration" id="ref-for-dictdef-videoconfiguration④">VideoConfiguration</a></code> may contain one of the following types: </p>
      <ul>
       <li> <dfn class="dfn-paneled idl-code" data-dfn-for="TransferFunction" data-dfn-type="enum-value" data-export data-lt="&quot;srgb&quot;|srgb" id="dom-transferfunction-srgb"><code>srgb</code></dfn>, representing
              the transfer function defined by <a data-link-type="biblio" href="#biblio-srgb">[sRGB]</a>. 
       <li> <dfn class="dfn-paneled idl-code" data-dfn-for="TransferFunction" data-dfn-type="enum-value" data-export data-lt="&quot;pq&quot;|pq" id="dom-transferfunction-pq"><code>pq</code></dfn>, representing the
              "Perceptual Quantizer" transfer function defined by <a data-link-type="biblio" href="#biblio-smpte-st-2084">[SMPTE-ST-2084]</a>. 
       <li> <dfn class="dfn-paneled idl-code" data-dfn-for="TransferFunction" data-dfn-type="enum-value" data-export data-lt="&quot;hlg&quot;|hlg" id="dom-transferfunction-hlg"><code>hlg</code></dfn>, representing the
              "Hybrid Log Gamma" transfer function defined by BT.2100. 
      </ul>
      <p></p>
      <p></p>
     </section>
     <section>
      <h4 class="heading settled" data-level="2.1.9" id="audioconfiguration"><span class="secno">2.1.9. </span><span class="content">AudioConfiguration</span><a class="self-link" href="#audioconfiguration"></a></h4>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-audioconfiguration"><code><c- g>AudioConfiguration</c-></code></dfn> {
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString①"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="DOMString " href="#dom-audioconfiguration-contenttype" id="ref-for-dom-audioconfiguration-contenttype"><c- g>contentType</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString②"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="DOMString " href="#dom-audioconfiguration-channels" id="ref-for-dom-audioconfiguration-channels"><c- g>channels</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long-long" id="ref-for-idl-unsigned-long-long①"><c- b>unsigned</c-> <c- b>long</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long long " href="#dom-audioconfiguration-bitrate" id="ref-for-dom-audioconfiguration-bitrate"><c- g>bitrate</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long②"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long " href="#dom-audioconfiguration-samplerate" id="ref-for-dom-audioconfiguration-samplerate"><c- g>samplerate</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean①"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="boolean " href="#dom-audioconfiguration-spatialrendering" id="ref-for-dom-audioconfiguration-spatialrendering"><c- g>spatialRendering</c-></a>;
};
</pre>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="AudioConfiguration" data-dfn-type="dict-member" data-export id="dom-audioconfiguration-contenttype"><code>contentType</code></dfn> member
        represents the MIME type of the audio track. </p>
      <p> To check if a <code class="idl"><a data-link-type="idl" href="#dictdef-audioconfiguration" id="ref-for-dictdef-audioconfiguration①">AudioConfiguration</a></code> <var>configuration</var> is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="valid-audio-configuration">valid audio configuration</dfn>, the following steps MUST be run: </p>
      <ol>
       <li> If <var>configuration</var>’s <code class="idl"><a data-link-type="idl" href="#dom-audioconfiguration-contenttype" id="ref-for-dom-audioconfiguration-contenttype①">contentType</a></code> is
            not a <a data-link-type="dfn" href="#valid-audio-mime-type" id="ref-for-valid-audio-mime-type">valid audio MIME type</a>, return <code>false</code> and
            abort these steps. 
       <li> Return <code>true</code>. 
      </ol>
      <p></p>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="AudioConfiguration" data-dfn-type="dict-member" data-export id="dom-audioconfiguration-channels"><code>channels</code></dfn> member
        represents the audio channels used by the audio track. </p>
      <p class="issue" id="issue-a7738173"><a class="self-link" href="#issue-a7738173"></a> The <code class="idl"><a data-link-type="idl" href="#dom-audioconfiguration-channels" id="ref-for-dom-audioconfiguration-channels①">channels</a></code> needs to be defined as a <code>double</code> (2.1, 4.1, 5.1, ...), an <code>unsigned short</code> (number of channels) or as an <code>enum</code> value. The current
        definition is a placeholder. </p>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="AudioConfiguration" data-dfn-type="dict-member" data-export id="dom-audioconfiguration-bitrate"><code>bitrate</code></dfn> member
        represents the number of average bitrate of the audio track. The bitrate
        is the number of bits used to encode a second of the audio track. </p>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="AudioConfiguration" data-dfn-type="dict-member" data-export id="dom-audioconfiguration-samplerate"><code>samplerate</code></dfn> represents the samplerate of the audio track in. The samplerate is the
        number of samples of audio carried per second. </p>
      <p class="note" role="note"> The <code class="idl"><a data-link-type="idl" href="#dom-audioconfiguration-samplerate" id="ref-for-dom-audioconfiguration-samplerate①">samplerate</a></code> is expressed in <code>Hz</code> (ie. number of samples of audio per second). Sometimes the samplerates
        value are expressed in <code>kHz</code> which represents the number of
        thousands of samples of audio per second.<br> 44100 <code>Hz</code> is equivalent to 44.1 <code>kHz</code>. </p>
      <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="AudioConfiguration" data-dfn-type="dict-member" data-export id="dom-audioconfiguration-spatialrendering"><code>spatialRendering</code></dfn> member indicates that the audio SHOULD be renderered spatially. The 
        details of spatial rendering SHOULD be inferred from the <code class="idl"><a data-link-type="idl" href="#dom-audioconfiguration-contenttype" id="ref-for-dom-audioconfiguration-contenttype②">contentType</a></code>. If not <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present⑨">present</a>, the UA MUST 
        presume spatialRendering is not required. When <code>true</code>, the
        user agent SHOULD only report this configuration as <a data-link-type="dfn" href="#mediacapabilitiesinfo-supported" id="ref-for-mediacapabilitiesinfo-supported">supported</a> if it can support spatial
        rendering *for the current audio output device* without failing back to a
        non-spatial mix of the stream. </p>
     </section>
    </section>
    <section>
     <h4 class="heading settled" data-level="2.1.10" id="mediacapabilitieskeysystemconfiguration"><span class="secno">2.1.10. </span><span class="content"> MediaCapabilitiesKeySystemConfiguration </span><a class="self-link" href="#mediacapabilitieskeysystemconfiguration"></a></h4>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-mediacapabilitieskeysystemconfiguration"><code><c- g>MediaCapabilitiesKeySystemConfiguration</c-></code></dfn> {
    <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString③"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="DOMString " href="#dom-mediacapabilitieskeysystemconfiguration-keysystem" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-keysystem"><c- g>keySystem</c-></a>;
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString④"><c- b>DOMString</c-></a> <a class="idl-code" data-default="&quot;&quot;" data-link-type="dict-member" data-type="DOMString " href="#dom-mediacapabilitieskeysystemconfiguration-initdatatype" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-initdatatype"><c- g>initDataType</c-></a> = "";
    <a class="n" data-link-type="idl-name" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysrequirement" id="ref-for-dom-mediakeysrequirement"><c- n>MediaKeysRequirement</c-></a> <a class="idl-code" data-default="&quot;optional&quot;" data-link-type="dict-member" data-type="MediaKeysRequirement " href="#dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier"><c- g>distinctiveIdentifier</c-></a> = "optional";
    <a class="n" data-link-type="idl-name" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysrequirement" id="ref-for-dom-mediakeysrequirement①"><c- n>MediaKeysRequirement</c-></a> <a class="idl-code" data-default="&quot;optional&quot;" data-link-type="dict-member" data-type="MediaKeysRequirement " href="#dom-mediacapabilitieskeysystemconfiguration-persistentstate" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-persistentstate"><c- g>persistentState</c-></a> = "optional";
    <c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑤"><c- b>DOMString</c-></a>> <a class="idl-code" data-link-type="dict-member" data-type="sequence<DOMString> " href="#dom-mediacapabilitieskeysystemconfiguration-sessiontypes" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-sessiontypes"><c- g>sessionTypes</c-></a>;
    <a class="n" data-link-type="idl-name" href="#dictdef-keysystemtrackconfiguration" id="ref-for-dictdef-keysystemtrackconfiguration"><c- n>KeySystemTrackConfiguration</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="KeySystemTrackConfiguration " href="#dom-mediacapabilitieskeysystemconfiguration-audio" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-audio"><c- g>audio</c-></a>;
    <a class="n" data-link-type="idl-name" href="#dictdef-keysystemtrackconfiguration" id="ref-for-dictdef-keysystemtrackconfiguration①"><c- n>KeySystemTrackConfiguration</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="KeySystemTrackConfiguration " href="#dom-mediacapabilitieskeysystemconfiguration-video" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-video"><c- g>video</c-></a>;
  };

</pre>
     <p class="note" role="note"> This dictionary refers to a number of types defined by <a data-link-type="biblio" href="#biblio-encrypted-media">[ENCRYPTED-MEDIA]</a> (EME). Sequences of EME types are
        flattened to a single value whenever the intent of the sequence was to
        have <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#navigator-extension:-requestmediakeysystemaccess()" id="ref-for-navigator-extension:-requestmediakeysystemaccess()">requestMediaKeySystemAccess()</a></code> choose a subset it supports.
        With MediaCapabilities, callers provide the sequence across multiple
        calls, ultimately letting the caller choose which configuration to use. </p>
     <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilitiesKeySystemConfiguration" data-dfn-type="dict-member" data-export id="dom-mediacapabilitieskeysystemconfiguration-keysystem"><code>keySystem</code></dfn> member represents a <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemaccess-keysystem" id="ref-for-dom-mediakeysystemaccess-keysystem">keySystem</a></code> name as described in <a data-link-type="biblio" href="#biblio-encrypted-media">[ENCRYPTED-MEDIA]</a>. </p>
     <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilitiesKeySystemConfiguration" data-dfn-type="dict-member" data-export id="dom-mediacapabilitieskeysystemconfiguration-initdatatype"><code>initDataType</code></dfn> member represents a single value from the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-initdatatypes" id="ref-for-dom-mediakeysystemconfiguration-initdatatypes">initDataTypes</a></code> sequence
        described in <a data-link-type="biblio" href="#biblio-encrypted-media">[ENCRYPTED-MEDIA]</a>. </p>
     <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilitiesKeySystemConfiguration" data-dfn-type="dict-member" data-export id="dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier"><code>distinctiveIdentifier</code></dfn> member represents a <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-distinctiveidentifier" id="ref-for-dom-mediakeysystemconfiguration-distinctiveidentifier">distinctiveIdentifier</a></code> requirement as
        described in <a data-link-type="biblio" href="#biblio-encrypted-media">[ENCRYPTED-MEDIA]</a>. </p>
     <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilitiesKeySystemConfiguration" data-dfn-type="dict-member" data-export id="dom-mediacapabilitieskeysystemconfiguration-persistentstate"><code>persistentState</code></dfn> member represents a <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-persistentstate" id="ref-for-dom-mediakeysystemconfiguration-persistentstate">persistentState</a></code> requirement as described in <a data-link-type="biblio" href="#biblio-encrypted-media">[ENCRYPTED-MEDIA]</a>. </p>
     <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilitiesKeySystemConfiguration" data-dfn-type="dict-member" data-export id="dom-mediacapabilitieskeysystemconfiguration-sessiontypes"><code>sessionTypes</code></dfn> member represents a sequence of required <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-sessiontypes" id="ref-for-dom-mediakeysystemconfiguration-sessiontypes">sessionTypes</a></code> as
        described in <a data-link-type="biblio" href="#biblio-encrypted-media">[ENCRYPTED-MEDIA]</a>. </p>
     <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilitiesKeySystemConfiguration" data-dfn-type="dict-member" data-export id="dom-mediacapabilitieskeysystemconfiguration-audio"><code>audio</code></dfn> member
        represents a <code class="idl"><a data-link-type="idl" href="#dictdef-keysystemtrackconfiguration" id="ref-for-dictdef-keysystemtrackconfiguration②">KeySystemTrackConfiguration</a></code> associated with the <code class="idl"><a data-link-type="idl" href="#dictdef-audioconfiguration" id="ref-for-dictdef-audioconfiguration②">AudioConfiguration</a></code>. </p>
     <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilitiesKeySystemConfiguration" data-dfn-type="dict-member" data-export id="dom-mediacapabilitieskeysystemconfiguration-video"><code>video</code></dfn> member
        represents a <code class="idl"><a data-link-type="idl" href="#dictdef-keysystemtrackconfiguration" id="ref-for-dictdef-keysystemtrackconfiguration③">KeySystemTrackConfiguration</a></code> associated with the <code class="idl"><a data-link-type="idl" href="#dictdef-videoconfiguration" id="ref-for-dictdef-videoconfiguration⑤">VideoConfiguration</a></code>. </p>
    </section>
    <section>
     <h4 class="heading settled" data-level="2.1.11" id="keysystemtrackconfiguration"><span class="secno">2.1.11. </span><span class="content"> KeySystemTrackConfiguration </span><a class="self-link" href="#keysystemtrackconfiguration"></a></h4>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-keysystemtrackconfiguration"><code><c- g>KeySystemTrackConfiguration</c-></code></dfn> {
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑥"><c- b>DOMString</c-></a> <a class="idl-code" data-default="&quot;&quot;" data-link-type="dict-member" data-type="DOMString " href="#dom-keysystemtrackconfiguration-robustness" id="ref-for-dom-keysystemtrackconfiguration-robustness"><c- g>robustness</c-></a> = "";
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑦"><c- b>DOMString</c-></a>? <a class="idl-code" data-default="null" data-link-type="dict-member" data-type="DOMString? " href="#dom-keysystemtrackconfiguration-encryptionscheme" id="ref-for-dom-keysystemtrackconfiguration-encryptionscheme"><c- g>encryptionScheme</c-></a> = <c- b>null</c->;
  };

</pre>
     <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="KeySystemTrackConfiguration" data-dfn-type="dict-member" data-export id="dom-keysystemtrackconfiguration-robustness"><code>robustness</code></dfn> member represents a <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemmediacapability-robustness" id="ref-for-dom-mediakeysystemmediacapability-robustness">robustness</a></code> level as described in <a data-link-type="biblio" href="#biblio-encrypted-media">[ENCRYPTED-MEDIA]</a>. </p>
     <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="KeySystemTrackConfiguration" data-dfn-type="dict-member" data-export id="dom-keysystemtrackconfiguration-encryptionscheme"><code>encryptionScheme</code></dfn> member represents an <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/encrypted-media/#dom-mediakeysystemmediacapability-encryptionscheme" id="ref-for-dom-mediakeysystemmediacapability-encryptionscheme">encryptionScheme</a></code> as described in <a data-link-type="biblio" href="#biblio-encrypted-media-draft">[ENCRYPTED-MEDIA-DRAFT]</a>. </p>
    </section>
    <section>
     <h3 class="heading settled" data-level="2.2" id="media-capabilities-info"><span class="secno">2.2. </span><span class="content">Media Capabilities Information</span><a class="self-link" href="#media-capabilities-info"></a></h3>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-mediacapabilitiesinfo"><code><c- g>MediaCapabilitiesInfo</c-></code></dfn> {
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean②"><c- b>boolean</c-></a> <dfn class="idl-code" data-dfn-for="MediaCapabilitiesInfo" data-dfn-type="dict-member" data-export data-type="boolean " id="dom-mediacapabilitiesinfo-supported"><code><c- g>supported</c-></code><a class="self-link" href="#dom-mediacapabilitiesinfo-supported"></a></dfn>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean③"><c- b>boolean</c-></a> <dfn class="idl-code" data-dfn-for="MediaCapabilitiesInfo" data-dfn-type="dict-member" data-export data-type="boolean " id="dom-mediacapabilitiesinfo-smooth"><code><c- g>smooth</c-></code><a class="self-link" href="#dom-mediacapabilitiesinfo-smooth"></a></dfn>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean④"><c- b>boolean</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilitiesInfo" data-dfn-type="dict-member" data-export data-type="boolean " id="dom-mediacapabilitiesinfo-powerefficient"><code><c- g>powerEfficient</c-></code></dfn>;
};
</pre>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-mediacapabilitiesdecodinginfo"><code><c- g>MediaCapabilitiesDecodingInfo</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitiesinfo" id="ref-for-dictdef-mediacapabilitiesinfo"><c- n>MediaCapabilitiesInfo</c-></a> {
  <c- b>required</c-> <a class="n" data-link-type="idl-name" href="https://www.w3.org/TR/encrypted-media/#mediakeysystemaccess-interface" id="ref-for-mediakeysystemaccess-interface"><c- n>MediaKeySystemAccess</c-></a> <dfn class="idl-code" data-dfn-for="MediaCapabilitiesDecodingInfo" data-dfn-type="dict-member" data-export data-type="MediaKeySystemAccess " id="dom-mediacapabilitiesdecodinginfo-keysystemaccess"><code><c- g>keySystemAccess</c-></code><a class="self-link" href="#dom-mediacapabilitiesdecodinginfo-keysystemaccess"></a></dfn>;
  <a class="n" data-link-type="idl-name" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration④"><c- n>MediaDecodingConfiguration</c-></a> <dfn class="idl-code" data-dfn-for="MediaCapabilitiesDecodingInfo" data-dfn-type="dict-member" data-export data-type="MediaDecodingConfiguration " id="dom-mediacapabilitiesdecodinginfo-configuration"><code><c- g>configuration</c-></code><a class="self-link" href="#dom-mediacapabilitiesdecodinginfo-configuration"></a></dfn>;
};
</pre>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-mediacapabilitiesencodinginfo"><code><c- g>MediaCapabilitiesEncodingInfo</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitiesinfo" id="ref-for-dictdef-mediacapabilitiesinfo①"><c- n>MediaCapabilitiesInfo</c-></a> {
  <a class="n" data-link-type="idl-name" href="#dictdef-mediaencodingconfiguration" id="ref-for-dictdef-mediaencodingconfiguration②"><c- n>MediaEncodingConfiguration</c-></a> <dfn class="idl-code" data-dfn-for="MediaCapabilitiesEncodingInfo" data-dfn-type="dict-member" data-export data-type="MediaEncodingConfiguration " id="dom-mediacapabilitiesencodinginfo-configuration"><code><c- g>configuration</c-></code><a class="self-link" href="#dom-mediacapabilitiesencodinginfo-configuration"></a></dfn>;
};
</pre>
     <p> A <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesinfo" id="ref-for-dictdef-mediacapabilitiesinfo②">MediaCapabilitiesInfo</a></code> has associated <dfn class="dfn-paneled" data-dfn-for="MediaCapabilitiesInfo" data-dfn-type="dfn" data-noexport id="mediacapabilitiesinfo-supported">supported</dfn>, <dfn class="dfn-paneled" data-dfn-for="MediaCapabilitiesInfo" data-dfn-type="dfn" data-noexport id="mediacapabilitiesinfo-smooth">smooth</dfn>, <dfn class="dfn-paneled" data-dfn-for="MediaCapabilitiesInfo" data-dfn-type="dfn" data-noexport id="mediacapabilitiesinfo-powerefficient">powerEfficient</dfn> fields which are
      booleans. </p>
     <p class="note" role="note"> Authors can use <code class="idl"><a data-link-type="idl" href="#dom-mediacapabilitiesinfo-powerefficient" id="ref-for-dom-mediacapabilitiesinfo-powerefficient">powerEfficient</a></code> in concordance
      with the Battery Status API <a data-link-type="biblio" href="#biblio-battery-status">[battery-status]</a> in order to determine
      whether the media they would like to play is appropriate for the user
      configuration. It is worth noting that even when a device is not power
      constrained, high power usage has side effects such as increasing the
      temperature or the fans noise. </p>
     <p> A <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesdecodinginfo" id="ref-for-dictdef-mediacapabilitiesdecodinginfo">MediaCapabilitiesDecodingInfo</a></code> has associated <dfn class="dfn-paneled" data-dfn-for="MediaCapabilitiesDecodingInfo" data-dfn-type="dfn" data-noexport id="mediacapabilitiesdecodinginfo-keysystemaccess">keySystemAccess</dfn> which is a <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#mediakeysystemaccess-interface" id="ref-for-mediakeysystemaccess-interface①">MediaKeySystemAccess</a></code> or <code>null</code> as appropriate. </p>
     <p> A <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesdecodinginfo" id="ref-for-dictdef-mediacapabilitiesdecodinginfo①">MediaCapabilitiesDecodingInfo</a></code> has an associated <dfn class="dfn-paneled" data-dfn-for="MediaCapabilitiesDecodingInfo" data-dfn-type="dfn" data-noexport id="mediacapabilitiesdecodinginfo-configuration">configuration</dfn> which
      is the decoding configuration properties used to generate the <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesdecodinginfo" id="ref-for-dictdef-mediacapabilitiesdecodinginfo②">MediaCapabilitiesDecodingInfo</a></code>. </p>
     <p> A <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesencodinginfo" id="ref-for-dictdef-mediacapabilitiesencodinginfo">MediaCapabilitiesEncodingInfo</a></code> has an associated <dfn class="dfn-paneled" data-dfn-for="MediaCapabilitiesEncodingInfo" data-dfn-type="dfn" data-noexport id="mediacapabilitiesencodinginfo-configuration">configuration</dfn> which
      is the encoding configuration properties used to generate the <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesencodinginfo" id="ref-for-dictdef-mediacapabilitiesencodinginfo①">MediaCapabilitiesEncodingInfo</a></code>. </p>
     <p class="note" role="note"> If the encrypted decoding configuration is supported, the
      resulting <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesinfo" id="ref-for-dictdef-mediacapabilitiesinfo③">MediaCapabilitiesInfo</a></code> will include a <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#mediakeysystemaccess-interface" id="ref-for-mediakeysystemaccess-interface②">MediaKeySystemAccess</a></code>. Authors may use this to create <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#mediakeys-interface" id="ref-for-mediakeys-interface">MediaKeys</a></code> and setup encrypted playback. </p>
     <section>
      <h3 class="heading settled" data-level="2.3" id="info-algorithms"><span class="secno">2.3. </span><span class="content">Algorithms</span><a class="self-link" href="#info-algorithms"></a></h3>
      <section>
       <h4 class="heading settled" data-level="2.3.1" id="create-media-capabilities-encoding-info"><span class="secno">2.3.1. </span><span class="content"> <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="create-a-mediacapabilitiesencodinginfo">Create a MediaCapabilitiesEncodingInfo</dfn> </span><a class="self-link" href="#create-media-capabilities-encoding-info"></a></h4>
       <p> Given a <code class="idl"><a data-link-type="idl" href="#dictdef-mediaencodingconfiguration" id="ref-for-dictdef-mediaencodingconfiguration③">MediaEncodingConfiguration</a></code> <var>configuration</var>, this
          algorithm returns a <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesencodinginfo" id="ref-for-dictdef-mediacapabilitiesencodinginfo②">MediaCapabilitiesEncodingInfo</a></code>. The following steps are
          run: </p>
       <ol>
        <li> Let <var>info</var> be a new <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesencodinginfo" id="ref-for-dictdef-mediacapabilitiesencodinginfo③">MediaCapabilitiesEncodingInfo</a></code> instance.
              Unless stated otherwise, reading and writing apply to <var>info</var> for the next steps. 
        <li> Set <a data-link-type="dfn" href="#mediacapabilitiesencodinginfo-configuration" id="ref-for-mediacapabilitiesencodinginfo-configuration">configuration</a> to be a new <code class="idl"><a data-link-type="idl" href="#dictdef-mediaencodingconfiguration" id="ref-for-dictdef-mediaencodingconfiguration④">MediaEncodingConfiguration</a></code>. For every property in <var>configuration</var> create a new property with the same name and value in <a data-link-type="dfn" href="#mediacapabilitiesencodinginfo-configuration" id="ref-for-mediacapabilitiesencodinginfo-configuration①">configuration</a>. 
        <li> If the user agent is able to encode the media represented by <var>configuration</var>, set <a data-link-type="dfn" href="#mediacapabilitiesinfo-supported" id="ref-for-mediacapabilitiesinfo-supported①">supported</a> to <code>true</code>. Otherwise set it to <code>false</code>. 
        <li> If the user agent is able to encode the media represented by <var>configuration</var> at a pace that
              allows encoding frames at the same pace as they are sent to 
              the encoder, set <a data-link-type="dfn" href="#mediacapabilitiesinfo-smooth" id="ref-for-mediacapabilitiesinfo-smooth">smooth</a> to <code>true</code>. Otherwise set it to <code>false</code>. 
        <li> If the user agent is able to encode the media represented by <var>configuration</var> in a power
              efficient manner, set <a data-link-type="dfn" href="#mediacapabilitiesinfo-powerefficient" id="ref-for-mediacapabilitiesinfo-powerefficient">powerEfficient</a> to <code>true</code>. Otherwise set it to <code>false</code>. 
              The user agent SHOULD NOT take into consideration the current 
              power source in order to determine the encoding power 
              efficiency unless the device’s power source has side effects 
              such as enabling different encoding modules. 
        <li> Return <var>info</var>. 
       </ol>
       <p></p>
      </section>
      <section>
       <h4 class="heading settled" data-level="2.3.2" id="create-media-capabilities-decoding-info"><span class="secno">2.3.2. </span><span class="content"> <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="create-a-mediacapabilitiesdecodinginfo">Create a MediaCapabilitiesDecodingInfo</dfn> </span><a class="self-link" href="#create-media-capabilities-decoding-info"></a></h4>
       <p> Given a <code class="idl"><a data-link-type="idl" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration⑤">MediaDecodingConfiguration</a></code> <var>configuration</var>, this
          algorithm returns a <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesdecodinginfo" id="ref-for-dictdef-mediacapabilitiesdecodinginfo③">MediaCapabilitiesDecodingInfo</a></code>. The following 
          steps are run: </p>
       <ol>
        <li> Let <var>info</var> be a new <code class="idl"><a data-link-type="idl" href="#dictdef-mediacapabilitiesdecodinginfo" id="ref-for-dictdef-mediacapabilitiesdecodinginfo④">MediaCapabilitiesDecodingInfo</a></code> instance.
              Unless stated otherwise, reading and writing apply to <var>info</var> for the next steps. 
        <li> Set <a data-link-type="dfn" href="#mediacapabilitiesdecodinginfo-configuration" id="ref-for-mediacapabilitiesdecodinginfo-configuration">configuration</a> to be a new <code class="idl"><a data-link-type="idl" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration⑥">MediaDecodingConfiguration</a></code>. For every property in <var>configuration</var> create a new property with the same name and value in <a data-link-type="dfn" href="#mediacapabilitiesdecodinginfo-configuration" id="ref-for-mediacapabilitiesdecodinginfo-configuration①">configuration</a>. 
        <li>
          If <code>configuration.keySystemConfiguration</code> is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present①⓪">present</a>: 
         <ol>
          <li> Set <a data-link-type="dfn" href="#mediacapabilitiesdecodinginfo-keysystemaccess" id="ref-for-mediacapabilitiesdecodinginfo-keysystemaccess">keySystemAccess</a> to the result of running the <a data-link-type="dfn" href="#check-encrypted-decoding-support" id="ref-for-check-encrypted-decoding-support">Check Encrypted Decoding 
                  Support</a> algorithm with <var>configuration</var>. 
          <li> If <a data-link-type="dfn" href="#mediacapabilitiesdecodinginfo-keysystemaccess" id="ref-for-mediacapabilitiesdecodinginfo-keysystemaccess①">keySystemAccess</a> is not <code>null</code> set <a data-link-type="dfn" href="#mediacapabilitiesinfo-supported" id="ref-for-mediacapabilitiesinfo-supported②">supported</a> to <code>true</code>. Otherwise set it to <code>false</code>. 
         </ol>
        <li>
          Otherwise, run the following steps: 
         <ol>
          <li> Set <a data-link-type="dfn" href="#mediacapabilitiesdecodinginfo-keysystemaccess" id="ref-for-mediacapabilitiesdecodinginfo-keysystemaccess②">keySystemAccess</a> to <code>null</code>. 
          <li> If the user agent is able to decode the media represented
                  by <var>configuration</var>, set <a data-link-type="dfn" href="#mediacapabilitiesinfo-supported" id="ref-for-mediacapabilitiesinfo-supported③">supported</a> to <code>true</code>. 
          <li>Otherwise, set it to <code>false</code>.
         </ol>
        <li> If the user agent is able to decode the media represented by <var>configuration</var> at a pace that allows a smooth
              playback, set <a data-link-type="dfn" href="#mediacapabilitiesinfo-smooth" id="ref-for-mediacapabilitiesinfo-smooth①">smooth</a> to <code>true</code>. Otherwise set it to <code>false</code>. 
        <li> If the user agent is able to decode the media represented by <var>configuration</var> in a power efficient
              manner, set <a data-link-type="dfn" href="#mediacapabilitiesinfo-powerefficient" id="ref-for-mediacapabilitiesinfo-powerefficient①">powerEfficient</a> to <code>true</code>. Otherwise set it to <code>false</code>. The
              user agent SHOULD NOT take into consideration the current 
              power source in order to determine the decoding power 
              efficiency unless the device’s power source has side effects 
              such as enabling different decoding modules. 
        <li> Return <var>info</var>. 
       </ol>
       <p></p>
      </section>
      <section>
       <h4 class="heading settled" data-level="2.3.3" id="is-encrypted-decode-supported"><span class="secno">2.3.3. </span><span class="content"> <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="check-encrypted-decoding-support">Check Encrypted Decoding Support</dfn> </span><a class="self-link" href="#is-encrypted-decode-supported"></a></h4>
       <p> Given a <code class="idl"><a data-link-type="idl" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration⑦">MediaDecodingConfiguration</a></code> <var>config</var> with a <code class="idl"><a data-link-type="idl" href="#dom-mediadecodingconfiguration-keysystemconfiguration" id="ref-for-dom-mediadecodingconfiguration-keysystemconfiguration①">keySystemConfiguration</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present①①">present</a>, this algorithm returns a <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#mediakeysystemaccess-interface" id="ref-for-mediakeysystemaccess-interface③">MediaKeySystemAccess</a></code> or <code>null</code> as appropriate. The
          following steps are run: </p>
       <ol>
        <li> If the <code class="idl"><a data-link-type="idl" href="#dom-mediacapabilitieskeysystemconfiguration-keysystem" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-keysystem①">keySystem</a></code> member of <code>config.keySystemConfiguration</code> is not one of the <a data-link-type="dfn" href="https://www.w3.org/TR/encrypted-media/#key-system" id="ref-for-key-system">Key Systems</a> supported by the user agent, return <code>null</code>. String comparison is case-sensitive. 
        <li> Let <var>origin</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/#concept-origin" id="ref-for-concept-origin">origin</a> of the calling 
              context’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document">Document</a>. 
        <li> Let <var>implementation</var> be the implementation of <code>config.keySystemConfiguration.keySystem</code> 
        <li> Let <var>emeConfiguration</var> be a new <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#mediakeysystemconfiguration-dictionary" id="ref-for-mediakeysystemconfiguration-dictionary">MediaKeySystemConfiguration</a></code>, and initialize it as follows: 
        <ol>
         <li> Set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-initdatatypes" id="ref-for-dom-mediakeysystemconfiguration-initdatatypes①">initDataTypes</a></code> attribute to a sequence containing <code>config.keySystemConfiguration.initDataType</code>. 
         <li> Set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-distinctiveidentifier" id="ref-for-dom-mediakeysystemconfiguration-distinctiveidentifier①">distinctiveIdentifier</a></code> attribute to <code>config.keySystemConfiguration.distinctiveIdentifier</code>. 
         <li> Set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-persistentstate" id="ref-for-dom-mediakeysystemconfiguration-persistentstate①">persistentState</a></code> attribute to <code>config.keySystemConfiguration.peristentState</code>. 
         <li> Set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-sessiontypes" id="ref-for-dom-mediakeysystemconfiguration-sessiontypes①">sessionTypes</a></code> attribute to <code>config.keySystemConfiguration.sessionTypes</code>. 
         <li>
           If <code class="idl"><a data-link-type="idl" href="#dom-mediaconfiguration-audio" id="ref-for-dom-mediaconfiguration-audio">audio</a></code> is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present①②">present</a> in <var>config</var>, set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-audiocapabilities" id="ref-for-dom-mediakeysystemconfiguration-audiocapabilities">audioCapabilities</a></code> attribute to a sequence containing a
                single <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#mediakeysystemmediacapability-dictionary" id="ref-for-mediakeysystemmediacapability-dictionary">MediaKeySystemMediaCapability</a></code>, initialized as
                follows: 
          <ol>
           <li> Set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemmediacapability-contenttype" id="ref-for-dom-mediakeysystemmediacapability-contenttype">contentType</a></code> attribute to <code>config.audio.contentType</code>. 
           <li>
             If <code>config.keySystemConfiguration.audio</code> is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present①③">present</a>: 
            <ol>
             <li> Set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemmediacapability-robustness" id="ref-for-dom-mediakeysystemmediacapability-robustness①">robustness</a></code> attribute to <code> config.keySystemConfiguration.audio.robustness</code> 
             <li> Set the <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/encrypted-media/#dom-mediakeysystemmediacapability-encryptionscheme" id="ref-for-dom-mediakeysystemmediacapability-encryptionscheme①">encryptionScheme</a></code> attribute to <code> config.keySystemConfiguration.audio.encryptionScheme</code> 
            </ol>
          </ol>
         <li>
           If <code class="idl"><a data-link-type="idl" href="#dom-mediaconfiguration-video" id="ref-for-dom-mediaconfiguration-video">video</a></code> is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present①④">present</a> in <var>config</var>, set the
                videoCapabilities attribute to a sequence containing a single <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#mediakeysystemmediacapability-dictionary" id="ref-for-mediakeysystemmediacapability-dictionary①">MediaKeySystemMediaCapability</a></code>, initialized as follows: 
          <ol>
           <li> Set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemmediacapability-contenttype" id="ref-for-dom-mediakeysystemmediacapability-contenttype①">contentType</a></code> attribute to <code>config.video.contentType</code>. 
           <li>
             If <code>config.keySystemConfiguration.video</code> is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present①⑤">present</a>: 
            <ol>
             <li> Set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemmediacapability-robustness" id="ref-for-dom-mediakeysystemmediacapability-robustness②">robustness</a></code> attribute to <code> config.keySystemConfiguration.video.robustness</code>. 
             <li> Set the <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/encrypted-media/#dom-mediakeysystemmediacapability-encryptionscheme" id="ref-for-dom-mediakeysystemmediacapability-encryptionscheme②">encryptionScheme</a></code> attribute to <code> config.keySystemConfiguration.video.encryptionScheme</code> 
            </ol>
          </ol>
        </ol>
        <li> Let <var>supported configuration</var> be the result of
              executing the <a data-link-type="dfn" href="https://www.w3.org/TR/encrypted-media/#get-supported-configuration" id="ref-for-get-supported-configuration">Get Supported Configuration</a> algorithm on <var>implementation</var>, <var>emeConfiguration</var>, and <var>origin</var>. 
        <li> If <var>supported configuration</var> is <code>NotSupported</code>, return <code>null</code> and abort
              these steps. 
        <li>
          Let <var>access</var> be a new <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#mediakeysystemaccess-interface" id="ref-for-mediakeysystemaccess-interface④">MediaKeySystemAccess</a></code> object, and initialize it as follows: 
         <ol>
          <li> Set the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemaccess-keysystem" id="ref-for-dom-mediakeysystemaccess-keysystem①">keySystem</a></code> attribute to <code>emeConfiguration.keySystem</code>. 
          <li> Let the <var>configuration</var> value be <var>supported configuration</var>. 
          <li> Let the <var>cdm implementation</var> value be <var>implementation</var>. 
         </ol>
        <li>Return <var>access</var>
       </ol>
       <p></p>
      </section>
     </section>
     <section>
      <h3 class="heading settled" data-level="2.4" id="navigators-extensions"><span class="secno">2.4. </span><span class="content">Navigator and WorkerNavigator extension</span><a class="self-link" href="#navigators-extensions"></a></h3>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/system-state.html#navigator" id="ref-for-navigator"><c- g>Navigator</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#mediacapabilities" id="ref-for-mediacapabilities"><c- n>MediaCapabilities</c-></a> <dfn class="idl-code" data-dfn-for="Navigator" data-dfn-type="attribute" data-export data-readonly data-type="MediaCapabilities" id="dom-navigator-mediacapabilities"><code><c- g>mediaCapabilities</c-></code><a class="self-link" href="#dom-navigator-mediacapabilities"></a></dfn>;
};
</pre>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①"><c- g>Exposed</c-></a>=<c- n>Worker</c->]
<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/workers.html#workernavigator" id="ref-for-workernavigator"><c- g>WorkerNavigator</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject①"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#mediacapabilities" id="ref-for-mediacapabilities①"><c- n>MediaCapabilities</c-></a> <dfn class="idl-code" data-dfn-for="WorkerNavigator" data-dfn-type="attribute" data-export data-readonly data-type="MediaCapabilities" id="dom-workernavigator-mediacapabilities"><code><c- g>mediaCapabilities</c-></code><a class="self-link" href="#dom-workernavigator-mediacapabilities"></a></dfn>;
};
</pre>
     </section>
     <section>
      <h3 class="heading settled" data-level="2.5" id="media-capabilities-interface"><span class="secno">2.5. </span><span class="content">Media Capabilities Interface</span><a class="self-link" href="#media-capabilities-interface"></a></h3>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②"><c- g>Exposed</c-></a>=(<c- n>Window</c->, <c- n>Worker</c->)]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="mediacapabilities"><code><c- g>MediaCapabilities</c-></code></dfn> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitiesdecodinginfo" id="ref-for-dictdef-mediacapabilitiesdecodinginfo⑤"><c- n>MediaCapabilitiesDecodingInfo</c-></a>> <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilities" data-dfn-type="method" data-export data-lt="decodingInfo(configuration)" id="dom-mediacapabilities-decodinginfo"><code><c- g>decodingInfo</c-></code></dfn>(<a class="n" data-link-type="idl-name" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration⑧"><c- n>MediaDecodingConfiguration</c-></a> <dfn class="idl-code" data-dfn-for="MediaCapabilities/decodingInfo(configuration)" data-dfn-type="argument" data-export id="dom-mediacapabilities-decodinginfo-configuration-configuration"><code><c- g>configuration</c-></code><a class="self-link" href="#dom-mediacapabilities-decodinginfo-configuration-configuration"></a></dfn>);
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject①"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitiesinfo" id="ref-for-dictdef-mediacapabilitiesinfo④"><c- n>MediaCapabilitiesInfo</c-></a>> <dfn class="dfn-paneled idl-code" data-dfn-for="MediaCapabilities" data-dfn-type="method" data-export data-lt="encodingInfo(configuration)" id="dom-mediacapabilities-encodinginfo"><code><c- g>encodingInfo</c-></code></dfn>(<a class="n" data-link-type="idl-name" href="#dictdef-mediaencodingconfiguration" id="ref-for-dictdef-mediaencodingconfiguration⑤"><c- n>MediaEncodingConfiguration</c-></a> <dfn class="idl-code" data-dfn-for="MediaCapabilities/encodingInfo(configuration)" data-dfn-type="argument" data-export id="dom-mediacapabilities-encodinginfo-configuration-configuration"><code><c- g>configuration</c-></code><a class="self-link" href="#dom-mediacapabilities-encodinginfo-configuration-configuration"></a></dfn>);
};
</pre>
      <p> The <code class="idl"><a data-link-type="idl" href="#dom-mediacapabilities-decodinginfo" id="ref-for-dom-mediacapabilities-decodinginfo">decodingInfo()</a></code> method method MUST run the following steps: </p>
      <ol>
       <li> If <var>configuration</var> is not a <a data-link-type="dfn" href="#valid-mediadecodingconfiguration" id="ref-for-valid-mediadecodingconfiguration">valid
          MediaDecodingConfiguration</a>, return a Promise rejected with a 
          newly created <code class="idl"><a data-link-type="idl" href="https://tc39.es/ecma262/#sec-native-error-types-used-in-this-standard-typeerror" id="ref-for-sec-native-error-types-used-in-this-standard-typeerror">TypeError</a></code>. 
       <li>
         If <code>configuration.keySystemConfiguration</code> is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-present" id="ref-for-dfn-present①⑥">present</a>, run the following substeps: 
        <ol>
         <li> If the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/#global-object" id="ref-for-global-object">global object</a> is of type <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/workers.html#workerglobalscope" id="ref-for-workerglobalscope">WorkerGlobalScope</a></code>,
              return a Promise rejected with a newly created <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException">DOMException</a></code> whose name is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#invalidstateerror" id="ref-for-invalidstateerror">InvalidStateError</a>. 
         <li> If the result of running <a data-link-type="dfn" href="https://www.w3.org/TR/secure-contexts/#settings-object" id="ref-for-settings-object">Is the environment settings object 
              settings a secure context?</a> <a data-link-type="biblio" href="#biblio-secure-contexts">[secure-contexts]</a> with the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/#global-object" id="ref-for-global-object①">global object’s</a> <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/#relevant-settings-object" id="ref-for-relevant-settings-object">relevant settings object</a> is not
              "Secure", return a Promise rejected with a newly created <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException①">DOMException</a></code> whose name is <a data-link-type="dfn" href="https://heycam.github.io/webidl/#securityerror" id="ref-for-securityerror">SecurityError</a>. 
        </ol>
       <li> Let <var>p</var> be a new promise. 
       <li> <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel">In parallel</a>, run the <a data-link-type="dfn" href="#create-a-mediacapabilitiesdecodinginfo" id="ref-for-create-a-mediacapabilitiesdecodinginfo">Create a 
          MediaCapabilitiesDecodingInfo</a> algorithm with <var>configuration</var> and resolve <var>p</var> with its result. 
       <li> Return <var>p</var>. 
      </ol>
      <p></p>
      <p class="note" role="note"> Note, calling <code class="idl"><a data-link-type="idl" href="#dom-mediacapabilities-decodinginfo" id="ref-for-dom-mediacapabilities-decodinginfo①">decodingInfo()</a></code> with a <code class="idl"><a data-link-type="idl" href="#dom-mediadecodingconfiguration-keysystemconfiguration" id="ref-for-dom-mediadecodingconfiguration-keysystemconfiguration②">keySystemConfiguration</a></code> present
      may have user-visible effects, including requests for user consent. Such
      calls should only be made when the author intends to create and use a <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/encrypted-media/#mediakeys-interface" id="ref-for-mediakeys-interface①">MediaKeys</a></code> object with the provided configuration. </p>
      <p> The <code class="idl"><a data-link-type="idl" href="#dom-mediacapabilities-encodinginfo" id="ref-for-dom-mediacapabilities-encodinginfo">encodingInfo()</a></code> method MUST run the following steps: </p>
      <ol>
       <li> If <var>configuration</var> is not a <a data-link-type="dfn" href="#valid-mediaconfiguration" id="ref-for-valid-mediaconfiguration①">valid MediaConfiguration</a>,
          return a Promise rejected with a newly created <code class="idl"><a data-link-type="idl" href="https://tc39.es/ecma262/#sec-native-error-types-used-in-this-standard-typeerror" id="ref-for-sec-native-error-types-used-in-this-standard-typeerror①">TypeError</a></code>. 
       <li> Let <var>p</var> be a new promise. 
       <li> <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel①">In parallel</a>, run the <a data-link-type="dfn" href="#create-a-mediacapabilitiesencodinginfo" id="ref-for-create-a-mediacapabilitiesencodinginfo">Create a MediaCapabilitiesEncodingInfo</a> algorithm with <var>configuration</var> and resolve <var>p</var> with its result. 
       <li> Return <var>p</var>. 
      </ol>
      <p></p>
     </section>
    </section>
    <section class="non-normative">
     <h2 class="heading settled" data-level="3" id="security-privacy-considerations"><span class="secno">3. </span><span class="content"> Security and Privacy Considerations </span><a class="self-link" href="#security-privacy-considerations"></a></h2>
     <section>
      <p> This specification does not introduce any security-sensitive information
      or APIs but is provides an easier access to some information that can be
      used to fingerprint users. </p>
      <section>
       <h3 class="heading settled" data-level="3.1" id="decoding-encoding-fingerprinting"><span class="secno">3.1. </span><span class="content"> Decoding/Encoding and Fingerprinting </span><a class="self-link" href="#decoding-encoding-fingerprinting"></a></h3>
       <p> The information exposed by the decoding/encoding capabilities can
        already be discovered via experimentation with the exception that the
        API will likely provide more accurate and consistent information. This
        information is expected to have a high correlation with other
        information already available to the web pages as a given class of
        device is expected to have very similar decoding/encoding capabilities.
        In other words, high end devices from a certain year are expected to
        decode some type of videos while older devices may not. Therefore, it is
        expected that the entropy added with this API isn’t going to be
        significant. </p>
       <p> HDR detection is more nuanced. Adding colorGamut, transferFunction, and
        hdrMetadataType has the potential to add significant entropy. However,
        for UAs whose decoders are implemented in software and therefore whose
        capabilities are fixed across devices, this feature adds no effective
        entropy. Additionally, for many cases, devices tend to fall into large
        categories, within which capabilities are similar thus minimizing
        effective entropy. </p>
       <p> If an implementation wishes to implement a fingerprint-proof version of
        this specification, it would be recommended to fake a given set of
        capabilities (ie. decode up to 1080p VP9, etc.) instead of returning
        always yes or always no as the latter approach could considerably 
        degrade the user’s experience. Another mitigation could be to limit
        these Web APIs to top-level browsing contexts. Yet another is to use a
        privacy budget that throttles and/or blocks calls to the API above a
        threshold. </p>
      </section>
      <section>
       <h3 class="heading settled" data-level="3.2" id="display-fingerprinting"><span class="secno">3.2. </span><span class="content">Display and Fingerprinting</span><a class="self-link" href="#display-fingerprinting"></a></h3>
       <p> The information exposed by the display capabilities can already be
        accessed via CSS for the most part. The specification also provides
        default values when the user agent does not which to expose the feature
        for privacy reasons. </p>
      </section>
     </section>
    </section>
    <section>
     <h2 class="heading settled" data-level="4" id="examples"><span class="secno">4. </span><span class="content">Examples</span><a class="self-link" href="#examples"></a></h2>
     <section>
      <h3 class="heading settled" data-level="4.1" id="example1"><span class="secno">4.1. </span><span class="content">Query playback capabilities with <code class="idl"><a data-link-type="idl" href="#dom-mediacapabilities-decodinginfo" id="ref-for-dom-mediacapabilities-decodinginfo②">decodingInfo()</a></code></span><a class="self-link" href="#example1"></a></h3>
      <p> The following example shows how to use <code class="idl"><a data-link-type="idl" href="#dom-mediacapabilities-decodinginfo" id="ref-for-dom-mediacapabilities-decodinginfo③">decodingInfo()</a></code> to query
        media playback capabilities when using Media Source Extensions <a data-link-type="biblio" href="#biblio-media-source">[media-source]</a>. </p>
      <div class="example" id="example-b084ff72">
       <a class="self-link" href="#example-b084ff72"></a> 
<pre class="highlight"><c- o>&lt;</c->script<c- o>></c->
  <c- kr>const</c-> contentType <c- o>=</c-> <c- t>'video/mp4;codecs=avc1.640028'</c-><c- p>;</c->

  <c- kr>const</c-> configuration <c- o>=</c-> <c- p>{</c->
    type<c- o>:</c-> <c- t>'media-source'</c-><c- p>,</c->
    video<c- o>:</c-> <c- p>{</c->
      contentType<c- o>:</c-> contentType<c- p>,</c->
      width<c- o>:</c-> <c- mi>640</c-><c- p>,</c->
      height<c- o>:</c-> <c- mi>360</c-><c- p>,</c->
      bitrate<c- o>:</c-> <c- mi>2000</c-><c- p>,</c->
      framerate<c- o>:</c-> <c- mf>29.97</c->
    <c- p>}</c->
  <c- p>};</c->

  navigator<c- p>.</c->mediaCapabilities<c- p>.</c->decodingInfo<c- p>(</c->configuration<c- p>)</c->
    <c- p>.</c->then<c- p>((</c->result<c- p>)</c-> <c- p>=></c-> <c- p>{</c->
      console<c- p>.</c->log<c- p>(</c-><c- t>'Decoding of '</c-> <c- o>+</c-> contentType <c- o>+</c-> <c- t>' is'</c->
        <c- o>+</c-> <c- p>(</c->result<c- p>.</c->supported <c- o>?</c-> <c- t>''</c-> <c- o>:</c-> <c- t>' NOT'</c-><c- p>)</c-> <c- o>+</c-> <c- t>' supported,'</c->
        <c- o>+</c-> <c- p>(</c->result<c- p>.</c->smooth <c- o>?</c-> <c- t>''</c-> <c- o>:</c-> <c- t>' NOT'</c-><c- p>)</c-> <c- o>+</c-> <c- t>' smooth and'</c->
        <c- o>+</c-> <c- p>(</c->result<c- p>.</c->powerEfficient <c- o>?</c-> <c- t>''</c-> <c- o>:</c-> <c- t>' NOT'</c-><c- p>)</c-> <c- o>+</c-> <c- t>' power efficient'</c-><c- p>);</c->
    <c- p>})</c->
    <c- p>.</c-><c- k>catch</c-><c- p>((</c->err<c- p>)</c-> <c- p>=></c-> <c- p>{</c->
      console<c- p>.</c->error<c- p>(</c->err<c- p>,</c-> <c- t>' caused decodingInfo to reject'</c-><c- p>);</c->
    <c- p>});</c->
<c- o>&lt;</c->/script>
</pre>
      </div>
     </section>
     <section>
      <h3 class="heading settled" data-level="4.2" id="example2"><span class="secno">4.2. </span><span class="content">Query recording capabilities with <code class="idl"><a data-link-type="idl" href="#dom-mediacapabilities-encodinginfo" id="ref-for-dom-mediacapabilities-encodinginfo①">encodingInfo()</a></code></span><a class="self-link" href="#example2"></a></h3>
      <div class="note" role="note"> The following example can also be found in e.g. <a href="https://codepen.io/miguelao/pen/bWNwej/left?editors=0010#0"> this codepen</a> with minimal modifications. </div>
      <div class="example" id="example-264e78d6">
       <a class="self-link" href="#example-264e78d6"></a> 
<pre class="highlight"><c- o>&lt;</c->script<c- o>></c->
  <c- kr>const</c-> contentType <c- o>=</c-> <c- t>'video/webm;codecs=vp8'</c-><c- p>;</c->

  <c- kr>const</c-> configuration <c- o>=</c-> <c- p>{</c->
    type<c- o>:</c-> <c- t>'record'</c-><c- p>,</c->
    video<c- o>:</c-> <c- p>{</c->
      contentType<c- o>:</c-> contentType<c- p>,</c->
      width<c- o>:</c-> <c- mi>640</c-><c- p>,</c->
      height<c- o>:</c-> <c- mi>480</c-><c- p>,</c->
      bitrate<c- o>:</c-> <c- mi>10000</c-><c- p>,</c->
      framerate<c- o>:</c-> <c- mf>29.97</c->
    <c- p>}</c->
  <c- p>};</c->

  navigator<c- p>.</c->mediaCapabilities<c- p>.</c->encodingInfo<c- p>(</c->configuration<c- p>)</c->
    <c- p>.</c->then<c- p>((</c->result<c- p>)</c-> <c- p>=></c-> <c- p>{</c->
      console<c- p>.</c->log<c- p>(</c->contentType <c- o>+</c-> <c- t>' is:'</c->
        <c- o>+</c-> <c- p>(</c->result<c- p>.</c->supported <c- o>?</c-> <c- t>''</c-> <c- o>:</c-> <c- t>' NOT'</c-><c- p>)</c-> <c- o>+</c-> <c- t>' supported,'</c->
        <c- o>+</c-> <c- p>(</c->result<c- p>.</c->smooth <c- o>?</c-> <c- t>''</c-> <c- o>:</c-> <c- t>' NOT'</c-><c- p>)</c-> <c- o>+</c-> <c- t>' smooth and'</c->
        <c- o>+</c-> <c- p>(</c->result<c- p>.</c->powerEfficient <c- o>?</c-> <c- t>''</c-> <c- o>:</c-> <c- t>' NOT'</c-><c- p>)</c-> <c- o>+</c-> <c- t>' power efficient'</c-><c- p>);</c->
    <c- p>})</c->
    <c- p>.</c-><c- k>catch</c-><c- p>((</c->err<c- p>)</c-> <c- p>=></c-> <c- p>{</c->
      console<c- p>.</c->error<c- p>(</c->err<c- p>,</c-> <c- t>' caused encodingInfo to reject'</c-><c- p>);</c->
    <c- p>});</c->
<c- o>&lt;</c->/script>
</pre>
      </div>
     </section>
    </section>
    <p id="back-to-top" role="navigation"><a href="#toc"><abbr title="Back to Top">↑</abbr></a></p>
<script src="https://www.w3.org/scripts/TR/2016/fixup.js"></script>
   </section>
  </main>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li>
    audio
    <ul>
     <li><a href="#dom-mediacapabilitieskeysystemconfiguration-audio">dict-member for MediaCapabilitiesKeySystemConfiguration</a><span>, in §2.1.10</span>
     <li><a href="#dom-mediaconfiguration-audio">dict-member for MediaConfiguration</a><span>, in §2.1.1</span>
    </ul>
   <li><a href="#dictdef-audioconfiguration">AudioConfiguration</a><span>, in §2.1.9</span>
   <li>
    bitrate
    <ul>
     <li><a href="#dom-audioconfiguration-bitrate">dict-member for AudioConfiguration</a><span>, in §2.1.9</span>
     <li><a href="#dom-videoconfiguration-bitrate">dict-member for VideoConfiguration</a><span>, in §2.1.5</span>
    </ul>
   <li><a href="#dom-audioconfiguration-channels">channels</a><span>, in §2.1.9</span>
   <li><a href="#check-encrypted-decoding-support">Check Encrypted Decoding Support</a><span>, in §2.3.3</span>
   <li><a href="#dom-videoconfiguration-colorgamut">colorGamut</a><span>, in §2.1.5</span>
   <li><a href="#enumdef-colorgamut">ColorGamut</a><span>, in §2.1.7</span>
   <li>
    configuration
    <ul>
     <li><a href="#mediacapabilitiesdecodinginfo-configuration">dfn for MediaCapabilitiesDecodingInfo</a><span>, in §2.2</span>
     <li><a href="#mediacapabilitiesencodinginfo-configuration">dfn for MediaCapabilitiesEncodingInfo</a><span>, in §2.2</span>
     <li><a href="#dom-mediacapabilitiesdecodinginfo-configuration">dict-member for MediaCapabilitiesDecodingInfo</a><span>, in §2.2</span>
     <li><a href="#dom-mediacapabilitiesencodinginfo-configuration">dict-member for MediaCapabilitiesEncodingInfo</a><span>, in §2.2</span>
    </ul>
   <li>
    contentType
    <ul>
     <li><a href="#dom-audioconfiguration-contenttype">dict-member for AudioConfiguration</a><span>, in §2.1.9</span>
     <li><a href="#dom-videoconfiguration-contenttype">dict-member for VideoConfiguration</a><span>, in §2.1.5</span>
    </ul>
   <li><a href="#create-a-mediacapabilitiesdecodinginfo">Create a MediaCapabilitiesDecodingInfo</a><span>, in §2.3.2</span>
   <li><a href="#create-a-mediacapabilitiesencodinginfo">Create a MediaCapabilitiesEncodingInfo</a><span>, in §2.3.1</span>
   <li><a href="#dom-mediacapabilities-decodinginfo">decodingInfo(configuration)</a><span>, in §2.5</span>
   <li><a href="#dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier">distinctiveIdentifier</a><span>, in §2.1.10</span>
   <li><a href="#dom-mediacapabilities-encodinginfo">encodingInfo(configuration)</a><span>, in §2.5</span>
   <li><a href="#dom-keysystemtrackconfiguration-encryptionscheme">encryptionScheme</a><span>, in §2.1.11</span>
   <li><a href="#dom-mediadecodingtype-file">"file"</a><span>, in §2.1.2</span>
   <li><a href="#dom-mediadecodingtype-file">file</a><span>, in §2.1.2</span>
   <li><a href="#dom-videoconfiguration-framerate">framerate</a><span>, in §2.1.5</span>
   <li><a href="#dom-videoconfiguration-hasalphachannel">hasAlphaChannel</a><span>, in §2.1.5</span>
   <li><a href="#enumdef-hdrmetadatatype">HdrMetadataType</a><span>, in §2.1.6</span>
   <li><a href="#dom-videoconfiguration-hdrmetadatatype">hdrMetadataType</a><span>, in §2.1.5</span>
   <li><a href="#dom-videoconfiguration-height">height</a><span>, in §2.1.5</span>
   <li><a href="#dom-transferfunction-hlg">hlg</a><span>, in §2.1.8</span>
   <li><a href="#dom-transferfunction-hlg">"hlg"</a><span>, in §2.1.8</span>
   <li><a href="#dom-mediacapabilitieskeysystemconfiguration-initdatatype">initDataType</a><span>, in §2.1.10</span>
   <li><a href="#dom-mediacapabilitieskeysystemconfiguration-keysystem">keySystem</a><span>, in §2.1.10</span>
   <li>
    keySystemAccess
    <ul>
     <li><a href="#mediacapabilitiesdecodinginfo-keysystemaccess">dfn for MediaCapabilitiesDecodingInfo</a><span>, in §2.2</span>
     <li><a href="#dom-mediacapabilitiesdecodinginfo-keysystemaccess">dict-member for MediaCapabilitiesDecodingInfo</a><span>, in §2.2</span>
    </ul>
   <li><a href="#dom-mediadecodingconfiguration-keysystemconfiguration">keySystemConfiguration</a><span>, in §2.1.1</span>
   <li><a href="#dictdef-keysystemtrackconfiguration">KeySystemTrackConfiguration</a><span>, in §2.1.11</span>
   <li><a href="#mediacapabilities">MediaCapabilities</a><span>, in §2.5</span>
   <li>
    mediaCapabilities
    <ul>
     <li><a href="#dom-navigator-mediacapabilities">attribute for Navigator</a><span>, in §2.4</span>
     <li><a href="#dom-workernavigator-mediacapabilities">attribute for WorkerNavigator</a><span>, in §2.4</span>
    </ul>
   <li><a href="#dictdef-mediacapabilitiesdecodinginfo">MediaCapabilitiesDecodingInfo</a><span>, in §2.2</span>
   <li><a href="#dictdef-mediacapabilitiesencodinginfo">MediaCapabilitiesEncodingInfo</a><span>, in §2.2</span>
   <li><a href="#dictdef-mediacapabilitiesinfo">MediaCapabilitiesInfo</a><span>, in §2.2</span>
   <li><a href="#dictdef-mediacapabilitieskeysystemconfiguration">MediaCapabilitiesKeySystemConfiguration</a><span>, in §2.1.10</span>
   <li><a href="#dictdef-mediaconfiguration">MediaConfiguration</a><span>, in §2.1.1</span>
   <li><a href="#dictdef-mediadecodingconfiguration">MediaDecodingConfiguration</a><span>, in §2.1.1</span>
   <li><a href="#enumdef-mediadecodingtype">MediaDecodingType</a><span>, in §2.1.2</span>
   <li><a href="#dictdef-mediaencodingconfiguration">MediaEncodingConfiguration</a><span>, in §2.1.1</span>
   <li><a href="#enumdef-mediaencodingtype">MediaEncodingType</a><span>, in §2.1.3</span>
   <li><a href="#dom-mediadecodingtype-media-source">"media-source"</a><span>, in §2.1.2</span>
   <li><a href="#dom-mediadecodingtype-media-source">media-source</a><span>, in §2.1.2</span>
   <li><a href="#dom-colorgamut-p3">"p3"</a><span>, in §2.1.7</span>
   <li><a href="#dom-colorgamut-p3">p3</a><span>, in §2.1.7</span>
   <li><a href="#dom-mediacapabilitieskeysystemconfiguration-persistentstate">persistentState</a><span>, in §2.1.10</span>
   <li>
    powerEfficient
    <ul>
     <li><a href="#mediacapabilitiesinfo-powerefficient">dfn for MediaCapabilitiesInfo</a><span>, in §2.2</span>
     <li><a href="#dom-mediacapabilitiesinfo-powerefficient">dict-member for MediaCapabilitiesInfo</a><span>, in §2.2</span>
    </ul>
   <li><a href="#dom-transferfunction-pq">pq</a><span>, in §2.1.8</span>
   <li><a href="#dom-transferfunction-pq">"pq"</a><span>, in §2.1.8</span>
   <li><a href="#dom-colorgamut-rec2020">"rec2020"</a><span>, in §2.1.7</span>
   <li><a href="#dom-colorgamut-rec2020">rec2020</a><span>, in §2.1.7</span>
   <li><a href="#dom-mediaencodingtype-record">"record"</a><span>, in §2.1.3</span>
   <li><a href="#dom-mediaencodingtype-record">record</a><span>, in §2.1.3</span>
   <li><a href="#dom-keysystemtrackconfiguration-robustness">robustness</a><span>, in §2.1.11</span>
   <li><a href="#dom-audioconfiguration-samplerate">samplerate</a><span>, in §2.1.9</span>
   <li><a href="#dom-mediacapabilitieskeysystemconfiguration-sessiontypes">sessionTypes</a><span>, in §2.1.10</span>
   <li>
    smooth
    <ul>
     <li><a href="#mediacapabilitiesinfo-smooth">dfn for MediaCapabilitiesInfo</a><span>, in §2.2</span>
     <li><a href="#dom-mediacapabilitiesinfo-smooth">dict-member for MediaCapabilitiesInfo</a><span>, in §2.2</span>
    </ul>
   <li><a href="#dom-hdrmetadatatype-smptest2086">smpteSt2086</a><span>, in §2.1.6</span>
   <li><a href="#dom-hdrmetadatatype-smptest2086">"smpteSt2086"</a><span>, in §2.1.6</span>
   <li><a href="#dom-hdrmetadatatype-smptest2094-10">smpteSt2094-10</a><span>, in §2.1.6</span>
   <li><a href="#dom-hdrmetadatatype-smptest2094-10">"smpteSt2094-10"</a><span>, in §2.1.6</span>
   <li><a href="#dom-hdrmetadatatype-smptest2094-40">smpteSt2094-40</a><span>, in §2.1.6</span>
   <li><a href="#dom-hdrmetadatatype-smptest2094-40">"smpteSt2094-40"</a><span>, in §2.1.6</span>
   <li><a href="#dom-audioconfiguration-spatialrendering">spatialRendering</a><span>, in §2.1.9</span>
   <li>
    "srgb"
    <ul>
     <li><a href="#dom-colorgamut-srgb">enum-value for ColorGamut</a><span>, in §2.1.7</span>
     <li><a href="#dom-transferfunction-srgb">enum-value for TransferFunction</a><span>, in §2.1.8</span>
    </ul>
   <li>
    srgb
    <ul>
     <li><a href="#dom-colorgamut-srgb">enum-value for ColorGamut</a><span>, in §2.1.7</span>
     <li><a href="#dom-transferfunction-srgb">enum-value for TransferFunction</a><span>, in §2.1.8</span>
    </ul>
   <li>
    supported
    <ul>
     <li><a href="#mediacapabilitiesinfo-supported">dfn for MediaCapabilitiesInfo</a><span>, in §2.2</span>
     <li><a href="#dom-mediacapabilitiesinfo-supported">dict-member for MediaCapabilitiesInfo</a><span>, in §2.2</span>
    </ul>
   <li><a href="#enumdef-transferfunction">TransferFunction</a><span>, in §2.1.8</span>
   <li><a href="#dom-videoconfiguration-transferfunction">transferFunction</a><span>, in §2.1.5</span>
   <li><a href="#dom-mediaencodingtype-transmission">"transmission"</a><span>, in §2.1.3</span>
   <li><a href="#dom-mediaencodingtype-transmission">transmission</a><span>, in §2.1.3</span>
   <li>
    type
    <ul>
     <li><a href="#dom-mediadecodingconfiguration-type">dict-member for MediaDecodingConfiguration</a><span>, in §2.1.1</span>
     <li><a href="#dom-mediaencodingconfiguration-type">dict-member for MediaEncodingConfiguration</a><span>, in §2.1.1</span>
    </ul>
   <li><a href="#valid-audio-configuration">valid audio configuration</a><span>, in §2.1.9</span>
   <li><a href="#valid-audio-mime-type">valid audio MIME type</a><span>, in §2.1.4</span>
   <li><a href="#valid-mediaconfiguration">valid MediaConfiguration</a><span>, in §2.1.1</span>
   <li><a href="#valid-mediadecodingconfiguration">valid MediaDecodingConfiguration</a><span>, in §2.1.1</span>
   <li><a href="#valid-media-mime-type">valid media MIME type</a><span>, in §2.1.4</span>
   <li><a href="#valid-video-configuration">valid video configuration</a><span>, in §2.1.5</span>
   <li><a href="#valid-video-mime-type">valid video MIME type</a><span>, in §2.1.4</span>
   <li>
    video
    <ul>
     <li><a href="#dom-mediacapabilitieskeysystemconfiguration-video">dict-member for MediaCapabilitiesKeySystemConfiguration</a><span>, in §2.1.10</span>
     <li><a href="#dom-mediaconfiguration-video">dict-member for MediaConfiguration</a><span>, in §2.1.1</span>
    </ul>
   <li><a href="#dictdef-videoconfiguration">VideoConfiguration</a><span>, in §2.1.5</span>
   <li><a href="#dom-videoconfiguration-width">width</a><span>, in §2.1.5</span>
  </ul>
  <aside class="dfn-panel" data-for="term-for-concept-document">
   <a href="https://dom.spec.whatwg.org/#concept-document">https://dom.spec.whatwg.org/#concept-document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-document">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sec-native-error-types-used-in-this-standard-typeerror">
   <a href="https://tc39.es/ecma262/#sec-native-error-types-used-in-this-standard-typeerror">https://tc39.es/ecma262/#sec-native-error-types-used-in-this-standard-typeerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-native-error-types-used-in-this-standard-typeerror">2.5. Media Capabilities Interface</a> <a href="#ref-for-sec-native-error-types-used-in-this-standard-typeerror①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mediakeysystemaccess-interface">
   <a href="https://www.w3.org/TR/encrypted-media/#mediakeysystemaccess-interface">https://www.w3.org/TR/encrypted-media/#mediakeysystemaccess-interface</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediakeysystemaccess-interface">2.2. Media Capabilities Information</a> <a href="#ref-for-mediakeysystemaccess-interface①">(2)</a> <a href="#ref-for-mediakeysystemaccess-interface②">(3)</a>
    <li><a href="#ref-for-mediakeysystemaccess-interface③">2.3.3. 
          Check Encrypted Decoding Support </a> <a href="#ref-for-mediakeysystemaccess-interface④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mediakeysystemconfiguration-dictionary">
   <a href="https://www.w3.org/TR/encrypted-media/#mediakeysystemconfiguration-dictionary">https://www.w3.org/TR/encrypted-media/#mediakeysystemconfiguration-dictionary</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediakeysystemconfiguration-dictionary">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mediakeysystemmediacapability-dictionary">
   <a href="https://www.w3.org/TR/encrypted-media/#mediakeysystemmediacapability-dictionary">https://www.w3.org/TR/encrypted-media/#mediakeysystemmediacapability-dictionary</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediakeysystemmediacapability-dictionary">2.3.3. 
          Check Encrypted Decoding Support </a> <a href="#ref-for-mediakeysystemmediacapability-dictionary①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mediakeys-interface">
   <a href="https://www.w3.org/TR/encrypted-media/#mediakeys-interface">https://www.w3.org/TR/encrypted-media/#mediakeys-interface</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediakeys-interface">2.2. Media Capabilities Information</a>
    <li><a href="#ref-for-mediakeys-interface①">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysrequirement">
   <a href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysrequirement">https://www.w3.org/TR/encrypted-media/#dom-mediakeysrequirement</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysrequirement">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a> <a href="#ref-for-dom-mediakeysrequirement①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysystemconfiguration-audiocapabilities">
   <a href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-audiocapabilities">https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-audiocapabilities</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysystemconfiguration-audiocapabilities">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysystemmediacapability-contenttype">
   <a href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemmediacapability-contenttype">https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemmediacapability-contenttype</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysystemmediacapability-contenttype">2.3.3. 
          Check Encrypted Decoding Support </a> <a href="#ref-for-dom-mediakeysystemmediacapability-contenttype①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysystemconfiguration-distinctiveidentifier">
   <a href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-distinctiveidentifier">https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-distinctiveidentifier</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysystemconfiguration-distinctiveidentifier">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
    <li><a href="#ref-for-dom-mediakeysystemconfiguration-distinctiveidentifier①">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-get-supported-configuration">
   <a href="https://www.w3.org/TR/encrypted-media/#get-supported-configuration">https://www.w3.org/TR/encrypted-media/#get-supported-configuration</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-get-supported-configuration">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysystemconfiguration-initdatatypes">
   <a href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-initdatatypes">https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-initdatatypes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysystemconfiguration-initdatatypes">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
    <li><a href="#ref-for-dom-mediakeysystemconfiguration-initdatatypes①">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-key-system">
   <a href="https://www.w3.org/TR/encrypted-media/#key-system">https://www.w3.org/TR/encrypted-media/#key-system</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-key-system">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysystemaccess-keysystem">
   <a href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemaccess-keysystem">https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemaccess-keysystem</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysystemaccess-keysystem">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
    <li><a href="#ref-for-dom-mediakeysystemaccess-keysystem①">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysystemconfiguration-persistentstate">
   <a href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-persistentstate">https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-persistentstate</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysystemconfiguration-persistentstate">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
    <li><a href="#ref-for-dom-mediakeysystemconfiguration-persistentstate①">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-navigator-extension:-requestmediakeysystemaccess()">
   <a href="https://www.w3.org/TR/encrypted-media/#navigator-extension:-requestmediakeysystemaccess()">https://www.w3.org/TR/encrypted-media/#navigator-extension:-requestmediakeysystemaccess()</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-navigator-extension:-requestmediakeysystemaccess()">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysystemmediacapability-robustness">
   <a href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemmediacapability-robustness">https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemmediacapability-robustness</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysystemmediacapability-robustness">2.1.11. 
      KeySystemTrackConfiguration </a>
    <li><a href="#ref-for-dom-mediakeysystemmediacapability-robustness①">2.3.3. 
          Check Encrypted Decoding Support </a> <a href="#ref-for-dom-mediakeysystemmediacapability-robustness②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysystemconfiguration-sessiontypes">
   <a href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-sessiontypes">https://www.w3.org/TR/encrypted-media/#dom-mediakeysystemconfiguration-sessiontypes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysystemconfiguration-sessiontypes">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
    <li><a href="#ref-for-dom-mediakeysystemconfiguration-sessiontypes①">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediakeysystemmediacapability-encryptionscheme">
   <a href="https://w3c.github.io/encrypted-media/#dom-mediakeysystemmediacapability-encryptionscheme">https://w3c.github.io/encrypted-media/#dom-mediakeysystemmediacapability-encryptionscheme</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediakeysystemmediacapability-encryptionscheme">2.1.11. 
      KeySystemTrackConfiguration </a>
    <li><a href="#ref-for-dom-mediakeysystemmediacapability-encryptionscheme①">2.3.3. 
          Check Encrypted Decoding Support </a> <a href="#ref-for-dom-mediakeysystemmediacapability-encryptionscheme②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-navigator">
   <a href="https://html.spec.whatwg.org/multipage/system-state.html#navigator">https://html.spec.whatwg.org/multipage/system-state.html#navigator</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-navigator">2.4. Navigator and WorkerNavigator extension</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-workerglobalscope">
   <a href="https://html.spec.whatwg.org/multipage/workers.html#workerglobalscope">https://html.spec.whatwg.org/multipage/workers.html#workerglobalscope</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-workerglobalscope">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-workernavigator">
   <a href="https://html.spec.whatwg.org/multipage/workers.html#workernavigator">https://html.spec.whatwg.org/multipage/workers.html#workernavigator</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-workernavigator">2.4. Navigator and WorkerNavigator extension</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-navigator-canplaytype">
   <a href="https://html.spec.whatwg.org/multipage/#dom-navigator-canplaytype">https://html.spec.whatwg.org/multipage/#dom-navigator-canplaytype</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-navigator-canplaytype">1. Introduction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-global-object">
   <a href="https://html.spec.whatwg.org/multipage/#global-object">https://html.spec.whatwg.org/multipage/#global-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-global-object">2.5. Media Capabilities Interface</a> <a href="#ref-for-global-object①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-in-parallel">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel">https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-in-parallel">2.5. Media Capabilities Interface</a> <a href="#ref-for-in-parallel①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-origin">
   <a href="https://html.spec.whatwg.org/multipage/#concept-origin">https://html.spec.whatwg.org/multipage/#concept-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-origin">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-relevant-settings-object">
   <a href="https://html.spec.whatwg.org/multipage/#relevant-settings-object">https://html.spec.whatwg.org/multipage/#relevant-settings-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-relevant-settings-object">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mediasource">
   <a href="https://www.w3.org/TR/media-source/#mediasource">https://www.w3.org/TR/media-source/#mediasource</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediasource">2.1.2. MediaDecodingType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-mediasource-istypesupported">
   <a href="https://www.w3.org/TR/media-source/#dom-mediasource-istypesupported">https://www.w3.org/TR/media-source/#dom-mediasource-istypesupported</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediasource-istypesupported">1. Introduction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mediarecorder">
   <a href="https://www.w3.org/TR/mediastream-recording/#mediarecorder">https://www.w3.org/TR/mediastream-recording/#mediarecorder</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediarecorder">2.1.3. MediaEncodingType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valid-mime-type">
   <a href="https://mimesniff.spec.whatwg.org/#valid-mime-type">https://mimesniff.spec.whatwg.org/#valid-mime-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valid-mime-type">2.1.4. MIME types</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-settings-object">
   <a href="https://www.w3.org/TR/secure-contexts/#settings-object">https://www.w3.org/TR/secure-contexts/#settings-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-settings-object">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-DOMException">
   <a href="https://heycam.github.io/webidl/#idl-DOMException">https://heycam.github.io/webidl/#idl-DOMException</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-DOMException">2.5. Media Capabilities Interface</a> <a href="#ref-for-idl-DOMException①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-DOMString">
   <a href="https://heycam.github.io/webidl/#idl-DOMString">https://heycam.github.io/webidl/#idl-DOMString</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-DOMString">2.1.5. VideoConfiguration</a>
    <li><a href="#ref-for-idl-DOMString①">2.1.9. AudioConfiguration</a> <a href="#ref-for-idl-DOMString②">(2)</a>
    <li><a href="#ref-for-idl-DOMString③">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a> <a href="#ref-for-idl-DOMString④">(2)</a> <a href="#ref-for-idl-DOMString⑤">(3)</a>
    <li><a href="#ref-for-idl-DOMString⑥">2.1.11. 
      KeySystemTrackConfiguration </a> <a href="#ref-for-idl-DOMString⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">2.4. Navigator and WorkerNavigator extension</a> <a href="#ref-for-Exposed①">(2)</a>
    <li><a href="#ref-for-Exposed②">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-NewObject">
   <a href="https://heycam.github.io/webidl/#NewObject">https://heycam.github.io/webidl/#NewObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-NewObject">2.5. Media Capabilities Interface</a> <a href="#ref-for-NewObject①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-SameObject">
   <a href="https://heycam.github.io/webidl/#SameObject">https://heycam.github.io/webidl/#SameObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-SameObject">2.4. Navigator and WorkerNavigator extension</a> <a href="#ref-for-SameObject①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-boolean">
   <a href="https://heycam.github.io/webidl/#idl-boolean">https://heycam.github.io/webidl/#idl-boolean</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-boolean">2.1.5. VideoConfiguration</a>
    <li><a href="#ref-for-idl-boolean①">2.1.9. AudioConfiguration</a>
    <li><a href="#ref-for-idl-boolean②">2.2. Media Capabilities Information</a> <a href="#ref-for-idl-boolean③">(2)</a> <a href="#ref-for-idl-boolean④">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-double">
   <a href="https://heycam.github.io/webidl/#idl-double">https://heycam.github.io/webidl/#idl-double</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-double">2.1.5. VideoConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-invalidstateerror">
   <a href="https://heycam.github.io/webidl/#invalidstateerror">https://heycam.github.io/webidl/#invalidstateerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-invalidstateerror">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-present">
   <a href="https://heycam.github.io/webidl/#dfn-present">https://heycam.github.io/webidl/#dfn-present</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-present">2.1.1. MediaConfiguration</a> <a href="#ref-for-dfn-present①">(2)</a> <a href="#ref-for-dfn-present②">(3)</a> <a href="#ref-for-dfn-present③">(4)</a> <a href="#ref-for-dfn-present④">(5)</a> <a href="#ref-for-dfn-present⑤">(6)</a> <a href="#ref-for-dfn-present⑥">(7)</a> <a href="#ref-for-dfn-present⑦">(8)</a> <a href="#ref-for-dfn-present⑧">(9)</a>
    <li><a href="#ref-for-dfn-present⑨">2.1.9. AudioConfiguration</a>
    <li><a href="#ref-for-dfn-present①⓪">2.3.2. 
          Create a MediaCapabilitiesDecodingInfo </a>
    <li><a href="#ref-for-dfn-present①①">2.3.3. 
          Check Encrypted Decoding Support </a> <a href="#ref-for-dfn-present①②">(2)</a> <a href="#ref-for-dfn-present①③">(3)</a> <a href="#ref-for-dfn-present①④">(4)</a> <a href="#ref-for-dfn-present①⑤">(5)</a>
    <li><a href="#ref-for-dfn-present①⑥">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-securityerror">
   <a href="https://heycam.github.io/webidl/#securityerror">https://heycam.github.io/webidl/#securityerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-securityerror">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-long">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-long">https://heycam.github.io/webidl/#idl-unsigned-long</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-long">2.1.5. VideoConfiguration</a> <a href="#ref-for-idl-unsigned-long①">(2)</a>
    <li><a href="#ref-for-idl-unsigned-long②">2.1.9. AudioConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-long-long">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-long-long">https://heycam.github.io/webidl/#idl-unsigned-long-long</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-long-long">2.1.5. VideoConfiguration</a>
    <li><a href="#ref-for-idl-unsigned-long-long①">2.1.9. AudioConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-interface-definition">
   <a href="https://www.w3.org/TR/webrtc/#interface-definition">https://www.w3.org/TR/webrtc/#interface-definition</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-interface-definition">2.1.3. MediaEncodingType</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[DOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-concept-document" style="color:initial">document</span>
    </ul>
   <li>
    <a data-link-type="biblio">[ECMASCRIPT]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-sec-native-error-types-used-in-this-standard-typeerror" style="color:initial">TypeError</span>
    </ul>
   <li>
    <a data-link-type="biblio">[ENCRYPTED-MEDIA]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-mediakeysystemaccess-interface" style="color:initial">MediaKeySystemAccess</span>
     <li><span class="dfn-paneled" id="term-for-mediakeysystemconfiguration-dictionary" style="color:initial">MediaKeySystemConfiguration</span>
     <li><span class="dfn-paneled" id="term-for-mediakeysystemmediacapability-dictionary" style="color:initial">MediaKeySystemMediaCapability</span>
     <li><span class="dfn-paneled" id="term-for-mediakeys-interface" style="color:initial">MediaKeys</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysrequirement" style="color:initial">MediaKeysRequirement</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysystemconfiguration-audiocapabilities" style="color:initial">audioCapabilities</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysystemmediacapability-contenttype" style="color:initial">contentType</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysystemconfiguration-distinctiveidentifier" style="color:initial">distinctiveIdentifier</span>
     <li><span class="dfn-paneled" id="term-for-get-supported-configuration" style="color:initial">get supported configuration</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysystemconfiguration-initdatatypes" style="color:initial">initDataTypes</span>
     <li><span class="dfn-paneled" id="term-for-key-system" style="color:initial">key system</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysystemaccess-keysystem" style="color:initial">keySystem</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysystemconfiguration-persistentstate" style="color:initial">persistentState</span>
     <li><span class="dfn-paneled" id="term-for-navigator-extension:-requestmediakeysystemaccess()" style="color:initial">requestMediaKeySystemAccess()</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysystemmediacapability-robustness" style="color:initial">robustness</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysystemconfiguration-sessiontypes" style="color:initial">sessionTypes</span>
    </ul>
   <li>
    <a data-link-type="biblio">[ENCRYPTED-MEDIA-DRAFT]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-dom-mediakeysystemmediacapability-encryptionscheme" style="color:initial">encryptionScheme</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-navigator" style="color:initial">Navigator</span>
     <li><span class="dfn-paneled" id="term-for-workerglobalscope" style="color:initial">WorkerGlobalScope</span>
     <li><span class="dfn-paneled" id="term-for-workernavigator" style="color:initial">WorkerNavigator</span>
     <li><span class="dfn-paneled" id="term-for-dom-navigator-canplaytype" style="color:initial">canPlayType()</span>
     <li><span class="dfn-paneled" id="term-for-global-object" style="color:initial">global object</span>
     <li><span class="dfn-paneled" id="term-for-in-parallel" style="color:initial">in parallel</span>
     <li><span class="dfn-paneled" id="term-for-concept-origin" style="color:initial">origin</span>
     <li><span class="dfn-paneled" id="term-for-relevant-settings-object" style="color:initial">relevant settings object</span>
    </ul>
   <li>
    <a data-link-type="biblio">[media-source]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-mediasource" style="color:initial">MediaSource</span>
     <li><span class="dfn-paneled" id="term-for-dom-mediasource-istypesupported" style="color:initial">isTypeSupported()</span>
    </ul>
   <li>
    <a data-link-type="biblio">[mediastream-recording]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-mediarecorder" style="color:initial">MediaRecorder</span>
    </ul>
   <li>
    <a data-link-type="biblio">[mimesniff]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-valid-mime-type" style="color:initial">valid mime type</span>
    </ul>
   <li>
    <a data-link-type="biblio">[secure-contexts]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-settings-object" style="color:initial">is the environment settings object settings a secure context?</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-idl-DOMException" style="color:initial">DOMException</span>
     <li><span class="dfn-paneled" id="term-for-idl-DOMString" style="color:initial">DOMString</span>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-NewObject" style="color:initial">NewObject</span>
     <li><span class="dfn-paneled" id="term-for-SameObject" style="color:initial">SameObject</span>
     <li><span class="dfn-paneled" id="term-for-idl-boolean" style="color:initial">boolean</span>
     <li><span class="dfn-paneled" id="term-for-idl-double" style="color:initial">double</span>
     <li><span class="dfn-paneled" id="term-for-invalidstateerror" style="color:initial">invalidstateerror</span>
     <li><span class="dfn-paneled" id="term-for-dfn-present" style="color:initial">present</span>
     <li><span class="dfn-paneled" id="term-for-securityerror" style="color:initial">securityerror</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-long" style="color:initial">unsigned long</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-long-long" style="color:initial">unsigned long long</span>
    </ul>
   <li>
    <a data-link-type="biblio">[webrtc]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-interface-definition" style="color:initial">RTCPeerConnection</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-dom">[DOM]
   <dd>Anne van Kesteren. <a href="https://dom.spec.whatwg.org/">DOM Standard</a>. Living Standard. URL: <a href="https://dom.spec.whatwg.org/">https://dom.spec.whatwg.org/</a>
   <dt id="biblio-ecmascript">[ECMASCRIPT]
   <dd><a href="https://tc39.es/ecma262/">ECMAScript Language Specification</a>. URL: <a href="https://tc39.es/ecma262/">https://tc39.es/ecma262/</a>
   <dt id="biblio-encrypted-media">[ENCRYPTED-MEDIA]
   <dd>David Dorwin; et al. <a href="https://www.w3.org/TR/encrypted-media/">Encrypted Media Extensions</a>. 18 September 2017. REC. URL: <a href="https://www.w3.org/TR/encrypted-media/">https://www.w3.org/TR/encrypted-media/</a>
   <dt id="biblio-encrypted-media-draft">[ENCRYPTED-MEDIA-DRAFT]
   <dd><a href="https://w3c.github.io/encrypted-media">Encrypted Media Extensions</a>. 13 December 2019. URL: <a href="https://w3c.github.io/encrypted-media">https://w3c.github.io/encrypted-media</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-media-source">[MEDIA-SOURCE]
   <dd>Matthew Wolenetz; et al. <a href="https://www.w3.org/TR/media-source/">Media Source Extensions™</a>. 17 November 2016. REC. URL: <a href="https://www.w3.org/TR/media-source/">https://www.w3.org/TR/media-source/</a>
   <dt id="biblio-mimesniff">[MIMESNIFF]
   <dd>Gordon P. Hemsley. <a href="https://mimesniff.spec.whatwg.org/">MIME Sniffing Standard</a>. Living Standard. URL: <a href="https://mimesniff.spec.whatwg.org/">https://mimesniff.spec.whatwg.org/</a>
   <dt id="biblio-secure-contexts">[SECURE-CONTEXTS]
   <dd>Mike West. <a href="https://www.w3.org/TR/secure-contexts/">Secure Contexts</a>. 15 September 2016. CR. URL: <a href="https://www.w3.org/TR/secure-contexts/">https://www.w3.org/TR/secure-contexts/</a>
   <dt id="biblio-smpte-st-2084">[SMPTE-ST-2084]
   <dd><a href="https://ieeexplore.ieee.org/document/7291452">High Dynamic Range Electro-Optical Transfer Function of Mastering Reference Displays</a>. 2014. URL: <a href="https://ieeexplore.ieee.org/document/7291452">https://ieeexplore.ieee.org/document/7291452</a>
   <dt id="biblio-smpte-st-2086">[SMPTE-ST-2086]
   <dd><a href="https://ieeexplore.ieee.org/document/7291707">Mastering Display Color Volume Metadata Supporting High Luminance and Wide Color Gamut Images</a>. 2014. URL: <a href="https://ieeexplore.ieee.org/document/7291707">https://ieeexplore.ieee.org/document/7291707</a>
   <dt id="biblio-smpte-st-2094">[SMPTE-ST-2094]
   <dd><a href="https://ieeexplore.ieee.org/document/7513361">Dynamic Metadata for Color Volume Transform Core Components</a>. 2016. URL: <a href="https://ieeexplore.ieee.org/document/7513361">https://ieeexplore.ieee.org/document/7513361</a>
   <dt id="biblio-srgb">[sRGB]
   <dd><a href="https://webstore.iec.ch/publication/6169">Multimedia systems and equipment - Colour measurement and management - Part 2-1: Colour management - Default RGB colour space - sRGB</a>. URL: <a href="https://webstore.iec.ch/publication/6169">https://webstore.iec.ch/publication/6169</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-battery-status">[BATTERY-STATUS]
   <dd>Anssi Kostiainen; Mounir Lamouri. <a href="https://www.w3.org/TR/battery-status/">Battery Status API</a>. 7 July 2016. CR. URL: <a href="https://www.w3.org/TR/battery-status/">https://www.w3.org/TR/battery-status/</a>
   <dt id="biblio-media-playback-quality">[MEDIA-PLAYBACK-QUALITY]
   <dd>Mounir Lamouri. <a href="https://w3c.github.io/media-playback-quality/">Media Playback Quality</a>. ED. URL: <a href="https://w3c.github.io/media-playback-quality/">https://w3c.github.io/media-playback-quality/</a>
   <dt id="biblio-mediastream-recording">[MEDIASTREAM-RECORDING]
   <dd>Miguel Casas-sanchez; James Barnett; Travis Leithead. <a href="https://www.w3.org/TR/mediastream-recording/">MediaStream Recording</a>. 21 June 2017. WD. URL: <a href="https://www.w3.org/TR/mediastream-recording/">https://www.w3.org/TR/mediastream-recording/</a>
   <dt id="biblio-rfc7231">[RFC7231]
   <dd>R. Fielding, Ed.; J. Reschke, Ed.. <a href="https://httpwg.org/specs/rfc7231.html">Hypertext Transfer Protocol (HTTP/1.1): Semantics and Content</a>. June 2014. Proposed Standard. URL: <a href="https://httpwg.org/specs/rfc7231.html">https://httpwg.org/specs/rfc7231.html</a>
   <dt id="biblio-webrtc">[WEBRTC]
   <dd>Cullen Jennings; et al. <a href="https://www.w3.org/TR/webrtc/">WebRTC 1.0: Real-time Communication Between Browsers</a>. 13 December 2019. CR. URL: <a href="https://www.w3.org/TR/webrtc/">https://www.w3.org/TR/webrtc/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def"><c- b>dictionary</c-> <a href="#dictdef-mediaconfiguration"><code><c- g>MediaConfiguration</c-></code></a> {
  <a class="n" data-link-type="idl-name" href="#dictdef-videoconfiguration" id="ref-for-dictdef-videoconfiguration⑥"><c- n>VideoConfiguration</c-></a> <a data-type="VideoConfiguration " href="#dom-mediaconfiguration-video"><code><c- g>video</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="#dictdef-audioconfiguration" id="ref-for-dictdef-audioconfiguration③"><c- n>AudioConfiguration</c-></a> <a data-type="AudioConfiguration " href="#dom-mediaconfiguration-audio"><code><c- g>audio</c-></code></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-mediadecodingconfiguration"><code><c- g>MediaDecodingConfiguration</c-></code></a> : <a class="n" data-link-type="idl-name" href="#dictdef-mediaconfiguration" id="ref-for-dictdef-mediaconfiguration③"><c- n>MediaConfiguration</c-></a> {
  <c- b>required</c-> <a class="n" data-link-type="idl-name" href="#enumdef-mediadecodingtype" id="ref-for-enumdef-mediadecodingtype①"><c- n>MediaDecodingType</c-></a> <a data-type="MediaDecodingType " href="#dom-mediadecodingconfiguration-type"><code><c- g>type</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitieskeysystemconfiguration" id="ref-for-dictdef-mediacapabilitieskeysystemconfiguration①"><c- n>MediaCapabilitiesKeySystemConfiguration</c-></a> <a data-type="MediaCapabilitiesKeySystemConfiguration " href="#dom-mediadecodingconfiguration-keysystemconfiguration"><code><c- g>keySystemConfiguration</c-></code></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-mediaencodingconfiguration"><code><c- g>MediaEncodingConfiguration</c-></code></a> : <a class="n" data-link-type="idl-name" href="#dictdef-mediaconfiguration" id="ref-for-dictdef-mediaconfiguration①①"><c- n>MediaConfiguration</c-></a> {
  <c- b>required</c-> <a class="n" data-link-type="idl-name" href="#enumdef-mediaencodingtype" id="ref-for-enumdef-mediaencodingtype①"><c- n>MediaEncodingType</c-></a> <a data-type="MediaEncodingType " href="#dom-mediaencodingconfiguration-type"><code><c- g>type</c-></code></a>;
};

<c- b>enum</c-> <a href="#enumdef-mediadecodingtype"><code><c- g>MediaDecodingType</c-></code></a> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-mediadecodingtype-file" id="ref-for-dom-mediadecodingtype-file①"><c- s>"file"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-mediadecodingtype-media-source" id="ref-for-dom-mediadecodingtype-media-source①"><c- s>"media-source"</c-></a>,
};

<c- b>enum</c-> <a href="#enumdef-mediaencodingtype"><code><c- g>MediaEncodingType</c-></code></a> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-mediaencodingtype-record" id="ref-for-dom-mediaencodingtype-record①"><c- s>"record"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-mediaencodingtype-transmission" id="ref-for-dom-mediaencodingtype-transmission①"><c- s>"transmission"</c-></a>
};

<c- b>dictionary</c-> <a href="#dictdef-videoconfiguration"><code><c- g>VideoConfiguration</c-></code></a> {
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑧"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="DOMString " href="#dom-videoconfiguration-contenttype" id="ref-for-dom-videoconfiguration-contenttype④"><c- g>contentType</c-></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long③"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long " href="#dom-videoconfiguration-width" id="ref-for-dom-videoconfiguration-width①"><c- g>width</c-></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①①"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long " href="#dom-videoconfiguration-height" id="ref-for-dom-videoconfiguration-height①"><c- g>height</c-></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long-long" id="ref-for-idl-unsigned-long-long②"><c- b>unsigned</c-> <c- b>long</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long long " href="#dom-videoconfiguration-bitrate" id="ref-for-dom-videoconfiguration-bitrate①"><c- g>bitrate</c-></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①"><c- b>double</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="double " href="#dom-videoconfiguration-framerate" id="ref-for-dom-videoconfiguration-framerate②"><c- g>framerate</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean⑤"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="boolean " href="#dom-videoconfiguration-hasalphachannel" id="ref-for-dom-videoconfiguration-hasalphachannel①"><c- g>hasAlphaChannel</c-></a>;
  <a class="n" data-link-type="idl-name" href="#enumdef-hdrmetadatatype" id="ref-for-enumdef-hdrmetadatatype③"><c- n>HdrMetadataType</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="HdrMetadataType " href="#dom-videoconfiguration-hdrmetadatatype" id="ref-for-dom-videoconfiguration-hdrmetadatatype①"><c- g>hdrMetadataType</c-></a>;
  <a class="n" data-link-type="idl-name" href="#enumdef-colorgamut" id="ref-for-enumdef-colorgamut②"><c- n>ColorGamut</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="ColorGamut " href="#dom-videoconfiguration-colorgamut" id="ref-for-dom-videoconfiguration-colorgamut①"><c- g>colorGamut</c-></a>;
  <a class="n" data-link-type="idl-name" href="#enumdef-transferfunction" id="ref-for-enumdef-transferfunction②"><c- n>TransferFunction</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="TransferFunction " href="#dom-videoconfiguration-transferfunction" id="ref-for-dom-videoconfiguration-transferfunction①"><c- g>transferFunction</c-></a>;
};

<c- b>enum</c-> <a href="#enumdef-hdrmetadatatype"><code><c- g>HdrMetadataType</c-></code></a> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-hdrmetadatatype-smptest2086" id="ref-for-dom-hdrmetadatatype-smptest2086①"><c- s>"smpteSt2086"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-hdrmetadatatype-smptest2094-10" id="ref-for-dom-hdrmetadatatype-smptest2094-10①"><c- s>"smpteSt2094-10"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-hdrmetadatatype-smptest2094-40" id="ref-for-dom-hdrmetadatatype-smptest2094-40①"><c- s>"smpteSt2094-40"</c-></a>
};

<c- b>enum</c-> <a href="#enumdef-colorgamut"><code><c- g>ColorGamut</c-></code></a> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-colorgamut-srgb" id="ref-for-dom-colorgamut-srgb②"><c- s>"srgb"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-colorgamut-p3" id="ref-for-dom-colorgamut-p3②"><c- s>"p3"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-colorgamut-rec2020" id="ref-for-dom-colorgamut-rec2020①"><c- s>"rec2020"</c-></a>
};

<c- b>enum</c-> <a href="#enumdef-transferfunction"><code><c- g>TransferFunction</c-></code></a> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-transferfunction-srgb" id="ref-for-dom-transferfunction-srgb①"><c- s>"srgb"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-transferfunction-pq" id="ref-for-dom-transferfunction-pq①"><c- s>"pq"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-transferfunction-hlg" id="ref-for-dom-transferfunction-hlg①"><c- s>"hlg"</c-></a>
};

<c- b>dictionary</c-> <a href="#dictdef-audioconfiguration"><code><c- g>AudioConfiguration</c-></code></a> {
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString①①"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="DOMString " href="#dom-audioconfiguration-contenttype" id="ref-for-dom-audioconfiguration-contenttype③"><c- g>contentType</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString②①"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="DOMString " href="#dom-audioconfiguration-channels" id="ref-for-dom-audioconfiguration-channels②"><c- g>channels</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long-long" id="ref-for-idl-unsigned-long-long①①"><c- b>unsigned</c-> <c- b>long</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long long " href="#dom-audioconfiguration-bitrate" id="ref-for-dom-audioconfiguration-bitrate①"><c- g>bitrate</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long②①"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="unsigned long " href="#dom-audioconfiguration-samplerate" id="ref-for-dom-audioconfiguration-samplerate②"><c- g>samplerate</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean①①"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="boolean " href="#dom-audioconfiguration-spatialrendering" id="ref-for-dom-audioconfiguration-spatialrendering①"><c- g>spatialRendering</c-></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-mediacapabilitieskeysystemconfiguration"><code><c- g>MediaCapabilitiesKeySystemConfiguration</c-></code></a> {
    <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString③①"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="DOMString " href="#dom-mediacapabilitieskeysystemconfiguration-keysystem" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-keysystem②"><c- g>keySystem</c-></a>;
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString④①"><c- b>DOMString</c-></a> <a class="idl-code" data-default="&quot;&quot;" data-link-type="dict-member" data-type="DOMString " href="#dom-mediacapabilitieskeysystemconfiguration-initdatatype" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-initdatatype①"><c- g>initDataType</c-></a> = "";
    <a class="n" data-link-type="idl-name" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysrequirement" id="ref-for-dom-mediakeysrequirement②"><c- n>MediaKeysRequirement</c-></a> <a class="idl-code" data-default="&quot;optional&quot;" data-link-type="dict-member" data-type="MediaKeysRequirement " href="#dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier①"><c- g>distinctiveIdentifier</c-></a> = "optional";
    <a class="n" data-link-type="idl-name" href="https://www.w3.org/TR/encrypted-media/#dom-mediakeysrequirement" id="ref-for-dom-mediakeysrequirement①①"><c- n>MediaKeysRequirement</c-></a> <a class="idl-code" data-default="&quot;optional&quot;" data-link-type="dict-member" data-type="MediaKeysRequirement " href="#dom-mediacapabilitieskeysystemconfiguration-persistentstate" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-persistentstate①"><c- g>persistentState</c-></a> = "optional";
    <c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑤①"><c- b>DOMString</c-></a>> <a class="idl-code" data-link-type="dict-member" data-type="sequence<DOMString> " href="#dom-mediacapabilitieskeysystemconfiguration-sessiontypes" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-sessiontypes①"><c- g>sessionTypes</c-></a>;
    <a class="n" data-link-type="idl-name" href="#dictdef-keysystemtrackconfiguration" id="ref-for-dictdef-keysystemtrackconfiguration④"><c- n>KeySystemTrackConfiguration</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="KeySystemTrackConfiguration " href="#dom-mediacapabilitieskeysystemconfiguration-audio" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-audio①"><c- g>audio</c-></a>;
    <a class="n" data-link-type="idl-name" href="#dictdef-keysystemtrackconfiguration" id="ref-for-dictdef-keysystemtrackconfiguration①①"><c- n>KeySystemTrackConfiguration</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="KeySystemTrackConfiguration " href="#dom-mediacapabilitieskeysystemconfiguration-video" id="ref-for-dom-mediacapabilitieskeysystemconfiguration-video①"><c- g>video</c-></a>;
  };


<c- b>dictionary</c-> <a href="#dictdef-keysystemtrackconfiguration"><code><c- g>KeySystemTrackConfiguration</c-></code></a> {
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑥①"><c- b>DOMString</c-></a> <a class="idl-code" data-default="&quot;&quot;" data-link-type="dict-member" data-type="DOMString " href="#dom-keysystemtrackconfiguration-robustness" id="ref-for-dom-keysystemtrackconfiguration-robustness①"><c- g>robustness</c-></a> = "";
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑦①"><c- b>DOMString</c-></a>? <a class="idl-code" data-default="null" data-link-type="dict-member" data-type="DOMString? " href="#dom-keysystemtrackconfiguration-encryptionscheme" id="ref-for-dom-keysystemtrackconfiguration-encryptionscheme①"><c- g>encryptionScheme</c-></a> = <c- b>null</c->;
  };


<c- b>dictionary</c-> <a href="#dictdef-mediacapabilitiesinfo"><code><c- g>MediaCapabilitiesInfo</c-></code></a> {
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean②①"><c- b>boolean</c-></a> <a data-type="boolean " href="#dom-mediacapabilitiesinfo-supported"><code><c- g>supported</c-></code></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean③①"><c- b>boolean</c-></a> <a data-type="boolean " href="#dom-mediacapabilitiesinfo-smooth"><code><c- g>smooth</c-></code></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean④①"><c- b>boolean</c-></a> <a data-type="boolean " href="#dom-mediacapabilitiesinfo-powerefficient"><code><c- g>powerEfficient</c-></code></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-mediacapabilitiesdecodinginfo"><code><c- g>MediaCapabilitiesDecodingInfo</c-></code></a> : <a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitiesinfo" id="ref-for-dictdef-mediacapabilitiesinfo⑤"><c- n>MediaCapabilitiesInfo</c-></a> {
  <c- b>required</c-> <a class="n" data-link-type="idl-name" href="https://www.w3.org/TR/encrypted-media/#mediakeysystemaccess-interface" id="ref-for-mediakeysystemaccess-interface⑤"><c- n>MediaKeySystemAccess</c-></a> <a data-type="MediaKeySystemAccess " href="#dom-mediacapabilitiesdecodinginfo-keysystemaccess"><code><c- g>keySystemAccess</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration④①"><c- n>MediaDecodingConfiguration</c-></a> <a data-type="MediaDecodingConfiguration " href="#dom-mediacapabilitiesdecodinginfo-configuration"><code><c- g>configuration</c-></code></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-mediacapabilitiesencodinginfo"><code><c- g>MediaCapabilitiesEncodingInfo</c-></code></a> : <a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitiesinfo" id="ref-for-dictdef-mediacapabilitiesinfo①①"><c- n>MediaCapabilitiesInfo</c-></a> {
  <a class="n" data-link-type="idl-name" href="#dictdef-mediaencodingconfiguration" id="ref-for-dictdef-mediaencodingconfiguration②①"><c- n>MediaEncodingConfiguration</c-></a> <a data-type="MediaEncodingConfiguration " href="#dom-mediacapabilitiesencodinginfo-configuration"><code><c- g>configuration</c-></code></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed③"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/system-state.html#navigator" id="ref-for-navigator①"><c- g>Navigator</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject②"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#mediacapabilities" id="ref-for-mediacapabilities②"><c- n>MediaCapabilities</c-></a> <a data-readonly data-type="MediaCapabilities" href="#dom-navigator-mediacapabilities"><code><c- g>mediaCapabilities</c-></code></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①①"><c- g>Exposed</c-></a>=<c- n>Worker</c->]
<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/workers.html#workernavigator" id="ref-for-workernavigator①"><c- g>WorkerNavigator</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject①①"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#mediacapabilities" id="ref-for-mediacapabilities①①"><c- n>MediaCapabilities</c-></a> <a data-readonly data-type="MediaCapabilities" href="#dom-workernavigator-mediacapabilities"><code><c- g>mediaCapabilities</c-></code></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②①"><c- g>Exposed</c-></a>=(<c- n>Window</c->, <c- n>Worker</c->)]
<c- b>interface</c-> <a href="#mediacapabilities"><code><c- g>MediaCapabilities</c-></code></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject②"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitiesdecodinginfo" id="ref-for-dictdef-mediacapabilitiesdecodinginfo⑤①"><c- n>MediaCapabilitiesDecodingInfo</c-></a>> <a href="#dom-mediacapabilities-decodinginfo"><code><c- g>decodingInfo</c-></code></a>(<a class="n" data-link-type="idl-name" href="#dictdef-mediadecodingconfiguration" id="ref-for-dictdef-mediadecodingconfiguration⑧①"><c- n>MediaDecodingConfiguration</c-></a> <a href="#dom-mediacapabilities-decodinginfo-configuration-configuration"><code><c- g>configuration</c-></code></a>);
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject①①"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#dictdef-mediacapabilitiesinfo" id="ref-for-dictdef-mediacapabilitiesinfo④①"><c- n>MediaCapabilitiesInfo</c-></a>> <a href="#dom-mediacapabilities-encodinginfo"><code><c- g>encodingInfo</c-></code></a>(<a class="n" data-link-type="idl-name" href="#dictdef-mediaencodingconfiguration" id="ref-for-dictdef-mediaencodingconfiguration⑤①"><c- n>MediaEncodingConfiguration</c-></a> <a href="#dom-mediacapabilities-encodinginfo-configuration-configuration"><code><c- g>configuration</c-></code></a>);
};

</pre>
  <h2 class="no-num no-ref heading settled" id="issues-index"><span class="content">Issues Index</span><a class="self-link" href="#issues-index"></a></h2>
  <div style="counter-reset:issue">
   <div class="issue"> The <code class="idl"><a data-link-type="idl" href="#dom-audioconfiguration-channels">channels</a></code> needs to be defined as a <code>double</code> (2.1, 4.1, 5.1, ...), an <code>unsigned short</code> (number of channels) or as an <code>enum</code> value. The current
        definition is a placeholder. <a href="#issue-a7738173"> ↵ </a></div>
  </div>
  <aside class="dfn-panel" data-for="dictdef-mediaconfiguration">
   <b><a href="#dictdef-mediaconfiguration">#dictdef-mediaconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-mediaconfiguration">2.1.1. MediaConfiguration</a> <a href="#ref-for-dictdef-mediaconfiguration①">(2)</a> <a href="#ref-for-dictdef-mediaconfiguration②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaconfiguration-video">
   <b><a href="#dom-mediaconfiguration-video">#dom-mediaconfiguration-video</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaconfiguration-video">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaconfiguration-audio">
   <b><a href="#dom-mediaconfiguration-audio">#dom-mediaconfiguration-audio</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaconfiguration-audio">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-mediadecodingconfiguration">
   <b><a href="#dictdef-mediadecodingconfiguration">#dictdef-mediadecodingconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-mediadecodingconfiguration">2.1.1. MediaConfiguration</a> <a href="#ref-for-dictdef-mediadecodingconfiguration①">(2)</a> <a href="#ref-for-dictdef-mediadecodingconfiguration②">(3)</a>
    <li><a href="#ref-for-dictdef-mediadecodingconfiguration③">2.1.2. MediaDecodingType</a>
    <li><a href="#ref-for-dictdef-mediadecodingconfiguration④">2.2. Media Capabilities Information</a>
    <li><a href="#ref-for-dictdef-mediadecodingconfiguration⑤">2.3.2. 
          Create a MediaCapabilitiesDecodingInfo </a> <a href="#ref-for-dictdef-mediadecodingconfiguration⑥">(2)</a>
    <li><a href="#ref-for-dictdef-mediadecodingconfiguration⑦">2.3.3. 
          Check Encrypted Decoding Support </a>
    <li><a href="#ref-for-dictdef-mediadecodingconfiguration⑧">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediadecodingconfiguration-keysystemconfiguration">
   <b><a href="#dom-mediadecodingconfiguration-keysystemconfiguration">#dom-mediadecodingconfiguration-keysystemconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediadecodingconfiguration-keysystemconfiguration">2.1.1. MediaConfiguration</a>
    <li><a href="#ref-for-dom-mediadecodingconfiguration-keysystemconfiguration①">2.3.3. 
          Check Encrypted Decoding Support </a>
    <li><a href="#ref-for-dom-mediadecodingconfiguration-keysystemconfiguration②">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-mediaencodingconfiguration">
   <b><a href="#dictdef-mediaencodingconfiguration">#dictdef-mediaencodingconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-mediaencodingconfiguration">2.1.1. MediaConfiguration</a>
    <li><a href="#ref-for-dictdef-mediaencodingconfiguration①">2.1.3. MediaEncodingType</a>
    <li><a href="#ref-for-dictdef-mediaencodingconfiguration②">2.2. Media Capabilities Information</a>
    <li><a href="#ref-for-dictdef-mediaencodingconfiguration③">2.3.1. 
          Create a MediaCapabilitiesEncodingInfo </a> <a href="#ref-for-dictdef-mediaencodingconfiguration④">(2)</a>
    <li><a href="#ref-for-dictdef-mediaencodingconfiguration⑤">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valid-mediaconfiguration">
   <b><a href="#valid-mediaconfiguration">#valid-mediaconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valid-mediaconfiguration">2.1.1. MediaConfiguration</a>
    <li><a href="#ref-for-valid-mediaconfiguration①">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valid-mediadecodingconfiguration">
   <b><a href="#valid-mediadecodingconfiguration">#valid-mediadecodingconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valid-mediadecodingconfiguration">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-mediadecodingtype">
   <b><a href="#enumdef-mediadecodingtype">#enumdef-mediadecodingtype</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-mediadecodingtype">2.1.1. MediaConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediadecodingtype-file">
   <b><a href="#dom-mediadecodingtype-file">#dom-mediadecodingtype-file</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediadecodingtype-file">2.1.2. MediaDecodingType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediadecodingtype-media-source">
   <b><a href="#dom-mediadecodingtype-media-source">#dom-mediadecodingtype-media-source</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediadecodingtype-media-source">2.1.2. MediaDecodingType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-mediaencodingtype">
   <b><a href="#enumdef-mediaencodingtype">#enumdef-mediaencodingtype</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-mediaencodingtype">2.1.1. MediaConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaencodingtype-record">
   <b><a href="#dom-mediaencodingtype-record">#dom-mediaencodingtype-record</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaencodingtype-record">2.1.3. MediaEncodingType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaencodingtype-transmission">
   <b><a href="#dom-mediaencodingtype-transmission">#dom-mediaencodingtype-transmission</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaencodingtype-transmission">2.1.3. MediaEncodingType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valid-media-mime-type">
   <b><a href="#valid-media-mime-type">#valid-media-mime-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valid-media-mime-type">2.1.4. MIME types</a> <a href="#ref-for-valid-media-mime-type①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valid-audio-mime-type">
   <b><a href="#valid-audio-mime-type">#valid-audio-mime-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valid-audio-mime-type">2.1.9. AudioConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valid-video-mime-type">
   <b><a href="#valid-video-mime-type">#valid-video-mime-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valid-video-mime-type">2.1.5. VideoConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-videoconfiguration">
   <b><a href="#dictdef-videoconfiguration">#dictdef-videoconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-videoconfiguration">2.1.1. MediaConfiguration</a>
    <li><a href="#ref-for-dictdef-videoconfiguration①">2.1.5. VideoConfiguration</a>
    <li><a href="#ref-for-dictdef-videoconfiguration②">2.1.6. HdrMetadataType</a>
    <li><a href="#ref-for-dictdef-videoconfiguration③">2.1.7. ColorGamut</a>
    <li><a href="#ref-for-dictdef-videoconfiguration④">2.1.8. TransferFunction</a>
    <li><a href="#ref-for-dictdef-videoconfiguration⑤">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-videoconfiguration-contenttype">
   <b><a href="#dom-videoconfiguration-contenttype">#dom-videoconfiguration-contenttype</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-videoconfiguration-contenttype">2.1.5. VideoConfiguration</a> <a href="#ref-for-dom-videoconfiguration-contenttype①">(2)</a> <a href="#ref-for-dom-videoconfiguration-contenttype②">(3)</a> <a href="#ref-for-dom-videoconfiguration-contenttype③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valid-video-configuration">
   <b><a href="#valid-video-configuration">#valid-video-configuration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valid-video-configuration">2.1.1. MediaConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-videoconfiguration-width">
   <b><a href="#dom-videoconfiguration-width">#dom-videoconfiguration-width</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-videoconfiguration-width">2.1.5. VideoConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-videoconfiguration-height">
   <b><a href="#dom-videoconfiguration-height">#dom-videoconfiguration-height</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-videoconfiguration-height">2.1.5. VideoConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-videoconfiguration-bitrate">
   <b><a href="#dom-videoconfiguration-bitrate">#dom-videoconfiguration-bitrate</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-videoconfiguration-bitrate">2.1.5. VideoConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-videoconfiguration-framerate">
   <b><a href="#dom-videoconfiguration-framerate">#dom-videoconfiguration-framerate</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-videoconfiguration-framerate">2.1.5. VideoConfiguration</a> <a href="#ref-for-dom-videoconfiguration-framerate①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-videoconfiguration-hasalphachannel">
   <b><a href="#dom-videoconfiguration-hasalphachannel">#dom-videoconfiguration-hasalphachannel</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-videoconfiguration-hasalphachannel">2.1.5. VideoConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-videoconfiguration-hdrmetadatatype">
   <b><a href="#dom-videoconfiguration-hdrmetadatatype">#dom-videoconfiguration-hdrmetadatatype</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-videoconfiguration-hdrmetadatatype">2.1.5. VideoConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-videoconfiguration-colorgamut">
   <b><a href="#dom-videoconfiguration-colorgamut">#dom-videoconfiguration-colorgamut</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-videoconfiguration-colorgamut">2.1.5. VideoConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-videoconfiguration-transferfunction">
   <b><a href="#dom-videoconfiguration-transferfunction">#dom-videoconfiguration-transferfunction</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-videoconfiguration-transferfunction">2.1.5. VideoConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-hdrmetadatatype">
   <b><a href="#enumdef-hdrmetadatatype">#enumdef-hdrmetadatatype</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-hdrmetadatatype">2.1.5. VideoConfiguration</a> <a href="#ref-for-enumdef-hdrmetadatatype①">(2)</a>
    <li><a href="#ref-for-enumdef-hdrmetadatatype②">2.1.6. HdrMetadataType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-hdrmetadatatype-smptest2086">
   <b><a href="#dom-hdrmetadatatype-smptest2086">#dom-hdrmetadatatype-smptest2086</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-hdrmetadatatype-smptest2086">2.1.6. HdrMetadataType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-hdrmetadatatype-smptest2094-10">
   <b><a href="#dom-hdrmetadatatype-smptest2094-10">#dom-hdrmetadatatype-smptest2094-10</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-hdrmetadatatype-smptest2094-10">2.1.6. HdrMetadataType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-hdrmetadatatype-smptest2094-40">
   <b><a href="#dom-hdrmetadatatype-smptest2094-40">#dom-hdrmetadatatype-smptest2094-40</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-hdrmetadatatype-smptest2094-40">2.1.6. HdrMetadataType</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-colorgamut">
   <b><a href="#enumdef-colorgamut">#enumdef-colorgamut</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-colorgamut">2.1.5. VideoConfiguration</a> <a href="#ref-for-enumdef-colorgamut①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-colorgamut-srgb">
   <b><a href="#dom-colorgamut-srgb">#dom-colorgamut-srgb</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-colorgamut-srgb">2.1.7. ColorGamut</a> <a href="#ref-for-dom-colorgamut-srgb①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-colorgamut-p3">
   <b><a href="#dom-colorgamut-p3">#dom-colorgamut-p3</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-colorgamut-p3">2.1.7. ColorGamut</a> <a href="#ref-for-dom-colorgamut-p3①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-colorgamut-rec2020">
   <b><a href="#dom-colorgamut-rec2020">#dom-colorgamut-rec2020</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-colorgamut-rec2020">2.1.7. ColorGamut</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-transferfunction">
   <b><a href="#enumdef-transferfunction">#enumdef-transferfunction</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-transferfunction">2.1.5. VideoConfiguration</a> <a href="#ref-for-enumdef-transferfunction①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-transferfunction-srgb">
   <b><a href="#dom-transferfunction-srgb">#dom-transferfunction-srgb</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-transferfunction-srgb">2.1.8. TransferFunction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-transferfunction-pq">
   <b><a href="#dom-transferfunction-pq">#dom-transferfunction-pq</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-transferfunction-pq">2.1.8. TransferFunction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-transferfunction-hlg">
   <b><a href="#dom-transferfunction-hlg">#dom-transferfunction-hlg</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-transferfunction-hlg">2.1.8. TransferFunction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-audioconfiguration">
   <b><a href="#dictdef-audioconfiguration">#dictdef-audioconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-audioconfiguration">2.1.1. MediaConfiguration</a>
    <li><a href="#ref-for-dictdef-audioconfiguration①">2.1.9. AudioConfiguration</a>
    <li><a href="#ref-for-dictdef-audioconfiguration②">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-audioconfiguration-contenttype">
   <b><a href="#dom-audioconfiguration-contenttype">#dom-audioconfiguration-contenttype</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-audioconfiguration-contenttype">2.1.9. AudioConfiguration</a> <a href="#ref-for-dom-audioconfiguration-contenttype①">(2)</a> <a href="#ref-for-dom-audioconfiguration-contenttype②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valid-audio-configuration">
   <b><a href="#valid-audio-configuration">#valid-audio-configuration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valid-audio-configuration">2.1.1. MediaConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-audioconfiguration-channels">
   <b><a href="#dom-audioconfiguration-channels">#dom-audioconfiguration-channels</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-audioconfiguration-channels">2.1.9. AudioConfiguration</a> <a href="#ref-for-dom-audioconfiguration-channels①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-audioconfiguration-bitrate">
   <b><a href="#dom-audioconfiguration-bitrate">#dom-audioconfiguration-bitrate</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-audioconfiguration-bitrate">2.1.9. AudioConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-audioconfiguration-samplerate">
   <b><a href="#dom-audioconfiguration-samplerate">#dom-audioconfiguration-samplerate</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-audioconfiguration-samplerate">2.1.9. AudioConfiguration</a> <a href="#ref-for-dom-audioconfiguration-samplerate①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-audioconfiguration-spatialrendering">
   <b><a href="#dom-audioconfiguration-spatialrendering">#dom-audioconfiguration-spatialrendering</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-audioconfiguration-spatialrendering">2.1.9. AudioConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-mediacapabilitieskeysystemconfiguration">
   <b><a href="#dictdef-mediacapabilitieskeysystemconfiguration">#dictdef-mediacapabilitieskeysystemconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-mediacapabilitieskeysystemconfiguration">2.1.1. MediaConfiguration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilitieskeysystemconfiguration-keysystem">
   <b><a href="#dom-mediacapabilitieskeysystemconfiguration-keysystem">#dom-mediacapabilitieskeysystemconfiguration-keysystem</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilitieskeysystemconfiguration-keysystem">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
    <li><a href="#ref-for-dom-mediacapabilitieskeysystemconfiguration-keysystem①">2.3.3. 
          Check Encrypted Decoding Support </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilitieskeysystemconfiguration-initdatatype">
   <b><a href="#dom-mediacapabilitieskeysystemconfiguration-initdatatype">#dom-mediacapabilitieskeysystemconfiguration-initdatatype</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilitieskeysystemconfiguration-initdatatype">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier">
   <b><a href="#dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier">#dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilitieskeysystemconfiguration-distinctiveidentifier">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilitieskeysystemconfiguration-persistentstate">
   <b><a href="#dom-mediacapabilitieskeysystemconfiguration-persistentstate">#dom-mediacapabilitieskeysystemconfiguration-persistentstate</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilitieskeysystemconfiguration-persistentstate">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilitieskeysystemconfiguration-sessiontypes">
   <b><a href="#dom-mediacapabilitieskeysystemconfiguration-sessiontypes">#dom-mediacapabilitieskeysystemconfiguration-sessiontypes</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilitieskeysystemconfiguration-sessiontypes">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilitieskeysystemconfiguration-audio">
   <b><a href="#dom-mediacapabilitieskeysystemconfiguration-audio">#dom-mediacapabilitieskeysystemconfiguration-audio</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilitieskeysystemconfiguration-audio">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilitieskeysystemconfiguration-video">
   <b><a href="#dom-mediacapabilitieskeysystemconfiguration-video">#dom-mediacapabilitieskeysystemconfiguration-video</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilitieskeysystemconfiguration-video">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-keysystemtrackconfiguration">
   <b><a href="#dictdef-keysystemtrackconfiguration">#dictdef-keysystemtrackconfiguration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-keysystemtrackconfiguration">2.1.10. 
        MediaCapabilitiesKeySystemConfiguration </a> <a href="#ref-for-dictdef-keysystemtrackconfiguration①">(2)</a> <a href="#ref-for-dictdef-keysystemtrackconfiguration②">(3)</a> <a href="#ref-for-dictdef-keysystemtrackconfiguration③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-keysystemtrackconfiguration-robustness">
   <b><a href="#dom-keysystemtrackconfiguration-robustness">#dom-keysystemtrackconfiguration-robustness</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-keysystemtrackconfiguration-robustness">2.1.11. 
      KeySystemTrackConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-keysystemtrackconfiguration-encryptionscheme">
   <b><a href="#dom-keysystemtrackconfiguration-encryptionscheme">#dom-keysystemtrackconfiguration-encryptionscheme</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-keysystemtrackconfiguration-encryptionscheme">2.1.11. 
      KeySystemTrackConfiguration </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-mediacapabilitiesinfo">
   <b><a href="#dictdef-mediacapabilitiesinfo">#dictdef-mediacapabilitiesinfo</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-mediacapabilitiesinfo">2.2. Media Capabilities Information</a> <a href="#ref-for-dictdef-mediacapabilitiesinfo①">(2)</a> <a href="#ref-for-dictdef-mediacapabilitiesinfo②">(3)</a> <a href="#ref-for-dictdef-mediacapabilitiesinfo③">(4)</a>
    <li><a href="#ref-for-dictdef-mediacapabilitiesinfo④">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilitiesinfo-powerefficient">
   <b><a href="#dom-mediacapabilitiesinfo-powerefficient">#dom-mediacapabilitiesinfo-powerefficient</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilitiesinfo-powerefficient">2.2. Media Capabilities Information</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-mediacapabilitiesdecodinginfo">
   <b><a href="#dictdef-mediacapabilitiesdecodinginfo">#dictdef-mediacapabilitiesdecodinginfo</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-mediacapabilitiesdecodinginfo">2.2. Media Capabilities Information</a> <a href="#ref-for-dictdef-mediacapabilitiesdecodinginfo①">(2)</a> <a href="#ref-for-dictdef-mediacapabilitiesdecodinginfo②">(3)</a>
    <li><a href="#ref-for-dictdef-mediacapabilitiesdecodinginfo③">2.3.2. 
          Create a MediaCapabilitiesDecodingInfo </a> <a href="#ref-for-dictdef-mediacapabilitiesdecodinginfo④">(2)</a>
    <li><a href="#ref-for-dictdef-mediacapabilitiesdecodinginfo⑤">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-mediacapabilitiesencodinginfo">
   <b><a href="#dictdef-mediacapabilitiesencodinginfo">#dictdef-mediacapabilitiesencodinginfo</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-mediacapabilitiesencodinginfo">2.2. Media Capabilities Information</a> <a href="#ref-for-dictdef-mediacapabilitiesencodinginfo①">(2)</a>
    <li><a href="#ref-for-dictdef-mediacapabilitiesencodinginfo②">2.3.1. 
          Create a MediaCapabilitiesEncodingInfo </a> <a href="#ref-for-dictdef-mediacapabilitiesencodinginfo③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediacapabilitiesinfo-supported">
   <b><a href="#mediacapabilitiesinfo-supported">#mediacapabilitiesinfo-supported</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediacapabilitiesinfo-supported">2.1.9. AudioConfiguration</a>
    <li><a href="#ref-for-mediacapabilitiesinfo-supported①">2.3.1. 
          Create a MediaCapabilitiesEncodingInfo </a>
    <li><a href="#ref-for-mediacapabilitiesinfo-supported②">2.3.2. 
          Create a MediaCapabilitiesDecodingInfo </a> <a href="#ref-for-mediacapabilitiesinfo-supported③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediacapabilitiesinfo-smooth">
   <b><a href="#mediacapabilitiesinfo-smooth">#mediacapabilitiesinfo-smooth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediacapabilitiesinfo-smooth">2.3.1. 
          Create a MediaCapabilitiesEncodingInfo </a>
    <li><a href="#ref-for-mediacapabilitiesinfo-smooth①">2.3.2. 
          Create a MediaCapabilitiesDecodingInfo </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediacapabilitiesinfo-powerefficient">
   <b><a href="#mediacapabilitiesinfo-powerefficient">#mediacapabilitiesinfo-powerefficient</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediacapabilitiesinfo-powerefficient">2.3.1. 
          Create a MediaCapabilitiesEncodingInfo </a>
    <li><a href="#ref-for-mediacapabilitiesinfo-powerefficient①">2.3.2. 
          Create a MediaCapabilitiesDecodingInfo </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediacapabilitiesdecodinginfo-keysystemaccess">
   <b><a href="#mediacapabilitiesdecodinginfo-keysystemaccess">#mediacapabilitiesdecodinginfo-keysystemaccess</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediacapabilitiesdecodinginfo-keysystemaccess">2.3.2. 
          Create a MediaCapabilitiesDecodingInfo </a> <a href="#ref-for-mediacapabilitiesdecodinginfo-keysystemaccess①">(2)</a> <a href="#ref-for-mediacapabilitiesdecodinginfo-keysystemaccess②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediacapabilitiesdecodinginfo-configuration">
   <b><a href="#mediacapabilitiesdecodinginfo-configuration">#mediacapabilitiesdecodinginfo-configuration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediacapabilitiesdecodinginfo-configuration">2.3.2. 
          Create a MediaCapabilitiesDecodingInfo </a> <a href="#ref-for-mediacapabilitiesdecodinginfo-configuration①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediacapabilitiesencodinginfo-configuration">
   <b><a href="#mediacapabilitiesencodinginfo-configuration">#mediacapabilitiesencodinginfo-configuration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediacapabilitiesencodinginfo-configuration">2.3.1. 
          Create a MediaCapabilitiesEncodingInfo </a> <a href="#ref-for-mediacapabilitiesencodinginfo-configuration①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="create-a-mediacapabilitiesencodinginfo">
   <b><a href="#create-a-mediacapabilitiesencodinginfo">#create-a-mediacapabilitiesencodinginfo</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-create-a-mediacapabilitiesencodinginfo">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="create-a-mediacapabilitiesdecodinginfo">
   <b><a href="#create-a-mediacapabilitiesdecodinginfo">#create-a-mediacapabilitiesdecodinginfo</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-create-a-mediacapabilitiesdecodinginfo">2.5. Media Capabilities Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="check-encrypted-decoding-support">
   <b><a href="#check-encrypted-decoding-support">#check-encrypted-decoding-support</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-check-encrypted-decoding-support">2.3.2. 
          Create a MediaCapabilitiesDecodingInfo </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediacapabilities">
   <b><a href="#mediacapabilities">#mediacapabilities</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediacapabilities">2.4. Navigator and WorkerNavigator extension</a> <a href="#ref-for-mediacapabilities①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilities-decodinginfo">
   <b><a href="#dom-mediacapabilities-decodinginfo">#dom-mediacapabilities-decodinginfo</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilities-decodinginfo">2.5. Media Capabilities Interface</a> <a href="#ref-for-dom-mediacapabilities-decodinginfo①">(2)</a>
    <li><a href="#ref-for-dom-mediacapabilities-decodinginfo②">4.1. Query playback capabilities with decodingInfo()</a> <a href="#ref-for-dom-mediacapabilities-decodinginfo③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediacapabilities-encodinginfo">
   <b><a href="#dom-mediacapabilities-encodinginfo">#dom-mediacapabilities-encodinginfo</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediacapabilities-encodinginfo">2.5. Media Capabilities Interface</a>
    <li><a href="#ref-for-dom-mediacapabilities-encodinginfo①">4.2. Query recording capabilities with encodingInfo()</a>
   </ul>
  </aside>
<script>/* script-dfn-panel */

document.body.addEventListener("click", function(e) {
    var queryAll = function(sel) { return [].slice.call(document.querySelectorAll(sel)); }
    // Find the dfn element or panel, if any, that was clicked on.
    var el = e.target;
    var target;
    var hitALink = false;
    while(el.parentElement) {
        if(el.tagName == "A") {
            // Clicking on a link in a <dfn> shouldn't summon the panel
            hitALink = true;
        }
        if(el.classList.contains("dfn-paneled")) {
            target = "dfn";
            break;
        }
        if(el.classList.contains("dfn-panel")) {
            target = "dfn-panel";
            break;
        }
        el = el.parentElement;
    }
    if(target != "dfn-panel") {
        // Turn off any currently "on" or "activated" panels.
        queryAll(".dfn-panel.on, .dfn-panel.activated").forEach(function(el){
            el.classList.remove("on");
            el.classList.remove("activated");
        });
    }
    if(target == "dfn" && !hitALink) {
        // open the panel
        var dfnPanel = document.querySelector(".dfn-panel[data-for='" + el.id + "']");
        if(dfnPanel) {
            dfnPanel.classList.add("on");
            var rect = el.getBoundingClientRect();
            dfnPanel.style.left = window.scrollX + rect.right + 5 + "px";
            dfnPanel.style.top = window.scrollY + rect.top + "px";
            var panelRect = dfnPanel.getBoundingClientRect();
            var panelWidth = panelRect.right - panelRect.left;
            if(panelRect.right > document.body.scrollWidth && (rect.left - (panelWidth + 5)) > 0) {
                // Reposition, because the panel is overflowing
                dfnPanel.style.left = window.scrollX + rect.left - (panelWidth + 5) + "px";
            }
        } else {
            console.log("Couldn't find .dfn-panel[data-for='" + el.id + "']");
        }
    } else if(target == "dfn-panel") {
        // Switch it to "activated" state, which pins it.
        el.classList.add("activated");
        el.style.left = null;
        el.style.top = null;
    }

});
</script>