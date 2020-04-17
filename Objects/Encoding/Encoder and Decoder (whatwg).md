<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <title>Credential Management Level 1</title>
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
	.overlarge > table {
		/* limit preferred width of table */
		max-width: 50em;
		margin-left: auto;
		margin-right: auto;
	}

	@media (min-width: 55em) {
		.overlarge {
			margin-left: calc(13px + 26.5rem - 50vw);
			margin-right: calc(13px + 26.5rem - 50vw);
			max-width: none;
		}
	}
	@media screen and (min-width: 78em) {
		body:not(.toc-inline) .overlarge {
			/* 30.5em body padding 50em content area */
			margin-left: calc(40em - 50vw) !important;
			margin-right: calc(40em - 50vw) !important;
		}
	}
	@media screen and (min-width: 90em) {
		body:not(.toc-inline) .overlarge {
			/* 4em html margin 30.5em body padding 50em content area */
			margin-left: 0 !important;
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
  <meta content="Bikeshed version 98212c11613b78977e54b28cc53499f2ee83d388" name="generator">
  <link href="http://www.w3.org/TR/credential-management-1/" rel="canonical">
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
<style>/* style-var-click-highlighting */

    var { cursor: pointer; }
    var.selected0 { background-color: #F4D200; box-shadow: 0 0 0 2px #F4D200; }
    var.selected1 { background-color: #FF87A2; box-shadow: 0 0 0 2px #FF87A2; }
    var.selected2 { background-color: #96E885; box-shadow: 0 0 0 2px #96E885; }
    var.selected3 { background-color: #3EEED2; box-shadow: 0 0 0 2px #3EEED2; }
    var.selected4 { background-color: #EACFB6; box-shadow: 0 0 0 2px #EACFB6; }
    var.selected5 { background-color: #82DDFF; box-shadow: 0 0 0 2px #82DDFF; }
    var.selected6 { background-color: #FFBCF2; box-shadow: 0 0 0 2px #FFBCF2; }
    </style>
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
   <h1>Credential Management Level 1</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2019-10-23">23 October 2019</time></span></h2>
   <div data-fill-with="spec-metadata">
    <dl>
     <dt>This version:
     <dd><a class="u-url" href="https://w3c.github.io/webappsec-credential-management/">https://w3c.github.io/webappsec-credential-management/</a>
     <dt>Latest published version:
     <dd><a href="http://www.w3.org/TR/credential-management-1/">http://www.w3.org/TR/credential-management-1/</a>
     <dt>Previous Versions:
     <dd><a href="http://www.w3.org/TR/2016/WD-credential-management-1-20160425/" rel="prev">http://www.w3.org/TR/2016/WD-credential-management-1-20160425/</a>
     <dt>Version History:
     <dd><a href="https://github.com/w3c/webappsec-credential-management/commits/master/index.src.html">https://github.com/w3c/webappsec-credential-management/commits/master/index.src.html</a>
     <dt>Feedback:
     <dd><span><a href="mailto:public-webappsec@w3.org?subject=%5Bcredential-management%5D%20YOUR%20TOPIC%20HERE">public-webappsec@w3.org</a> with subject line “<kbd>[credential-management] <i data-lt>… message topic …</i></kbd>” (<a href="https://lists.w3.org/Archives/Public/public-webappsec/" rel="discussion">archives</a>)</span>
     <dt class="editor">Editor:
     <dd class="editor p-author h-card vcard" data-editor-id="56384"><a class="p-name fn u-email email" href="mailto:mkwst@google.com">Mike West</a> (<span class="p-org org">Google Inc.</span>)
     <dt>Participate:
     <dd><a href="https://github.com/w3c/webappsec-credential-management/issues/new">File an issue</a> (<a href="https://github.com/w3c/webappsec-credential-management/issues">open issues</a>)
    </dl>
   </div>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2019 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/copyright-documents">document use</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>This specification describes an imperative API enabling a website to request a

  user’s credentials from a user agent, and to help the user agent correctly
  store user credentials for future use.</p>
  </div>
  <h2 class="no-num no-toc no-ref heading settled" id="status"><span class="content">Status of this document</span></h2>
  <div data-fill-with="status">
   <p> This is a public copy of the editors’ draft.
	It is provided for discussion only and may change at any moment.
	Its publication here does not imply endorsement of its contents by W3C.
	Don’t cite this document other than as work in progress. </p>
   <p> <strong>Changes to this document may be tracked at <a href="https://github.com/w3c/webappsec">https://github.com/w3c/webappsec</a>.</strong> </p>
   <p> The (<a href="https://lists.w3.org/Archives/Public/public-webappsec/">archived</a>) public mailing list <a href="mailto:public-webappsec@w3.org?Subject=%5Bcredential-management%5D%20PUT%20SUBJECT%20HERE">public-webappsec@w3.org</a> (see <a href="https://www.w3.org/Mail/Request">instructions</a>)
	is preferred for discussion of this specification.
	When sending e-mail,
	please put the text “credential-management” in the subject,
	preferably like this:
	“[credential-management] <em>…summary of comment…</em>” </p>
   <p> This document was produced by the <a href="https://www.w3.org/2011/webappsec/">Web Application Security Working Group</a>. </p>
   <p> This document was produced by a group operating under
	the <a href="https://www.w3.org/Consortium/Patent-Policy/">W3C Patent Policy</a>.
	W3C maintains a <a href="https://www.w3.org/2004/01/pp-impl/49309/status" rel="disclosure">public list of any patent disclosures</a> made in connection with the deliverables of the group;
	that page also includes instructions for disclosing a patent.
	An individual who has actual knowledge of a patent which the individual believes contains <a href="https://www.w3.org/Consortium/Patent-Policy/#def-essential">Essential Claim(s)</a> must disclose the information in accordance with <a href="https://www.w3.org/Consortium/Patent-Policy/#sec-Disclosure">section 6 of the W3C Patent Policy</a>. </p>
   <p> This document is governed by the <a href="https://www.w3.org/2019/Process-20190301/" id="w3c_process_revision">1 March 2019 W3C Process Document</a>. </p>
   <p></p>
  </div>
  <div data-fill-with="at-risk"></div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li>
     <a href="#introduction"><span class="secno">1</span> <span class="content">Introduction</span></a>
     <ol class="toc">
      <li><a href="#use-cases"><span class="secno">1.1</span> <span class="content">Use Cases</span></a>
     </ol>
    <li>
     <a href="#core"><span class="secno">2</span> <span class="content">Core API</span></a>
     <ol class="toc">
      <li><a href="#core-infrastructure"><span class="secno">2.1</span> <span class="content">Infrastructure</span></a>
      <li>
       <a href="#the-credential-interface"><span class="secno">2.2</span> <span class="content">The <code>Credential</code> Interface</span></a>
       <ol class="toc">
        <li>
         <a href="#credential-internal-methods"><span class="secno">2.2.1</span> <span class="content"><code>Credential</code> Internal Methods</span></a>
         <ol class="toc">
          <li><a href="#algorithm-collect-creds"><span class="secno">2.2.1.1</span> <span class="content"><code>[[CollectFromCredentialStore]]</code> internal method</span></a>
          <li><a href="#algorithm-discover-creds"><span class="secno">2.2.1.2</span> <span class="content"><code>[[DiscoverFromExternalSource]]</code> internal method</span></a>
          <li><a href="#algorithm-store-cred"><span class="secno">2.2.1.3</span> <span class="content"><code>[[Store]]</code> internal method</span></a>
          <li><a href="#algorithm-create-cred"><span class="secno">2.2.1.4</span> <span class="content"><code>[[Create]]</code> internal method</span></a>
         </ol>
        <li><a href="#credentialuserdata-mixin"><span class="secno">2.2.2</span> <span class="content"><code>CredentialUserData</code> Mixin</span></a>
       </ol>
      <li>
       <a href="#framework-credential-management"><span class="secno">2.3</span> <span class="content"><code>navigator.credentials</code></span></a>
       <ol class="toc">
        <li><a href="#credentialrequestoptions-dictionary"><span class="secno">2.3.1</span> <span class="content">The <code>CredentialRequestOptions</code> Dictionary</span></a>
        <li>
         <a href="#mediation-requirements"><span class="secno">2.3.2</span> <span class="content">Mediation Requirements</span></a>
         <ol class="toc">
          <li><a href="#mediation-examples"><span class="secno">2.3.2.1</span> <span class="content">Examples</span></a>
         </ol>
       </ol>
      <li><a href="#credentialcreationoptions-dictionary"><span class="secno">2.4</span> <span class="content">The <code>CredentialCreationOptions</code> Dictionary</span></a>
      <li>
       <a href="#algorithms"><span class="secno">2.5</span> <span class="content">Algorithms</span></a>
       <ol class="toc">
        <li><a href="#algorithm-request"><span class="secno">2.5.1</span> <span class="content">Request a <code>Credential</code></span></a>
        <li><a href="#algorithm-collect-known"><span class="secno">2.5.2</span> <span class="content">Collect <code>Credential</code>s from the credential store</span></a>
        <li><a href="#algorithm-store"><span class="secno">2.5.3</span> <span class="content">Store a <code>Credential</code></span></a>
        <li><a href="#algorithm-create"><span class="secno">2.5.4</span> <span class="content">Create a <code>Credential</code></span></a>
        <li><a href="#algorithm-prevent-silent-access"><span class="secno">2.5.5</span> <span class="content">Prevent Silent Access</span></a>
       </ol>
     </ol>
    <li>
     <a href="#passwords"><span class="secno">3</span> <span class="content">Password Credentials</span></a>
     <ol class="toc">
      <li>
       <a href="#password-examples"><span class="secno">3.1</span> <span class="content">Examples</span></a>
       <ol class="toc">
        <li><a href="#examples-password-signin"><span class="secno">3.1.1</span> <span class="content">Password-based Sign-in</span></a>
        <li><a href="#examples-post-signin"><span class="secno">3.1.2</span> <span class="content">Post-sign-in Confirmation</span></a>
        <li><a href="#examples-change-password"><span class="secno">3.1.3</span> <span class="content">Change Password</span></a>
       </ol>
      <li><a href="#passwordcredential-interface"><span class="secno">3.2</span> <span class="content">The <code>PasswordCredential</code> Interface</span></a>
      <li>
       <a href="#passwordcredential-algorithms"><span class="secno">3.3</span> <span class="content">Algorithms</span></a>
       <ol class="toc">
        <li><a href="#collectfromcredentialstore-passwordcredential"><span class="secno">3.3.1</span> <span class="content"> <code>PasswordCredential</code>'s <code>[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</code> </span></a>
        <li><a href="#create-passwordcredential"><span class="secno">3.3.2</span> <span class="content"> <code>PasswordCredential</code>'s <code>[[Create]](origin, options, sameOriginWithAncestors)</code> </span></a>
        <li><a href="#store-passwordcredential"><span class="secno">3.3.3</span> <span class="content"> <code>PasswordCredential</code>'s <code>[[Store]](credential, sameOriginWithAncestors)</code> </span></a>
        <li><a href="#construct-passwordcredential-form"><span class="secno">3.3.4</span> <span class="content"> Create a <code>PasswordCredential</code> from an <code>HTMLFormElement</code> </span></a>
        <li><a href="#construct-passwordcredential-data"><span class="secno">3.3.5</span> <span class="content"> Create a <code>PasswordCredential</code> from <code>PasswordCredentialData</code> </span></a>
        <li><a href="#passwordcredential-matching"><span class="secno">3.3.6</span> <span class="content"> <code>CredentialRequestOptions</code> Matching for <code>PasswordCredential</code> </span></a>
       </ol>
     </ol>
    <li>
     <a href="#federated"><span class="secno">4</span> <span class="content">Federated Credentials</span></a>
     <ol class="toc">
      <li>
       <a href="#federatedcredential-interface"><span class="secno">4.1</span> <span class="content">The <code>FederatedCredential</code> Interface</span></a>
       <ol class="toc">
        <li><a href="#provider-identification"><span class="secno">4.1.1</span> <span class="content">Identifying Providers</span></a>
       </ol>
      <li>
       <a href="#federatedcredential-algorithms"><span class="secno">4.2</span> <span class="content">Algorithms</span></a>
       <ol class="toc">
        <li><a href="#collectfromcredentialstore-federatedcredential"><span class="secno">4.2.1</span> <span class="content"> <code>FederatedCredential</code>'s <code>[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</code> </span></a>
        <li><a href="#create-federatedcredential"><span class="secno">4.2.2</span> <span class="content"> <code>FederatedCredential</code>'s <code>[[Create]](origin, options, sameOriginWithAncestors)</code> </span></a>
        <li><a href="#store-federatedcredential"><span class="secno">4.2.3</span> <span class="content"> <code>FederatedCredential</code>'s <code>[[Store]](credential, sameOriginWithAncestors)</code> </span></a>
        <li><a href="#construct-federatedcredential-data"><span class="secno">4.2.4</span> <span class="content"> Create a <code>FederatedCredential</code> from <code>FederatedCredentialInit</code> </span></a>
       </ol>
     </ol>
    <li>
     <a href="#user-mediation"><span class="secno">5</span> <span class="content">User Mediation</span></a>
     <ol class="toc">
      <li><a href="#user-mediated-storage"><span class="secno">5.1</span> <span class="content">Storing and Updating Credentials</span></a>
      <li><a href="#user-mediation-requirement"><span class="secno">5.2</span> <span class="content">Requiring User Mediation</span></a>
      <li><a href="#user-mediated-selection"><span class="secno">5.3</span> <span class="content">Credential Selection</span></a>
     </ol>
    <li>
     <a href="#security-and-privacy"><span class="secno">6</span> <span class="content">Security and Privacy Considerations</span></a>
     <ol class="toc">
      <li><a href="#security-credential-access"><span class="secno">6.1</span> <span class="content">Cross-domain credential access</span></a>
      <li><a href="#security-leakage"><span class="secno">6.2</span> <span class="content">Credential Leakage</span></a>
      <li><a href="#insecure-sites"><span class="secno">6.3</span> <span class="content">Insecure Sites</span></a>
      <li><a href="#security-origin-confusion"><span class="secno">6.4</span> <span class="content">Origin Confusion</span></a>
      <li><a href="#security-timing"><span class="secno">6.5</span> <span class="content">Timing Attacks</span></a>
      <li><a href="#security-signout"><span class="secno">6.6</span> <span class="content">Signing-Out</span></a>
      <li><a href="#security-chooser-leakage"><span class="secno">6.7</span> <span class="content">Chooser Leakage</span></a>
      <li><a href="#security-local-data"><span class="secno">6.8</span> <span class="content">Locally Stored Data</span></a>
     </ol>
    <li>
     <a href="#implementation"><span class="secno">7</span> <span class="content">Implementation Considerations</span></a>
     <ol class="toc">
      <li><a href="#implementation-authors"><span class="secno">7.1</span> <span class="content">Website Authors</span></a>
      <li><a href="#implementation-extension"><span class="secno">7.2</span> <span class="content">Extension Points</span></a>
      <li><a href="#browser-extensions"><span class="secno">7.3</span> <span class="content">Browser Extensions</span></a>
     </ol>
    <li><a href="#teh-futur"><span class="secno">8</span> <span class="content">Future Work</span></a>
    <li>
     <a href="#conformance"><span class="secno"></span> <span class="content">Conformance</span></a>
     <ol class="toc">
      <li><a href="#conventions"><span class="secno"></span> <span class="content">Document conventions</span></a>
      <li><a href="#conformant-algorithms"><span class="secno"></span> <span class="content">Conformant Algorithms</span></a>
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
   <section>
    <h2 class="heading settled" data-level="1" id="introduction"><span class="secno">1. </span><span class="content">Introduction</span><a class="self-link" href="#introduction"></a></h2>
    <p><em>This section is not normative.</em></p>
    <p>Signing into websites is more difficult than it should be. The user agent is in a unique position
  to improve the experience in a number of ways, and most modern user agents have recognized this by
  providing some measure of  credential management natively in the browser. Users can save usernames
  and passwords for websites, and those <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential">credentials</a> are autofilled into sign-in forms with
  varying degrees of success.</p>
    <p>The <code><a data-link-type="element-sub" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete" id="ref-for-attr-fe-autocomplete">autocomplete</a></code> attribute offers a declarative mechanism by which websites can work
  with user agents to improve the latter’s ability to detect and fill sign-in forms by marking
  specific fields as "username" or "password", and user agents implement a wide variety of detection
  heuristics to work with websites which haven’t taken the time to provide this detail in markup.</p>
    <p>While this combination of heuristic and declarative detection works relatively well, the status
  quo leaves some large gaps where detection is problematic. Sites with uncommon sign-in
  mechanisms (submitting credentials via <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest">XMLHttpRequest</a></code> <a data-link-type="biblio" href="#biblio-xmlhttprequest">[XMLHTTPREQUEST]</a>, for instance) are
  difficult to reliably detect, as is the increasingly common case in which users wish to
  authenticate themselves using a federated identity provider. Allowing websites to more directly
  interact with the user agent’s credential manager would allow the credential manager to be more
  accurate on the one hand, and to assist users with federated sign-in on the other.</p>
    <p>These use cases are explored in more detail in <a href="#use-cases">§ 1.1 Use Cases</a> and in <a href="https://w3c.github.io/webappsec/usecases/credentialmanagement/">Credential Management:
  Use Cases and Requirements</a>; this specification attempts to address many of the requirements
  that document outlines by defining a Credential Manager API which a website can use to request <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①">credentials</a> for a user, and to ask the user agent to persist credentials when a user signs in
  successfully.</p>
    <p class="note" role="note"><span>Note:</span> The API defined here is intentionally small and simple: it does not intend to provide
  authentication in and of itself, but is limited to providing an interface to the existing
  credential managers implemented by existing user agents. That functionality is valuable <em>right now</em>, without significant effort on the part of either vendors or authors. There’s
  certainly quite a bit more which could be done, of course. See <a href="#teh-futur">§ 8 Future Work</a> for some thoughts
  we’ve punted for now, but which could be explored in future iterations of this API.</p>
    <h3 class="heading settled" data-level="1.1" id="use-cases"><span class="secno">1.1. </span><span class="content">Use Cases</span><a class="self-link" href="#use-cases"></a></h3>
    <p>Modern user agents generally offer users the capability to save passwords when signing into a
  website, and likewise offer the capability to fill those passwords into sign-in forms fully- or
  semi-automatically when users return to a website. From the perspective of a website, this
  behavior is completely invisible: the website doesn’t know that passwords have been stored, and
  it isn’t notified that passwords have been filled. This is both good and bad. On the one hand, a
  user agent’s password manager works regardless of whether or not a site cooperates, which is
  excellent for users. On the other, the password managers' behaviors are a fragile and proprietary
  hodgepodge of heuristics meant to detect and fill sign-in forms, password change forms, etc.</p>
    <p>A few problems with the status quo stand out as being particularly noteworthy:</p>
    <ul>
     <li data-md>
      <p>User agents have an incredibly difficult time helping users with
  federated identity providers. While detecting a username/password
  form submission is fairly straightforward, detecting sign-in via a
  third-party is quite difficult to reliably do well. It would be nice
  if a website could help the user agent understand the intent behind the
  redirects associated with a typical federated sign-in action.</p>
     <li data-md>
      <p>Likewise, user agents struggle to detect more esoteric sign-in
  mechanisms than simple username/password forms. Authors increasingly
  asynchronously sign users in via <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest①">XMLHttpRequest</a></code> or similar
  mechanisms in order to improve the experience and take more control over
  the presentation. This is good for users, but tough for user agents to
  integrate into their password managers. It would be nice if a website
  could help the user agent make sense of the sign-in mechanism they
  choose to use.</p>
     <li data-md>
      <p>Finally, changing passwords is less well-supported than it could be if
  the website explicitly informed the user agent that credentials had
  changed.</p>
    </ul>
   </section>
   <section>
    <h2 class="heading settled" data-level="2" id="core"><span class="secno">2. </span><span class="content">Core API</span><a class="self-link" href="#core"></a></h2>
    <p>From a developer’s perspective, a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-credential">credential</dfn> is an
  object which allows a developer to make an authentication decision for a particular action. This
  section defines a generic and extensible <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential">Credential</a></code> interface which serves as a base class
  for <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential②">credentials</a> defined in this and other documents, along with a set of APIs
  hanging off of <code class="idl"><a data-link-type="idl" href="#credentialscontainer" id="ref-for-credentialscontainer">navigator.credentials.*</a></code> which enable developers to
  obtain them.</p>
    <p>Various types of <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential③">credentials</a> are represented to JavaScript as an interface which <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-inherit" id="ref-for-dfn-inherit">inherits</a>, either directly or indirectly, from the <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①">Credential</a></code> interface. This
  document defines two such interfaces, <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential">PasswordCredential</a></code> and <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential">FederatedCredential</a></code>.</p>
    <p>A <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential④">credential</a> is <dfn class="dfn-paneled" data-dfn-for="credential" data-dfn-type="dfn" data-export id="credential-effective">effective</dfn> for a particular <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin">origin</a> if it
  is accepted as authentication on that origin. Even if a credential is effective at a particular
  point in time, the UA can’t assume that the same credential will be effective at any future time,
  for a couple reasons:</p>
    <ol>
     <li data-md>
      <p>A password credential may stop being effective if the account holder changes their password.</p>
     <li data-md>
      <p>A credential made from a token received over SMS is likely to only be effective for a single
 use.</p>
    </ol>
    <p>Single-use <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential⑤">credentials</a> are generated by a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="credential-source">credential source</dfn>, which could be
  a private key, access to a federated account, the ability to receive SMS messages at a particular
  phone number, or something else. Credential sources are not exposed to Javascript or explicitly
  represented in this specification. To unify the model, we consider a password to be a credential
  source on its own, which is simply copied to create password credentials.</p>
    <p>Even though the UA can’t assume that an effective credential will still be effective if used a
  second time, or that a credential source that has generated an effective credential will be able
  to generate a second effective credential in the future, the second is more likely than the first.
  By recording (with <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store">store()</a></code>) which credentials have been effective in the
  past, the UA has a better chance of <a href="#user-mediated-selection">offering</a> effective credential
  sources to the user in the future.</p>
    <h3 class="heading settled" data-level="2.1" id="core-infrastructure"><span class="secno">2.1. </span><span class="content">Infrastructure</span><a class="self-link" href="#core-infrastructure"></a></h3>
    <p>User agents MUST internally provide a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="credential store" id="concept-credential-store">credential
  store</dfn>, which is a vendor-specific, opaque storage mechanism to record which <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential⑥">credentials</a> have been <a data-link-type="dfn" href="#credential-effective" id="ref-for-credential-effective">effective</a>. It offers the following capabilities for <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential⑦">credential</a> access and
  persistence:</p>
    <ol>
     <li data-md>
      <p><dfn data-dfn-for="credential store" data-dfn-type="abstract-op" data-export id="abstract-opdef-credential-store-store-a-credential">Store a credential<a class="self-link" href="#abstract-opdef-credential-store-store-a-credential"></a></dfn> for later retrieval.
  This accepts a <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential⑧">credential</a>, and inserts it into the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store">credential store</a>.</p>
     <li data-md>
      <p><dfn class="dfn-paneled" data-dfn-for="credential store" data-dfn-type="abstract-op" data-export id="abstract-opdef-credential-store-retrieve-a-list-of-credentials">Retrieve a list of credentials</dfn>. This
  accepts an arbitrary filter, and returns a set of <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential⑨">credentials</a> that match the filter.</p>
     <li data-md>
      <p><dfn data-dfn-for="credential store" data-dfn-type="abstract-op" data-export id="abstract-opdef-credential-store-modify-a-credential">Modify a credential<a class="self-link" href="#abstract-opdef-credential-store-modify-a-credential"></a></dfn>. This accepts a <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①⓪">credential</a>, and overwrites the state of an existing <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①①">credential</a> in the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①">credential store</a>.</p>
    </ol>
    <p>Additionally, the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②">credential store</a> should maintain a <dfn class="dfn-paneled" data-dfn-for="origin" data-dfn-type="dfn" data-noexport id="origin-prevent-silent-access-flag"><code>prevent silent access</code> flag</dfn> for <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin①">origins</a> (which is set to <code>true</code> unless otherwise specified).
  An origin <dfn class="dfn-paneled" data-dfn-for="origin" data-dfn-type="dfn" data-noexport id="origin-requires-user-mediation">requires user mediation</dfn> if its flag is set to <code>true</code>.</p>
    <p class="note" role="note"><span>Note:</span> The importance of user mediation is discussed in more detail in <a href="#user-mediation">§ 5 User Mediation</a>.</p>
    <p class="note" role="note"><span>Note:</span> The <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store③">credential store</a> is an internal implementation detail of a user agent’s
  implementation of the API specified in this document, and is not exposed to the web directly.
  More capabilities may be specified by other documents in support of specific <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①②">credential</a> types.</p>
    <p>This document depends on the Infra Standard for a number of foundational concepts used in its
  algorithms and prose <a data-link-type="biblio" href="#biblio-infra">[INFRA]</a>.</p>
    <p>An <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object">environment settings object</a> (<var>settings</var>) is <dfn class="dfn-paneled" data-dfn-type="dfn" data-lt="same-origin with its ancestors" data-noexport id="same-origin-with-its-ancestors">same-origin with its
  ancestors</dfn> if the following algorithm returns <code>true</code>:</p>
    <ol>
     <li data-md>
      <p>If <var>settings</var> has no <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context" id="ref-for-responsible-browsing-context">responsible browsing context</a>,
  return <code>false</code>.</p>
     <li data-md>
      <p>Let <var>origin</var> be <var>settings</var>’ <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin">origin</a>.</p>
     <li data-md>
      <p>Let <var>current</var> be <var>settings</var>’ <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context" id="ref-for-responsible-browsing-context①">responsible browsing context</a>.</p>
     <li data-md>
      <p>While <var>current</var> has a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#parent-browsing-context" id="ref-for-parent-browsing-context">parent browsing context</a>:</p>
      <ol>
       <li data-md>
        <p>Set <var>current</var> to <var>current</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#parent-browsing-context" id="ref-for-parent-browsing-context①">parent browsing context</a>.</p>
       <li data-md>
        <p>If <var>current</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document">active document</a>'s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin②">origin</a> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin">same origin</a> with <var>origin</var>,
  return <code>false</code>.</p>
      </ol>
     <li data-md>
      <p>Return <code>true</code>.</p>
    </ol>
    <h3 class="heading settled" data-level="2.2" id="the-credential-interface"><span class="secno">2.2. </span><span class="content">The <code>Credential</code> Interface</span><a class="self-link" href="#the-credential-interface"></a></h3>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="credential"><code><c- g>Credential</c-></code></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-credential-id" id="ref-for-dom-credential-id"><c- g>id</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="DOMString" href="#dom-credential-type" id="ref-for-dom-credential-type"><c- g>type</c-></a>;
};
</pre>
    <div>
     <dl>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="Credential" data-dfn-type="attribute" data-export id="dom-credential-id"><code>id</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①">USVString</a>, readonly</span>
      <dd data-md>
       <p>The credential’s identifier. The requirements for the identifier are distinct for each type
  of <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①③">credential</a>. It might represent a username for username/password tuples, for example.</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="Credential" data-dfn-type="attribute" data-export id="dom-credential-type"><code>type</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString①">DOMString</a>, readonly</span>
      <dd data-md>
       <p>This attribute’s getter returns the value of the object’s <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object">interface object</a>'s <code class="idl"><a data-link-type="idl" href="#dom-credential-type-slot" id="ref-for-dom-credential-type-slot">[[type]]</a></code> slot, which specifies the <a data-link-type="dfn" href="#credential-credential-type" id="ref-for-credential-credential-type">credential type</a> represented by this object.</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="Credential" data-dfn-type="attribute" data-export id="dom-credential-type-slot"><code>[[type]]</code></dfn>
      <dd data-md>
       <p>The <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential②">Credential</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①">interface object</a> has an internal slot named <code>[[type]]</code>, which
  unsurprisingly contains a string representing the <dfn class="dfn-paneled" data-dfn-for="Credential" data-dfn-type="dfn" data-noexport id="credential-credential-type">credential type</dfn>. The slot’s value
  is the empty string unless otherwise specified.</p>
       <p class="note" role="note"><span>Note:</span> The <code class="idl"><a data-link-type="idl" href="#dom-credential-type-slot" id="ref-for-dom-credential-type-slot①">[[type]]</a></code> slot’s value will be the same for all credentials implementing a
  particular interface, which means that developers can rely on <code>obj.type</code> returning a string
  that unambiguously represents the specific kind of <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③">Credential</a></code> they’re dealing with.</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="Credential" data-dfn-type="attribute" data-export id="dom-credential-discovery-slot"><code>[[discovery]]</code></dfn>
      <dd data-md>
       <p>The <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential④">Credential</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object②">interface object</a> has an internal slot named <code>[[discovery]]</code>,
  representing the mechanism by which the user agent can collect credentials of
  a given type. Its value is either
  "<dfn class="dfn-paneled idl-code" data-dfn-for="Credential/[[discovery]]" data-dfn-type="enum-value" data-export id="dom-credential-discovery-credential-store"><code>credential store</code></dfn>" or
  "<dfn class="idl-code" data-dfn-for="Credential/[[discovery]]" data-dfn-type="enum-value" data-export id="dom-credential-discovery-remote"><code>remote</code><a class="self-link" href="#dom-credential-discovery-remote"></a></dfn>". The former value means that
  all available credential information is stored in the user agent’s <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store④">credential store</a>,
  while the latter means that the user agent can discover credentials outside of those
  explicitly represented in the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store⑤">credential store</a> via interaction with some external device
  or service.</p>
     </dl>
    </div>
    <p class="issue" id="issue-47fed4d0"><a class="self-link" href="#issue-47fed4d0"></a> Talk to Tobie/Dominic about the <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object③">interface object</a> bits, here and in <a href="#algorithm-request">§ 2.5.1 Request a Credential</a>, etc. I’m not sure I’ve gotten the terminology right. <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-prototype-object" id="ref-for-dfn-interface-prototype-object">interface prototype
  object</a>, maybe?</p>
    <p>Some <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤">Credential</a></code> objects are <dfn class="dfn-paneled" data-dfn-for="Credential" data-dfn-type="dfn" data-noexport id="credential-origin-bound">origin bound</dfn>: these contain an
  internal slot named <dfn class="dfn-paneled idl-code" data-dfn-for="Credential" data-dfn-type="attribute" data-export id="dom-credential-origin-slot"><code>[[origin]]</code></dfn>, which stores the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin③">origin</a> for which the <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑥">Credential</a></code> may be <a data-link-type="dfn" href="#credential-effective" id="ref-for-credential-effective①">effective</a>.</p>
    <h4 class="heading settled" data-level="2.2.1" id="credential-internal-methods"><span class="secno">2.2.1. </span><span class="content"><code>Credential</code> Internal Methods</span><a class="self-link" href="#credential-internal-methods"></a></h4>
    <p>The <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑦">Credential</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object④">interface object</a> features several <a data-link-type="dfn" href="https://tc39.github.io/ecma262/#sec-ordinary-object-internal-methods-and-internal-slots" id="ref-for-sec-ordinary-object-internal-methods-and-internal-slots">internal methods</a> facilitating
  retrieval and storage of <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑧">Credential</a></code> objects, with default "no-op" implementations
  as specified in this section, below.</p>
    <p>Unless otherwise specified, each <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object⑤">interface object</a> created for interfaces which <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-inherit" id="ref-for-dfn-inherit①">inherit</a> from <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑨">Credential</a></code> MUST provide implementations for at least one of these internal methods, overriding <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①⓪">Credential</a></code>'s default implementations, as appropriate for the <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①④">credential</a> type. E.g., <a href="#passwordcredential-interface">§ 3.2 The PasswordCredential Interface</a>, <a href="#federatedcredential-interface">§ 4.1 The FederatedCredential Interface</a>, and <a data-link-type="biblio" href="#biblio-webauthn">[WEBAUTHN]</a>.</p>
    <h5 class="heading settled algorithm" data-algorithm="[[CollectFromCredentialStore]] internal method" data-level="2.2.1.1" id="algorithm-collect-creds"><span class="secno">2.2.1.1. </span><span class="content"><code>[[CollectFromCredentialStore]]</code> internal method</span><a class="self-link" href="#algorithm-collect-creds"></a></h5>
     <dfn class="dfn-paneled idl-code" data-dfn-for="Credential" data-dfn-type="method" data-export id="dom-credential-collectfromcredentialstore-slot"><code>[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</code></dfn> is called with an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin①">origin</a>, a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions">CredentialRequestOptions</a></code>, and a boolean which
    is true iff the caller’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object①">environment settings object</a> is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors">same-origin with its ancestors</a>.
    The algorithm returns a set of <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①①">Credential</a></code> objects from the user agent’s <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store⑥">credential store</a> that
    match the options provided. If no matching <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①②">Credential</a></code> objects are available, the
    returned set will be empty. 
    <p><code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①③">Credential</a></code>'s default implementation of <code class="idl"><a data-link-type="idl" href="#dom-credential-collectfromcredentialstore-slot" id="ref-for-dom-credential-collectfromcredentialstore-slot">[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</a></code>:</p>
    <ol class="algorithm">
     <li data-md>
      <p>Return an empty set.</p>
    </ol>
    <h5 class="heading settled algorithm" data-algorithm="[[DiscoverFromExternalSource]] internal method" data-level="2.2.1.2" id="algorithm-discover-creds"><span class="secno">2.2.1.2. </span><span class="content"><code>[[DiscoverFromExternalSource]]</code> internal method</span><a class="self-link" href="#algorithm-discover-creds"></a></h5>
     <dfn class="dfn-paneled idl-code" data-dfn-for="Credential" data-dfn-type="method" data-export id="dom-credential-discoverfromexternalsource-slot"><code>[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</code></dfn> is called <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel">in parallel</a> with an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin②">origin</a>, a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①">CredentialRequestOptions</a></code> object,
    and a boolean which is true iff the caller’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object②">environment settings object</a> is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors①">same-origin with its ancestors</a>.
    It returns a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①④">Credential</a></code> if one can be
    returned given the options provided, <code>null</code> if no credential is available, or an error if
    discovery fails (for example, incorrect options could produce a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror">TypeError</a></code>). If this
    kind of <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①⑤">Credential</a></code> is only <a data-link-type="dfn" href="#credential-effective" id="ref-for-credential-effective②">effective</a> for a single use or a limited time, this
    method is responsible for generating new <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①⑤">credentials</a> using a <a data-link-type="dfn" href="#credential-source" id="ref-for-credential-source">credential source</a>. 
    <p><code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①⑥">Credential</a></code>'s default implementation of <code class="idl"><a data-link-type="idl" href="#dom-credential-discoverfromexternalsource-slot" id="ref-for-dom-credential-discoverfromexternalsource-slot">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</a></code>:</p>
    <ol class="algorithm">
     <li data-md>
      <p>Return <code>null</code>.</p>
    </ol>
    <h5 class="heading settled algorithm" data-algorithm="[[Store]] internal method" data-level="2.2.1.3" id="algorithm-store-cred"><span class="secno">2.2.1.3. </span><span class="content"><code>[[Store]]</code> internal method</span><a class="self-link" href="#algorithm-store-cred"></a></h5>
     <dfn class="dfn-paneled idl-code" data-dfn-for="Credential" data-dfn-type="method" data-export id="dom-credential-store-slot"><code>[[Store]](credential, sameOriginWithAncestors)</code></dfn> is called <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel①">in parallel</a> with a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①⑦">Credential</a></code>, and a boolean which is true iff the caller’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object③">environment settings object</a> is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors②">same-origin with its ancestors</a>.
    The algorithm returns once <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①⑧">Credential</a></code> is persisted to the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store⑦">credential store</a>. 
    <p><code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential①⑨">Credential</a></code>'s default implementation of <code class="idl"><a data-link-type="idl" href="#dom-credential-store-slot" id="ref-for-dom-credential-store-slot">[[Store]](credential, sameOriginWithAncestors)</a></code>:</p>
    <ol class="algorithm">
     <li data-md>
      <p>Return <code>undefined</code>.</p>
    </ol>
    <h5 class="heading settled algorithm" data-algorithm="[[Create]] internal method" data-level="2.2.1.4" id="algorithm-create-cred"><span class="secno">2.2.1.4. </span><span class="content"><code>[[Create]]</code> internal method</span><a class="self-link" href="#algorithm-create-cred"></a></h5>
     <dfn class="dfn-paneled idl-code" data-dfn-for="Credential" data-dfn-type="method" data-export id="dom-credential-create-slot"><code>[[Create]](origin, options, sameOriginWithAncestors)</code></dfn> is called <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel②">in parallel</a> with an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin③">origin</a>, a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions">CredentialCreationOptions</a></code>,
    and a boolean which is true iff the caller’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object④">environment settings object</a> is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors③">same-origin with its ancestors</a>.
    The algorithm either: 
    <ul>
     <li data-md>
      <p>creates a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential②⓪">Credential</a></code>, or</p>
     <li data-md>
      <p>does not create a credential and returns <code>null</code>, or</p>
     <li data-md>
      <p>returns an error if creation fails due to exceptional situations
  (for example, incorrect options could produce a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①">TypeError</a></code>).</p>
    </ul>
    <p>When creating a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential②①">Credential</a></code>, it will return an algorithm that takes a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global" id="ref-for-concept-settings-object-global">global object</a> and returns an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object⑥">interface object</a> inheriting from <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential②②">Credential</a></code>. This algorithm MUST be invoked from a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-task" id="ref-for-concept-task">task</a>.</p>
    <p class="note" role="note"><span>Note:</span> This algorithm’s steps are defined on a per-<a data-link-type="dfn" href="#credential-credential-type" id="ref-for-credential-credential-type①">credential type</a> basis.</p>
    <p><code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential②③">Credential</a></code>'s default implementation of <code class="idl"><a data-link-type="idl" href="#dom-credential-create-slot" id="ref-for-dom-credential-create-slot">[[Create]](origin, options, sameOriginWithAncestors)</a></code>:</p>
    <ol class="algorithm">
     <li data-md>
      <p>Return <code>null</code>.</p>
    </ol>
    <h4 class="heading settled" data-level="2.2.2" id="credentialuserdata-mixin"><span class="secno">2.2.2. </span><span class="content"><code>CredentialUserData</code> Mixin</span><a class="self-link" href="#credentialuserdata-mixin"></a></h4>
    <p>Some <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential②④">Credential</a></code> objects contain data which aims to give users a human-readable disambiguation
  mechanism in the <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser">credential chooser</a> by providing a friendly name and icon:</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext①"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <c- b>mixin</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="credentialuserdata"><code><c- g>CredentialUserData</c-></code></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString②"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name"><c- g>name</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString③"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl"><c- g>iconURL</c-></a>;
};
</pre>
    <div>
     <dl>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialUserData" data-dfn-type="attribute" data-export id="dom-credentialuserdata-name"><code>name</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString④">USVString</a>, readonly</span>
      <dd data-md>
       <p>A name associated with the credential, intended as a human-understandable public name for
  display in a <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser①">credential chooser</a>.</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialUserData" data-dfn-type="attribute" data-export id="dom-credentialuserdata-iconurl"><code>iconURL</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑤">USVString</a>, readonly</span>
      <dd data-md>
       <p>A URL pointing to an image for the credential, intended for display in a <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser②">credential chooser</a>. This URL MUST be an <a data-link-type="dfn" href="https://w3c.github.io/webappsec-mixed-content/#a-priori-authenticated-url" id="ref-for-a-priori-authenticated-url"><i lang="la">a priori</i> authenticated
  URL</a>.</p>
     </dl>
    </div>
    <h3 class="heading settled" data-level="2.3" id="framework-credential-management"><span class="secno">2.3. </span><span class="content"><code>navigator.credentials</code></span><a class="self-link" href="#framework-credential-management"></a></h3>
    <p>Developers retrieve <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential②⑤">Credential</a></code>s and interact with the user agent’s <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store⑧">credential store</a> via
  methods exposed on the <code class="idl"><a data-link-type="idl" href="#credentialscontainer" id="ref-for-credentialscontainer①">CredentialsContainer</a></code> interface, which hangs off the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/system-state.html#navigator" id="ref-for-navigator">Navigator</a></code> object as <a class="idl-code" data-link-type="attribute" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials"><code>navigator.credentials</code></a>.</p>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/system-state.html#navigator" id="ref-for-navigator①"><c- g>Navigator</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext②"><c- g>SecureContext</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#credentialscontainer" id="ref-for-credentialscontainer②"><c- n>CredentialsContainer</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CredentialsContainer" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials①"><c- g>credentials</c-></a>;
};
</pre>
    <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Navigator" data-dfn-type="attribute" data-export id="dom-navigator-credentials"><code>credentials</code></dfn> attribute MUST return the <code class="idl"><a data-link-type="idl" href="#credentialscontainer" id="ref-for-credentialscontainer③">CredentialsContainer</a></code> associated with the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object">context object</a>.</p>
    <p class="note" role="note"><span>Note:</span> As discussed in <a href="#insecure-sites">§ 6.3 Insecure Sites</a>, the credential management API is exposed only in <a data-link-type="dfn" href="https://w3c.github.io/webappsec-secure-contexts/#secure-contexts" id="ref-for-secure-contexts">Secure Contexts</a>.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①"><c- g>Exposed</c-></a>=<c- n>Window</c->, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext③"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="credentialscontainer"><code><c- g>CredentialsContainer</c-></code></dfn> {
  <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential②⑥"><c- n>Credential</c-></a>?> <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get"><c- g>get</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions②"><c- n>CredentialRequestOptions</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-credentialscontainer-get-options-options" id="ref-for-dom-credentialscontainer-get-options-options"><c- g>options</c-></a> = {});
  <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential②⑦"><c- n>Credential</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store①"><c- g>store</c-></a>(<a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential②⑧"><c- n>Credential</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-credentialscontainer-store-credential-credential" id="ref-for-dom-credentialscontainer-store-credential-credential"><c- g>credential</c-></a>);
  <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential②⑨"><c- n>Credential</c-></a>?> <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-create" id="ref-for-dom-credentialscontainer-create"><c- g>create</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions①"><c- n>CredentialCreationOptions</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-credentialscontainer-create-options-options" id="ref-for-dom-credentialscontainer-create-options-options"><c- g>options</c-></a> = {});
  <c- b>Promise</c->&lt;<c- b>void</c->> <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-preventsilentaccess" id="ref-for-dom-credentialscontainer-preventsilentaccess"><c- g>preventSilentAccess</c-></a>();
};

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-credentialdata"><code><c- g>CredentialData</c-></code></dfn> {
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑥"><c- b>USVString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="CredentialData" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-credentialdata-id"><code><c- g>id</c-></code></dfn>;
};
</pre>
    <div>
     <dl>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialsContainer" data-dfn-type="method" data-export data-lt="get(options)|get()" id="dom-credentialscontainer-get"><code>get(options)</code></dfn>
      <dd data-md>
       <p>When <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①">get()</a></code> is called, the user agent MUST return the result of
  executing <a data-link-type="abstract-op" href="#abstract-opdef-request-a-credential" id="ref-for-abstract-opdef-request-a-credential">Request a <code>Credential</code></a> on <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get-options-options" id="ref-for-dom-credentialscontainer-get-options-options①">options</a></code>.</p>
       <table class="argumentdef data">
        <caption>Arguments for the <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get②">CredentialsContainer.get(options)</a> method.</caption>
        <thead>
         <tr>
          <th>Parameter 
          <th>Type 
          <th>Nullable 
          <th>Optional 
          <th>Description 
        <tbody>
         <tr>
          <td><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialsContainer/get(options)" data-dfn-type="argument" data-export id="dom-credentialscontainer-get-options-options"><code>options</code></dfn> 
          <td> CredentialRequestOptions 
          <td> <span class="no">✘</span>
          <td> <span class="yes">✔</span>
          <td>The set of properties governing the scope of the request. 
       </table>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialsContainer" data-dfn-type="method" data-export data-lt="store(credential)|store()" id="dom-credentialscontainer-store"><code>store(credential)</code></dfn>
      <dd data-md>
       <p>When <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store②">store()</a></code> is called, the user agent MUST return the result of
  executing <a data-link-type="abstract-op" href="#abstract-opdef-store-a-credential" id="ref-for-abstract-opdef-store-a-credential">Store a <code>Credential</code></a> on <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store-credential-credential" id="ref-for-dom-credentialscontainer-store-credential-credential①">credential</a></code>.</p>
       <table class="argumentdef data">
        <caption>Arguments for the <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store③">CredentialsContainer.store(credential)</a> method.</caption>
        <thead>
         <tr>
          <th>Parameter 
          <th>Type 
          <th>Nullable 
          <th>Optional 
          <th>Description 
        <tbody>
         <tr>
          <td><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialsContainer/store(credential)" data-dfn-type="argument" data-export id="dom-credentialscontainer-store-credential-credential"><code>credential</code></dfn> 
          <td> Credential 
          <td> <span class="no">✘</span>
          <td> <span class="no">✘</span>
          <td>The credential to be stored. 
       </table>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialsContainer" data-dfn-type="method" data-export data-lt="create(options)|create()" id="dom-credentialscontainer-create"><code>create(options)</code></dfn>
      <dd data-md>
       <p>When <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-create" id="ref-for-dom-credentialscontainer-create①">create()</a></code> is called, the user agent MUST return the result of
  executing <a data-link-type="abstract-op" href="#abstract-opdef-create-a-credential" id="ref-for-abstract-opdef-create-a-credential">Create a <code>Credential</code></a> on <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-create-options-options" id="ref-for-dom-credentialscontainer-create-options-options①">options</a></code>.</p>
       <table class="argumentdef data">
        <caption>Arguments for the <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-create" id="ref-for-dom-credentialscontainer-create②">CredentialsContainer.create(options)</a> method.</caption>
        <thead>
         <tr>
          <th>Parameter 
          <th>Type 
          <th>Nullable 
          <th>Optional 
          <th>Description 
        <tbody>
         <tr>
          <td><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialsContainer/create(options)" data-dfn-type="argument" data-export id="dom-credentialscontainer-create-options-options"><code>options</code></dfn> 
          <td> CredentialCreationOptions 
          <td> <span class="no">✘</span>
          <td> <span class="yes">✔</span>
          <td>The options used to create a <code>Credential</code>. 
       </table>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialsContainer" data-dfn-type="method" data-export id="dom-credentialscontainer-preventsilentaccess"><code>preventSilentAccess()</code></dfn>
      <dd data-md>
       <p>When <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-preventsilentaccess" id="ref-for-dom-credentialscontainer-preventsilentaccess①">preventSilentAccess()</a></code> is called, the user agent MUST return
  the result of executing <a data-link-type="abstract-op" href="#abstract-opdef-prevent-silent-access" id="ref-for-abstract-opdef-prevent-silent-access">Prevent Silent Access</a> on the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object">current settings
  object</a>.</p>
       <p class="note" role="note"><span>Note:</span> The intent here is a signal from the origin that the user has signed out. That
  is, after a click on a "Sign out" button, the site updates the user’s session info, and
  calls <code>navigator.credentials.preventSilentAccess()</code>. This sets the <a data-link-type="dfn" href="#origin-prevent-silent-access-flag" id="ref-for-origin-prevent-silent-access-flag"><code>prevent silent access</code> flag</a>, meaning that credentials will not be automagically handed back to the
  page next time the user visits.</p>
       <p class="note" role="note"><span>Note:</span> This function was previously called <code>requireUserMediation()</code> which should be considered
  deprecated.</p>
     </dl>
    </div>
    <div class="algorithm" data-algorithm="create credentialscontainer"> When a <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/system-state.html#navigator" id="ref-for-navigator②">Navigator</a></code> object (<var>navigator</var>) is created, the user agent MUST create a
    new <code class="idl"><a data-link-type="idl" href="#credentialscontainer" id="ref-for-credentialscontainer④">CredentialsContainer</a></code> object, using <var>navigator</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-relevant-realm" id="ref-for-concept-relevant-realm">relevant Realm</a>, and associate it
    with <var>navigator</var>. </div>
    <h4 class="heading settled" data-level="2.3.1" id="credentialrequestoptions-dictionary"><span class="secno">2.3.1. </span><span class="content">The <code>CredentialRequestOptions</code> Dictionary</span><a class="self-link" href="#credentialrequestoptions-dictionary"></a></h4>
    <p>In order to retrieve a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③⓪">Credential</a></code> via <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get③">get()</a></code>, the caller specifies a
  few parameters in a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions③">CredentialRequestOptions</a></code> object.</p>
    <p class="note" role="note"><span>Note:</span> The <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions④">CredentialRequestOptions</a></code> dictionary is an extension point. If and when new types of
  credentials are introduced that require options, their dictionary types will be added to the
  dictionary so they can be passed into the request. See <a href="#implementation-extension">§ 7.2 Extension Points</a>.</p>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-credentialrequestoptions"><code><c- g>CredentialRequestOptions</c-></code></dfn> {
  <a class="n" data-link-type="idl-name" href="#enumdef-credentialmediationrequirement" id="ref-for-enumdef-credentialmediationrequirement"><c- n>CredentialMediationRequirement</c-></a> <a class="idl-code" data-default="&quot;optional&quot;" data-link-type="dict-member" data-type="CredentialMediationRequirement " href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation"><c- g>mediation</c-></a> = "optional";
  <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal"><c- n>AbortSignal</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="AbortSignal " href="#dom-credentialrequestoptions-signal" id="ref-for-dom-credentialrequestoptions-signal"><c- g>signal</c-></a>;
};
</pre>
    <div>
     <dl>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialRequestOptions" data-dfn-type="dict-member" data-export id="dom-credentialrequestoptions-mediation"><code>mediation</code></dfn>, <span> of type <a data-link-type="idl-name" href="#enumdef-credentialmediationrequirement" id="ref-for-enumdef-credentialmediationrequirement①">CredentialMediationRequirement</a>, defaulting to <code>"optional"</code></span>
      <dd data-md>
       <p>This property specifies the mediation requirements for a given credential request. The
  meaning of each enum value is described below in <code class="idl"><a data-link-type="idl" href="#enumdef-credentialmediationrequirement" id="ref-for-enumdef-credentialmediationrequirement②">CredentialMediationRequirement</a></code>.
  Processing details are defined in <a href="#algorithm-request">§ 2.5.1 Request a Credential</a>.</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialRequestOptions" data-dfn-type="dict-member" data-export id="dom-credentialrequestoptions-signal"><code>signal</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal①">AbortSignal</a></span>
      <dd data-md>
       <p>This property lets the developer abort an ongoing <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get④">get()</a></code> operation.
  An aborted operation may complete normally (generally if the abort was received after the
  operation finished) or reject with an "<code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#aborterror" id="ref-for-aborterror">AbortError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException">DOMException</a></code>."</p>
     </dl>
    </div>
    <div class="note" role="note">
      Earlier versions of this specification defined a boolean <code>unmediated</code> member. Setting that
    to <code>true</code> had the effect of setting <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation①">mediation</a></code> to
    "<code class="idl"><a data-link-type="idl" href="#dom-credentialmediationrequirement-silent" id="ref-for-dom-credentialmediationrequirement-silent">silent</a></code>", and setting it to <code>false</code> had the effect of
    setting <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation②">mediation</a></code> to "<code class="idl"><a data-link-type="idl" href="#dom-credentialmediationrequirement-optional" id="ref-for-dom-credentialmediationrequirement-optional">optional</a></code>". 
     <p><code>unmediated</code> should be considered deprecated; new code should instead rely on <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation③">mediation</a></code>.</p>
    </div>
    <div class="algorithm" data-algorithm="relevant credential interfaces">
      The <dfn class="dfn-paneled" data-dfn-for="CredentialRequestOptions" data-dfn-type="dfn" data-noexport id="credentialrequestoptions-relevant-credential-interface-objects">relevant credential interface objects</dfn> for a given <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions⑤">CredentialRequestOptions</a></code> (<var>options</var>) is a set of <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object⑦">interface objects</a>, collected as follows: 
     <ol class="algorithm">
      <li data-md>
       <p>Let <var>settings</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object①">current settings object</a></p>
      <li data-md>
       <p>Let <var>interface objects</var> be the set of <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object⑧">interface objects</a> on <var>settings</var>’ <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global" id="ref-for-concept-settings-object-global①">global object</a>.</p>
      <li data-md>
       <p>Let <var>relevant interface objects</var> be an empty set.</p>
      <li data-md>
       <p>For each <var>object</var> in <var>interface objects</var>:</p>
       <ol>
        <li data-md>
         <p>If <var>object</var>’s <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-inherited-interfaces" id="ref-for-dfn-inherited-interfaces">inherited interfaces</a> do not <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-contain" id="ref-for-list-contain">contain</a> <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③①">Credential</a></code>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-continue" id="ref-for-iteration-continue">continue</a>.</p>
        <li data-md>
         <p>Let <var>key</var> be <var>object</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-type-slot" id="ref-for-dom-credential-type-slot②">[[type]]</a></code> slot’s value.</p>
        <li data-md>
         <p>If <var>options</var>[<var>key</var>] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists">exists</a>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append">append</a> <var>object</var> to <var>relevant interface objects</var>.</p>
       </ol>
     </ol>
     <p class="issue" id="issue-962f77e2"><a class="self-link" href="#issue-962f77e2"></a> jyasskin@ suggests replacing the iteration through the interface objects with a registry.
    I’m not sure which is less clear, honestly. I’ll leave it like this for the moment, and we can
    argue about whether this is too much of a <code>COMEFROM</code> interface.</p>
    </div>
    <div class="algorithm" data-algorithm="can collect locally">
      A given <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions⑥">CredentialRequestOptions</a></code> <var>options</var> is <dfn class="dfn-paneled" data-dfn-for="CredentialRequestOptions" data-dfn-type="dfn" data-noexport id="credentialrequestoptions-matchable-a-priori">matchable <i lang="la">a priori</i></dfn> if the following
    steps return <code>true</code>: 
     <ol class="algorithm">
      <li data-md>
       <p>For each <var>interface</var> in <var>options</var>’ <a data-link-type="dfn" href="#credentialrequestoptions-relevant-credential-interface-objects" id="ref-for-credentialrequestoptions-relevant-credential-interface-objects">relevant credential interface objects</a>:</p>
       <ol>
        <li data-md>
         <p>If <var>interface</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-discovery-slot" id="ref-for-dom-credential-discovery-slot">[[discovery]]</a></code> slot’s value is not
  "<code class="idl"><a data-link-type="idl" href="#dom-credential-discovery-credential-store" id="ref-for-dom-credential-discovery-credential-store">credential store</a></code>", return <code>false</code>.</p>
       </ol>
      <li data-md>
       <p>Return <code>true</code>.</p>
     </ol>
     <p class="note" role="note"><span>Note:</span> When executing <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get⑤">get(options)</a></code>, we only return credentials without <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated">user mediation</a> if
    the provided <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions⑦">CredentialRequestOptions</a></code> is <a data-link-type="dfn" href="#credentialrequestoptions-matchable-a-priori" id="ref-for-credentialrequestoptions-matchable-a-priori">matchable <i lang="la">a priori</i></a>. If any
    credential types are requested that could require discovery from some external service (OAuth
    tokens, security key authenticators, etc.), then <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated①">user mediation</a> will be required in order
    to guide the discovery process (by choosing a federated identity provider, BTLE device, etc).</p>
    </div>
    <h4 class="heading settled" data-level="2.3.2" id="mediation-requirements"><span class="secno">2.3.2. </span><span class="content">Mediation Requirements</span><a class="self-link" href="#mediation-requirements"></a></h4>
    <p>When making a request via <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get⑥">get(options)</a></code>, developers can set a case-by-case requirement for <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated②">user mediation</a> by choosing the appropriate <code class="idl"><a data-link-type="idl" href="#enumdef-credentialmediationrequirement" id="ref-for-enumdef-credentialmediationrequirement③">CredentialMediationRequirement</a></code> enum value.</p>
    <p class="note" role="note"><span>Note:</span> The <a href="#user-mediation">§ 5 User Mediation</a> section gives more detail on the concept in general, and its
  implications on how the user agent deals with individual requests for a given origin).</p>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-credentialmediationrequirement"><code><c- g>CredentialMediationRequirement</c-></code></dfn> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-silent" id="ref-for-dom-credentialmediationrequirement-silent①"><c- s>"silent"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-optional" id="ref-for-dom-credentialmediationrequirement-optional①"><c- s>"optional"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-required" id="ref-for-dom-credentialmediationrequirement-required"><c- s>"required"</c-></a>
};
</pre>
    <div>
     <dl>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialMediationRequirement" data-dfn-type="enum-value" data-export data-lt="&quot;silent&quot;|silent" id="dom-credentialmediationrequirement-silent"><code>silent</code></dfn>
      <dd data-md>
       <p>User mediation is suppressed for the given operation. If the operation can be performed
  without user involvement, wonderful. If user involvement is necessary, then the operation
  will return <code>null</code> rather than involving the user.</p>
       <p class="note" role="note"><span>Note:</span> The intended usage is to support <a href="#example-mediation-silent">"Keep me signed-into this site"
  scenarios</a>, where a developer may wish to silently obtain
  credentials if a user should be automatically signed in, but to delay bothering the user
  with a sign-in prompt until they actively choose to sign-in.</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialMediationRequirement" data-dfn-type="enum-value" data-export data-lt="&quot;optional&quot;|optional" id="dom-credentialmediationrequirement-optional"><code>optional</code></dfn>
      <dd data-md>
       <p>If credentials can be handed over for a given operation without user mediation, they will
  be. If <a data-link-type="dfn" href="#origin-requires-user-mediation" id="ref-for-origin-requires-user-mediation">user mediation is required</a>, then the user agent will
  involve the user in the decision.</p>
       <p class="note" role="note"><span>Note:</span> This is the default behavior for <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get⑦">get()</a></code>, and is intended to serve a case where a
  developer has reasonable confidence that a user expects to start a sign-in operation. If
  a user has just clicked "sign-in" for example, then they won’t be surprised or confused to
  see a <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser③">credential chooser</a> if necessary.</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialMediationRequirement" data-dfn-type="enum-value" data-export data-lt="&quot;required&quot;|required" id="dom-credentialmediationrequirement-required"><code>required</code></dfn>
      <dd data-md>
       <p>The user agent will not hand over credentials without <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated③">user mediation</a>, even if the <a data-link-type="dfn" href="#origin-prevent-silent-access-flag" id="ref-for-origin-prevent-silent-access-flag①">prevent silent access flag</a> is unset for an origin.</p>
       <p class="note" role="note"><span>Note:</span> This requirement is intended to support <a href="#example-mediation-require">reauthentication</a> or <a href="#example-mediation-switch">user-switching</a> scenarios. Further, the requirement is tied
  to a specific operation, and does not affect the <a data-link-type="dfn" href="#origin-prevent-silent-access-flag" id="ref-for-origin-prevent-silent-access-flag②">prevent silent access flag</a> for the
  origin. To set that flag, developers should call <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-preventsilentaccess" id="ref-for-dom-credentialscontainer-preventsilentaccess②">preventSilentAccess()</a></code>.</p>
     </dl>
    </div>
    <h5 class="heading settled" data-level="2.3.2.1" id="mediation-examples"><span class="secno">2.3.2.1. </span><span class="content">Examples</span><a class="self-link" href="#mediation-examples"></a></h5>
    <div class="example" id="example-mediation-silent">
     <a class="self-link" href="#example-mediation-silent"></a> MegaCorp, Inc. wishes to seamlessly sign in users when possible. They can do so by calling <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get⑧">get()</a></code> for all non-signed in users at some convinient point while a landing page is loading,
    passing in a <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation④">mediation</a></code> member set to
    "<code class="idl"><a data-link-type="idl" href="#dom-credentialmediationrequirement-silent" id="ref-for-dom-credentialmediationrequirement-silent②">silent</a></code>". This ensures that users who have opted-into
    dropping the requirements for user mediation (as described in <a href="#user-mediation-requirement">§ 5.2 Requiring User Mediation</a>)
    are signed in, and users who haven’t opted-into such behavior won’t be bothered with a confusing <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser④">credential chooser</a> popping up without context: 
<pre>window.addEventListener('load', async () => {
  const credentials = await navigator.<a class="idl-code" data-link-type="attribute" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials②">credentials</a>.<a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get⑨">get</a>({
    ...,
    <a class="idl-code" data-link-type="dict-member" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation⑤">mediation</a>: '<a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-silent" id="ref-for-dom-credentialmediationrequirement-silent③">silent</a>'
  });
  if (credentials) {
    // Hooray! Let’s sign the user in using these credentials!
  }
});
</pre>
    </div>
    <div class="example" id="example-mediation-optional">
     <a class="self-link" href="#example-mediation-optional"></a> When a user clicks "Sign In", MegaCorp, Inc. wishes to give them the smoothest possible
    experience. If they have <a href="#user-mediation-requirement">opted-into</a> signing in without <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated④">user mediation</a>, and the user agent can unambigiously choose a credential, great! If
    not, a <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser⑤">credential chooser</a> will be presented. 
<pre>document.querySelector('#sign-in').addEventListener('click', async () => {
  const credentials = await navigator.<a class="idl-code" data-link-type="attribute" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials③">credentials</a>.<a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①⓪">get</a>({
    ...,
    <a class="idl-code" data-link-type="dict-member" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation⑥">mediation</a>: '<a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-optional" id="ref-for-dom-credentialmediationrequirement-optional②">optional</a>'
  });
  if (credentials) {
    // Hooray! Let’s sign the user in using these credentials!
  }
});
</pre>
     <p class="note" role="note"><span>Note:</span> MegaCorp, Inc. could also have left off the <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation⑦">mediation</a></code> member entirely, as "<code class="idl"><a data-link-type="idl" href="#dom-credentialmediationrequirement-optional" id="ref-for-dom-credentialmediationrequirement-optional③">optional</a></code>" is its default.</p>
    </div>
    <div class="example" id="example-mediation-require">
     <a class="self-link" href="#example-mediation-require"></a> MegaCorp, Inc. wishes to protect a sensitive operation by requiring a user to reauthenticate
    before taking action. Even if a user has <a href="#user-mediation-requirement">opted-into</a> signing in
    without <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated⑤">user mediation</a>, MegaCorp, Inc. can ensure that the user agent requires mediation
    by calling <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①①">get()</a></code> with a <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation⑧">mediation</a></code> member set to
    "<code class="idl"><a data-link-type="idl" href="#dom-credentialmediationrequirement-required" id="ref-for-dom-credentialmediationrequirement-required①">required</a></code>": 
     <p class="note" role="note"><span>Note:</span> Depending on the security model of the browser or the credential type, this may require
    the user to authenticate themselves in some way, perhaps by entering a master password, scanning
    a fingerprint, etc. before a credential is handed to the website.</p>
<pre>document.querySelector('#important-form').addEventListener('submit', async () => {
  const credentials = await navigator.<a class="idl-code" data-link-type="attribute" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials④">credentials</a>.<a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①②">get</a>({
    ...,
    <a class="idl-code" data-link-type="dict-member" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation⑨">mediation</a>: '<a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-required" id="ref-for-dom-credentialmediationrequirement-required②">required</a>'
  });
  if (credentials) {
    // Verify that |credentials| enables access, and cancel the submission
    // if it doesn’t.
  } else {
    e.preventDefault();
  }
});
</pre>
    </div>
    <div class="example" id="example-mediation-switch">
     <a class="self-link" href="#example-mediation-switch"></a> MegaCorp, Inc. wishes to support signing into multiple user accounts at once. In order to ensure
    that the user gets a chance to select a different credential, MegaCorp, Inc. can call <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①③">get()</a></code> with a <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation①⓪">mediation</a></code> member set to
    "<code class="idl"><a data-link-type="idl" href="#dom-credentialmediationrequirement-required" id="ref-for-dom-credentialmediationrequirement-required③">required</a></code>" in order to ensure that that credentials aren’t
    returned automatically in response to clicking on an "Add account" button: 
<pre>document.querySelector('#switch-button').addEventListener('click', e => {
  var c = await navigator.<a class="idl-code" data-link-type="attribute" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials⑤">credentials</a>.<a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①④">get</a>({
    ...,
    <a class="idl-code" data-link-type="dict-member" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation①①">mediation</a>: '<a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-required" id="ref-for-dom-credentialmediationrequirement-required④">required</a>'
  });
  if (c) {
    // Sign the user in using |c|.
  }
});
</pre>
    </div>
    <h3 class="heading settled" data-level="2.4" id="credentialcreationoptions-dictionary"><span class="secno">2.4. </span><span class="content">The <code>CredentialCreationOptions</code> Dictionary</span><a class="self-link" href="#credentialcreationoptions-dictionary"></a></h3>
    <p>In order to create a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③②">Credential</a></code> via <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-create" id="ref-for-dom-credentialscontainer-create③">create()</a></code>, the caller specifies a
  few parameters in a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions②">CredentialCreationOptions</a></code> object.</p>
    <p class="note" role="note"><span>Note:</span> The <code class="idl"><a data-link-type="idl" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions③">CredentialCreationOptions</a></code> dictionary is an extension point. If and when new types of
  credentials are introduced, they will add to the dictionary so they can be passed into the
  creation method. See <a href="#implementation-extension">§ 7.2 Extension Points</a>, and the extensions introduced in this document: <a href="#passwordcredential-interface">§ 3.2 The PasswordCredential Interface</a> and <a href="#federatedcredential-interface">§ 4.1 The FederatedCredential Interface</a>.</p>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-credentialcreationoptions"><code><c- g>CredentialCreationOptions</c-></code></dfn> {
  <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal②"><c- n>AbortSignal</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="AbortSignal " href="#dom-credentialcreationoptions-signal" id="ref-for-dom-credentialcreationoptions-signal"><c- g>signal</c-></a>;
};
</pre>
    <div>
     <dl>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="CredentialCreationOptions" data-dfn-type="dict-member" data-export id="dom-credentialcreationoptions-signal"><code>signal</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal③">AbortSignal</a></span>
      <dd data-md>
       <p>This property lets the developer abort an ongoing <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-create" id="ref-for-dom-credentialscontainer-create④">create()</a></code> operation. An aborted operation may complete normally (generally if the abort was received
  after the operation finished) or reject with an "<code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#aborterror" id="ref-for-aborterror①">AbortError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException①">DOMException</a></code>."</p>
     </dl>
    </div>
    <h3 class="heading settled" data-level="2.5" id="algorithms"><span class="secno">2.5. </span><span class="content">Algorithms</span><a class="self-link" href="#algorithms"></a></h3>
    <h4 class="heading settled algorithm" data-algorithm="Request a Credential" data-level="2.5.1" id="algorithm-request"><span class="secno">2.5.1. </span><span class="content">Request a <code>Credential</code></span><a class="self-link" href="#algorithm-request"></a></h4>
    <p>The <dfn class="dfn-paneled" data-dfn-type="abstract-op" data-export id="abstract-opdef-request-a-credential">Request a <code>Credential</code></dfn> algorithm accepts a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions⑧">CredentialRequestOptions</a></code> (<var>options</var>), and returns a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise">Promise</a></code> that resolves with a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③③">Credential</a></code> if one can be
  unambigiously obtained, or with <code>null</code> if not.</p>
    <ol class="algorithm">
     <li data-md>
      <p>Let <var>settings</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object②">current settings object</a></p>
     <li data-md>
      <p class="assertion">Assert: <var>settings</var> is a <a data-link-type="dfn" href="https://w3c.github.io/webappsec-secure-contexts/#secure-contexts" id="ref-for-secure-contexts①">secure context</a>.</p>
     <li data-md>
      <p>If <code><var>options</var>.<code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-signal" id="ref-for-dom-credentialrequestoptions-signal①">signal</a></code></code>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#abortsignal-aborted-flag" id="ref-for-abortsignal-aborted-flag">aborted flag</a> is set, then return <a data-link-type="dfn" href="https://heycam.github.io/webidl/#a-promise-rejected-with" id="ref-for-a-promise-rejected-with">a promise rejected with</a> an "<code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#aborterror" id="ref-for-aborterror②">AbortError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException②">DOMException</a></code>.</p>
     <li data-md>
      <p>Let <var>p</var> be <a data-link-type="dfn" href="https://heycam.github.io/webidl/#a-new-promise" id="ref-for-a-new-promise">a new promise</a>.</p>
     <li data-md>
      <p>Let <var>origin</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object③">current settings object</a>'s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin④">origin</a>.</p>
     <li data-md>
      <p>Let <var>sameOriginWithAncestors</var> be <code>true</code> if <var>settings</var> is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors④">same-origin with its
  ancestors</a>, and <code>false</code> otherwise.</p>
     <li data-md>
      <p>Run the following steps <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel③">in parallel</a>:</p>
      <ol>
       <li data-md>
        <p>Let <var>credentials</var> be the result of <a data-link-type="abstract-op" href="#abstract-opdef-collect-credentials-from-the-credential-store" id="ref-for-abstract-opdef-collect-credentials-from-the-credential-store">collecting <code>Credential</code>s from the credential store</a>, given <var>origin</var>, <var>options</var>, and <var>sameOriginWithAncestors</var>.</p>
       <li data-md>
        <p>If <var>credentials</var> is an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception">exception</a>, <a data-link-type="dfn" href="https://heycam.github.io/webidl/#reject" id="ref-for-reject">reject</a> <var>p</var> with <var>credentials</var>.</p>
       <li data-md>
        <p>If all of the following statements are true, resolve <var>p</var> with <var>credentials</var>[0] and
  skip the remaining steps:</p>
        <ol>
         <li data-md>
          <p><var>credentials</var>’ <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-size" id="ref-for-list-size">size</a> is 1</p>
         <li data-md>
          <p><var>origin</var> does not <a data-link-type="dfn" href="#origin-requires-user-mediation" id="ref-for-origin-requires-user-mediation①">require user mediation</a></p>
         <li data-md>
          <p><var>options</var> is <a data-link-type="dfn" href="#credentialrequestoptions-matchable-a-priori" id="ref-for-credentialrequestoptions-matchable-a-priori①">matchable <i lang="la">a priori</i></a>.</p>
         <li data-md>
          <p><var>options</var>.<code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation①②">mediation</a></code> is not
  "<code class="idl"><a data-link-type="idl" href="#dom-credentialmediationrequirement-required" id="ref-for-dom-credentialmediationrequirement-required⑤">required</a></code>".</p>
        </ol>
        <p class="issue" id="issue-e720ed3b"><a class="self-link" href="#issue-e720ed3b"></a> This might be the wrong model. It would be nice to support a site that wished
  to accept either username/passwords or webauthn-style credentials without forcing
  a chooser for those users who use the former, and who wish to remain signed in.</p>
       <li data-md>
        <p>If <var>options</var>’ <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation①③">mediation</a></code> is
  "<code class="idl"><a data-link-type="idl" href="#dom-credentialmediationrequirement-silent" id="ref-for-dom-credentialmediationrequirement-silent④">silent</a></code>", <a data-link-type="dfn">resolve</a> <var>p</var> with <code>null</code>, and skip
  the remaining steps.</p>
       <li data-md>
        <p>Let <var>choice</var> be the result of <a data-link-type="abstract-op" href="#abstract-opdef-ask-the-user-to-choose-a-credential" id="ref-for-abstract-opdef-ask-the-user-to-choose-a-credential">asking the user to
  choose a <code>Credential</code></a>, given <var>options</var> and <var>credentials</var>.</p>
       <li data-md>
        <p>If <var>choice</var> is <code>null</code> or a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③④">Credential</a></code>, <a data-link-type="dfn">resolve</a> <var>p</var> with <var>choice</var> and skip the
  remaining steps.</p>
       <li data-md>
        <p class="assertion">Assert: <var>choice</var> is an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object⑨">interface object</a>.</p>
       <li data-md>
        <p>Let <var>result</var> be the result of executing <var>choice</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-discoverfromexternalsource-slot" id="ref-for-dom-credential-discoverfromexternalsource-slot①">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</a></code>,
  given <var>origin</var>, <var>options</var>, and <var>sameOriginWithAncestors</var>.</p>
       <li data-md>
        <p>If <var>result</var> is a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③⑤">Credential</a></code> or <code>null</code>, resolve <var>p</var> with <var>result</var>.</p>
        <p>Otherwise, <a data-link-type="dfn" href="https://heycam.github.io/webidl/#reject" id="ref-for-reject①">reject</a> <var>p</var> with <var>result</var>.</p>
      </ol>
     <li data-md>
      <p>Return <var>p</var>.</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="Collect Credentials from the credential store" data-level="2.5.2" id="algorithm-collect-known"><span class="secno">2.5.2. </span><span class="content">Collect <code>Credential</code>s from the credential store</span><a class="self-link" href="#algorithm-collect-known"></a></h4>
    <p>Given an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin⑤">origin</a> (<var>origin</var>),
  a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions⑨">CredentialRequestOptions</a></code> (<var>options</var>), and a boolean which is <code>true</code> iff the calling
  context is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors⑤">same-origin with its ancestors</a> (<var>sameOriginWithAncestors</var>), the user agent may <dfn class="dfn-paneled" data-dfn-type="abstract-op" data-export data-local-lt="collect local" id="abstract-opdef-collect-credentials-from-the-credential-store">collect <code>Credential</code>s from the credential store</dfn>,
  returning a set of <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③⑥">Credential</a></code> objects stored by the user agent locally that match <var>options</var>’
  filter. If no such <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③⑦">Credential</a></code> objects are known, the returned set will be empty:</p>
    <ol class="algorithm">
     <li data-md>
      <p>Let <var>possible matches</var> be an empty set.</p>
     <li data-md>
      <p>For each <var>interface</var> in <var>options</var>’ <a data-link-type="dfn" href="#credentialrequestoptions-relevant-credential-interface-objects" id="ref-for-credentialrequestoptions-relevant-credential-interface-objects①">relevant credential interface objects</a>:</p>
      <ol>
       <li data-md>
        <p>Let <var>r</var> be the result of executing <var>interface</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-collectfromcredentialstore-slot" id="ref-for-dom-credential-collectfromcredentialstore-slot①">[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</a></code> internal method on <var>origin</var>, <var>options</var>, and <var>sameOriginWithAncestors</var>.</p>
       <li data-md>
        <p>If <var>r</var> is an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception①">exception</a>, return <var>r</var>.</p>
       <li data-md>
        <p class="assertion">Assert: <var>r</var> is a list of <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①⓪">interface objects</a>.</p>
       <li data-md>
        <p>For each <var>c</var> in <var>r</var>:</p>
        <ol>
         <li data-md>
          <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append①">Append</a> <var>c</var> to <var>possible matches</var>.</p>
        </ol>
      </ol>
     <li data-md>
      <p>Return <var>possible matches</var>.</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="Store a Credential" data-level="2.5.3" id="algorithm-store"><span class="secno">2.5.3. </span><span class="content">Store a <code>Credential</code></span><a class="self-link" href="#algorithm-store"></a></h4>
    <p>The <dfn class="dfn-paneled" data-dfn-type="abstract-op" data-export id="abstract-opdef-store-a-credential">Store a <code>Credential</code></dfn> algorithm accepts a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③⑧">Credential</a></code> (<var>credential</var>), and returns a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise①">Promise</a></code> which resolves once the object is persisted to the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store⑨">credential store</a>.</p>
    <ol class="algorithm">
     <li data-md>
      <p>Let <var>settings</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object④">current settings object</a></p>
     <li data-md>
      <p class="assertion">Assert: <var>settings</var> is a <a data-link-type="dfn" href="https://w3c.github.io/webappsec-secure-contexts/#secure-contexts" id="ref-for-secure-contexts②">secure context</a>.</p>
     <li data-md>
      <p>Let <var>sameOriginWithAncestors</var> be <code>true</code> if the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object⑤">current settings object</a> is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors⑥">same-origin
  with its ancestors</a>, and <code>false</code> otherwise.</p>
     <li data-md>
      <p>Let <var>p</var> be <a data-link-type="dfn" href="https://heycam.github.io/webidl/#a-new-promise" id="ref-for-a-new-promise①">a new promise</a>.</p>
     <li data-md>
      <p>Run the following steps <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel④">in parallel</a>:</p>
      <ol>
       <li data-md>
        <p>Let <var>r</var> be the result of executing <var>credential</var>’s <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①①">interface object</a>'s <code class="idl"><a data-link-type="idl" href="#dom-credential-store-slot" id="ref-for-dom-credential-store-slot①">[[Store]](credential, sameOriginWithAncestors)</a></code> internal method on <var>credential</var> and <var>sameOriginWithAncestors</var>.</p>
       <li data-md>
        <p>If <var>r</var> is an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception②">exception</a>, <a data-link-type="dfn" href="https://heycam.github.io/webidl/#reject" id="ref-for-reject②">reject</a> <var>p</var> with <var>r</var>.</p>
        <p>Otherwise, <a data-link-type="dfn">resolve</a> <var>p</var> with <var>r</var>.</p>
      </ol>
     <li data-md>
      <p>Return <var>p</var>.</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="Create a Credential" data-level="2.5.4" id="algorithm-create"><span class="secno">2.5.4. </span><span class="content">Create a <code>Credential</code></span><a class="self-link" href="#algorithm-create"></a></h4>
    <p>The <dfn class="dfn-paneled" data-dfn-type="abstract-op" data-export id="abstract-opdef-create-a-credential">Create a <code>Credential</code></dfn> algorithm accepts a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions④">CredentialCreationOptions</a></code> (<var>options</var>), and returns a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise②">Promise</a></code> which resolves with a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential③⑨">Credential</a></code> if one can be created
  using the options provided, or <code>null</code> if no <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential④⓪">Credential</a></code> can be created. In exceptional
  circumstances, the <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise③">Promise</a></code> may reject with an appropriate exception:</p>
    <ol class="algorithm">
     <li data-md>
      <p>Let <var>settings</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object⑥">current settings object</a>.</p>
     <li data-md>
      <p class="assertion">Assert: <var>settings</var> is a <a data-link-type="dfn" href="https://w3c.github.io/webappsec-secure-contexts/#secure-contexts" id="ref-for-secure-contexts③">secure context</a>.</p>
     <li data-md>
      <p>Let <var>global</var> be <var>settings</var>’ <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global" id="ref-for-concept-settings-object-global②">global object</a>.</p>
     <li data-md>
      <p>Let <var>sameOriginWithAncestors</var> be <code>true</code> if the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object⑦">current settings object</a> is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors⑦">same-origin
  with its ancestors</a>, and <code>false</code> otherwise.</p>
     <li data-md>
      <p>Let <var>interfaces</var> be the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-set" id="ref-for-ordered-set">set</a> of <var>options</var>’ <a data-link-type="dfn" href="#credentialrequestoptions-relevant-credential-interface-objects" id="ref-for-credentialrequestoptions-relevant-credential-interface-objects②">relevant credential interface objects</a>.</p>
     <li data-md>
      <p>Return <a data-link-type="dfn" href="https://heycam.github.io/webidl/#a-promise-rejected-with" id="ref-for-a-promise-rejected-with①">a promise rejected with</a> <code>NotSupportedError</code> if any of the following statements
  are true:</p>
      <ol>
       <li data-md>
        <p><var>settings</var> does not have a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-document" id="ref-for-responsible-document">responsible document</a>.</p>
       <li data-md>
        <p><var>interfaces</var>’ <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-size" id="ref-for-list-size①">size</a> is greater than 1.</p>
        <p class="note" role="note"><span>Note:</span> It may be reasonable at some point in the future to loosen this restriction, and
  allow the user agent to help the user choose among one of many potential credential
  types in order to support a "sign-up" use case. For the moment, though, we’re punting
  on that by restricting the dictionary to a single entry.</p>
      </ol>
     <li data-md>
      <p>If <code><var>options</var>.<code class="idl"><a data-link-type="idl" href="#dom-credentialcreationoptions-signal" id="ref-for-dom-credentialcreationoptions-signal①">signal</a></code></code>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#abortsignal-aborted-flag" id="ref-for-abortsignal-aborted-flag①">aborted
  flag</a> is set, then return <a data-link-type="dfn" href="https://heycam.github.io/webidl/#a-promise-rejected-with" id="ref-for-a-promise-rejected-with②">a promise rejected with</a> an "<code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#aborterror" id="ref-for-aborterror③">AbortError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException③">DOMException</a></code>.</p>
     <li data-md>
      <p>Let <var>p</var> be <a data-link-type="dfn" href="https://heycam.github.io/webidl/#a-new-promise" id="ref-for-a-new-promise②">a new promise</a>.</p>
     <li data-md>
      <p>Let <var>origin</var> be <var>settings</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin⑥">origin</a>.</p>
     <li data-md>
      <p>Run the following steps <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel⑤">in parallel</a>:</p>
      <ol>
       <li data-md>
        <p>Let <var>r</var> be the result of executing <var>interfaces</var>[0]'s <code class="idl"><a data-link-type="idl" href="#dom-credential-create-slot" id="ref-for-dom-credential-create-slot①">[[Create]](origin, options, sameOriginWithAncestors)</a></code> internal method on <var>origin</var>, <var>options</var>, and <var>sameOriginWithAncestors</var>.</p>
       <li data-md>
        <p>If <var>r</var> is an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception③">exception</a>, <a data-link-type="dfn" href="https://heycam.github.io/webidl/#reject" id="ref-for-reject③">reject</a> <var>p</var> with <var>r</var>, and terminate these substeps.</p>
       <li data-md>
        <p>If <var>r</var> is a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential④①">Credential</a></code> or <code>null</code>, <a data-link-type="dfn">resolve</a> <var>p</var> with <var>r</var>, and terminate these substeps.</p>
       <li data-md>
        <p class="assertion">Assert: <var>r</var> is a algorithm (as defined in <a href="#algorithm-create-cred">§ 2.2.1.4 [[Create]] internal method</a>).</p>
       <li data-md>
        <p><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#queue-a-task" id="ref-for-queue-a-task">Queue a task</a> on <var>global</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#dom-manipulation-task-source" id="ref-for-dom-manipulation-task-source">DOM manipulation task source</a> to run the following substeps:</p>
        <ol>
         <li data-md>
          <p><a data-link-type="dfn">Resolve</a> <var>p</var> with the result of <a data-link-type="dfn">promise-calling</a> <var>r</var> given <var>global</var>.</p>
        </ol>
      </ol>
     <li data-md>
      <p>Return <var>p</var>.</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="Prevent Silent Access" data-level="2.5.5" id="algorithm-prevent-silent-access"><span class="secno">2.5.5. </span><span class="content">Prevent Silent Access</span><a class="self-link" href="#algorithm-prevent-silent-access"></a></h4>
    <p>The <dfn class="dfn-paneled" data-dfn-type="abstract-op" data-export id="abstract-opdef-prevent-silent-access">Prevent Silent Access</dfn> algorithm accepts an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object⑤">environment settings
  object</a> (<var>settings</var>), and returns a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise④">Promise</a></code> which resolves once the <code>prevent silent access</code> flag is persisted to the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①⓪">credential store</a>.</p>
    <ol class="algorithm">
     <li data-md>
      <p>Let <var>origin</var> be <var>settings</var>’ <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin⑦">origin</a>.</p>
     <li data-md>
      <p>Let <var>p</var> be <a data-link-type="dfn" href="https://heycam.github.io/webidl/#a-new-promise" id="ref-for-a-new-promise③">a new promise</a></p>
     <li data-md>
      <p>Run the following seps <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel⑥">in parallel</a>:</p>
      <ol>
       <li data-md>
        <p>Set <var>origin</var>’s <a data-link-type="dfn" href="#origin-prevent-silent-access-flag" id="ref-for-origin-prevent-silent-access-flag③"><code>prevent silent access</code> flag</a> in the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①①">credential store</a>.</p>
       <li data-md>
        <p><a data-link-type="dfn">Resolve</a> <var>p</var> with <code>undefined</code>.</p>
      </ol>
     <li data-md>
      <p>Retun <var>p</var>.</p>
    </ol>
   </section>
   <section>
    <h2 class="heading settled" data-level="3" id="passwords"><span class="secno">3. </span><span class="content">Password Credentials</span><a class="self-link" href="#passwords"></a></h2>
    <p>For good or for ill, many websites rely on username/password pairs as an authentication mechanism.
  The <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①">PasswordCredential</a></code> interface is a <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①⑥">credential</a> meant to enable this use case, storing
  both a username and password, as well as metadata that can help a user choose the right account
  from within a <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser⑥">credential chooser</a>.</p>
    <h3 class="heading settled" data-level="3.1" id="password-examples"><span class="secno">3.1. </span><span class="content">Examples</span><a class="self-link" href="#password-examples"></a></h3>
    <h4 class="heading settled" data-level="3.1.1" id="examples-password-signin"><span class="secno">3.1.1. </span><span class="content">Password-based Sign-in</span><a class="self-link" href="#examples-password-signin"></a></h4>
    <div class="example" id="example-1e3287d5">
     <a class="self-link" href="#example-1e3287d5"></a> MegaCorp, Inc. supports passwords, and can use <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①⑤">navigator.credentials.get()</a></code> to obtain
    username/password pairs from a user’s <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①②">credential store</a>: 
<pre>navigator.<a class="idl-code" data-link-type="attribute" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials⑥">credentials</a>
  .<a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①⑥">get</a>({ '<a class="idl-code" data-link-type="dict-member" href="#dom-credentialrequestoptions-password" id="ref-for-dom-credentialrequestoptions-password">password</a>': true })
  .then(credential => {
    if (!credential) {
      // The user either doesn’t have credentials for this site, or
      // refused to share them. Insert some code here to fall back to
      // a basic login form.
      return;
    }
    if (credential.<a class="idl-code" data-link-type="attribute" href="#dom-credential-type" id="ref-for-dom-credential-type①">type</a> == '<a class="idl-code" data-link-type="const" href="#dom-credential-type-password" id="ref-for-dom-credential-type-password">password</a>') {
      var form = new FormData();
      form.append('username_field', credential.id);
      form.append('password_field', credential.password);
      var opt = {
        method: 'POST',
        body: form,
        credentials: 'include'  // Send cookies.
      };
      fetch('https://example.com/loginEndpoint', opt)
        .then(function (response) {
          if (/* |response| indicates a successful login */) {
            // Record that the credential was effective. See note below.
            navigator.<a class="idl-code" data-link-type="attribute" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials⑦">credentials</a>.<a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store④">store</a>(credential);
            // Notify the user that sign-in succeeded! Do amazing, signed-in things!
            // Maybe navigate to a landing page via location.href =
            // '/signed-in-experience'?
          } else {
            // Insert some code here to fall back to a basic login form.
          }
        });
    }
  });
</pre>
     <p>Alternatively, the website could just copy the credential data into a <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/forms.html#the-form-element" id="ref-for-the-form-element">form</a></code> and call <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/forms.html#dom-form-submit" id="ref-for-dom-form-submit">submit()</a></code> on the form:</p>
<pre>navigator.<a class="idl-code" data-link-type="attribute" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials⑧">credentials</a>
  .<a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①⑦">get</a>({ '<a class="idl-code" data-link-type="dict-member" href="#dom-credentialrequestoptions-password" id="ref-for-dom-credentialrequestoptions-password①">password</a>': true })
  .then(credential => {
    if (!credential) {
      return; // as above...
    }
    if (credential.<a class="idl-code" data-link-type="attribute" href="#dom-credential-type" id="ref-for-dom-credential-type②">type</a> === '<a class="idl-code" data-link-type="const" href="#password-literal">password</a>') {
      document.querySelector('input[name=username_field]').value =
        credential.id;
      document.querySelector('input[name=password_field]').value =
        credential.password;
      document.getElementById('myform').submit();
    }
  });
</pre>
     <p>Note that the former method is much preferred, as it contains an explicit call
    to <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store⑤">store()</a></code> and saves the credentials. The <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/forms.html#the-form-element" id="ref-for-the-form-element①">form</a></code> based mechanism
    relies on form submission, which navigates the browsing context, making it difficult to
    ensure that <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store⑥">store()</a></code> is called after successful sign-in.</p>
    </div>
    <p class="note" role="note"><span>Note:</span> The <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser⑦">credential chooser</a> presented by the user agent could allow the user to choose
  credentials that aren’t actually stored for the current origin. For instance, it might offer up
  credentials from <code>https://m.example.com</code> when signing into <code>https://www.example.com</code> (as
  described in <a href="#security-credential-access">§ 6.1 Cross-domain credential access</a>), or it might allow a user to create a new
  credential on the fly. Developers can deal gracefully with this uncertainty by calling <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store⑦">store()</a></code> every time credentials are successfully used, even right after
  credentials have been retrieved from <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①⑧">get()</a></code>: if the credentials aren’t
  yet stored for the origin, the user will be given the opportunity to do so. If they are stored,
  the user won’t be prompted.</p>
    <h4 class="heading settled" data-level="3.1.2" id="examples-post-signin"><span class="secno">3.1.2. </span><span class="content">Post-sign-in Confirmation</span><a class="self-link" href="#examples-post-signin"></a></h4>
    <p>To ensure that users are offered to store new credentials after a successful sign-in, they can
  to be passed to <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store⑧">store()</a></code>.</p>
    <div class="example" id="example-c7eaa6aa">
     <a class="self-link" href="#example-c7eaa6aa"></a> If a user is signed in by submitting the credentials to a sign-in endpoint via <code class="idl"><a data-link-type="idl" href="https://fetch.spec.whatwg.org/#dom-global-fetch" id="ref-for-dom-global-fetch">fetch()</a></code>,
    we can check the response to determine whether the user
    was signed in successfully, and notify the user agent accordingly. Given a sign-in form like the
    following: 
<pre>&lt;form action="https://example.com/login" method="POST" id="theForm">
  &lt;label for="username">Username&lt;/label>
  &lt;input type="text" id="username" name="username" <a data-link-type="element-attr" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete" id="ref-for-attr-fe-autocomplete①">autocomplete</a>="<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-username" id="ref-for-attr-fe-autocomplete-username">username</a>">
  &lt;label for="password">Password&lt;/label>
  &lt;input type="password" id="password" name="password" <a data-link-type="element-attr" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete" id="ref-for-attr-fe-autocomplete②">autocomplete</a>="<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-current-password" id="ref-for-attr-fe-autocomplete-current-password">current-password</a>">
  &lt;input type="submit">
&lt;/form>
</pre>
     <p>Then the developer can handle the form submission with something like the following handler:</p>
<pre>document.querySelector('#theForm').addEventListener('submit', e => {
    if (<a class="idl-code" data-link-type="interface" href="#passwordcredential" id="ref-for-passwordcredential②">window.PasswordCredential</a>) {
      e.preventDefault();

      // Construct a new <a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential③">PasswordCredential</a> from the <a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement">HTMLFormElement</a>
      // that fired the "submit" event: this will suck up the values of the fields
      // labeled with "username" and "current-password" <a data-link-type="element-attr" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete" id="ref-for-attr-fe-autocomplete③">autocomplete</a>
      // attributes:
      var c = new <a data-link-type="idl" href="#dom-passwordcredential-passwordcredential" id="ref-for-dom-passwordcredential-passwordcredential">PasswordCredential</a>(e.target);

      // Fetch the form’s action URL, passing that new credential object in
      // as a FormData object. If the response indicates success, tell the user agent
      // so it can ask the user to store the password for future use:
      var opt = {
        method: 'POST',
        body: new FormData(e.target),
        credentials: 'include'  // Send cookies.
      };
      fetch(e.target.action, opt).then(r => {
        if (/* |r| is a "successful" <a data-link-type="idl" href="https://fetch.spec.whatwg.org/#response" id="ref-for-response">Response</a> */)
          <a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store⑨">navigator.credentials.store</a>(c);
      });
    }
});
</pre>
    </div>
    <h4 class="heading settled" data-level="3.1.3" id="examples-change-password"><span class="secno">3.1.3. </span><span class="content">Change Password</span><a class="self-link" href="#examples-change-password"></a></h4>
    <p>This same storage mechanism can be reused for "password change" with no modifications: if the
  user changes their credentials, the website can notify the user agent that they’ve successfully
  signed in with new credentials. The user agent can then update the credentials it stores:</p>
    <div class="example" id="example-640da6a4">
     <a class="self-link" href="#example-640da6a4"></a> MegaCorp Inc. allows users to change their passwords by POSTing data to
    a backend server asynchronously. After doing so successfully, they can
    update the user’s credentials by calling <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store①⓪">store()</a></code> with the new information. 
     <p>Given a password change form like the following:</p>
<pre>&lt;form action="https://example.com/changePassword" method="POST" id="theForm">
  &lt;input type="hidden" name="username" <a data-link-type="element-attr" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete" id="ref-for-attr-fe-autocomplete④">autocomplete</a>="<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-username" id="ref-for-attr-fe-autocomplete-username①">username</a>" value="user">
  &lt;label for="password">New Password&lt;/label>
  &lt;input type="password" id="password" name="password" <a data-link-type="element-attr" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete" id="ref-for-attr-fe-autocomplete⑤">autocomplete</a>="<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-new-password" id="ref-for-attr-fe-autocomplete-new-password">new-password</a>">
  &lt;input type="submit">
&lt;/form>
</pre>
     <p>The developer can handle the form submission with something like the following:</p>
<pre>document.querySelector('#theForm').addEventListener('submit', e => {
  if (<a class="idl-code" data-link-type="interface" href="#passwordcredential" id="ref-for-passwordcredential④">window.PasswordCredential</a>) {
    e.preventDefault();

    // Construct a new <a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential⑤">PasswordCredential</a> from the <a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement①">HTMLFormElement</a>
    // that fired the "submit" event: this will suck up the values of the fields
    // labeled with "username" and "new-password" <a data-link-type="element-attr" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete" id="ref-for-attr-fe-autocomplete⑥">autocomplete</a>
    // attributes:
    var c = new <a data-link-type="idl" href="#dom-passwordcredential-passwordcredential" id="ref-for-dom-passwordcredential-passwordcredential①">PasswordCredential</a>(e.target);

    // Fetch the form’s action URL, passing that new credential object in
    // as a FormData object. If the response indicates success, tell the user agent
    // so it can ask the user to store the password for future use:
    var opt = {
      method: 'POST',
      body: new FormData(e.target),
      credentials: 'include'  // Send cookies.
    };
    fetch(e.target.action, opt).then(r => {
      if (/* |r| is a "successful" <a data-link-type="idl" href="https://fetch.spec.whatwg.org/#response" id="ref-for-response①">Response</a> */)
        <a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store①①">navigator.credentials.store</a>(c);
    });
  }
});
</pre>
    </div>
    <h3 class="heading settled" data-level="3.2" id="passwordcredential-interface"><span class="secno">3.2. </span><span class="content">The <code>PasswordCredential</code> Interface</span><a class="self-link" href="#passwordcredential-interface"></a></h3>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②"><c- g>Exposed</c-></a>=<c- n>Window</c->,
 <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext④"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="passwordcredential"><code><c- g>PasswordCredential</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential④②"><c- n>Credential</c-></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-passwordcredential-passwordcredential" id="ref-for-dom-passwordcredential-passwordcredential②"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement②"><c- n>HTMLFormElement</c-></a> <dfn class="idl-code" data-dfn-for="PasswordCredential/constructor(form)" data-dfn-type="argument" data-export id="dom-passwordcredential-constructor-form-form"><code><c- g>form</c-></code><a class="self-link" href="#dom-passwordcredential-constructor-form-form"></a></dfn>);
  <a class="idl-code" data-link-type="constructor" href="#dom-passwordcredential-passwordcredential-data" id="ref-for-dom-passwordcredential-passwordcredential-data"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata"><c- n>PasswordCredentialData</c-></a> <dfn class="idl-code" data-dfn-for="PasswordCredential/constructor(data)" data-dfn-type="argument" data-export id="dom-passwordcredential-constructor-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-passwordcredential-constructor-data-data"></a></dfn>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑦"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-passwordcredential-password" id="ref-for-dom-passwordcredential-password"><c- g>password</c-></a>;
};
<a class="n" data-link-type="idl-name" href="#passwordcredential" id="ref-for-passwordcredential⑥"><c- n>PasswordCredential</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#credentialuserdata" id="ref-for-credentialuserdata"><c- n>CredentialUserData</c-></a>;

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①⓪"><c- g>CredentialRequestOptions</c-></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean"><c- b>boolean</c-></a> <dfn class="dfn-paneled idl-code" data-default="false" data-dfn-for="CredentialRequestOptions" data-dfn-type="dict-member" data-export data-type="boolean " id="dom-credentialrequestoptions-password"><code><c- g>password</c-></code></dfn> = <c- b>false</c->;
};
</pre>
    <div>
     <dl>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredential" data-dfn-type="attribute" data-export id="dom-passwordcredential-password"><code>password</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑧">USVString</a>, readonly</span>
      <dd data-md>
       <p>This attribute represents the password of the credential.</p>
      <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-type-slot" id="ref-for-dom-credential-type-slot③">[[type]]</a></code>
      <dd data-md>
       <p>The <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential⑦">PasswordCredential</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①②">interface object</a> has an internal slot named <code>[[type]]</code> whose
  value is "<dfn class="dfn-paneled idl-code" data-dfn-for="Credential/[[type]]" data-dfn-type="const" data-export id="dom-credential-type-password"><code>password</code></dfn>".</p>
      <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-discovery-slot" id="ref-for-dom-credential-discovery-slot①">[[discovery]]</a></code>
      <dd data-md>
       <p>The <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential⑧">PasswordCredential</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①③">interface object</a> has an internal slot named <code>[[discovery]]</code> whose value is "<code class="idl"><a data-link-type="idl" href="#dom-credential-discovery-credential-store" id="ref-for-dom-credential-discovery-credential-store①">credential store</a></code>".</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredential" data-dfn-type="constructor" data-export data-lt="PasswordCredential(form)|constructor(form)" id="dom-passwordcredential-passwordcredential"><code>PasswordCredential(form)</code></dfn>
      <dd data-md>
       <p>This constructor accepts an <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement③">HTMLFormElement</a></code> (<var>form</var>), and runs the following steps:</p>
       <ol>
        <li data-md>
         <p>Let <var>origin</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object⑧">current settings object</a>'s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin⑧">origin</a>.</p>
        <li data-md>
         <p>Let <var>r</var> be the result of executing <a data-link-type="abstract-op" href="#abstract-opdef-create-a-passwordcredential-from-an-htmlformelement" id="ref-for-abstract-opdef-create-a-passwordcredential-from-an-htmlformelement">Create a <code>PasswordCredential</code> from
  an <code>HTMLFormElement</code></a> given <var>form</var> and <var>origin</var>.</p>
        <li data-md>
         <p>If <var>r</var> is an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception④">exception</a>, <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw">throw</a> <var>r</var>.</p>
         <p>Otherwise, return <var>r</var>.</p>
       </ol>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredential" data-dfn-type="constructor" data-export data-lt="PasswordCredential(data)|constructor(data)" id="dom-passwordcredential-passwordcredential-data"><code>PasswordCredential(data)</code></dfn>
      <dd data-md>
       <p>This constructor accepts a <code class="idl"><a data-link-type="idl" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata①">PasswordCredentialData</a></code> (<var>data</var>), and runs the following steps:</p>
       <ol>
        <li data-md>
         <p>Let <var>r</var> be the result of executing <a data-link-type="abstract-op" href="#abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata" id="ref-for-abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata">Create a <code>PasswordCredential</code> from <code>PasswordCredentialData</code></a> on <var>data</var>.</p>
        <li data-md>
         <p>If <var>r</var> is an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception⑤">exception</a>, <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①">throw</a> <var>r</var>.</p>
         <p>Otherwise, return <var>r</var>.</p>
       </ol>
     </dl>
    </div>
    <p><code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential⑨">PasswordCredential</a></code> objects can be created via <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-create" id="ref-for-dom-credentialscontainer-create⑤">navigator.credentials.create()</a></code> either explicitly by passing in a <code class="idl"><a data-link-type="idl" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata②">PasswordCredentialData</a></code> dictionary, or based on the contents
  of an <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement④">HTMLFormElement</a></code>'s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/forms.html#category-submit" id="ref-for-category-submit">submittable elements</a>.</p>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-passwordcredentialdata"><code><c- g>PasswordCredentialData</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#dictdef-credentialdata" id="ref-for-dictdef-credentialdata"><c- n>CredentialData</c-></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑨"><c- b>USVString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredentialData" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-passwordcredentialdata-name"><code><c- g>name</c-></code></dfn>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⓪"><c- b>USVString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredentialData" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-passwordcredentialdata-iconurl"><code><c- g>iconURL</c-></code></dfn>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①①"><c- b>USVString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredentialData" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-passwordcredentialdata-origin"><code><c- g>origin</c-></code></dfn>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①②"><c- b>USVString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredentialData" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-passwordcredentialdata-password"><code><c- g>password</c-></code></dfn>;
};

<c- b>typedef</c-> (<a class="n" data-link-type="idl-name" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata③"><c- n>PasswordCredentialData</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement⑤"><c- n>HTMLFormElement</c-></a>) <dfn class="dfn-paneled idl-code" data-dfn-type="typedef" data-export id="typedefdef-passwordcredentialinit"><code><c- g>PasswordCredentialInit</c-></code></dfn>;

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions⑤"><c- g>CredentialCreationOptions</c-></a> {
  <a class="n" data-link-type="idl-name" href="#typedefdef-passwordcredentialinit" id="ref-for-typedefdef-passwordcredentialinit"><c- n>PasswordCredentialInit</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="CredentialCreationOptions" data-dfn-type="dict-member" data-export data-type="PasswordCredentialInit " id="dom-credentialcreationoptions-password"><code><c- g>password</c-></code></dfn>;
};
</pre>
    <p><code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①⓪">PasswordCredential</a></code> objects are <a data-link-type="dfn" href="#credential-origin-bound" id="ref-for-credential-origin-bound">origin bound</a>.</p>
    <p><code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①①">PasswordCredential</a></code>'s <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①④">interface object</a> inherits <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential④③">Credential</a></code>'s implementation of <code class="idl"><a data-link-type="idl" href="#dom-credential-discoverfromexternalsource-slot" id="ref-for-dom-credential-discoverfromexternalsource-slot②">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</a></code>, and defines
  its own implementation of <code class="idl"><a data-link-type="idl" href="#dom-passwordcredential-collectfromcredentialstore-slot" id="ref-for-dom-passwordcredential-collectfromcredentialstore-slot">[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-passwordcredential-create-slot" id="ref-for-dom-passwordcredential-create-slot">[[Create]](origin, options, sameOriginWithAncestors)</a></code>, and <code class="idl"><a data-link-type="idl" href="#dom-passwordcredential-store-slot" id="ref-for-dom-passwordcredential-store-slot">[[Store]](credential, sameOriginWithAncestors)</a></code>.</p>
    <h3 class="heading settled" data-level="3.3" id="passwordcredential-algorithms"><span class="secno">3.3. </span><span class="content">Algorithms</span><a class="self-link" href="#passwordcredential-algorithms"></a></h3>
    <h4 class="heading settled algorithm" data-algorithm="PasswordCredential&apos;s [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)" data-level="3.3.1" id="collectfromcredentialstore-passwordcredential"><span class="secno">3.3.1. </span><span class="content"> <code>PasswordCredential</code>'s <code>[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</code> </span><a class="self-link" href="#collectfromcredentialstore-passwordcredential"></a></h4>
    <p><dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredential" data-dfn-type="method" data-export id="dom-passwordcredential-collectfromcredentialstore-slot"><code>[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</code></dfn> is called with an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin④">origin</a> (<var>origin</var>), a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①①">CredentialRequestOptions</a></code> (<var>options</var>),
  and a boolean which is <code>true</code> iff the calling context is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors⑧">same-origin with its ancestors</a> (<var>sameOriginWithAncestors</var>).
  The algorithm returns a set of <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential④④">Credential</a></code> objects from
  the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①③">credential store</a>. If no matching <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential④⑤">Credential</a></code> objects are available, the returned set
  will be empty.</p>
    <p>The algorithm will return a <code>NotAllowedError</code> if <var>sameOriginWithAncestors</var> is not <code>true</code>.</p>
    <ol class="algorithm">
     <li data-md>
      <p class="assertion">Assert: <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-password" id="ref-for-dom-credentialrequestoptions-password②">password</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①">exists</a>.</p>
     <li data-md>
      <p>If |sameOriginWithAncestors is <code>false</code>, return a "<code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#notallowederror" id="ref-for-notallowederror">NotAllowedError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException④">DOMException</a></code>.</p>
      <p class="note" role="note"><span>Note:</span> This restriction aims to address the concern raised in <a href="#security-origin-confusion">§ 6.4 Origin Confusion</a>.</p>
     <li data-md>
      <p>Return the empty set if <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-password" id="ref-for-dom-credentialrequestoptions-password③">password</a></code>"] is not <code>true</code>.</p>
     <li data-md>
      <p>Return the result of <a data-link-type="abstract-op" href="#abstract-opdef-credential-store-retrieve-a-list-of-credentials" id="ref-for-abstract-opdef-credential-store-retrieve-a-list-of-credentials">retrieving</a> credentials from the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①④">credential store</a> that match the following filter:</p>
      <ol>
       <li data-md>
        <p>The credential is a <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①②">PasswordCredential</a></code></p>
       <li data-md>
        <p>The credential’s <code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot">[[origin]]</a></code> is the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin①">same origin</a> as <var>origin</var>.</p>
      </ol>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="PasswordCredential&apos;s [[Create]](origin, options, sameOriginWithAncestors)" data-level="3.3.2" id="create-passwordcredential"><span class="secno">3.3.2. </span><span class="content"> <code>PasswordCredential</code>'s <code>[[Create]](origin, options, sameOriginWithAncestors)</code> </span><a class="self-link" href="#create-passwordcredential"></a></h4>
    <p><dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredential" data-dfn-type="method" data-export id="dom-passwordcredential-create-slot"><code>[[Create]](origin, options, sameOriginWithAncestors)</code></dfn> is called with an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin⑤">origin</a> (<var>origin</var>), a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions⑥">CredentialCreationOptions</a></code> (<var>options</var>), and a boolean which is <code>true</code> iff the calling
  context is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors⑨">same-origin with its ancestors</a> (<var>sameOriginWithAncestors</var>).
  The algorithm returns a <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①③">PasswordCredential</a></code> if one can be created, <code>null</code> otherwise. The <code class="idl"><a data-link-type="idl" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions⑦">CredentialCreationOptions</a></code> dictionary must have a <code>password</code> member which
  holds either an <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement⑥">HTMLFormElement</a></code> or a <code class="idl"><a data-link-type="idl" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata④">PasswordCredentialData</a></code>. If that member’s value cannot be
  used to create a <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①④">PasswordCredential</a></code>, this algorithm will return a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②">TypeError</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception⑥">exception</a>.</p>
    <ol class="algorithm">
     <li data-md>
      <p class="assertion">Assert: <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialcreationoptions-password" id="ref-for-dom-credentialcreationoptions-password">password</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists②">exists</a>, and <var>sameOriginWithAncestors</var> is unused.</p>
     <li data-md>
      <p>If <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialcreationoptions-password" id="ref-for-dom-credentialcreationoptions-password①">password</a></code>"] is an <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement⑦">HTMLFormElement</a></code>, return the
  result of executing <a data-link-type="abstract-op" href="#abstract-opdef-create-a-passwordcredential-from-an-htmlformelement" id="ref-for-abstract-opdef-create-a-passwordcredential-from-an-htmlformelement①">Create a <code>PasswordCredential</code> from an <code>HTMLFormElement</code></a> given <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialcreationoptions-password" id="ref-for-dom-credentialcreationoptions-password②">password</a></code>"] and <var>origin</var>.</p>
     <li data-md>
      <p>If <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialcreationoptions-password" id="ref-for-dom-credentialcreationoptions-password③">password</a></code>"] is a <code class="idl"><a data-link-type="idl" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata⑤">PasswordCredentialData</a></code>, return
  the result of executing <a data-link-type="abstract-op" href="#abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata" id="ref-for-abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata①">Create a <code>PasswordCredential</code> from <code>PasswordCredentialData</code></a> given <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialcreationoptions-password" id="ref-for-dom-credentialcreationoptions-password④">password</a></code>"].</p>
     <li data-md>
      <p>Return a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror③">TypeError</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception⑦">exception</a>.</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="PasswordCredential&apos;s [[Store]](credential, sameOriginWithAncestors)" data-level="3.3.3" id="store-passwordcredential"><span class="secno">3.3.3. </span><span class="content"> <code>PasswordCredential</code>'s <code>[[Store]](credential, sameOriginWithAncestors)</code> </span><a class="self-link" href="#store-passwordcredential"></a></h4>
    <p><dfn class="dfn-paneled idl-code" data-dfn-for="PasswordCredential" data-dfn-type="method" data-export id="dom-passwordcredential-store-slot"><code>[[Store]](credential, sameOriginWithAncestors)</code></dfn> is
  called with a <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①⑤">PasswordCredential</a></code> (<var>credential</var>), and a boolean which is <code>true</code> iff the calling
  context is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors①⓪">same-origin with its ancestors</a> (<var>sameOriginWithAncestors</var>). The algorithm returns <code>undefined</code> once <var>credential</var> is persisted to the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①⑤">credential store</a>.</p>
    <p>The algorithm will return a <code>NotAllowedError</code> if <var>sameOriginWithAncestors</var> is not <code>true</code>.</p>
    <ol class="algorithm">
     <li data-md>
      <p>Return a "<code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#notallowederror" id="ref-for-notallowederror①">NotAllowedError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException⑤">DOMException</a></code> without altering the user agent’s <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①⑥">credential store</a> if <var>sameOriginWithAncestors</var> is <code>false</code>.</p>
      <p class="note" role="note"><span>Note:</span> This restriction aims to address the concern raised in <a href="#security-origin-confusion">§ 6.4 Origin Confusion</a>.</p>
     <li data-md>
      <p>If the user agent’s <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①⑦">credential store</a> contains a <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①⑥">PasswordCredential</a></code> (<var>stored</var>)
  whose <code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id①">id</a></code> attribute is <var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id②">id</a></code> and whose <code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot①">[[origin]]</a></code> slot is the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin②">same origin</a> as <var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot②">[[origin]]</a></code>,
  then:</p>
      <ol>
       <li data-md>
        <p>If the user grants permission to update credentials (as discussed when defining <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated⑥">user mediation</a>), then:</p>
        <ol>
         <li data-md>
          <p>Set <var>stored</var>’s <a class="idl-code" data-link-type="attribute" href="#dom-passwordcredential-password" id="ref-for-dom-passwordcredential-password①"><code>password</code></a> to <var>credential</var>’s <a class="idl-code" data-link-type="attribute" href="#dom-passwordcredential-password" id="ref-for-dom-passwordcredential-password②"><code>password</code></a>.</p>
         <li data-md>
          <p>Set <var>stored</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name①">name</a></code> to <var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name②">name</a></code>.</p>
         <li data-md>
          <p>Set <var>stored</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl①">iconURL</a></code> to <var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl②">iconURL</a></code>.</p>
        </ol>
      </ol>
      <p>Otherwise, if the user grants permission to store credentials (as discussed when
  defining <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated⑦">user mediation</a>, then:</p>
      <ol>
       <li data-md>
        <p>Store a <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①⑦">PasswordCredential</a></code> in the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①⑧">credential store</a> with the following
  properties:</p>
        <dl>
         <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id③">id</a></code>
         <dd data-md>
          <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id④">id</a></code></p>
         <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name③">name</a></code>,
         <dd data-md>
          <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name④">name</a></code></p>
         <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl③">iconURL</a></code>
         <dd data-md>
          <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl④">iconURL</a></code></p>
         <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot③">[[origin]]</a></code>
         <dd data-md>
          <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot④">[[origin]]</a></code></p>
         <dt data-md><a class="idl-code" data-link-type="attribute" href="#dom-passwordcredential-password" id="ref-for-dom-passwordcredential-password③"><code>password</code></a>
         <dd data-md>
          <p><var>credential</var>’s <a class="idl-code" data-link-type="attribute" href="#dom-passwordcredential-password" id="ref-for-dom-passwordcredential-password④"><code>password</code></a></p>
        </dl>
      </ol>
     <li data-md>
      <p>Return <code>undefined</code>.</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="Create a PasswordCredential from an HTMLFormElement" data-level="3.3.4" id="construct-passwordcredential-form"><span class="secno">3.3.4. </span><span class="content"> Create a <code>PasswordCredential</code> from an <code>HTMLFormElement</code> </span><a class="self-link" href="#construct-passwordcredential-form"></a></h4>
    <p>To <dfn class="dfn-paneled" data-dfn-type="abstract-op" data-export id="abstract-opdef-create-a-passwordcredential-from-an-htmlformelement">Create a <code>PasswordCredential</code> from an <code>HTMLFormElement</code></dfn>, given an <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement⑧">HTMLFormElement</a></code> (<var>form</var>) and an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin⑥">origin</a> (<var>origin</var>), run these steps.</p>
    <p class="note" role="note"><span>Note:</span> <a href="#examples-post-signin">§ 3.1.2 Post-sign-in Confirmation</a> and <a href="#examples-change-password">§ 3.1.3 Change Password</a> provide examples of the intended
  usage.</p>
    <ol class="algorithm">
     <li data-md>
      <p>Let <var>data</var> be a new <code class="idl"><a data-link-type="idl" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata⑥">PasswordCredentialData</a></code> dictionary.</p>
     <li data-md>
      <p>Set <var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredentialdata-origin" id="ref-for-dom-passwordcredentialdata-origin">origin</a></code> member’s value to <var>origin</var>’s value.</p>
     <li data-md>
      <p>Let <var>formData</var> be the result of executing the <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#interface-formdata" id="ref-for-interface-formdata">FormData</a></code> constructor
  on <var>form</var>.</p>
     <li data-md>
      <p>Let <var>elements</var> be a list of all the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/forms.html#category-submit" id="ref-for-category-submit①">submittable elements</a> whose <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#form-owner" id="ref-for-form-owner">form owner</a> is <var>form</var>, in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-tree-order" id="ref-for-concept-tree-order">tree order</a>.</p>
     <li data-md>
      <p>Let <var>newPasswordObserved</var> be <code>false</code>.</p>
     <li data-md>
      <p>For each <var>field</var> in <var>elements</var>, run the following steps:</p>
      <ol>
       <li data-md>
        <p>If <var>field</var> does not have an <code><a data-link-type="element-sub" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete" id="ref-for-attr-fe-autocomplete⑦">autocomplete</a></code> attribute, then skip to the next <var>field</var>.</p>
       <li data-md>
        <p>Let <var>name</var> be the value of <var>field</var>’s <code><a data-link-type="element-sub" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-name" id="ref-for-attr-fe-name">name</a></code> attribute.</p>
       <li data-md>
        <p>If <var>formData</var>’s <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#dom-formdata-has" id="ref-for-dom-formdata-has">has()</a></code> method returns <code>false</code> when executed on <var>name</var>, then
  skip to the next <var>field</var>.</p>
       <li data-md>
        <p>If <var>field</var>’s <code><a data-link-type="element-sub" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete" id="ref-for-attr-fe-autocomplete⑧">autocomplete</a></code> attribute’s value contains one or more <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill-detail-tokens" id="ref-for-autofill-detail-tokens">autofill
  detail tokens</a> (<var>tokens</var>), then:</p>
        <ol>
         <li data-md>
          <p>For each <var>token</var> in <var>tokens</var>:</p>
          <ol>
           <li data-md>
            <p>If <var>token</var> is an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-case-insensitive" id="ref-for-ascii-case-insensitive">ASCII case-insensitive</a> match for one
  of the following strings, run the associated steps:</p>
            <dl>
             <dt data-md>"<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-new-password" id="ref-for-attr-fe-autocomplete-new-password①"><code>new-password</code></a>"
             <dd data-md>
              <p>Set <var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredentialdata-password" id="ref-for-dom-passwordcredentialdata-password">password</a></code> member’s
  value to the result of executing <var>formData</var>’s <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#dom-formdata-get" id="ref-for-dom-formdata-get">get()</a></code> method on <var>name</var>, and <var>newPasswordObserved</var> to <code>true</code>.</p>
             <dt data-md>"<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-current-password" id="ref-for-attr-fe-autocomplete-current-password①"><code>current-password</code></a>"
             <dd data-md>
              <p>If <var>newPasswordObserved</var> is <code>false</code>,
  set <var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredentialdata-password" id="ref-for-dom-passwordcredentialdata-password①">password</a></code> member’s
  value to the result of executing <var>formData</var>’s <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#dom-formdata-get" id="ref-for-dom-formdata-get①">get()</a></code> method on <var>name</var>.</p>
              <p class="note" role="note"><span>Note:</span> By checking that <var>newPasswordObserved</var> is <code>false</code>, <code>new-password</code> fields take precedence over <code>current-password</code> fields.</p>
             <dt data-md>"<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-photo" id="ref-for-attr-fe-autocomplete-photo"><code>photo</code></a>"
             <dd data-md>
              <p>Set <var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl⑤">iconURL</a></code> member’s
  value to the result of executing <var>formData</var>’s <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#dom-formdata-get" id="ref-for-dom-formdata-get②">get()</a></code> method on <var>name</var>.</p>
             <dt data-md>"<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-name" id="ref-for-attr-fe-autocomplete-name"><code>name</code></a>"
             <dt data-md>"<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-nickname" id="ref-for-attr-fe-autocomplete-nickname"><code>nickname</code></a>"
             <dd data-md>
              <p>Set <var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name⑤">name</a></code> member’s
  value to the result of executing <var>formData</var>’s <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#dom-formdata-get" id="ref-for-dom-formdata-get③">get()</a></code> method on <var>name</var>.</p>
             <dt data-md>"<a data-link-type="attr-value" href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-username" id="ref-for-attr-fe-autocomplete-username②"><code>username</code></a>"
             <dd data-md>
              <p>Set <var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialdata-id" id="ref-for-dom-credentialdata-id">id</a></code> member’s value to the
  result of executing <var>formData</var>’s <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#dom-formdata-get" id="ref-for-dom-formdata-get④">get()</a></code> method
  on <var>name</var>.</p>
            </dl>
          </ol>
        </ol>
      </ol>
     <li data-md>
      <p>Let <var>c</var> be the result of executing <a data-link-type="abstract-op" href="#abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata" id="ref-for-abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata②">Create a <code>PasswordCredential</code> from <code>PasswordCredentialData</code></a> on <var>data</var>.</p>
     <li data-md>
      <p>If <var>c</var> is an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception⑧">exception</a>, return <var>c</var>.</p>
     <li data-md>
      <p class="assertion">Assert: <var>c</var> is a <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①⑧">PasswordCredential</a></code>.</p>
     <li data-md>
      <p>Return <var>c</var>.</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="Create a PasswordCredential from PasswordCredentialData" data-level="3.3.5" id="construct-passwordcredential-data"><span class="secno">3.3.5. </span><span class="content"> Create a <code>PasswordCredential</code> from <code>PasswordCredentialData</code> </span><a class="self-link" href="#construct-passwordcredential-data"></a></h4>
    <p>To <dfn class="dfn-paneled" data-dfn-type="abstract-op" data-export id="abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata">Create a <code>PasswordCredential</code> from <code>PasswordCredentialData</code></dfn>, given an <code class="idl"><a data-link-type="idl" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata⑦">PasswordCredentialData</a></code> (<var>data</var>), run these steps.</p>
    <ol class="algorithm">
     <li data-md>
      <p>Let <var>c</var> be a new <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential①⑨">PasswordCredential</a></code> object.</p>
     <li data-md>
      <p>If any of the following are the empty string, return a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror④">TypeError</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception⑨">exception</a>:</p>
      <ul>
       <li data-md>
        <p><var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialdata-id" id="ref-for-dom-credentialdata-id①">id</a></code> member’s value</p>
       <li data-md>
        <p><var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredentialdata-origin" id="ref-for-dom-passwordcredentialdata-origin①">origin</a></code> member’s value</p>
       <li data-md>
        <p><var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredentialdata-password" id="ref-for-dom-passwordcredentialdata-password②">password</a></code> member’s value</p>
      </ul>
     <li data-md>
      <p>Set <var>c</var>’s properties as follows:</p>
      <dl>
       <dt data-md><a class="idl-code" data-link-type="attribute" href="#dom-passwordcredential-password" id="ref-for-dom-passwordcredential-password⑤"><code>password</code></a>
       <dd data-md>
        <p><var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredentialdata-password" id="ref-for-dom-passwordcredentialdata-password③">password</a></code> member’s value</p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id⑤">id</a></code>
       <dd data-md>
        <p><var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialdata-id" id="ref-for-dom-credentialdata-id②">id</a></code> member’s value</p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl⑥">iconURL</a></code>
       <dd data-md>
        <p><var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredentialdata-iconurl" id="ref-for-dom-passwordcredentialdata-iconurl">iconURL</a></code> member’s value</p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name⑥">name</a></code>
       <dd data-md>
        <p><var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredentialdata-name" id="ref-for-dom-passwordcredentialdata-name">name</a></code> member’s value</p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot⑤">[[origin]]</a></code>
       <dd data-md>
        <p><var>data</var>’s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredentialdata-origin" id="ref-for-dom-passwordcredentialdata-origin②">origin</a></code> member’s value.</p>
      </dl>
     <li data-md>
      <p>Return <var>c</var>.</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="CredentialRequestOptions Matching for PasswordCredential" data-level="3.3.6" id="passwordcredential-matching"><span class="secno">3.3.6. </span><span class="content"> <code>CredentialRequestOptions</code> Matching for <code>PasswordCredential</code> </span><a class="self-link" href="#passwordcredential-matching"></a></h4>
    <p>Given a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①②">CredentialRequestOptions</a></code> (<var>options</var>), the following algorithm returns "<code>Matches</code>" if
  the <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential②⓪">PasswordCredential</a></code> should be available as a response to a <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get①⑨">get()</a></code> request, and "<code>Does Not Match</code>" otherwise.</p>
    <ol>
     <li data-md>
      <p>If <var>options</var> has a <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-password" id="ref-for-dom-credentialrequestoptions-password④">password</a></code> member whose value is <code>true</code>, then
  return "<code>Matches</code>".</p>
     <li data-md>
      <p>Return "<code>Does Not Match</code>".</p>
    </ol>
   </section>
   <section>
    <h2 class="heading settled" data-level="4" id="federated"><span class="secno">4. </span><span class="content">Federated Credentials</span><a class="self-link" href="#federated"></a></h2>
    <h3 class="heading settled" data-level="4.1" id="federatedcredential-interface"><span class="secno">4.1. </span><span class="content">The <code>FederatedCredential</code> Interface</span><a class="self-link" href="#federatedcredential-interface"></a></h3>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed③"><c- g>Exposed</c-></a>=<c- n>Window</c->,
 <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext⑤"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="federatedcredential"><code><c- g>FederatedCredential</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential④⑥"><c- n>Credential</c-></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-federatedcredential-federatedcredential" id="ref-for-dom-federatedcredential-federatedcredential"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="#dictdef-federatedcredentialinit" id="ref-for-dictdef-federatedcredentialinit"><c- n>FederatedCredentialInit</c-></a> <dfn class="idl-code" data-dfn-for="FederatedCredential/constructor(data)" data-dfn-type="argument" data-export id="dom-federatedcredential-constructor-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-federatedcredential-constructor-data-data"></a></dfn>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①③"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider"><c- g>provider</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString②"><c- b>DOMString</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="DOMString?" href="#dom-federatedcredential-protocol" id="ref-for-dom-federatedcredential-protocol"><c- g>protocol</c-></a>;
};
<a class="n" data-link-type="idl-name" href="#federatedcredential" id="ref-for-federatedcredential①"><c- n>FederatedCredential</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#credentialuserdata" id="ref-for-credentialuserdata①"><c- n>CredentialUserData</c-></a>;

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-federatedcredentialrequestoptions"><code><c- g>FederatedCredentialRequestOptions</c-></code></dfn> {
  <c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①④"><c- b>USVString</c-></a>> <dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredentialRequestOptions" data-dfn-type="dict-member" data-export data-type="sequence<USVString> " id="dom-federatedcredentialrequestoptions-providers"><code><c- g>providers</c-></code></dfn>;
  <c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString③"><c- b>DOMString</c-></a>> <dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredentialRequestOptions" data-dfn-type="dict-member" data-export data-type="sequence<DOMString> " id="dom-federatedcredentialrequestoptions-protocols"><code><c- g>protocols</c-></code></dfn>;
};

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①③"><c- g>CredentialRequestOptions</c-></a> {
  <a class="n" data-link-type="idl-name" href="#dictdef-federatedcredentialrequestoptions" id="ref-for-dictdef-federatedcredentialrequestoptions"><c- n>FederatedCredentialRequestOptions</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="CredentialRequestOptions" data-dfn-type="dict-member" data-export data-type="FederatedCredentialRequestOptions " id="dom-credentialrequestoptions-federated"><code><c- g>federated</c-></code></dfn>;
};
</pre>
    <div>
     <dl>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredential" data-dfn-type="attribute" data-export id="dom-federatedcredential-provider"><code>provider</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⑤">USVString</a>, readonly</span>
      <dd data-md>
       <p>The credential’s federated identity provider. See <a href="#provider-identification">§ 4.1.1 Identifying Providers</a> for
  details regarding valid formats.</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredential" data-dfn-type="attribute" data-export id="dom-federatedcredential-protocol"><code>protocol</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString④">DOMString</a>, readonly, nullable</span>
      <dd data-md>
       <p>The credential’s federated identity provider’s protocol (e.g. "<code>openidconnect</code>"). If the
  value is <code>null</code>, then the protocol can be inferred from the <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider①">provider</a></code>.</p>
      <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-type-slot" id="ref-for-dom-credential-type-slot④">[[type]]</a></code>
      <dd data-md>
       <p>The <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential②">FederatedCredential</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①⑤">interface object</a> has an internal slot named <code>[[type]]</code> whose
  value is "<dfn class="idl-code" data-dfn-for="FederatedCredential" data-dfn-type="const" data-export id="dom-federatedcredential-federated"><code>federated</code><a class="self-link" href="#dom-federatedcredential-federated"></a></dfn>".</p>
      <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-discovery-slot" id="ref-for-dom-credential-discovery-slot②">[[discovery]]</a></code>
      <dd data-md>
       <p>The <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential③">FederatedCredential</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①⑥">interface object</a> has an internal slot named <code>[[discovery]]</code> whose value is "<code class="idl"><a data-link-type="idl" href="#dom-credential-discovery-credential-store" id="ref-for-dom-credential-discovery-credential-store②">credential store</a></code>".</p>
      <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredential" data-dfn-type="constructor" data-export data-lt="FederatedCredential(data)|constructor(data)" id="dom-federatedcredential-federatedcredential"><code>FederatedCredential(data)</code></dfn>
      <dd data-md>
       <p>This constructor accepts a <code class="idl"><a data-link-type="idl" href="#dictdef-federatedcredentialinit" id="ref-for-dictdef-federatedcredentialinit①">FederatedCredentialInit</a></code> (<var>data</var>), and runs the following steps:</p>
       <ol>
        <li data-md>
         <p>Let <var>r</var> be the result of executing <a data-link-type="abstract-op" href="#abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit" id="ref-for-abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit">Create a <code>FederatedCredential</code> from <code>FederatedCredentialInit</code></a> on <var>data</var>.</p>
        <li data-md>
         <p>If <var>r</var> is an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception①⓪">exception</a>, <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②">throw</a> <var>r</var>.</p>
         <p>Otherwise, return <var>r</var>.</p>
       </ol>
     </dl>
    </div>
    <p><code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential④">FederatedCredential</a></code> objects can be created by passing a <code class="idl"><a data-link-type="idl" href="#dictdef-federatedcredentialinit" id="ref-for-dictdef-federatedcredentialinit②">FederatedCredentialInit</a></code> dictionary
  into <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-create" id="ref-for-dom-credentialscontainer-create⑥">navigator.credentials.create()</a></code>.</p>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-federatedcredentialinit"><code><c- g>FederatedCredentialInit</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#dictdef-credentialdata" id="ref-for-dictdef-credentialdata①"><c- n>CredentialData</c-></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⑥"><c- b>USVString</c-></a> <dfn class="idl-code" data-dfn-for="FederatedCredentialInit" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-federatedcredentialinit-name"><code><c- g>name</c-></code><a class="self-link" href="#dom-federatedcredentialinit-name"></a></dfn>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⑦"><c- b>USVString</c-></a> <dfn class="idl-code" data-dfn-for="FederatedCredentialInit" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-federatedcredentialinit-iconurl"><code><c- g>iconURL</c-></code><a class="self-link" href="#dom-federatedcredentialinit-iconurl"></a></dfn>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⑧"><c- b>USVString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredentialInit" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-federatedcredentialinit-origin"><code><c- g>origin</c-></code></dfn>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⑨"><c- b>USVString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredentialInit" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-federatedcredentialinit-provider"><code><c- g>provider</c-></code></dfn>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑤"><c- b>DOMString</c-></a> <dfn class="idl-code" data-dfn-for="FederatedCredentialInit" data-dfn-type="dict-member" data-export data-type="DOMString " id="dom-federatedcredentialinit-protocol"><code><c- g>protocol</c-></code><a class="self-link" href="#dom-federatedcredentialinit-protocol"></a></dfn>;
};

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions⑧"><c- g>CredentialCreationOptions</c-></a> {
  <a class="n" data-link-type="idl-name" href="#dictdef-federatedcredentialinit" id="ref-for-dictdef-federatedcredentialinit③"><c- n>FederatedCredentialInit</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="CredentialCreationOptions" data-dfn-type="dict-member" data-export data-type="FederatedCredentialInit " id="dom-credentialcreationoptions-federated"><code><c- g>federated</c-></code></dfn>;
};
</pre>
    <p><code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential⑤">FederatedCredential</a></code> objects are <a data-link-type="dfn" href="#credential-origin-bound" id="ref-for-credential-origin-bound①">origin bound</a>.</p>
    <p><code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential⑥">FederatedCredential</a></code>'s <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①⑦">interface object</a> inherits <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential④⑦">Credential</a></code>'s implementation of <code class="idl"><a data-link-type="idl" href="#dom-credential-discoverfromexternalsource-slot" id="ref-for-dom-credential-discoverfromexternalsource-slot③">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</a></code>,
  and defines its own implementation of <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-collectfromcredentialstore-slot" id="ref-for-dom-federatedcredential-collectfromcredentialstore-slot">[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-create-slot" id="ref-for-dom-federatedcredential-create-slot">[[Create]](origin, options, sameOriginWithAncestors)</a></code>, and <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-store-slot" id="ref-for-dom-federatedcredential-store-slot">[[Store]](credential, sameOriginWithAncestors)</a></code>.</p>
    <p class="note" role="note"><span>Note:</span> If, in the future, we teach the user agent to obtain authentication tokens on a user’s
  behalf, we could do so by building an implementation of <code>[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</code>.</p>
    <h4 class="heading settled" data-level="4.1.1" id="provider-identification"><span class="secno">4.1.1. </span><span class="content">Identifying Providers</span><a class="self-link" href="#provider-identification"></a></h4>
    <p>Every site should use the same identifier when referring to a specific federated identity
  provider. For example, <a href="https://developers.facebook.com/docs/facebook-login/v2.0">Facebook Login</a> shouldn’t be referred to as "Facebook" and "Facebook Login" and "FB" and "FBL" and "Facebook.com"
  and so on. It should have a canonical identifier which everyone can make use of, as consistent
  identification makes it possible for user agents to be helpful.</p>
    <p>For consistency, federations passed into the APIs defined in this document (e.g. <code class="idl"><a data-link-type="idl" href="#dictdef-federatedcredentialrequestoptions" id="ref-for-dictdef-federatedcredentialrequestoptions①">FederatedCredentialRequestOptions</a></code>'s <code class="idl"><a data-link-type="idl" href="#dom-federatedcredentialrequestoptions-providers" id="ref-for-dom-federatedcredentialrequestoptions-providers">providers</a></code> array, or <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential⑦">FederatedCredential</a></code>'s <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider②">provider</a></code> property) MUST be identified by the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#ascii-serialisation-of-an-origin" id="ref-for-ascii-serialisation-of-an-origin">ASCII serialization</a> of the origin the provider uses
  for sign in. That is, Facebook would be represented by <code>https://www.facebook.com</code> and Google by <code>https://accounts.google.com</code>.</p>
    <p>This serialization of an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin⑦">origin</a> does _not_ include a trailing U+002F SOLIDUS ("<code>/</code>"), but
  user agents SHOULD accept them silently: <code>https://accounts.google.com/</code> is clearly
  intended to be the same as <code>https://accounts.google.com</code>.</p>
    <h3 class="heading settled" data-level="4.2" id="federatedcredential-algorithms"><span class="secno">4.2. </span><span class="content">Algorithms</span><a class="self-link" href="#federatedcredential-algorithms"></a></h3>
    <h4 class="heading settled algorithm" data-algorithm="FederatedCredential&apos;s [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)" data-level="4.2.1" id="collectfromcredentialstore-federatedcredential"><span class="secno">4.2.1. </span><span class="content"> <code>FederatedCredential</code>'s <code>[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</code> </span><a class="self-link" href="#collectfromcredentialstore-federatedcredential"></a></h4>
    <p><dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredential" data-dfn-type="method" data-export id="dom-federatedcredential-collectfromcredentialstore-slot"><code>[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</code></dfn> is called with an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin⑧">origin</a> (<var>origin</var>), a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①④">CredentialRequestOptions</a></code> (<var>options</var>),
  and a boolean which is <code>true</code> iff the calling context is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors①①">same-origin with its ancestors</a> (<var>sameOriginWithAncestors</var>).
  The algorithm returns a set of <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential④⑧">Credential</a></code> objects from
  the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store①⑨">credential store</a>. If no matching <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential④⑨">Credential</a></code> objects are available, the returned set
  will be empty.</p>
    <ol class="algorithm">
     <li data-md>
      <p class="assertion">Assert: <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-federated" id="ref-for-dom-credentialrequestoptions-federated">federated</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists③">exists</a>.</p>
     <li data-md>
      <p>If <var>sameOriginWithAncestors</var> is <code>false</code>, return a "<code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#notallowederror" id="ref-for-notallowederror②">NotAllowedError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException⑥">DOMException</a></code>.</p>
      <p class="note" role="note"><span>Note:</span> This restriction aims to address the concern raised in <a href="#security-origin-confusion">§ 6.4 Origin Confusion</a>.</p>
     <li data-md>
      <p>Return the empty set if <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-federated" id="ref-for-dom-credentialrequestoptions-federated①">federated</a></code>"] is not <code>true</code>.</p>
     <li data-md>
      <p>Return the result of <a data-link-type="abstract-op" href="#abstract-opdef-credential-store-retrieve-a-list-of-credentials" id="ref-for-abstract-opdef-credential-store-retrieve-a-list-of-credentials①">retrieving</a> credentials from the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②⓪">credential store</a> that match the following filter:</p>
      <ol>
       <li data-md>
        <p>The credential is a <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential⑧">FederatedCredential</a></code></p>
       <li data-md>
        <p>The credential’s <code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot⑥">[[origin]]</a></code> is the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin③">same origin</a> as <var>origin</var>.</p>
       <li data-md>
        <p>If <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-federated" id="ref-for-dom-credentialrequestoptions-federated②">federated</a></code>"]["<code class="idl"><a data-link-type="idl" href="#dom-federatedcredentialrequestoptions-providers" id="ref-for-dom-federatedcredentialrequestoptions-providers①">providers</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists④">exists</a>, its value <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-contain" id="ref-for-list-contain①">contains</a> the credentials’s <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider③">provider</a></code>.</p>
       <li data-md>
        <p>If <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-federated" id="ref-for-dom-credentialrequestoptions-federated③">federated</a></code>"]["<code class="idl"><a data-link-type="idl" href="#dom-federatedcredentialrequestoptions-protocols" id="ref-for-dom-federatedcredentialrequestoptions-protocols">protocols</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists⑤">exists</a>, its value <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-contain" id="ref-for-list-contain②">contains</a> the credentials’s <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-protocol" id="ref-for-dom-federatedcredential-protocol①">protocol</a></code>.</p>
      </ol>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="FederatedCredential&apos;s [[Create]](origin, options, sameOriginWithAncestors)" data-level="4.2.2" id="create-federatedcredential"><span class="secno">4.2.2. </span><span class="content"> <code>FederatedCredential</code>'s <code>[[Create]](origin, options, sameOriginWithAncestors)</code> </span><a class="self-link" href="#create-federatedcredential"></a></h4>
    <p><dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredential" data-dfn-type="method" data-export id="dom-federatedcredential-create-slot"><code>[[Create]](origin, options, sameOriginWithAncestors)</code></dfn> is called with an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin⑨">origin</a> (<var>origin</var>), a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions⑨">CredentialCreationOptions</a></code> (<var>options</var>), and a boolean which is <code>true</code> iff the
  calling context is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors①②">same-origin with its ancestors</a> (<var>sameOriginWithAncestors</var>).
  The algorithm returns a <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential⑨">FederatedCredential</a></code> if one can be created, <code>null</code> otherwise, or an <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception①①">exception</a> in exceptional circumstances:</p>
    <ol class="algorithm">
     <li data-md>
      <p class="assertion">Assert: <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialcreationoptions-federated" id="ref-for-dom-credentialcreationoptions-federated">federated</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists⑥">exists</a>, and <var>sameOriginWithAncestors</var> is unused.</p>
     <li data-md>
      <p>Set <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialcreationoptions-federated" id="ref-for-dom-credentialcreationoptions-federated①">federated</a></code>"]'s <code class="idl"><a data-link-type="idl" href="#dom-federatedcredentialinit-origin" id="ref-for-dom-federatedcredentialinit-origin">origin</a></code> member’s value to <var>origin</var>’s value.</p>
     <li data-md>
      <p>Return the result of executing <a data-link-type="abstract-op" href="#abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit" id="ref-for-abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit①">Create a <code>FederatedCredential</code> from <code>FederatedCredentialInit</code></a> given <var>options</var>["<code class="idl"><a data-link-type="idl" href="#dom-credentialcreationoptions-federated" id="ref-for-dom-credentialcreationoptions-federated②">federated</a></code>"].</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="FederatedCredential&apos;s [[Store]](credential, sameOriginWithAncestors)" data-level="4.2.3" id="store-federatedcredential"><span class="secno">4.2.3. </span><span class="content"> <code>FederatedCredential</code>'s <code>[[Store]](credential, sameOriginWithAncestors)</code> </span><a class="self-link" href="#store-federatedcredential"></a></h4>
    <p><dfn class="dfn-paneled idl-code" data-dfn-for="FederatedCredential" data-dfn-type="method" data-export id="dom-federatedcredential-store-slot"><code>[[Store]](credential, sameOriginWithAncestors)</code></dfn> is
  called with a <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential①⓪">FederatedCredential</a></code> (<var>credential</var>), and a boolean which is <code>true</code> iff the
  calling context is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors①③">same-origin with its ancestors</a> (<var>sameOriginWithAncestors</var>). The algorithm
  returns <code>undefined</code> once <var>credential</var> is persisted to the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②①">credential store</a>.</p>
    <p>The algorithm will return a <code>NotAllowedError</code> if <var>sameOriginWithAncestors</var> is not <code>true</code>.</p>
    <ol class="algorithm">
     <li data-md>
      <p>Return a "<code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#notallowederror" id="ref-for-notallowederror③">NotAllowedError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException⑦">DOMException</a></code> without altering the user agent’s <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②②">credential store</a> if <var>sameOriginWithAncestors</var> is <code>false</code>.</p>
      <p class="note" role="note"><span>Note:</span> This restriction aims to address the concern raised in <a href="#security-origin-confusion">§ 6.4 Origin Confusion</a>.</p>
     <li data-md>
      <p>If the user agent’s <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②③">credential store</a> contains a <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential①①">FederatedCredential</a></code> whose <code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id⑥">id</a></code> attribute is <var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id⑦">id</a></code> and whose <code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot⑦">[[origin]]</a></code> slot is the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin④">same origin</a> as <var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot⑧">[[origin]]</a></code>, and
  whose <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider④">provider</a></code> is <var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider⑤">provider</a></code>, then return.</p>
     <li data-md>
      <p>If the user grants permission to store credentials (as discussed when defining <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated⑧">user mediation</a>), then store a <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential①②">FederatedCredential</a></code> in the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②④">credential store</a> with
  the following properties:</p>
      <dl>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id⑧">id</a></code>
       <dd data-md>
        <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id⑨">id</a></code></p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name⑦">name</a></code>,
       <dd data-md>
        <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name⑧">name</a></code></p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl⑦">iconURL</a></code>
       <dd data-md>
        <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl⑧">iconURL</a></code></p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot⑨">[[origin]]</a></code>
       <dd data-md>
        <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot①⓪">[[origin]]</a></code></p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider⑥">provider</a></code>
       <dd data-md>
        <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider⑦">provider</a></code></p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-protocol" id="ref-for-dom-federatedcredential-protocol②">protocol</a></code>
       <dd data-md>
        <p><var>credential</var>’s <code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-protocol" id="ref-for-dom-federatedcredential-protocol③">protocol</a></code></p>
      </dl>
     <li data-md>
      <p>Return <code>undefined</code>.</p>
    </ol>
    <h4 class="heading settled algorithm" data-algorithm="Create a FederatedCredential from FederatedCredentialInit" data-level="4.2.4" id="construct-federatedcredential-data"><span class="secno">4.2.4. </span><span class="content"> Create a <code>FederatedCredential</code> from <code>FederatedCredentialInit</code> </span><a class="self-link" href="#construct-federatedcredential-data"></a></h4>
    <p>To <dfn class="dfn-paneled" data-dfn-type="abstract-op" data-export id="abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit">Create a <code>FederatedCredential</code> from <code>FederatedCredentialInit</code></dfn>, given a <code class="idl"><a data-link-type="idl" href="#dictdef-federatedcredentialinit" id="ref-for-dictdef-federatedcredentialinit④">FederatedCredentialInit</a></code> (<var>init</var>), run these steps.</p>
    <ol class="algorithm">
     <li data-md>
      <p>Let <var>c</var> be a new <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential①③">FederatedCredential</a></code> object.</p>
     <li data-md>
      <p>If any of the following are the empty string, return a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror⑤">TypeError</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-exception" id="ref-for-dfn-exception①②">exception</a>:</p>
      <ul>
       <li data-md>
        <p><var>init</var>.<code class="idl"><a data-link-type="idl" href="#dom-credentialdata-id" id="ref-for-dom-credentialdata-id③">id</a></code>'s value</p>
       <li data-md>
        <p><var>init</var>.<code class="idl"><a data-link-type="idl" href="#dom-federatedcredentialinit-provider" id="ref-for-dom-federatedcredentialinit-provider">provider</a></code>'s value</p>
      </ul>
     <li data-md>
      <p>Set <var>c</var>’s properties as follows:</p>
      <dl>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-id" id="ref-for-dom-credential-id①⓪">id</a></code>
       <dd data-md>
        <p><var>init</var>.<code class="idl"><a data-link-type="idl" href="#dom-credentialdata-id" id="ref-for-dom-credentialdata-id④">id</a></code>'s value</p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider⑧">provider</a></code>
       <dd data-md>
        <p><var>init</var>.<code class="idl"><a data-link-type="idl" href="#dom-federatedcredentialinit-provider" id="ref-for-dom-federatedcredentialinit-provider①">provider</a></code>'s value</p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl⑨">iconURL</a></code>
       <dd data-md>
        <p><var>init</var>.<code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl①⓪">iconURL</a></code>'s value</p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name⑨">name</a></code>
       <dd data-md>
        <p><var>init</var>.<code class="idl"><a data-link-type="idl" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name①⓪">name</a></code>'s value</p>
       <dt data-md><code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot①①">[[origin]]</a></code>
       <dd data-md>
        <p><var>init</var>.<code class="idl"><a data-link-type="idl" href="#dom-federatedcredentialinit-origin" id="ref-for-dom-federatedcredentialinit-origin①">origin</a></code>'s value.</p>
      </dl>
     <li data-md>
      <p>Return <var>c</var>.</p>
    </ol>
   </section>
   <section>
    <h2 class="heading settled" data-level="5" id="user-mediation"><span class="secno">5. </span><span class="content">User Mediation</span><a class="self-link" href="#user-mediation"></a></h2>
    <p>Exposing credential information to the web via an API has a number of potential impacts on user
  privacy. The user agent, therefore, MUST involve the user in a number of cases in order to ensure
  that they clearly understands what’s going on, and with whom their credentials are being shared.</p>
    <p>We call a particular action <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="user mediated|user mediation" id="user-mediated">user mediated</dfn> if
  it takes place after gaining a user’s explicit consent. Consent might be expressed through a
  user’s direct interaction with a <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser⑧">credential chooser</a> interface, for example. In general, <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated⑨">user
  mediated</a> actions will involve presenting the user some sort of UI, and asking them to make a
  decision.</p>
    <p>An action is unmediated if it takes place silently, without explicit user consent. For example,
  if a user configures their browser to grant persistent credential access to a particular origin,
  credentials may be provided without presenting the user with a UI requesting a decision.</p>
    <p>Here we’ll spell out a few requirements that hold for all credential types, but note that there’s
  a good deal of latitude left up to the user agent (which is in a priviliged position to assist
  the user). Moreover, specific credential types may have distinct requirements that exceed the
  requirements laid out more generally here.</p>
    <h3 class="heading settled" data-level="5.1" id="user-mediated-storage"><span class="secno">5.1. </span><span class="content">Storing and Updating Credentials</span><a class="self-link" href="#user-mediated-storage"></a></h3>
    <p>Credential information is sensitive data, and users MUST remain in control of that information’s
  storage. Inadvertent credential storage could, for instance, unexpectedly link a user’s local
  profile on a particular device to a specific online persona. To mitigate the risk of surprise:</p>
    <ol>
     <li data-md>
      <p>Credential information SHOULD NOT be stored or updated without <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated①⓪">user mediation</a>. For
  example, the user agent could display a "Save this credential?" dialog box to the user in
  response to each call to <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store①②">store()</a></code>.</p>
      <p>User consent MAY be inferred if a user agent chooses to offer a persistant grant of consent
  in the form of an "Always save passwords" option (though we’d suggest that user agents should
  err on the side of something more narrowly scoped: perhaps "Always save _generated_
  passwords.", or "Always save passwords for this site.").</p>
     <li data-md>
      <p>User agents SHOULD notify users when credentials are stored. This might take the form of an
  icon in the address bar, or some similar location.</p>
     <li data-md>
      <p>User agents MUST allow users to manually remove stored credentials. This functionality might
  be implemented as a settings page, or via interaction with a notification as described above.</p>
    </ol>
    <h3 class="heading settled" data-level="5.2" id="user-mediation-requirement"><span class="secno">5.2. </span><span class="content">Requiring User Mediation</span><a class="self-link" href="#user-mediation-requirement"></a></h3>
    <p>By default, <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated①①">user mediation</a> is required for all <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin①⓪">origins</a>, as the relevant <a data-link-type="dfn" href="#origin-prevent-silent-access-flag" id="ref-for-origin-prevent-silent-access-flag④">prevent silent
  access flag</a> in the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②⑤">credential store</a> is set to <code>true</code>. Users MAY choose to grant an
  origin persistent access to credentials (perhaps in the form of a "Stay signed into this site."
  option), which would set this flag to <code>false</code>. In this case, the user would always be signed into
  that site, which is desirable from the perspective of usability and convinience, but which
  might nevertheless have surprising implications (consider a user agent which syncs this flag’s
  state across devices, for instance).</p>
    <p>To mitigate the risk of surprise:</p>
    <ol>
     <li data-md>
      <p>User agents MUST allow users to require <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated①②">user mediation</a> for a given origin or for all
  origins. This functionality might be implemented as a global toggle that overrides each
  origin’s <a data-link-type="dfn" href="#origin-prevent-silent-access-flag" id="ref-for-origin-prevent-silent-access-flag⑤"><code>prevent silent access</code> flag</a> to return <code>false</code>, or via more granular
  settings for specific origins (or specific credentials on specific origins).</p>
     <li data-md>
      <p>User agents MUST NOT set an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin①①">origin</a>'s <a data-link-type="dfn" href="#origin-prevent-silent-access-flag" id="ref-for-origin-prevent-silent-access-flag⑥"><code>prevent silent access</code> flag</a> to <code>false</code> without <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated①③">user mediation</a>. For example, the <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser⑨">credential chooser</a> described in <a href="#user-mediated-selection">§ 5.3 Credential Selection</a> could have a checkbox which the user could toggle to mark a
  credential as available without mediation for the origin, or the user agent could have an
  onboarding process for its credential manager which asked a user for a default setting.</p>
     <li data-md>
      <p>User agents MUST notify users when credentials are provided to an origin. This could take the
  form of an icon in the address bar, or some similar location.</p>
     <li data-md>
      <p>If a user clears her browsing data for an origin (cookies, localStorage, and so on), the user
  agent MUST set the <a data-link-type="dfn" href="#origin-prevent-silent-access-flag" id="ref-for-origin-prevent-silent-access-flag⑦"><code>prevent silent access</code> flag</a> to <code>true</code> for that origin.</p>
    </ol>
    <h3 class="heading settled" data-level="5.3" id="user-mediated-selection"><span class="secno">5.3. </span><span class="content">Credential Selection</span><a class="self-link" href="#user-mediated-selection"></a></h3>
    <p>When responding to a call to <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get②⓪">get()</a></code> on an origin which requires <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated①④">user mediation</a>, user agents MUST ask the user for permission to share credential information.
  This SHOULD take the form of a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="credential-chooser">credential chooser</dfn> which presents the user with a
  list of credentials that are available for use on a site, allowing them to select one which should
  be provided to the website, or to reject the request entirely.</p>
    <p>The chooser interface SHOULD be implemented in such a way as to be distinguishable from UI which a
  website could produce. For example, the chooser might overlap the user agent’s UI in some
  unspoofable way.</p>
    <p>The chooser interface MUST include an indication of the origin which is requesting credentials.</p>
    <p>The chooser interface SHOULD include all <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤⓪">Credential</a></code> objects associated with the origin that
  requested credentials.</p>
    <p>User agents MAY internally associate information with each <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤①">Credential</a></code> object beyond the
  attributes specified in this document in order to enhance the utility of such a chooser. For
  example, favicons could help disambiguate identity providers, etc. Any additional information
  stored MUST not be exposed directly to the web.</p>
    <p>The chooser’s behavior is not defined here: user agents are encouraged to experiment with UI
  treatments that educate users about their authentication options, and guide them through the
  process of choosing a credential to present. That said, the interface to the chooser is as
  follows:</p>
    <section class="algorithm" data-algorithm="ask the user to choose">
      The user agent can <dfn class="dfn-paneled" data-dfn-type="abstract-op" data-export data-local-lt="ask to choose" data-lt="ask the user to choose a Credential" id="abstract-opdef-ask-the-user-to-choose-a-credential">ask the user to choose a <code>Credential</code></dfn>, given a <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①⑤">CredentialRequestOptions</a></code> (<var>options</var>), and a set of <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤②">Credential</a></code> objects from the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②⑥">credential store</a> (<var>locally discovered credentials</var>). 
     <p>This algorithm returns either <code>null</code> if the user chose not to share a credential with the site,
    a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤③">Credential</a></code> object if the user chose a specific credential, or a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤④">Credential</a></code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①⑧">interface
    object</a> if the user chose a type of credential.</p>
     <div class="note" role="note">
       It seems reasonable for the chooser interface to display the list of <var>locally discovered
      credentials</var> to the user, perhaps something like this exceptionally non-normative mock: 
      <p><img alt="A mockup of what a chooser might look like." src="./mock-chooser.png"></p>
      <p>If the <var>options</var> provided is not <a data-link-type="dfn" href="#credentialrequestoptions-matchable-a-priori" id="ref-for-credentialrequestoptions-matchable-a-priori②">matchable <i lang="la">a priori</i></a>, then it might
      also make sense for the chooser interface to list the <a data-link-type="dfn" href="#credentialrequestoptions-relevant-credential-interface-objects" id="ref-for-credentialrequestoptions-relevant-credential-interface-objects③">relevant credential interface
      objects</a> for <var>options</var> that aren’t covered by the list of explicit credentials. If, for
      instance, a site accepts webauthn-style authenticators, then "Security Key" might show up
      in the chooser list with an appropriate icon.</p>
      <p>Also, note that in some cases the user agent may skip the chooser entirely. For example, if
      the only <a data-link-type="dfn" href="#credentialrequestoptions-relevant-credential-interface-objects" id="ref-for-credentialrequestoptions-relevant-credential-interface-objects④">relevant credential interface objects</a> is one that itself requires user
      interaction, the user agent may return that interface directly, and rely on its internal
      mediation flow for user consent.</p>
     </div>
    </section>
   </section>
   <section>
    <h2 class="heading settled" data-level="6" id="security-and-privacy"><span class="secno">6. </span><span class="content">Security and Privacy Considerations</span><a class="self-link" href="#security-and-privacy"></a></h2>
    <p>The following sections represent guidelines for various security and privacy considerations.
  Individual credential types may enforce stricter or more relaxed versions of these guidelines.</p>
    <h3 class="heading settled" data-level="6.1" id="security-credential-access"><span class="secno">6.1. </span><span class="content">Cross-domain credential access</span><a class="self-link" href="#security-credential-access"></a></h3>
    <p>Credentials are sensitive information, and user agents need to exercise caution in determining
  when they can be safely shared with a website. The safest option is to restrict credential
  sharing to the exact origin on which they were saved. That is likely too restrictive for the
  web, however: consider sites which divide functionality into subdomains like <code>example.com</code> vs <code>admin.example.com</code>.</p>
    <p>As a compromise between annoying users, and securing their credentials, user agents:</p>
    <ol>
     <li data-md>
      <p>MUST NOT share credentials between origins whose scheme components represent a downgrade in
  security. That is, it may make sense to allow credentials saved on <code>http://example.com/</code> to
  be made available to <code>https://example.com/</code> (in order to encourage developers to migrate to
  secure transport), but the inverse would be dangerous.</p>
     <li data-md>
      <p>MAY use the Public Suffix List <a data-link-type="biblio" href="#biblio-psl">[PSL]</a> to determine the effective scope of a credential by
  comparing the <a data-link-type="dfn" href="https://publicsuffix.org/list/#" id="termref-for-">registerable domain</a> of the credential’s <code class="idl"><a data-link-type="idl" href="#dom-credential-origin-slot" id="ref-for-dom-credential-origin-slot①②">[[origin]]</a></code> with the
  origin in which <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get②①">get()</a></code> is called. That is: credentials saved on <code>https://admin.example.com/</code> and <code>https://example.com/</code> MAY be offered to users when <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get②②">get()</a></code> is called from <code>https://www.example.com/</code>, and vice versa.</p>
     <li data-md>
      <p>MUST NOT offer credentials to an origin in response to <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get②③">get()</a></code> without <a data-link-type="dfn" href="#user-mediated" id="ref-for-user-mediated①⑤">user mediation</a> if the credential’s origin is not an exact match for the calling origin.
  That is, <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤⑤">Credential</a></code> objects for <code>https://example.com</code> would not be returned directly to <code>https://www.example.com</code>, but could be offered to the user via the chooser.</p>
    </ol>
    <h3 class="heading settled" data-level="6.2" id="security-leakage"><span class="secno">6.2. </span><span class="content">Credential Leakage</span><a class="self-link" href="#security-leakage"></a></h3>
    <p>Developers are well-advised to take
  some precautions to mitigate the risk that a cross-site scripting attack could turn into
  persistent access to a user’s account by setting a reasonable Content Security Policy <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> which restricts the endpoints to which data can be sent. In particular, developers should ensure
  that the following directives are set, explicitly or implicitly, in their pages' policies:</p>
    <ul>
     <li data-md>
      <p><a data-link-type="dfn"><code>script-src</code></a> and <a data-link-type="dfn"><code>object-src</code></a> both restrict script execution on a page, making
  it less likely that a cross-site scripting attack will succeed in the first place. If sites
  are populating <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/forms.html#the-form-element" id="ref-for-the-form-element②">form</a></code> elements, also <a data-link-type="dfn"><code>form-action</code></a> directives should be set.</p>
     <li data-md>
      <p><a data-link-type="dfn"><code>connect-src</code></a> restricts the origins to which <code class="idl"><a data-link-type="idl" href="https://fetch.spec.whatwg.org/#dom-global-fetch" id="ref-for-dom-global-fetch①">fetch()</a></code> may submit data (which
  mitigates the risk that credentials could be exfiltrated to <code>evil.com</code>.</p>
     <li data-md>
      <p><a data-link-type="dfn"><code>child-src</code></a> restricts the nested browsing contexts which may be embedded in a page,
  making it more difficult to inject a malicious <code>postMessage()</code> target. <a data-link-type="biblio" href="#biblio-webmessaging">[WEBMESSAGING]</a></p>
    </ul>
    <p>Developers should, of course, also properly escape input and output, and consider using other
  layers of defense, such as Subresource Integrity <a data-link-type="biblio" href="#biblio-sri">[SRI]</a> to further reduce risk.</p>
    <p>When defining specific credential types, specific credential types SHOULD give due consideration
  to the ways in which credential data can be transmitted over the wire. It might be reasonable,
  for example, to define transmission mechanisms which are restricted to same-origin endpoints.</p>
    <h3 class="heading settled" data-level="6.3" id="insecure-sites"><span class="secno">6.3. </span><span class="content">Insecure Sites</span><a class="self-link" href="#insecure-sites"></a></h3>
    <p>User agents MUST NOT expose the APIs defined here to environments which are not <a data-link-type="dfn" href="https://w3c.github.io/webappsec-secure-contexts/#secure-contexts" id="ref-for-secure-contexts④">secure
  contexts</a>. User agents might implement autofill mechanisms which store user credentials and fill
  sign-in forms on non-<a data-link-type="dfn" href="https://w3c.github.io/webappsec-mixed-content/#a-priori-authenticated-url" id="ref-for-a-priori-authenticated-url①"><i lang="la">a priori</i> authenticated URLs</a>, but those sites cannot
  be trusted to interact directly with the credential manager in any meaningful way, and those sites
  MUST NOT have access to credentials saved in <a data-link-type="dfn" href="https://w3c.github.io/webappsec-secure-contexts/#secure-contexts" id="ref-for-secure-contexts⑤">secure contexts</a>.</p>
    <h3 class="heading settled" data-level="6.4" id="security-origin-confusion"><span class="secno">6.4. </span><span class="content">Origin Confusion</span><a class="self-link" href="#security-origin-confusion"></a></h3>
    <p>If framed pages have access to the APIs defined here, it might be possible to confuse a user into
  granting access to credentials for an origin other than the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#top-level-browsing-context" id="ref-for-top-level-browsing-context">top-level browsing context</a>,
  which is the only security origin which users can reasonably be expected to understand.</p>
    <p>This document exposes the Credential Management APIs to those contexts, as it’s likely that some
  credential types will be straightforward to make available if user agents put enough thought and
  context into their UI.</p>
    <p>Specific credential types, however, will be difficult to expose in those contexts without risk.
  Those credential types are restricted via checks in their <code class="idl"><a data-link-type="idl" href="#dom-credential-create-slot" id="ref-for-dom-credential-create-slot②">[[Create]](origin, options, sameOriginWithAncestors)</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-credential-collectfromcredentialstore-slot" id="ref-for-dom-credential-collectfromcredentialstore-slot②">[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-credential-discoverfromexternalsource-slot" id="ref-for-dom-credential-discoverfromexternalsource-slot④">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</a></code>, and <code class="idl"><a data-link-type="idl" href="#dom-credential-store-slot" id="ref-for-dom-credential-store-slot②">[[Store]](credential, sameOriginWithAncestors)</a></code> methods, as appropriate.</p>
    <p>For example <code class="idl"><a data-link-type="idl" href="#passwordcredential" id="ref-for-passwordcredential②①">PasswordCredential</a></code>'s <code class="idl"><a data-link-type="idl" href="#dom-passwordcredential-collectfromcredentialstore-slot" id="ref-for-dom-passwordcredential-collectfromcredentialstore-slot①">[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</a></code> method
  will immedietely return an empty set if called from inside a <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/workers.html#worker" id="ref-for-worker">Worker</a></code>, or a non-<a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#top-level-browsing-context" id="ref-for-top-level-browsing-context①">top-level
  browsing context</a>.</p>
    <h3 class="heading settled" data-level="6.5" id="security-timing"><span class="secno">6.5. </span><span class="content">Timing Attacks</span><a class="self-link" href="#security-timing"></a></h3>
    <p>If the user has no credentials for an origin, a call to <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get②④">get()</a></code> will
  resolve very quickly indeed. A malicious website could distinguish between a user with no
  credentials and a user with credentials who chooses not to share them.</p>
    <p>User agents SHOULD also rate-limit credential requests. It’s almost certainly abusive for a page
  to request credentials more than a few times in a short period.</p>
    <h3 class="heading settled" data-level="6.6" id="security-signout"><span class="secno">6.6. </span><span class="content">Signing-Out</span><a class="self-link" href="#security-signout"></a></h3>
    <p>If a user has chosen to automatically sign-in to websites, as discussed in <a href="#user-mediation-requirement">§ 5.2 Requiring User Mediation</a>, then the user agent will provide credentials to an origin
  whenever it asks for them. The website can instruct the user agent to suppress this behavior by
  calling <code class="idl"><a data-link-type="idl" href="#credentialscontainer" id="ref-for-credentialscontainer⑤">CredentialsContainer</a></code>'s <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-preventsilentaccess" id="ref-for-dom-credentialscontainer-preventsilentaccess③">preventSilentAccess()</a></code> method, which
  will turn off automatic sign-in for a given origin.</p>
    <p>The user agent relies on the website to do the right thing; an inattentive (or malicious) website
  could simply neglect to call this method, causing the user agent to continue providing credentials
  against the user’s apparent intention. This is marginally worse than the status-quo of a site that
  doesn’t clear user credentials when they click "Sign-out", as the user agent becomes complicit in
  the authentication.</p>
    <p>The user MUST have some control over this behavior. As noted in <a href="#user-mediation-requirement">§ 5.2 Requiring User Mediation</a>,
  clearing cookies for an origin will also reset that origin’s <a data-link-type="dfn" href="#origin-prevent-silent-access-flag" id="ref-for-origin-prevent-silent-access-flag⑧"><code>prevent silent access</code> flag</a> the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②⑦">credential store</a> to <code>true</code>. Additionally, the user agent SHOULD provide some UI affordance
  for disabling automatic sign-in for a particular origin. This could be tied to the notification
  that credentials have been provided to an origin, for example.</p>
    <h3 class="heading settled" data-level="6.7" id="security-chooser-leakage"><span class="secno">6.7. </span><span class="content">Chooser Leakage</span><a class="self-link" href="#security-chooser-leakage"></a></h3>
    <p>If a user agent’s <a data-link-type="dfn" href="#credential-chooser" id="ref-for-credential-chooser①⓪">credential chooser</a> displays images supplied by an origin (for example, if a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤⑥">Credential</a></code> displays a site’s favicon), then, requests for these images MUST NOT be directly
  tied to instantiating the chooser in order to avoid leaking chooser usage. One option would be to
  fetch the images in the background when saving or updating a <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤⑦">Credential</a></code>, and to cache them for
  the lifetime of the <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤⑧">Credential</a></code>.</p>
    <p>These images MUST be fetched with the <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode">credentials mode</a> set to "<code>omit</code>", the <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#request-service-workers-mode" id="ref-for-request-service-workers-mode">service-workers mode</a> set to "<code>none</code>", the <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-request-client" id="ref-for-concept-request-client">client</a> set to <code>null</code>, the <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-request-initiator" id="ref-for-concept-request-initiator">initiator</a> set to the empty string, and the <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-request-destination" id="ref-for-concept-request-destination">destination</a> "<code>subresource</code>".</p>
    <p>Moreover, if the user agent allows the user to change either the name or icon associated with the
  credential, the alterations to the data SHOULD NOT be exposed to the website (consider a user who
  names two credentials for an origin "My fake account" and "My real account", for instance).</p>
    <h3 class="heading settled" data-level="6.8" id="security-local-data"><span class="secno">6.8. </span><span class="content">Locally Stored Data</span><a class="self-link" href="#security-local-data"></a></h3>
    <p>This API offers an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin①②">origin</a> the ability to store data persistently along with a user’s profile.
  Since most user agents treat credential data differently than "browsing data" (cookies, etc.)
  this might have the side effect of surprising a user who might believe that all traces of an
  origin have been wiped out when they clear their cookies.</p>
    <p>User agents SHOULD provide UI that makes it clear to a user that credential data is stored for an
  origin, and SHOULD make it easy for users to remove such data when they’re no longer interested in
  keeping it around.</p>
   </section>
   <section class="non-normative">
    <h2 class="heading settled" data-level="7" id="implementation"><span class="secno">7. </span><span class="content">Implementation Considerations</span><a class="self-link" href="#implementation"></a></h2>
    <p><em>This section is non-normative.</em></p>
    <h3 class="heading settled" data-level="7.1" id="implementation-authors"><span class="secno">7.1. </span><span class="content">Website Authors</span><a class="self-link" href="#implementation-authors"></a></h3>
    <p class="issue" id="issue-84808a53"><a class="self-link" href="#issue-84808a53"></a> Add some thoughts here about when and how the API
  should be used, especially with regard to <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation①④">mediation</a></code>. <a href="https://github.com/w3c/webappsec/issues/290">&lt;https://github.com/w3c/webappsec/issues/290></a></p>
    <p class="issue" id="issue-19b3ffaf"><a class="self-link" href="#issue-19b3ffaf"></a> Describe encoding restrictions of submitting credentials by <code class="idl"><a data-link-type="idl" href="https://fetch.spec.whatwg.org/#dom-global-fetch" id="ref-for-dom-global-fetch②">fetch()</a></code> with
  a <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#interface-formdata" id="ref-for-interface-formdata①">FormData</a></code> body.</p>
    <p>When performing feature detection for a given credential type, developers are encouraged to verify
  that the relevant <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑤⑨">Credential</a></code> specialization is present, rather than relying on the presence of <code>navigator.credentals</code>. The latter verifies the existence of the API itself, but does not ensure
  that the specific kind of credential necessary for a given site is supported. For example, if a
  given site requires passwords, checking <code>if (window.PasswordCredential)</code> is the most effective
  verification of support.</p>
    <h3 class="heading settled" data-level="7.2" id="implementation-extension"><span class="secno">7.2. </span><span class="content">Extension Points</span><a class="self-link" href="#implementation-extension"></a></h3>
    <p>This document provides a generic, high-level API that’s meant to be extended with specific types
  of <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①⑦">credentials</a> that serve specific authentication needs. Doing so is, hopefully,
  straightforward:</p>
    <ol>
     <li data-md>
      <p>Define a new interface that inherits from <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑥⓪">Credential</a></code>:</p>
      <div class="example" id="example-99055e03">
       <a class="self-link" href="#example-99055e03"></a> 
<pre>[Exposed=Window,
 SecureContext]
interface ExampleCredential : Credential {
  // Definition goes here.
};
</pre>
      </div>
     <li data-md>
      <p>Define appropriate <code class="idl"><a data-link-type="idl" href="#dom-credential-create-slot" id="ref-for-dom-credential-create-slot③">[[Create]](origin, options, sameOriginWithAncestors)</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-credential-collectfromcredentialstore-slot" id="ref-for-dom-credential-collectfromcredentialstore-slot③">[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-credential-discoverfromexternalsource-slot" id="ref-for-dom-credential-discoverfromexternalsource-slot⑤">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</a></code>, and <code class="idl"><a data-link-type="idl" href="#dom-credential-store-slot" id="ref-for-dom-credential-store-slot③">[[Store]](credential, sameOriginWithAncestors)</a></code> methods on <code>ExampleCredential</code>'s <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object①⑨">interface object</a>. <code class="idl"><a data-link-type="idl" href="#dom-credential-collectfromcredentialstore-slot" id="ref-for-dom-credential-collectfromcredentialstore-slot④">[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</a></code> is appropriate for <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①⑧">credentials</a> that remain <a data-link-type="dfn" href="#credential-effective" id="ref-for-credential-effective③">effective</a> forever and
  can therefore simply be copied out of the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②⑧">credential store</a>, while <code class="idl"><a data-link-type="idl" href="#dom-credential-discoverfromexternalsource-slot" id="ref-for-dom-credential-discoverfromexternalsource-slot⑥">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</a></code> is appropriate for <a data-link-type="dfn" href="#concept-credential" id="ref-for-concept-credential①⑨">credentials</a> that need to be re-generated from a <a data-link-type="dfn" href="#credential-source" id="ref-for-credential-source①">credential source</a>.</p>
      <p>Long-running operations, like those in <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/webauthn/#publickeycredential" id="ref-for-publickeycredential">PublicKeyCredential</a></code>'s <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/webauthn/#dom-publickeycredential-create-slot" id="ref-for-dom-publickeycredential-create-slot">[[Create]](origin, options, sameOriginWithAncestors)</a></code> and <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/webauthn/#dom-publickeycredential-discoverfromexternalsource-slot" id="ref-for-dom-publickeycredential-discoverfromexternalsource-slot">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</a></code> operations are encouraged to use <code>options.signal</code> to allow developers to abort
  the operation. See <a href="https://dom.spec.whatwg.org/#abortcontroller-api-integration">DOM §3.3 Using AbortController and AbortSignal objects in APIs</a> for detailed instructions.</p>
      <div class="example" id="example-aa966077">
       <a class="self-link" href="#example-aa966077"></a> <code>ExampleCredential</code>'s <code>[[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)</code> internal method is called
    with an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin⑨">origin</a> (<code>origin</code>), a CredentialRequestOptions
    object (<code>options</code>), and a boolean which is <code>true</code> iff the calling context is <a data-link-type="dfn" href="#same-origin-with-its-ancestors" id="ref-for-same-origin-with-its-ancestors①④">same-origin with its ancestors</a>.
    The algorithm returns a set of <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑥①">Credential</a></code> objects that match the options provided. If no matching <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑥②">Credential</a></code> objects are
    available, the returned set will be empty. 
       <ol>
        <li data-md>
         <p class="assertion">Assert: <code>options</code>[<code>example</code>] exists.</p>
        <li data-md>
         <p>If <code>options</code>[<code>example</code>] is not truthy, return the empty set.</p>
        <li data-md>
         <p>For each <i>credential</i> in the <a data-link-type="dfn" href="#concept-credential-store" id="ref-for-concept-credential-store②⑨">credential store</a>:</p>
         <ol>
          <li data-md>
           <p>...</p>
         </ol>
       </ol>
      </div>
     <li data-md>
      <p>Define the value of the <code>ExampleCredential</code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object②⓪">interface object</a>'s <code class="idl"><a data-link-type="idl" href="#dom-credential-type-slot" id="ref-for-dom-credential-type-slot⑤">[[type]]</a></code> slot:</p>
      <div class="example" id="example-b9aa85d8"><a class="self-link" href="#example-b9aa85d8"></a> The <code>ExampleCredential</code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object②①">interface object</a> has an internal slot named <code>[[type]]</code> whose
    value is the string "<code>example</code>". </div>
     <li data-md>
      <p>Define the value of the <code>ExampleCredential</code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object②②">interface object</a>'s <code class="idl"><a data-link-type="idl" href="#dom-credential-discovery-slot" id="ref-for-dom-credential-discovery-slot③">[[discovery]]</a></code> slot:</p>
      <div class="example" id="example-1ee7dd92"><a class="self-link" href="#example-1ee7dd92"></a> The <code>ExampleCredential</code> <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object" id="ref-for-dfn-interface-object②③">interface object</a> has an internal slot named <code>[[type]]</code> whose
    value is "<code class="idl"><a data-link-type="idl" href="#dom-credential-discovery-credential-store" id="ref-for-dom-credential-discovery-credential-store③">credential store</a></code>". </div>
     <li data-md>
      <p>Extend <code class="idl"><a data-link-type="idl" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①⑥">CredentialRequestOptions</a></code> with the options the new credential type needs to respond
  reasonably to <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get②⑤">get()</a></code>:</p>
      <div class="example" id="example-b76ecbfb">
       <a class="self-link" href="#example-b76ecbfb"></a> 
<pre>dictionary ExampleCredentialRequestOptions {
  // Definition goes here.
};

partial dictionary CredentialRequestOptions {
  ExampleCredentialRequestOptions example;
};
</pre>
      </div>
     <li data-md>
      <p>Extend <code class="idl"><a data-link-type="idl" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions①⓪">CredentialCreationOptions</a></code> with the data the new credential type needs to create <code>Credential</code> objects in response to <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-create" id="ref-for-dom-credentialscontainer-create⑦">create()</a></code>:</p>
      <div class="example" id="example-a3c18cc7">
       <a class="self-link" href="#example-a3c18cc7"></a> 
<pre>dictionary ExampleCredentialInit {
  // Definition goes here.
};

partial dictionary CredentialCreationOptions {
  ExampleCredentialInit example;
};
</pre>
      </div>
    </ol>
    <p>You might also find that new primitives are necessary. For instance, you might want to return
  many <code class="idl"><a data-link-type="idl" href="#credential" id="ref-for-credential⑥③">Credential</a></code> objects rather than just one in some sort of complicated, multi-factor
  sign-in process. That might be accomplished in a generic fashion by adding a <code>getAll()</code> method to <code class="idl"><a data-link-type="idl" href="#credentialscontainer" id="ref-for-credentialscontainer⑥">CredentialsContainer</a></code> which returned a <code>sequence&lt;Credential></code>, and defining a reasonable
  mechanism for dealing with requesting credentials of distinct types.</p>
    <p>For any such extension, we recommend getting in touch with <a href="mailto:public-webappsec@w3.org">public-webappsec@</a> for consultation and review.</p>
    <h3 class="heading settled" data-level="7.3" id="browser-extensions"><span class="secno">7.3. </span><span class="content">Browser Extensions</span><a class="self-link" href="#browser-extensions"></a></h3>
    <p>Ideally, user agents that implement an extension system of some sort will
  allow third-parties to hook into these API endpoints in order to improve
  the behavior of third party credential management software in the same way
  that user agents can improve their own via this imperative approach.</p>
    <p>This could range from a complex new API that the user agent mediates, or
  simply by allowing extensions to overwrite the <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get②⑥">get()</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store①③">store()</a></code> endpoints for their own purposes.</p>
   </section>
   <section>
    <h2 class="heading settled" data-level="8" id="teh-futur"><span class="secno">8. </span><span class="content">Future Work</span><a class="self-link" href="#teh-futur"></a></h2>
    <p><em>This section is non-normative.</em></p>
    <p>The API defined here does the bare minimum to expose user agent’s credential managers to the web,
  and allows the web to help those credential managers understand when federated identity providers
  are in use. The next logical step will be along the lines sketched in documents like <a data-link-type="biblio" href="#biblio-web-login">[WEB-LOGIN]</a> (and, to some extent, Mozilla’s BrowserID <a data-link-type="biblio" href="#biblio-browserid">[BROWSERID]</a>).</p>
    <p>The user agent is in the unique position of being able to effectively mediate the relationship
  between users, identity providers, and websites. If the user agent can remove some of the risk and
  confusion associated with the typical authentication flows, users will be in a significantly
  better position than today.</p>
    <p>A natural way to expose this information might be to extend the <code class="idl"><a data-link-type="idl" href="#federatedcredential" id="ref-for-federatedcredential①④">FederatedCredential</a></code> interface
  with properties like authentication tokens, and possibly to add some form of manifest format with
  properties that declare the authentication type which the provider supports.</p>
    <p>The API described here is designed to be extensible enough to support use cases that require user
  interaction, perhaps with websites other than the one which requested credentials. We hope that
  the Promise-based system we’ve settled on is extensible enough to support these kinds of
  asynchronous flows which could require some level of interaction between multiple browsing
  contexts (e.g. mediated activity on <code>idp.com</code> might resolve a Promise handed back to <code>rp.com</code>) or between devices and user agents (e.g. <a data-link-type="biblio" href="#biblio-webauthn">[WEBAUTHN]</a>) in the future without
  redesigning the API from the ground up.</p>
    <p>Baby steps.</p>
   </section>
  </main>
  <h2 class="no-ref no-num heading settled" id="conformance"><span class="content">Conformance</span><a class="self-link" href="#conformance"></a></h2>
  <h3 class="no-ref no-num heading settled" id="conventions"><span class="content">Document conventions</span><a class="self-link" href="#conventions"></a></h3>
  <p>Conformance requirements are expressed with a combination of
    descriptive assertions and RFC 2119 terminology. The key words “MUST”,
    “MUST NOT”, “REQUIRED”, “SHALL”, “SHALL NOT”, “SHOULD”, “SHOULD NOT”,
    “RECOMMENDED”, “MAY”, and “OPTIONAL” in the normative parts of this
    document are to be interpreted as described in RFC 2119.
    However, for readability, these words do not appear in all uppercase
    letters in this specification. </p>
  <p>All of the text of this specification is normative except sections
    explicitly marked as non-normative, examples, and notes. <a data-link-type="biblio" href="#biblio-rfc2119">[RFC2119]</a></p>
  <p>Examples in this specification are introduced with the words “for example”
    or are set apart from the normative text with <code>class="example"</code>,
    like this: </p>
  <div class="example" id="example-ae2b6bc0">
   <a class="self-link" href="#example-ae2b6bc0"></a> 
   <p>This is an example of an informative example.</p>
  </div>
  <p>Informative notes begin with the word “Note” and are set apart from the
    normative text with <code>class="note"</code>, like this: </p>
  <p class="note" role="note">Note, this is an informative note.</p>
  <h3 class="no-ref no-num heading settled" id="conformant-algorithms"><span class="content">Conformant Algorithms</span><a class="self-link" href="#conformant-algorithms"></a></h3>
  <p>Requirements phrased in the imperative as part of algorithms (such as
    "strip any leading space characters" or "return false and abort these
    steps") are to be interpreted with the meaning of the key word ("must",
    "should", "may", etc) used in introducing the algorithm.</p>
  <p>Conformance requirements phrased as algorithms or specific steps can be
    implemented in any manner, so long as the end result is equivalent. In
    particular, the algorithms defined in this specification are intended to
    be easy to understand and are not intended to be performant. Implementers
    are encouraged to optimize.</p>
<script src="https://www.w3.org/scripts/TR/2016/fixup.js"></script>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#abstract-opdef-ask-the-user-to-choose-a-credential">ask the user to choose a Credential</a><span>, in §5.3</span>
   <li><a href="#abstract-opdef-ask-the-user-to-choose-a-credential">ask to choose</a><span>, in §5.3</span>
   <li><a href="#abstract-opdef-collect-credentials-from-the-credential-store">collect Credentials from the credential store</a><span>, in §2.5.2</span>
   <li>
    [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors)
    <ul>
     <li><a href="#dom-credential-collectfromcredentialstore-slot">method for Credential</a><span>, in §2.2.1.1</span>
     <li><a href="#dom-federatedcredential-collectfromcredentialstore-slot">method for FederatedCredential</a><span>, in §4.2.1</span>
     <li><a href="#dom-passwordcredential-collectfromcredentialstore-slot">method for PasswordCredential</a><span>, in §3.3.1</span>
    </ul>
   <li><a href="#abstract-opdef-collect-credentials-from-the-credential-store">collect local</a><span>, in §2.5.2</span>
   <li>
    constructor(data)
    <ul>
     <li><a href="#dom-federatedcredential-federatedcredential">constructor for FederatedCredential</a><span>, in §4.1</span>
     <li><a href="#dom-passwordcredential-passwordcredential-data">constructor for PasswordCredential</a><span>, in §3.2</span>
    </ul>
   <li><a href="#dom-passwordcredential-passwordcredential">constructor(form)</a><span>, in §3.2</span>
   <li><a href="#dom-credentialscontainer-create">create()</a><span>, in §2.3</span>
   <li><a href="#abstract-opdef-create-a-credential">Create a Credential</a><span>, in §2.5.4</span>
   <li><a href="#abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit">Create a FederatedCredential from FederatedCredentialInit</a><span>, in §4.2.4</span>
   <li><a href="#abstract-opdef-create-a-passwordcredential-from-an-htmlformelement">Create a PasswordCredential from an HTMLFormElement</a><span>, in §3.3.4</span>
   <li><a href="#abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata">Create a PasswordCredential from PasswordCredentialData</a><span>, in §3.3.5</span>
   <li><a href="#dom-credentialscontainer-create">create(options)</a><span>, in §2.3</span>
   <li>
    [[Create]](origin, options, sameOriginWithAncestors)
    <ul>
     <li><a href="#dom-credential-create-slot">method for Credential</a><span>, in §2.2.1.4</span>
     <li><a href="#dom-federatedcredential-create-slot">method for FederatedCredential</a><span>, in §4.2.2</span>
     <li><a href="#dom-passwordcredential-create-slot">method for PasswordCredential</a><span>, in §3.3.2</span>
    </ul>
   <li><a href="#credential">Credential</a><span>, in §2.2</span>
   <li><a href="#concept-credential">credential</a><span>, in §2</span>
   <li><a href="#credential-chooser">credential chooser</a><span>, in §5.3</span>
   <li><a href="#dictdef-credentialcreationoptions">CredentialCreationOptions</a><span>, in §2.4</span>
   <li><a href="#dictdef-credentialdata">CredentialData</a><span>, in §2.3</span>
   <li><a href="#enumdef-credentialmediationrequirement">CredentialMediationRequirement</a><span>, in §2.3.2</span>
   <li><a href="#dictdef-credentialrequestoptions">CredentialRequestOptions</a><span>, in §2.3.1</span>
   <li><a href="#dom-navigator-credentials">credentials</a><span>, in §2.3</span>
   <li><a href="#credentialscontainer">CredentialsContainer</a><span>, in §2.3</span>
   <li><a href="#credential-source">credential source</a><span>, in §2</span>
   <li>
    credential store
    <ul>
     <li><a href="#concept-credential-store">definition of</a><span>, in §2.1</span>
     <li><a href="#dom-credential-discovery-credential-store">enum-value for Credential/[[discovery]]</a><span>, in §2.2</span>
    </ul>
   <li><a href="#credential-credential-type">credential type</a><span>, in §2.2</span>
   <li><a href="#credentialuserdata">CredentialUserData</a><span>, in §2.2.2</span>
   <li><a href="#dom-credential-discoverfromexternalsource-slot">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</a><span>, in §2.2.1.2</span>
   <li><a href="#dom-credential-discovery-slot">[[discovery]]</a><span>, in §2.2</span>
   <li><a href="#credential-effective">effective</a><span>, in §2</span>
   <li>
    federated
    <ul>
     <li><a href="#dom-federatedcredential-federated">const for FederatedCredential</a><span>, in §4.1</span>
     <li><a href="#dom-credentialcreationoptions-federated">dict-member for CredentialCreationOptions</a><span>, in §4.1</span>
     <li><a href="#dom-credentialrequestoptions-federated">dict-member for CredentialRequestOptions</a><span>, in §4.1</span>
    </ul>
   <li><a href="#federatedcredential">FederatedCredential</a><span>, in §4.1</span>
   <li><a href="#dom-federatedcredential-federatedcredential">FederatedCredential(data)</a><span>, in §4.1</span>
   <li><a href="#dictdef-federatedcredentialinit">FederatedCredentialInit</a><span>, in §4.1</span>
   <li><a href="#dictdef-federatedcredentialrequestoptions">FederatedCredentialRequestOptions</a><span>, in §4.1</span>
   <li><a href="#dom-credentialscontainer-get">get()</a><span>, in §2.3</span>
   <li><a href="#dom-credentialscontainer-get">get(options)</a><span>, in §2.3</span>
   <li>
    iconURL
    <ul>
     <li><a href="#dom-credentialuserdata-iconurl">attribute for CredentialUserData</a><span>, in §2.2.2</span>
     <li><a href="#dom-federatedcredentialinit-iconurl">dict-member for FederatedCredentialInit</a><span>, in §4.1</span>
     <li><a href="#dom-passwordcredentialdata-iconurl">dict-member for PasswordCredentialData</a><span>, in §3.2</span>
    </ul>
   <li>
    id
    <ul>
     <li><a href="#dom-credential-id">attribute for Credential</a><span>, in §2.2</span>
     <li><a href="#dom-credentialdata-id">dict-member for CredentialData</a><span>, in §2.3</span>
    </ul>
   <li><a href="#credentialrequestoptions-matchable-a-priori">matchable a priori</a><span>, in §2.3.1</span>
   <li><a href="#dom-credentialrequestoptions-mediation">mediation</a><span>, in §2.3.1</span>
   <li><a href="#abstract-opdef-credential-store-modify-a-credential">Modify a credential</a><span>, in §2.1</span>
   <li>
    name
    <ul>
     <li><a href="#dom-credentialuserdata-name">attribute for CredentialUserData</a><span>, in §2.2.2</span>
     <li><a href="#dom-federatedcredentialinit-name">dict-member for FederatedCredentialInit</a><span>, in §4.1</span>
     <li><a href="#dom-passwordcredentialdata-name">dict-member for PasswordCredentialData</a><span>, in §3.2</span>
    </ul>
   <li><a href="#dom-credentialmediationrequirement-optional">optional</a><span>, in §2.3.2</span>
   <li><a href="#dom-credentialmediationrequirement-optional">"optional"</a><span>, in §2.3.2</span>
   <li>
    origin
    <ul>
     <li><a href="#dom-federatedcredentialinit-origin">dict-member for FederatedCredentialInit</a><span>, in §4.1</span>
     <li><a href="#dom-passwordcredentialdata-origin">dict-member for PasswordCredentialData</a><span>, in §3.2</span>
    </ul>
   <li><a href="#dom-credential-origin-slot">[[origin]]</a><span>, in §2.2</span>
   <li><a href="#credential-origin-bound">origin bound</a><span>, in §2.2</span>
   <li>
    password
    <ul>
     <li><a href="#dom-passwordcredential-password">attribute for PasswordCredential</a><span>, in §3.2</span>
     <li><a href="#dom-credential-type-password">const for Credential/[[type]]</a><span>, in §3.2</span>
     <li><a href="#dom-credentialcreationoptions-password">dict-member for CredentialCreationOptions</a><span>, in §3.2</span>
     <li><a href="#dom-credentialrequestoptions-password">dict-member for CredentialRequestOptions</a><span>, in §3.2</span>
     <li><a href="#dom-passwordcredentialdata-password">dict-member for PasswordCredentialData</a><span>, in §3.2</span>
    </ul>
   <li><a href="#passwordcredential">PasswordCredential</a><span>, in §3.2</span>
   <li><a href="#dom-passwordcredential-passwordcredential-data">PasswordCredential(data)</a><span>, in §3.2</span>
   <li><a href="#dictdef-passwordcredentialdata">PasswordCredentialData</a><span>, in §3.2</span>
   <li><a href="#dom-passwordcredential-passwordcredential">PasswordCredential(form)</a><span>, in §3.2</span>
   <li><a href="#typedefdef-passwordcredentialinit">PasswordCredentialInit</a><span>, in §3.2</span>
   <li><a href="#dom-credentialscontainer-preventsilentaccess">preventSilentAccess()</a><span>, in §2.3</span>
   <li><a href="#abstract-opdef-prevent-silent-access">Prevent Silent Access</a><span>, in §2.5.5</span>
   <li><a href="#origin-prevent-silent-access-flag">prevent silent access flag</a><span>, in §2.1</span>
   <li>
    protocol
    <ul>
     <li><a href="#dom-federatedcredential-protocol">attribute for FederatedCredential</a><span>, in §4.1</span>
     <li><a href="#dom-federatedcredentialinit-protocol">dict-member for FederatedCredentialInit</a><span>, in §4.1</span>
    </ul>
   <li><a href="#dom-federatedcredentialrequestoptions-protocols">protocols</a><span>, in §4.1</span>
   <li>
    provider
    <ul>
     <li><a href="#dom-federatedcredential-provider">attribute for FederatedCredential</a><span>, in §4.1</span>
     <li><a href="#dom-federatedcredentialinit-provider">dict-member for FederatedCredentialInit</a><span>, in §4.1</span>
    </ul>
   <li><a href="#dom-federatedcredentialrequestoptions-providers">providers</a><span>, in §4.1</span>
   <li><a href="#credentialrequestoptions-relevant-credential-interface-objects">relevant credential interface objects</a><span>, in §2.3.1</span>
   <li><a href="#dom-credential-discovery-remote">remote</a><span>, in §2.2</span>
   <li><a href="#abstract-opdef-request-a-credential">Request a Credential</a><span>, in §2.5.1</span>
   <li><a href="#dom-credentialmediationrequirement-required">required</a><span>, in §2.3.2</span>
   <li><a href="#dom-credentialmediationrequirement-required">"required"</a><span>, in §2.3.2</span>
   <li><a href="#origin-requires-user-mediation">requires user mediation</a><span>, in §2.1</span>
   <li><a href="#abstract-opdef-credential-store-retrieve-a-list-of-credentials">Retrieve a list of credentials</a><span>, in §2.1</span>
   <li><a href="#same-origin-with-its-ancestors">same-origin with its ancestors</a><span>, in §2.1</span>
   <li>
    signal
    <ul>
     <li><a href="#dom-credentialcreationoptions-signal">dict-member for CredentialCreationOptions</a><span>, in §2.4</span>
     <li><a href="#dom-credentialrequestoptions-signal">dict-member for CredentialRequestOptions</a><span>, in §2.3.1</span>
    </ul>
   <li><a href="#dom-credentialmediationrequirement-silent">silent</a><span>, in §2.3.2</span>
   <li><a href="#dom-credentialmediationrequirement-silent">"silent"</a><span>, in §2.3.2</span>
   <li><a href="#dom-credentialscontainer-store">store()</a><span>, in §2.3</span>
   <li><a href="#abstract-opdef-credential-store-store-a-credential">Store a credential</a><span>, in §2.1</span>
   <li><a href="#abstract-opdef-store-a-credential">Store a Credential</a><span>, in §2.5.3</span>
   <li><a href="#dom-credentialscontainer-store">store(credential)</a><span>, in §2.3</span>
   <li>
    [[Store]](credential, sameOriginWithAncestors)
    <ul>
     <li><a href="#dom-credential-store-slot">method for Credential</a><span>, in §2.2.1.3</span>
     <li><a href="#dom-federatedcredential-store-slot">method for FederatedCredential</a><span>, in §4.2.3</span>
     <li><a href="#dom-passwordcredential-store-slot">method for PasswordCredential</a><span>, in §3.3.3</span>
    </ul>
   <li><a href="#dom-credential-type">type</a><span>, in §2.2</span>
   <li><a href="#dom-credential-type-slot">[[type]]</a><span>, in §2.2</span>
   <li><a href="#user-mediated">user mediated</a><span>, in §5</span>
   <li><a href="#user-mediated">user mediation</a><span>, in §5</span>
  </ul>
  <aside class="dfn-panel" data-for="term-for-abortsignal">
   <a href="https://dom.spec.whatwg.org/#abortsignal">https://dom.spec.whatwg.org/#abortsignal</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abortsignal">2.3.1. The CredentialRequestOptions Dictionary</a> <a href="#ref-for-abortsignal①">(2)</a>
    <li><a href="#ref-for-abortsignal②">2.4. The CredentialCreationOptions Dictionary</a> <a href="#ref-for-abortsignal③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-abortsignal-aborted-flag">
   <a href="https://dom.spec.whatwg.org/#abortsignal-aborted-flag">https://dom.spec.whatwg.org/#abortsignal-aborted-flag</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abortsignal-aborted-flag">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-abortsignal-aborted-flag①">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-context-object">
   <a href="https://dom.spec.whatwg.org/#context-object">https://dom.spec.whatwg.org/#context-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-context-object">2.3. navigator.credentials</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-tree-order">
   <a href="https://dom.spec.whatwg.org/#concept-tree-order">https://dom.spec.whatwg.org/#concept-tree-order</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-tree-order">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sec-ordinary-object-internal-methods-and-internal-slots">
   <a href="https://tc39.github.io/ecma262/#sec-ordinary-object-internal-methods-and-internal-slots">https://tc39.github.io/ecma262/#sec-ordinary-object-internal-methods-and-internal-slots</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-ordinary-object-internal-methods-and-internal-slots">2.2.1. Credential Internal Methods</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-response">
   <a href="https://fetch.spec.whatwg.org/#response">https://fetch.spec.whatwg.org/#response</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-response">3.1.2. Post-sign-in Confirmation</a>
    <li><a href="#ref-for-response①">3.1.3. Change Password</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-request-client">
   <a href="https://fetch.spec.whatwg.org/#concept-request-client">https://fetch.spec.whatwg.org/#concept-request-client</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-client">6.7. Chooser Leakage</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-request-credentials-mode">
   <a href="https://fetch.spec.whatwg.org/#concept-request-credentials-mode">https://fetch.spec.whatwg.org/#concept-request-credentials-mode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-credentials-mode">6.7. Chooser Leakage</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-request-destination">
   <a href="https://fetch.spec.whatwg.org/#concept-request-destination">https://fetch.spec.whatwg.org/#concept-request-destination</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-destination">6.7. Chooser Leakage</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-global-fetch">
   <a href="https://fetch.spec.whatwg.org/#dom-global-fetch">https://fetch.spec.whatwg.org/#dom-global-fetch</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-global-fetch">3.1.2. Post-sign-in Confirmation</a>
    <li><a href="#ref-for-dom-global-fetch①">6.2. Credential Leakage</a>
    <li><a href="#ref-for-dom-global-fetch②">7.1. Website Authors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-request-initiator">
   <a href="https://fetch.spec.whatwg.org/#concept-request-initiator">https://fetch.spec.whatwg.org/#concept-request-initiator</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-initiator">6.7. Chooser Leakage</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-request-service-workers-mode">
   <a href="https://fetch.spec.whatwg.org/#request-service-workers-mode">https://fetch.spec.whatwg.org/#request-service-workers-mode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-request-service-workers-mode">6.7. Chooser Leakage</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-htmlformelement">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement">https://html.spec.whatwg.org/multipage/forms.html#htmlformelement</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-htmlformelement">3.1.2. Post-sign-in Confirmation</a>
    <li><a href="#ref-for-htmlformelement①">3.1.3. Change Password</a>
    <li><a href="#ref-for-htmlformelement②">3.2. The PasswordCredential Interface</a> <a href="#ref-for-htmlformelement③">(2)</a> <a href="#ref-for-htmlformelement④">(3)</a> <a href="#ref-for-htmlformelement⑤">(4)</a>
    <li><a href="#ref-for-htmlformelement⑥">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-htmlformelement⑦">(2)</a>
    <li><a href="#ref-for-htmlformelement⑧">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-navigator">
   <a href="https://html.spec.whatwg.org/multipage/system-state.html#navigator">https://html.spec.whatwg.org/multipage/system-state.html#navigator</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-navigator">2.3. navigator.credentials</a> <a href="#ref-for-navigator①">(2)</a> <a href="#ref-for-navigator②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-worker">
   <a href="https://html.spec.whatwg.org/multipage/workers.html#worker">https://html.spec.whatwg.org/multipage/workers.html#worker</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-worker">6.4. Origin Confusion</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-active-document">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#active-document">https://html.spec.whatwg.org/multipage/browsers.html#active-document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-active-document">2.1. Infrastructure</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-serialisation-of-an-origin">
   <a href="https://html.spec.whatwg.org/multipage/origin.html#ascii-serialisation-of-an-origin">https://html.spec.whatwg.org/multipage/origin.html#ascii-serialisation-of-an-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-serialisation-of-an-origin">4.1.1. Identifying Providers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-attr-fe-autocomplete">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete">https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-attr-fe-autocomplete">1. Introduction</a>
    <li><a href="#ref-for-attr-fe-autocomplete①">3.1.2. Post-sign-in Confirmation</a> <a href="#ref-for-attr-fe-autocomplete②">(2)</a> <a href="#ref-for-attr-fe-autocomplete③">(3)</a>
    <li><a href="#ref-for-attr-fe-autocomplete④">3.1.3. Change Password</a> <a href="#ref-for-attr-fe-autocomplete⑤">(2)</a> <a href="#ref-for-attr-fe-autocomplete⑥">(3)</a>
    <li><a href="#ref-for-attr-fe-autocomplete⑦">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a> <a href="#ref-for-attr-fe-autocomplete⑧">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-autofill-detail-tokens">
   <a href="https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill-detail-tokens">https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill-detail-tokens</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-autofill-detail-tokens">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-current-settings-object">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object">https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-current-settings-object">2.3. navigator.credentials</a>
    <li><a href="#ref-for-current-settings-object①">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-current-settings-object②">2.5.1. Request a Credential</a> <a href="#ref-for-current-settings-object③">(2)</a>
    <li><a href="#ref-for-current-settings-object④">2.5.3. Store a Credential</a> <a href="#ref-for-current-settings-object⑤">(2)</a>
    <li><a href="#ref-for-current-settings-object⑥">2.5.4. Create a Credential</a> <a href="#ref-for-current-settings-object⑦">(2)</a>
    <li><a href="#ref-for-current-settings-object⑧">3.2. The PasswordCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-attr-fe-autocomplete-current-password">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-current-password">https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-current-password</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-attr-fe-autocomplete-current-password">3.1.2. Post-sign-in Confirmation</a>
    <li><a href="#ref-for-attr-fe-autocomplete-current-password①">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-manipulation-task-source">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#dom-manipulation-task-source">https://html.spec.whatwg.org/multipage/webappapis.html#dom-manipulation-task-source</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-manipulation-task-source">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-environment-settings-object">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object">https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-environment-settings-object">2.1. Infrastructure</a>
    <li><a href="#ref-for-environment-settings-object①">2.2.1.1. [[CollectFromCredentialStore]] internal method</a>
    <li><a href="#ref-for-environment-settings-object②">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-environment-settings-object③">2.2.1.3. [[Store]] internal method</a>
    <li><a href="#ref-for-environment-settings-object④">2.2.1.4. [[Create]] internal method</a>
    <li><a href="#ref-for-environment-settings-object⑤">2.5.5. Prevent Silent Access</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-the-form-element">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#the-form-element">https://html.spec.whatwg.org/multipage/forms.html#the-form-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-form-element">3.1.1. Password-based Sign-in</a> <a href="#ref-for-the-form-element①">(2)</a>
    <li><a href="#ref-for-the-form-element②">6.2. Credential Leakage</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-form-owner">
   <a href="https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#form-owner">https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#form-owner</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-form-owner">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-settings-object-global">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global">https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-settings-object-global">2.2.1.4. [[Create]] internal method</a>
    <li><a href="#ref-for-concept-settings-object-global①">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-concept-settings-object-global②">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-in-parallel">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel">https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-in-parallel">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-in-parallel①">2.2.1.3. [[Store]] internal method</a>
    <li><a href="#ref-for-in-parallel②">2.2.1.4. [[Create]] internal method</a>
    <li><a href="#ref-for-in-parallel③">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-in-parallel④">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-in-parallel⑤">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-in-parallel⑥">2.5.5. Prevent Silent Access</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-attr-fe-name">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-name">https://html.spec.whatwg.org/multipage/forms.html#attr-fe-name</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-attr-fe-name">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-attr-fe-autocomplete-new-password">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-new-password">https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-new-password</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-attr-fe-autocomplete-new-password">3.1.3. Change Password</a>
    <li><a href="#ref-for-attr-fe-autocomplete-new-password①">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-attr-fe-autocomplete-nickname">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-nickname">https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-nickname</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-attr-fe-autocomplete-nickname">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-settings-object-origin">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin">https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-settings-object-origin">2.1. Infrastructure</a>
    <li><a href="#ref-for-concept-settings-object-origin①">2.2.1.1. [[CollectFromCredentialStore]] internal method</a>
    <li><a href="#ref-for-concept-settings-object-origin②">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-concept-settings-object-origin③">2.2.1.4. [[Create]] internal method</a>
    <li><a href="#ref-for-concept-settings-object-origin④">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-concept-settings-object-origin⑤">2.5.2. Collect Credentials from the credential store</a>
    <li><a href="#ref-for-concept-settings-object-origin⑥">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-concept-settings-object-origin⑦">2.5.5. Prevent Silent Access</a>
    <li><a href="#ref-for-concept-settings-object-origin⑧">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-concept-settings-object-origin⑨">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-parent-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#parent-browsing-context">https://html.spec.whatwg.org/multipage/browsers.html#parent-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parent-browsing-context">2.1. Infrastructure</a> <a href="#ref-for-parent-browsing-context①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-attr-fe-autocomplete-photo">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-photo">https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-photo</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-attr-fe-autocomplete-photo">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-queue-a-task">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#queue-a-task">https://html.spec.whatwg.org/multipage/webappapis.html#queue-a-task</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-queue-a-task">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-relevant-realm">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-relevant-realm">https://html.spec.whatwg.org/multipage/webappapis.html#concept-relevant-realm</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-relevant-realm">2.3. navigator.credentials</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-responsible-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context">https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-responsible-browsing-context">2.1. Infrastructure</a> <a href="#ref-for-responsible-browsing-context①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-responsible-document">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-document">https://html.spec.whatwg.org/multipage/webappapis.html#responsible-document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-responsible-document">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-same-origin">
   <a href="https://html.spec.whatwg.org/multipage/origin.html#same-origin">https://html.spec.whatwg.org/multipage/origin.html#same-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-same-origin">2.1. Infrastructure</a>
    <li><a href="#ref-for-same-origin①">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-same-origin②">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-same-origin③">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-same-origin④">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-form-submit">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#dom-form-submit">https://html.spec.whatwg.org/multipage/forms.html#dom-form-submit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-form-submit">3.1.1. Password-based Sign-in</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-category-submit">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#category-submit">https://html.spec.whatwg.org/multipage/forms.html#category-submit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-category-submit">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-category-submit①">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-task">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-task">https://html.spec.whatwg.org/multipage/webappapis.html#concept-task</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-task">2.2.1.4. [[Create]] internal method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-top-level-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#top-level-browsing-context">https://html.spec.whatwg.org/multipage/browsers.html#top-level-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-top-level-browsing-context">6.4. Origin Confusion</a> <a href="#ref-for-top-level-browsing-context①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-attr-fe-autocomplete-username">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-username">https://html.spec.whatwg.org/multipage/forms.html#attr-fe-autocomplete-username</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-attr-fe-autocomplete-username">3.1.2. Post-sign-in Confirmation</a>
    <li><a href="#ref-for-attr-fe-autocomplete-username①">3.1.3. Change Password</a>
    <li><a href="#ref-for-attr-fe-autocomplete-username②">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-set-append">
   <a href="https://infra.spec.whatwg.org/#set-append">https://infra.spec.whatwg.org/#set-append</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-set-append">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-set-append①">2.5.2. Collect Credentials from the credential store</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-case-insensitive">
   <a href="https://infra.spec.whatwg.org/#ascii-case-insensitive">https://infra.spec.whatwg.org/#ascii-case-insensitive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-case-insensitive">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-contain">
   <a href="https://infra.spec.whatwg.org/#list-contain">https://infra.spec.whatwg.org/#list-contain</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-contain">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-list-contain①">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-list-contain②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-iteration-continue">
   <a href="https://infra.spec.whatwg.org/#iteration-continue">https://infra.spec.whatwg.org/#iteration-continue</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-iteration-continue">2.3.1. The CredentialRequestOptions Dictionary</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-map-exists">
   <a href="https://infra.spec.whatwg.org/#map-exists">https://infra.spec.whatwg.org/#map-exists</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-map-exists">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-map-exists①">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-map-exists②">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-map-exists③">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-map-exists④">(2)</a> <a href="#ref-for-map-exists⑤">(3)</a>
    <li><a href="#ref-for-map-exists⑥">4.2.2. 
    FederatedCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ordered-set">
   <a href="https://infra.spec.whatwg.org/#ordered-set">https://infra.spec.whatwg.org/#ordered-set</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ordered-set">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-size">
   <a href="https://infra.spec.whatwg.org/#list-size">https://infra.spec.whatwg.org/#list-size</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-size">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-list-size①">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-a-priori-authenticated-url">
   <a href="https://w3c.github.io/webappsec-mixed-content/#a-priori-authenticated-url">https://w3c.github.io/webappsec-mixed-content/#a-priori-authenticated-url</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-a-priori-authenticated-url">2.2.2. CredentialUserData Mixin</a>
    <li><a href="#ref-for-a-priori-authenticated-url①">6.3. Insecure Sites</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-">
   <a href="https://publicsuffix.org/list/#">https://publicsuffix.org/list/#</a><b>Referenced in:</b>
   <ul>
    <li><a href="#termref-for-">6.1. Cross-domain credential access</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-secure-contexts">
   <a href="https://w3c.github.io/webappsec-secure-contexts/#secure-contexts">https://w3c.github.io/webappsec-secure-contexts/#secure-contexts</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-secure-contexts">2.3. navigator.credentials</a>
    <li><a href="#ref-for-secure-contexts①">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-secure-contexts②">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-secure-contexts③">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-secure-contexts④">6.3. Insecure Sites</a> <a href="#ref-for-secure-contexts⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-publickeycredential">
   <a href="https://w3c.github.io/webauthn/#publickeycredential">https://w3c.github.io/webauthn/#publickeycredential</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-publickeycredential">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-publickeycredential-create-slot">
   <a href="https://w3c.github.io/webauthn/#dom-publickeycredential-create-slot">https://w3c.github.io/webauthn/#dom-publickeycredential-create-slot</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-publickeycredential-create-slot">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-publickeycredential-discoverfromexternalsource-slot">
   <a href="https://w3c.github.io/webauthn/#dom-publickeycredential-discoverfromexternalsource-slot">https://w3c.github.io/webauthn/#dom-publickeycredential-discoverfromexternalsource-slot</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-publickeycredential-discoverfromexternalsource-slot">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-aborterror">
   <a href="https://heycam.github.io/webidl/#aborterror">https://heycam.github.io/webidl/#aborterror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-aborterror">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-aborterror①">2.4. The CredentialCreationOptions Dictionary</a>
    <li><a href="#ref-for-aborterror②">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-aborterror③">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-DOMException">
   <a href="https://heycam.github.io/webidl/#idl-DOMException">https://heycam.github.io/webidl/#idl-DOMException</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-DOMException">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-idl-DOMException①">2.4. The CredentialCreationOptions Dictionary</a>
    <li><a href="#ref-for-idl-DOMException②">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-idl-DOMException③">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-idl-DOMException④">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-idl-DOMException⑤">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-idl-DOMException⑥">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-idl-DOMException⑦">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-DOMString">
   <a href="https://heycam.github.io/webidl/#idl-DOMString">https://heycam.github.io/webidl/#idl-DOMString</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-DOMString">2.2. The Credential Interface</a> <a href="#ref-for-idl-DOMString①">(2)</a>
    <li><a href="#ref-for-idl-DOMString②">4.1. The FederatedCredential Interface</a> <a href="#ref-for-idl-DOMString③">(2)</a> <a href="#ref-for-idl-DOMString④">(3)</a> <a href="#ref-for-idl-DOMString⑤">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">2.2. The Credential Interface</a>
    <li><a href="#ref-for-Exposed①">2.3. navigator.credentials</a>
    <li><a href="#ref-for-Exposed②">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-Exposed③">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-notallowederror">
   <a href="https://heycam.github.io/webidl/#notallowederror">https://heycam.github.io/webidl/#notallowederror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-notallowederror">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-notallowederror①">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-notallowederror②">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-notallowederror③">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-promise">
   <a href="https://heycam.github.io/webidl/#idl-promise">https://heycam.github.io/webidl/#idl-promise</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-promise">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-idl-promise①">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-idl-promise②">2.5.4. Create a Credential</a> <a href="#ref-for-idl-promise③">(2)</a>
    <li><a href="#ref-for-idl-promise④">2.5.5. Prevent Silent Access</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-SameObject">
   <a href="https://heycam.github.io/webidl/#SameObject">https://heycam.github.io/webidl/#SameObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-SameObject">2.3. navigator.credentials</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-SecureContext">
   <a href="https://heycam.github.io/webidl/#SecureContext">https://heycam.github.io/webidl/#SecureContext</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-SecureContext">2.2. The Credential Interface</a>
    <li><a href="#ref-for-SecureContext①">2.2.2. CredentialUserData Mixin</a>
    <li><a href="#ref-for-SecureContext②">2.3. navigator.credentials</a> <a href="#ref-for-SecureContext③">(2)</a>
    <li><a href="#ref-for-SecureContext④">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-SecureContext⑤">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-exceptiondef-typeerror">
   <a href="https://heycam.github.io/webidl/#exceptiondef-typeerror">https://heycam.github.io/webidl/#exceptiondef-typeerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-exceptiondef-typeerror">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-exceptiondef-typeerror①">2.2.1.4. [[Create]] internal method</a>
    <li><a href="#ref-for-exceptiondef-typeerror②">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-exceptiondef-typeerror③">(2)</a>
    <li><a href="#ref-for-exceptiondef-typeerror④">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
    <li><a href="#ref-for-exceptiondef-typeerror⑤">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-USVString">
   <a href="https://heycam.github.io/webidl/#idl-USVString">https://heycam.github.io/webidl/#idl-USVString</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-USVString">2.2. The Credential Interface</a> <a href="#ref-for-idl-USVString①">(2)</a>
    <li><a href="#ref-for-idl-USVString②">2.2.2. CredentialUserData Mixin</a> <a href="#ref-for-idl-USVString③">(2)</a> <a href="#ref-for-idl-USVString④">(3)</a> <a href="#ref-for-idl-USVString⑤">(4)</a>
    <li><a href="#ref-for-idl-USVString⑥">2.3. navigator.credentials</a>
    <li><a href="#ref-for-idl-USVString⑦">3.2. The PasswordCredential Interface</a> <a href="#ref-for-idl-USVString⑧">(2)</a> <a href="#ref-for-idl-USVString⑨">(3)</a> <a href="#ref-for-idl-USVString①⓪">(4)</a> <a href="#ref-for-idl-USVString①①">(5)</a> <a href="#ref-for-idl-USVString①②">(6)</a>
    <li><a href="#ref-for-idl-USVString①③">4.1. The FederatedCredential Interface</a> <a href="#ref-for-idl-USVString①④">(2)</a> <a href="#ref-for-idl-USVString①⑤">(3)</a> <a href="#ref-for-idl-USVString①⑥">(4)</a> <a href="#ref-for-idl-USVString①⑦">(5)</a> <a href="#ref-for-idl-USVString①⑧">(6)</a> <a href="#ref-for-idl-USVString①⑨">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-a-new-promise">
   <a href="https://heycam.github.io/webidl/#a-new-promise">https://heycam.github.io/webidl/#a-new-promise</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-a-new-promise">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-a-new-promise①">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-a-new-promise②">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-a-new-promise③">2.5.5. Prevent Silent Access</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-a-promise-rejected-with">
   <a href="https://heycam.github.io/webidl/#a-promise-rejected-with">https://heycam.github.io/webidl/#a-promise-rejected-with</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-a-promise-rejected-with">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-a-promise-rejected-with①">2.5.4. Create a Credential</a> <a href="#ref-for-a-promise-rejected-with②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-boolean">
   <a href="https://heycam.github.io/webidl/#idl-boolean">https://heycam.github.io/webidl/#idl-boolean</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-boolean">3.2. The PasswordCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-exception">
   <a href="https://heycam.github.io/webidl/#dfn-exception">https://heycam.github.io/webidl/#dfn-exception</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-exception">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-dfn-exception①">2.5.2. Collect Credentials from the credential store</a>
    <li><a href="#ref-for-dfn-exception②">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-dfn-exception③">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-dfn-exception④">3.2. The PasswordCredential Interface</a> <a href="#ref-for-dfn-exception⑤">(2)</a>
    <li><a href="#ref-for-dfn-exception⑥">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-dfn-exception⑦">(2)</a>
    <li><a href="#ref-for-dfn-exception⑧">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
    <li><a href="#ref-for-dfn-exception⑨">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
    <li><a href="#ref-for-dfn-exception①⓪">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dfn-exception①①">4.2.2. 
    FederatedCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-dfn-exception①②">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-inherit">
   <a href="https://heycam.github.io/webidl/#dfn-inherit">https://heycam.github.io/webidl/#dfn-inherit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-inherit">2. Core API</a>
    <li><a href="#ref-for-dfn-inherit①">2.2.1. Credential Internal Methods</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-inherited-interfaces">
   <a href="https://heycam.github.io/webidl/#dfn-inherited-interfaces">https://heycam.github.io/webidl/#dfn-inherited-interfaces</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-inherited-interfaces">2.3.1. The CredentialRequestOptions Dictionary</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-interface-object">
   <a href="https://heycam.github.io/webidl/#dfn-interface-object">https://heycam.github.io/webidl/#dfn-interface-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-interface-object">2.2. The Credential Interface</a> <a href="#ref-for-dfn-interface-object①">(2)</a> <a href="#ref-for-dfn-interface-object②">(3)</a> <a href="#ref-for-dfn-interface-object③">(4)</a>
    <li><a href="#ref-for-dfn-interface-object④">2.2.1. Credential Internal Methods</a> <a href="#ref-for-dfn-interface-object⑤">(2)</a>
    <li><a href="#ref-for-dfn-interface-object⑥">2.2.1.4. [[Create]] internal method</a>
    <li><a href="#ref-for-dfn-interface-object⑦">2.3.1. The CredentialRequestOptions Dictionary</a> <a href="#ref-for-dfn-interface-object⑧">(2)</a>
    <li><a href="#ref-for-dfn-interface-object⑨">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-dfn-interface-object①⓪">2.5.2. Collect Credentials from the credential store</a>
    <li><a href="#ref-for-dfn-interface-object①①">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-dfn-interface-object①②">3.2. The PasswordCredential Interface</a> <a href="#ref-for-dfn-interface-object①③">(2)</a> <a href="#ref-for-dfn-interface-object①④">(3)</a>
    <li><a href="#ref-for-dfn-interface-object①⑤">4.1. The FederatedCredential Interface</a> <a href="#ref-for-dfn-interface-object①⑥">(2)</a> <a href="#ref-for-dfn-interface-object①⑦">(3)</a>
    <li><a href="#ref-for-dfn-interface-object①⑧">5.3. Credential Selection</a>
    <li><a href="#ref-for-dfn-interface-object①⑨">7.2. Extension Points</a> <a href="#ref-for-dfn-interface-object②⓪">(2)</a> <a href="#ref-for-dfn-interface-object②①">(3)</a> <a href="#ref-for-dfn-interface-object②②">(4)</a> <a href="#ref-for-dfn-interface-object②③">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-interface-prototype-object">
   <a href="https://heycam.github.io/webidl/#dfn-interface-prototype-object">https://heycam.github.io/webidl/#dfn-interface-prototype-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-interface-prototype-object">2.2. The Credential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-reject">
   <a href="https://heycam.github.io/webidl/#reject">https://heycam.github.io/webidl/#reject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-reject">2.5.1. Request a Credential</a> <a href="#ref-for-reject①">(2)</a>
    <li><a href="#ref-for-reject②">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-reject③">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-throw">
   <a href="https://heycam.github.io/webidl/#dfn-throw">https://heycam.github.io/webidl/#dfn-throw</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-throw">3.2. The PasswordCredential Interface</a> <a href="#ref-for-dfn-throw①">(2)</a>
    <li><a href="#ref-for-dfn-throw②">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-interface-formdata">
   <a href="https://xhr.spec.whatwg.org/#interface-formdata">https://xhr.spec.whatwg.org/#interface-formdata</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-interface-formdata">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
    <li><a href="#ref-for-interface-formdata①">7.1. Website Authors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-xmlhttprequest">
   <a href="https://xhr.spec.whatwg.org/#xmlhttprequest">https://xhr.spec.whatwg.org/#xmlhttprequest</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-xmlhttprequest">1. Introduction</a>
    <li><a href="#ref-for-xmlhttprequest①">1.1. Use Cases</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-formdata-get">
   <a href="https://xhr.spec.whatwg.org/#dom-formdata-get">https://xhr.spec.whatwg.org/#dom-formdata-get</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-formdata-get">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a> <a href="#ref-for-dom-formdata-get①">(2)</a> <a href="#ref-for-dom-formdata-get②">(3)</a> <a href="#ref-for-dom-formdata-get③">(4)</a> <a href="#ref-for-dom-formdata-get④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-formdata-has">
   <a href="https://xhr.spec.whatwg.org/#dom-formdata-has">https://xhr.spec.whatwg.org/#dom-formdata-has</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-formdata-has">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[DOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-abortsignal" style="color:initial">AbortSignal</span>
     <li><span class="dfn-paneled" id="term-for-abortsignal-aborted-flag" style="color:initial">aborted flag</span>
     <li><span class="dfn-paneled" id="term-for-context-object" style="color:initial">context object</span>
     <li><span class="dfn-paneled" id="term-for-concept-tree-order" style="color:initial">tree order</span>
    </ul>
   <li>
    <a data-link-type="biblio">[ecma262]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-sec-ordinary-object-internal-methods-and-internal-slots" style="color:initial">internal method</span>
    </ul>
   <li>
    <a data-link-type="biblio">[FETCH]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-response" style="color:initial">Response</span>
     <li><span class="dfn-paneled" id="term-for-concept-request-client" style="color:initial">client</span>
     <li><span class="dfn-paneled" id="term-for-concept-request-credentials-mode" style="color:initial">credentials mode</span>
     <li><span class="dfn-paneled" id="term-for-concept-request-destination" style="color:initial">destination</span>
     <li><span class="dfn-paneled" id="term-for-dom-global-fetch" style="color:initial">fetch(input)</span>
     <li><span class="dfn-paneled" id="term-for-concept-request-initiator" style="color:initial">initiator</span>
     <li><span class="dfn-paneled" id="term-for-request-service-workers-mode" style="color:initial">service-workers mode</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-htmlformelement" style="color:initial">HTMLFormElement</span>
     <li><span class="dfn-paneled" id="term-for-navigator" style="color:initial">Navigator</span>
     <li><span class="dfn-paneled" id="term-for-worker" style="color:initial">Worker</span>
     <li><span class="dfn-paneled" id="term-for-active-document" style="color:initial">active document</span>
     <li><span class="dfn-paneled" id="term-for-ascii-serialisation-of-an-origin" style="color:initial">ascii serialization of an origin</span>
     <li><span class="dfn-paneled" id="term-for-attr-fe-autocomplete" style="color:initial">autocomplete</span>
     <li><span class="dfn-paneled" id="term-for-autofill-detail-tokens" style="color:initial">autofill detail tokens</span>
     <li><span class="dfn-paneled" id="term-for-current-settings-object" style="color:initial">current settings object</span>
     <li><span class="dfn-paneled" id="term-for-attr-fe-autocomplete-current-password" style="color:initial">current-password</span>
     <li><span class="dfn-paneled" id="term-for-dom-manipulation-task-source" style="color:initial">dom manipulation task source</span>
     <li><span class="dfn-paneled" id="term-for-environment-settings-object" style="color:initial">environment settings object</span>
     <li><span class="dfn-paneled" id="term-for-the-form-element" style="color:initial">form</span>
     <li><span class="dfn-paneled" id="term-for-form-owner" style="color:initial">form owner</span>
     <li><span class="dfn-paneled" id="term-for-concept-settings-object-global" style="color:initial">global object</span>
     <li><span class="dfn-paneled" id="term-for-in-parallel" style="color:initial">in parallel</span>
     <li><span class="dfn-paneled" id="term-for-attr-fe-name" style="color:initial">name <small>(for input)</small></span>
     <li><span class="dfn-paneled" id="term-for-attr-fe-autocomplete-new-password" style="color:initial">new-password</span>
     <li><span class="dfn-paneled" id="term-for-attr-fe-autocomplete-nickname" style="color:initial">nickname</span>
     <li><span class="dfn-paneled" id="term-for-concept-settings-object-origin" style="color:initial">origin <small>(for environment settings object)</small></span>
     <li><span class="dfn-paneled" id="term-for-parent-browsing-context" style="color:initial">parent browsing context</span>
     <li><span class="dfn-paneled" id="term-for-attr-fe-autocomplete-photo" style="color:initial">photo</span>
     <li><span class="dfn-paneled" id="term-for-queue-a-task" style="color:initial">queue a task</span>
     <li><span class="dfn-paneled" id="term-for-concept-relevant-realm" style="color:initial">relevant realm</span>
     <li><span class="dfn-paneled" id="term-for-responsible-browsing-context" style="color:initial">responsible browsing context</span>
     <li><span class="dfn-paneled" id="term-for-responsible-document" style="color:initial">responsible document</span>
     <li><span class="dfn-paneled" id="term-for-same-origin" style="color:initial">same origin</span>
     <li><span class="dfn-paneled" id="term-for-dom-form-submit" style="color:initial">submit()</span>
     <li><span class="dfn-paneled" id="term-for-category-submit" style="color:initial">submittable elements</span>
     <li><span class="dfn-paneled" id="term-for-concept-task" style="color:initial">task</span>
     <li><span class="dfn-paneled" id="term-for-top-level-browsing-context" style="color:initial">top-level browsing context</span>
     <li><span class="dfn-paneled" id="term-for-attr-fe-autocomplete-username" style="color:initial">username</span>
    </ul>
   <li>
    <a data-link-type="biblio">[INFRA]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-set-append" style="color:initial">append</span>
     <li><span class="dfn-paneled" id="term-for-ascii-case-insensitive" style="color:initial">ascii case-insensitive</span>
     <li><span class="dfn-paneled" id="term-for-list-contain" style="color:initial">contain</span>
     <li><span class="dfn-paneled" id="term-for-iteration-continue" style="color:initial">continue</span>
     <li><span class="dfn-paneled" id="term-for-map-exists" style="color:initial">exist</span>
     <li><span class="dfn-paneled" id="term-for-ordered-set" style="color:initial">set</span>
     <li><span class="dfn-paneled" id="term-for-list-size" style="color:initial">size</span>
    </ul>
   <li>
    <a data-link-type="biblio">[mixed-content]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-a-priori-authenticated-url" style="color:initial">a priori authenticated url</span>
    </ul>
   <li>
    <a data-link-type="biblio">[PSL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-" style="color:initial">registerable domain</span>
    </ul>
   <li>
    <a data-link-type="biblio">[secure-contexts]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-secure-contexts" style="color:initial">secure contexts</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WEBAUTHN]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-publickeycredential" style="color:initial">PublicKeyCredential</span>
     <li><span class="dfn-paneled" id="term-for-dom-publickeycredential-create-slot" style="color:initial">[[Create]](origin, options, sameOriginWithAncestors)</span>
     <li><span class="dfn-paneled" id="term-for-dom-publickeycredential-discoverfromexternalsource-slot" style="color:initial">[[DiscoverFromExternalSource]](origin, options, sameOriginWithAncestors)</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-aborterror" style="color:initial">AbortError</span>
     <li><span class="dfn-paneled" id="term-for-idl-DOMException" style="color:initial">DOMException</span>
     <li><span class="dfn-paneled" id="term-for-idl-DOMString" style="color:initial">DOMString</span>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-notallowederror" style="color:initial">NotAllowedError</span>
     <li><span class="dfn-paneled" id="term-for-idl-promise" style="color:initial">Promise</span>
     <li><span class="dfn-paneled" id="term-for-SameObject" style="color:initial">SameObject</span>
     <li><span class="dfn-paneled" id="term-for-SecureContext" style="color:initial">SecureContext</span>
     <li><span class="dfn-paneled" id="term-for-exceptiondef-typeerror" style="color:initial">TypeError</span>
     <li><span class="dfn-paneled" id="term-for-idl-USVString" style="color:initial">USVString</span>
     <li><span class="dfn-paneled" id="term-for-a-new-promise" style="color:initial">a new promise</span>
     <li><span class="dfn-paneled" id="term-for-a-promise-rejected-with" style="color:initial">a promise rejected with</span>
     <li><span class="dfn-paneled" id="term-for-idl-boolean" style="color:initial">boolean</span>
     <li><span class="dfn-paneled" id="term-for-dfn-exception" style="color:initial">exception</span>
     <li><span class="dfn-paneled" id="term-for-dfn-inherit" style="color:initial">inherit</span>
     <li><span class="dfn-paneled" id="term-for-dfn-inherited-interfaces" style="color:initial">inherited interfaces</span>
     <li><span class="dfn-paneled" id="term-for-dfn-interface-object" style="color:initial">interface object</span>
     <li><span class="dfn-paneled" id="term-for-dfn-interface-prototype-object" style="color:initial">interface prototype object</span>
     <li><span class="dfn-paneled" id="term-for-reject" style="color:initial">reject</span>
     <li><span class="dfn-paneled" id="term-for-dfn-throw" style="color:initial">throw</span>
    </ul>
   <li>
    <a data-link-type="biblio">[XHR]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-interface-formdata" style="color:initial">FormData</span>
     <li><span class="dfn-paneled" id="term-for-xmlhttprequest" style="color:initial">XMLHttpRequest</span>
     <li><span class="dfn-paneled" id="term-for-dom-formdata-get" style="color:initial">get(name)</span>
     <li><span class="dfn-paneled" id="term-for-dom-formdata-has" style="color:initial">has(name)</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-csp">[CSP]
   <dd>Mike West. <a href="https://www.w3.org/TR/CSP3/">Content Security Policy Level 3</a>. 15 October 2018. WD. URL: <a href="https://www.w3.org/TR/CSP3/">https://www.w3.org/TR/CSP3/</a>
   <dt id="biblio-dom">[DOM]
   <dd>Anne van Kesteren. <a href="https://dom.spec.whatwg.org/">DOM Standard</a>. Living Standard. URL: <a href="https://dom.spec.whatwg.org/">https://dom.spec.whatwg.org/</a>
   <dt id="biblio-fetch">[FETCH]
   <dd>Anne van Kesteren. <a href="https://fetch.spec.whatwg.org/">Fetch Standard</a>. Living Standard. URL: <a href="https://fetch.spec.whatwg.org/">https://fetch.spec.whatwg.org/</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-infra">[INFRA]
   <dd>Anne van Kesteren; Domenic Denicola. <a href="https://infra.spec.whatwg.org/">Infra Standard</a>. Living Standard. URL: <a href="https://infra.spec.whatwg.org/">https://infra.spec.whatwg.org/</a>
   <dt id="biblio-mixed-content">[MIXED-CONTENT]
   <dd>Mike West. <a href="https://www.w3.org/TR/mixed-content/">Mixed Content</a>. 2 August 2016. CR. URL: <a href="https://www.w3.org/TR/mixed-content/">https://www.w3.org/TR/mixed-content/</a>
   <dt id="biblio-psl">[PSL]
   <dd><cite><a href="https://publicsuffix.org/">Public Suffix List</a></cite>.    Mozilla Foundation.
   <dt id="biblio-rfc2119">[RFC2119]
   <dd>S. Bradner. <a href="https://tools.ietf.org/html/rfc2119">Key words for use in RFCs to Indicate Requirement Levels</a>. March 1997. Best Current Practice. URL: <a href="https://tools.ietf.org/html/rfc2119">https://tools.ietf.org/html/rfc2119</a>
   <dt id="biblio-secure-contexts">[SECURE-CONTEXTS]
   <dd>Mike West. <a href="https://www.w3.org/TR/secure-contexts/">Secure Contexts</a>. 15 September 2016. CR. URL: <a href="https://www.w3.org/TR/secure-contexts/">https://www.w3.org/TR/secure-contexts/</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
   <dt id="biblio-xhr">[XHR]
   <dd>Anne van Kesteren. <a href="https://xhr.spec.whatwg.org/">XMLHttpRequest Standard</a>. Living Standard. URL: <a href="https://xhr.spec.whatwg.org/">https://xhr.spec.whatwg.org/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-browserid">[BROWSERID]
   <dd>Ben Adida; et al. <a href="https://github.com/mozilla/id-specs/blob/prod/browserid/index.md">BrowserID</a>. 26 February 2013. URL: <a href="https://github.com/mozilla/id-specs/blob/prod/browserid/index.md">https://github.com/mozilla/id-specs/blob/prod/browserid/index.md</a>
   <dt id="biblio-sri">[SRI]
   <dd>Devdatta Akhawe; et al. <a href="https://www.w3.org/TR/SRI/">Subresource Integrity</a>. 23 June 2016. REC. URL: <a href="https://www.w3.org/TR/SRI/">https://www.w3.org/TR/SRI/</a>
   <dt id="biblio-web-login">[WEB-LOGIN]
   <dd>Jason Denizac; Robin Berjon; Anne van Kesteren. <a href="https://github.com/jden/web-login">web-login</a>. URL: <a href="https://github.com/jden/web-login">https://github.com/jden/web-login</a>
   <dt id="biblio-webauthn">[WEBAUTHN]
   <dd>Dirk Balfanz; et al. <a href="https://www.w3.org/TR/webauthn-1/">Web Authentication:An API for accessing Public Key Credentials Level 1</a>. 4 March 2019. REC. URL: <a href="https://www.w3.org/TR/webauthn-1/">https://www.w3.org/TR/webauthn-1/</a>
   <dt id="biblio-webmessaging">[WEBMESSAGING]
   <dd>Ian Hickson. <a href="https://www.w3.org/TR/webmessaging/">HTML5 Web Messaging</a>. 19 May 2015. REC. URL: <a href="https://www.w3.org/TR/webmessaging/">https://www.w3.org/TR/webmessaging/</a>
   <dt id="biblio-xmlhttprequest">[XMLHTTPREQUEST]
   <dd>Anne van Kesteren; et al. <a href="https://www.w3.org/TR/XMLHttpRequest/">XMLHttpRequest Level 1</a>. 6 October 2016. NOTE. URL: <a href="https://www.w3.org/TR/XMLHttpRequest/">https://www.w3.org/TR/XMLHttpRequest/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed④"><c- g>Exposed</c-></a>=<c- n>Window</c->, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext⑥"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <a href="#credential"><code><c- g>Credential</c-></code></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString②⓪"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-credential-id" id="ref-for-dom-credential-id①①"><c- g>id</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑥"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="DOMString" href="#dom-credential-type" id="ref-for-dom-credential-type③"><c- g>type</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext①①"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <c- b>mixin</c-> <a href="#credentialuserdata"><code><c- g>CredentialUserData</c-></code></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString②①"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-credentialuserdata-name" id="ref-for-dom-credentialuserdata-name①①"><c- g>name</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString③①"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-credentialuserdata-iconurl" id="ref-for-dom-credentialuserdata-iconurl①①"><c- g>iconURL</c-></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/system-state.html#navigator" id="ref-for-navigator①①"><c- g>Navigator</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext②①"><c- g>SecureContext</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject①"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#credentialscontainer" id="ref-for-credentialscontainer②①"><c- n>CredentialsContainer</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CredentialsContainer" href="#dom-navigator-credentials" id="ref-for-dom-navigator-credentials①①"><c- g>credentials</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①①"><c- g>Exposed</c-></a>=<c- n>Window</c->, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext③①"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <a href="#credentialscontainer"><code><c- g>CredentialsContainer</c-></code></a> {
  <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential②⑥①"><c- n>Credential</c-></a>?> <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-get" id="ref-for-dom-credentialscontainer-get②⑦"><c- g>get</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions②①"><c- n>CredentialRequestOptions</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-credentialscontainer-get-options-options" id="ref-for-dom-credentialscontainer-get-options-options②"><c- g>options</c-></a> = {});
  <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential②⑦①"><c- n>Credential</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-store" id="ref-for-dom-credentialscontainer-store①④"><c- g>store</c-></a>(<a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential②⑧①"><c- n>Credential</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-credentialscontainer-store-credential-credential" id="ref-for-dom-credentialscontainer-store-credential-credential②"><c- g>credential</c-></a>);
  <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential②⑨①"><c- n>Credential</c-></a>?> <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-create" id="ref-for-dom-credentialscontainer-create⑧"><c- g>create</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions①①"><c- n>CredentialCreationOptions</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-credentialscontainer-create-options-options" id="ref-for-dom-credentialscontainer-create-options-options②"><c- g>options</c-></a> = {});
  <c- b>Promise</c->&lt;<c- b>void</c->> <a class="idl-code" data-link-type="method" href="#dom-credentialscontainer-preventsilentaccess" id="ref-for-dom-credentialscontainer-preventsilentaccess④"><c- g>preventSilentAccess</c-></a>();
};

<c- b>dictionary</c-> <a href="#dictdef-credentialdata"><code><c- g>CredentialData</c-></code></a> {
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑥①"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-credentialdata-id"><code><c- g>id</c-></code></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-credentialrequestoptions"><code><c- g>CredentialRequestOptions</c-></code></a> {
  <a class="n" data-link-type="idl-name" href="#enumdef-credentialmediationrequirement" id="ref-for-enumdef-credentialmediationrequirement④"><c- n>CredentialMediationRequirement</c-></a> <a class="idl-code" data-default="&quot;optional&quot;" data-link-type="dict-member" data-type="CredentialMediationRequirement " href="#dom-credentialrequestoptions-mediation" id="ref-for-dom-credentialrequestoptions-mediation①⑤"><c- g>mediation</c-></a> = "optional";
  <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal④"><c- n>AbortSignal</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="AbortSignal " href="#dom-credentialrequestoptions-signal" id="ref-for-dom-credentialrequestoptions-signal②"><c- g>signal</c-></a>;
};

<c- b>enum</c-> <a href="#enumdef-credentialmediationrequirement"><code><c- g>CredentialMediationRequirement</c-></code></a> {
  <a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-silent" id="ref-for-dom-credentialmediationrequirement-silent①①"><c- s>"silent"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-optional" id="ref-for-dom-credentialmediationrequirement-optional①①"><c- s>"optional"</c-></a>,
  <a class="idl-code" data-link-type="enum-value" href="#dom-credentialmediationrequirement-required" id="ref-for-dom-credentialmediationrequirement-required⑥"><c- s>"required"</c-></a>
};

<c- b>dictionary</c-> <a href="#dictdef-credentialcreationoptions"><code><c- g>CredentialCreationOptions</c-></code></a> {
  <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal②①"><c- n>AbortSignal</c-></a> <a class="idl-code" data-link-type="dict-member" data-type="AbortSignal " href="#dom-credentialcreationoptions-signal" id="ref-for-dom-credentialcreationoptions-signal②"><c- g>signal</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②①"><c- g>Exposed</c-></a>=<c- n>Window</c->,
 <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext④①"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <a href="#passwordcredential"><code><c- g>PasswordCredential</c-></code></a> : <a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential④②①"><c- n>Credential</c-></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-passwordcredential-passwordcredential" id="ref-for-dom-passwordcredential-passwordcredential②①"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement②①"><c- n>HTMLFormElement</c-></a> <a href="#dom-passwordcredential-constructor-form-form"><code><c- g>form</c-></code></a>);
  <a class="idl-code" data-link-type="constructor" href="#dom-passwordcredential-passwordcredential-data" id="ref-for-dom-passwordcredential-passwordcredential-data①"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata⑧"><c- n>PasswordCredentialData</c-></a> <a href="#dom-passwordcredential-constructor-data-data"><code><c- g>data</c-></code></a>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑦①"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-passwordcredential-password" id="ref-for-dom-passwordcredential-password⑥"><c- g>password</c-></a>;
};
<a class="n" data-link-type="idl-name" href="#passwordcredential" id="ref-for-passwordcredential⑥①"><c- n>PasswordCredential</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#credentialuserdata" id="ref-for-credentialuserdata②"><c- n>CredentialUserData</c-></a>;

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①⓪①"><c- g>CredentialRequestOptions</c-></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean①"><c- b>boolean</c-></a> <a data-default="false" data-type="boolean " href="#dom-credentialrequestoptions-password"><code><c- g>password</c-></code></a> = <c- b>false</c->;
};

<c- b>dictionary</c-> <a href="#dictdef-passwordcredentialdata"><code><c- g>PasswordCredentialData</c-></code></a> : <a class="n" data-link-type="idl-name" href="#dictdef-credentialdata" id="ref-for-dictdef-credentialdata②"><c- n>CredentialData</c-></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑨①"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-passwordcredentialdata-name"><code><c- g>name</c-></code></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⓪①"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-passwordcredentialdata-iconurl"><code><c- g>iconURL</c-></code></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①①①"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-passwordcredentialdata-origin"><code><c- g>origin</c-></code></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①②①"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-passwordcredentialdata-password"><code><c- g>password</c-></code></a>;
};

<c- b>typedef</c-> (<a class="n" data-link-type="idl-name" href="#dictdef-passwordcredentialdata" id="ref-for-dictdef-passwordcredentialdata③①"><c- n>PasswordCredentialData</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/forms.html#htmlformelement" id="ref-for-htmlformelement⑤①"><c- n>HTMLFormElement</c-></a>) <a href="#typedefdef-passwordcredentialinit"><code><c- g>PasswordCredentialInit</c-></code></a>;

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions⑤①"><c- g>CredentialCreationOptions</c-></a> {
  <a class="n" data-link-type="idl-name" href="#typedefdef-passwordcredentialinit" id="ref-for-typedefdef-passwordcredentialinit①"><c- n>PasswordCredentialInit</c-></a> <a data-type="PasswordCredentialInit " href="#dom-credentialcreationoptions-password"><code><c- g>password</c-></code></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed③①"><c- g>Exposed</c-></a>=<c- n>Window</c->,
 <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SecureContext" id="ref-for-SecureContext⑤①"><c- g>SecureContext</c-></a>]
<c- b>interface</c-> <a href="#federatedcredential"><code><c- g>FederatedCredential</c-></code></a> : <a class="n" data-link-type="idl-name" href="#credential" id="ref-for-credential④⑥①"><c- n>Credential</c-></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-federatedcredential-federatedcredential" id="ref-for-dom-federatedcredential-federatedcredential①"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="#dictdef-federatedcredentialinit" id="ref-for-dictdef-federatedcredentialinit⑤"><c- n>FederatedCredentialInit</c-></a> <a href="#dom-federatedcredential-constructor-data-data"><code><c- g>data</c-></code></a>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①③①"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-federatedcredential-provider" id="ref-for-dom-federatedcredential-provider⑨"><c- g>provider</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString②①"><c- b>DOMString</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="DOMString?" href="#dom-federatedcredential-protocol" id="ref-for-dom-federatedcredential-protocol④"><c- g>protocol</c-></a>;
};
<a class="n" data-link-type="idl-name" href="#federatedcredential" id="ref-for-federatedcredential①⑤"><c- n>FederatedCredential</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#credentialuserdata" id="ref-for-credentialuserdata①①"><c- n>CredentialUserData</c-></a>;

<c- b>dictionary</c-> <a href="#dictdef-federatedcredentialrequestoptions"><code><c- g>FederatedCredentialRequestOptions</c-></code></a> {
  <c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①④①"><c- b>USVString</c-></a>> <a data-type="sequence<USVString> " href="#dom-federatedcredentialrequestoptions-providers"><code><c- g>providers</c-></code></a>;
  <c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString③①"><c- b>DOMString</c-></a>> <a data-type="sequence<DOMString> " href="#dom-federatedcredentialrequestoptions-protocols"><code><c- g>protocols</c-></code></a>;
};

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="#dictdef-credentialrequestoptions" id="ref-for-dictdef-credentialrequestoptions①③①"><c- g>CredentialRequestOptions</c-></a> {
  <a class="n" data-link-type="idl-name" href="#dictdef-federatedcredentialrequestoptions" id="ref-for-dictdef-federatedcredentialrequestoptions②"><c- n>FederatedCredentialRequestOptions</c-></a> <a data-type="FederatedCredentialRequestOptions " href="#dom-credentialrequestoptions-federated"><code><c- g>federated</c-></code></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-federatedcredentialinit"><code><c- g>FederatedCredentialInit</c-></code></a> : <a class="n" data-link-type="idl-name" href="#dictdef-credentialdata" id="ref-for-dictdef-credentialdata①①"><c- n>CredentialData</c-></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⑥①"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-federatedcredentialinit-name"><code><c- g>name</c-></code></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⑦①"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-federatedcredentialinit-iconurl"><code><c- g>iconURL</c-></code></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⑧①"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-federatedcredentialinit-origin"><code><c- g>origin</c-></code></a>;
  <c- b>required</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①⑨①"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-federatedcredentialinit-provider"><code><c- g>provider</c-></code></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑤①"><c- b>DOMString</c-></a> <a data-type="DOMString " href="#dom-federatedcredentialinit-protocol"><code><c- g>protocol</c-></code></a>;
};

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="#dictdef-credentialcreationoptions" id="ref-for-dictdef-credentialcreationoptions⑧①"><c- g>CredentialCreationOptions</c-></a> {
  <a class="n" data-link-type="idl-name" href="#dictdef-federatedcredentialinit" id="ref-for-dictdef-federatedcredentialinit③①"><c- n>FederatedCredentialInit</c-></a> <a data-type="FederatedCredentialInit " href="#dom-credentialcreationoptions-federated"><code><c- g>federated</c-></code></a>;
};

</pre>
  <h2 class="no-num no-ref heading settled" id="issues-index"><span class="content">Issues Index</span><a class="self-link" href="#issues-index"></a></h2>
  <div style="counter-reset:issue">
   <div class="issue"> Talk to Tobie/Dominic about the <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-object">interface object</a> bits, here and in <a href="#algorithm-request">§ 2.5.1 Request a Credential</a>, etc. I’m not sure I’ve gotten the terminology right. <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-interface-prototype-object">interface prototype
  object</a>, maybe?<a href="#issue-47fed4d0"> ↵ </a></div>
   <div class="issue"> jyasskin@ suggests replacing the iteration through the interface objects with a registry.
    I’m not sure which is less clear, honestly. I’ll leave it like this for the moment, and we can
    argue about whether this is too much of a <code>COMEFROM</code> interface.<a href="#issue-962f77e2"> ↵ </a></div>
   <div class="issue"> This might be the wrong model. It would be nice to support a site that wished
  to accept either username/passwords or webauthn-style credentials without forcing
  a chooser for those users who use the former, and who wish to remain signed in.<a href="#issue-e720ed3b"> ↵ </a></div>
   <div class="issue"> Add some thoughts here about when and how the API
  should be used, especially with regard to <code class="idl"><a data-link-type="idl" href="#dom-credentialrequestoptions-mediation">mediation</a></code>. <a href="https://github.com/w3c/webappsec/issues/290">&lt;https://github.com/w3c/webappsec/issues/290></a><a href="#issue-84808a53"> ↵ </a></div>
   <div class="issue"> Describe encoding restrictions of submitting credentials by <code class="idl"><a data-link-type="idl" href="https://fetch.spec.whatwg.org/#dom-global-fetch">fetch()</a></code> with
  a <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#interface-formdata">FormData</a></code> body.<a href="#issue-19b3ffaf"> ↵ </a></div>
  </div>
  <aside class="dfn-panel" data-for="concept-credential">
   <b><a href="#concept-credential">#concept-credential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-credential">1. Introduction</a> <a href="#ref-for-concept-credential①">(2)</a>
    <li><a href="#ref-for-concept-credential②">2. Core API</a> <a href="#ref-for-concept-credential③">(2)</a> <a href="#ref-for-concept-credential④">(3)</a> <a href="#ref-for-concept-credential⑤">(4)</a>
    <li><a href="#ref-for-concept-credential⑥">2.1. Infrastructure</a> <a href="#ref-for-concept-credential⑦">(2)</a> <a href="#ref-for-concept-credential⑧">(3)</a> <a href="#ref-for-concept-credential⑨">(4)</a> <a href="#ref-for-concept-credential①⓪">(5)</a> <a href="#ref-for-concept-credential①①">(6)</a> <a href="#ref-for-concept-credential①②">(7)</a>
    <li><a href="#ref-for-concept-credential①③">2.2. The Credential Interface</a>
    <li><a href="#ref-for-concept-credential①④">2.2.1. Credential Internal Methods</a>
    <li><a href="#ref-for-concept-credential①⑤">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-concept-credential①⑥">3. Password Credentials</a>
    <li><a href="#ref-for-concept-credential①⑦">7.2. Extension Points</a> <a href="#ref-for-concept-credential①⑧">(2)</a> <a href="#ref-for-concept-credential①⑨">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credential-effective">
   <b><a href="#credential-effective">#credential-effective</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credential-effective">2.1. Infrastructure</a>
    <li><a href="#ref-for-credential-effective①">2.2. The Credential Interface</a>
    <li><a href="#ref-for-credential-effective②">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-credential-effective③">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credential-source">
   <b><a href="#credential-source">#credential-source</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credential-source">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-credential-source①">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-credential-store">
   <b><a href="#concept-credential-store">#concept-credential-store</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-credential-store">2.1. Infrastructure</a> <a href="#ref-for-concept-credential-store①">(2)</a> <a href="#ref-for-concept-credential-store②">(3)</a> <a href="#ref-for-concept-credential-store③">(4)</a>
    <li><a href="#ref-for-concept-credential-store④">2.2. The Credential Interface</a> <a href="#ref-for-concept-credential-store⑤">(2)</a>
    <li><a href="#ref-for-concept-credential-store⑥">2.2.1.1. [[CollectFromCredentialStore]] internal method</a>
    <li><a href="#ref-for-concept-credential-store⑦">2.2.1.3. [[Store]] internal method</a>
    <li><a href="#ref-for-concept-credential-store⑧">2.3. navigator.credentials</a>
    <li><a href="#ref-for-concept-credential-store⑨">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-concept-credential-store①⓪">2.5.5. Prevent Silent Access</a> <a href="#ref-for-concept-credential-store①①">(2)</a>
    <li><a href="#ref-for-concept-credential-store①②">3.1.1. Password-based Sign-in</a>
    <li><a href="#ref-for-concept-credential-store①③">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-concept-credential-store①④">(2)</a>
    <li><a href="#ref-for-concept-credential-store①⑤">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-concept-credential-store①⑥">(2)</a> <a href="#ref-for-concept-credential-store①⑦">(3)</a> <a href="#ref-for-concept-credential-store①⑧">(4)</a>
    <li><a href="#ref-for-concept-credential-store①⑨">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-concept-credential-store②⓪">(2)</a>
    <li><a href="#ref-for-concept-credential-store②①">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-concept-credential-store②②">(2)</a> <a href="#ref-for-concept-credential-store②③">(3)</a> <a href="#ref-for-concept-credential-store②④">(4)</a>
    <li><a href="#ref-for-concept-credential-store②⑤">5.2. Requiring User Mediation</a>
    <li><a href="#ref-for-concept-credential-store②⑥">5.3. Credential Selection</a>
    <li><a href="#ref-for-concept-credential-store②⑦">6.6. Signing-Out</a>
    <li><a href="#ref-for-concept-credential-store②⑧">7.2. Extension Points</a> <a href="#ref-for-concept-credential-store②⑨">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-credential-store-retrieve-a-list-of-credentials">
   <b><a href="#abstract-opdef-credential-store-retrieve-a-list-of-credentials">#abstract-opdef-credential-store-retrieve-a-list-of-credentials</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-credential-store-retrieve-a-list-of-credentials">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-abstract-opdef-credential-store-retrieve-a-list-of-credentials①">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="origin-prevent-silent-access-flag">
   <b><a href="#origin-prevent-silent-access-flag">#origin-prevent-silent-access-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-origin-prevent-silent-access-flag">2.3. navigator.credentials</a>
    <li><a href="#ref-for-origin-prevent-silent-access-flag①">2.3.2. Mediation Requirements</a> <a href="#ref-for-origin-prevent-silent-access-flag②">(2)</a>
    <li><a href="#ref-for-origin-prevent-silent-access-flag③">2.5.5. Prevent Silent Access</a>
    <li><a href="#ref-for-origin-prevent-silent-access-flag④">5.2. Requiring User Mediation</a> <a href="#ref-for-origin-prevent-silent-access-flag⑤">(2)</a> <a href="#ref-for-origin-prevent-silent-access-flag⑥">(3)</a> <a href="#ref-for-origin-prevent-silent-access-flag⑦">(4)</a>
    <li><a href="#ref-for-origin-prevent-silent-access-flag⑧">6.6. Signing-Out</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="origin-requires-user-mediation">
   <b><a href="#origin-requires-user-mediation">#origin-requires-user-mediation</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-origin-requires-user-mediation">2.3.2. Mediation Requirements</a>
    <li><a href="#ref-for-origin-requires-user-mediation①">2.5.1. Request a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="same-origin-with-its-ancestors">
   <b><a href="#same-origin-with-its-ancestors">#same-origin-with-its-ancestors</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-same-origin-with-its-ancestors">2.2.1.1. [[CollectFromCredentialStore]] internal method</a>
    <li><a href="#ref-for-same-origin-with-its-ancestors①">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-same-origin-with-its-ancestors②">2.2.1.3. [[Store]] internal method</a>
    <li><a href="#ref-for-same-origin-with-its-ancestors③">2.2.1.4. [[Create]] internal method</a>
    <li><a href="#ref-for-same-origin-with-its-ancestors④">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-same-origin-with-its-ancestors⑤">2.5.2. Collect Credentials from the credential store</a>
    <li><a href="#ref-for-same-origin-with-its-ancestors⑥">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-same-origin-with-its-ancestors⑦">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-same-origin-with-its-ancestors⑧">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-same-origin-with-its-ancestors⑨">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-same-origin-with-its-ancestors①⓪">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-same-origin-with-its-ancestors①①">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-same-origin-with-its-ancestors①②">4.2.2. 
    FederatedCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-same-origin-with-its-ancestors①③">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-same-origin-with-its-ancestors①④">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credential">
   <b><a href="#credential">#credential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credential">2. Core API</a> <a href="#ref-for-credential①">(2)</a>
    <li><a href="#ref-for-credential②">2.2. The Credential Interface</a> <a href="#ref-for-credential③">(2)</a> <a href="#ref-for-credential④">(3)</a> <a href="#ref-for-credential⑤">(4)</a> <a href="#ref-for-credential⑥">(5)</a>
    <li><a href="#ref-for-credential⑦">2.2.1. Credential Internal Methods</a> <a href="#ref-for-credential⑧">(2)</a> <a href="#ref-for-credential⑨">(3)</a> <a href="#ref-for-credential①⓪">(4)</a>
    <li><a href="#ref-for-credential①①">2.2.1.1. [[CollectFromCredentialStore]] internal method</a> <a href="#ref-for-credential①②">(2)</a> <a href="#ref-for-credential①③">(3)</a>
    <li><a href="#ref-for-credential①④">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a> <a href="#ref-for-credential①⑤">(2)</a> <a href="#ref-for-credential①⑥">(3)</a>
    <li><a href="#ref-for-credential①⑦">2.2.1.3. [[Store]] internal method</a> <a href="#ref-for-credential①⑧">(2)</a> <a href="#ref-for-credential①⑨">(3)</a>
    <li><a href="#ref-for-credential②⓪">2.2.1.4. [[Create]] internal method</a> <a href="#ref-for-credential②①">(2)</a> <a href="#ref-for-credential②②">(3)</a> <a href="#ref-for-credential②③">(4)</a>
    <li><a href="#ref-for-credential②④">2.2.2. CredentialUserData Mixin</a>
    <li><a href="#ref-for-credential②⑤">2.3. navigator.credentials</a> <a href="#ref-for-credential②⑥">(2)</a> <a href="#ref-for-credential②⑦">(3)</a> <a href="#ref-for-credential②⑧">(4)</a> <a href="#ref-for-credential②⑨">(5)</a>
    <li><a href="#ref-for-credential③⓪">2.3.1. The CredentialRequestOptions Dictionary</a> <a href="#ref-for-credential③①">(2)</a>
    <li><a href="#ref-for-credential③②">2.4. The CredentialCreationOptions Dictionary</a>
    <li><a href="#ref-for-credential③③">2.5.1. Request a Credential</a> <a href="#ref-for-credential③④">(2)</a> <a href="#ref-for-credential③⑤">(3)</a>
    <li><a href="#ref-for-credential③⑥">2.5.2. Collect Credentials from the credential store</a> <a href="#ref-for-credential③⑦">(2)</a>
    <li><a href="#ref-for-credential③⑧">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-credential③⑨">2.5.4. Create a Credential</a> <a href="#ref-for-credential④⓪">(2)</a> <a href="#ref-for-credential④①">(3)</a>
    <li><a href="#ref-for-credential④②">3.2. The PasswordCredential Interface</a> <a href="#ref-for-credential④③">(2)</a>
    <li><a href="#ref-for-credential④④">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-credential④⑤">(2)</a>
    <li><a href="#ref-for-credential④⑥">4.1. The FederatedCredential Interface</a> <a href="#ref-for-credential④⑦">(2)</a>
    <li><a href="#ref-for-credential④⑧">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-credential④⑨">(2)</a>
    <li><a href="#ref-for-credential⑤⓪">5.3. Credential Selection</a> <a href="#ref-for-credential⑤①">(2)</a> <a href="#ref-for-credential⑤②">(3)</a> <a href="#ref-for-credential⑤③">(4)</a> <a href="#ref-for-credential⑤④">(5)</a>
    <li><a href="#ref-for-credential⑤⑤">6.1. Cross-domain credential access</a>
    <li><a href="#ref-for-credential⑤⑥">6.7. Chooser Leakage</a> <a href="#ref-for-credential⑤⑦">(2)</a> <a href="#ref-for-credential⑤⑧">(3)</a>
    <li><a href="#ref-for-credential⑤⑨">7.1. Website Authors</a>
    <li><a href="#ref-for-credential⑥⓪">7.2. Extension Points</a> <a href="#ref-for-credential⑥①">(2)</a> <a href="#ref-for-credential⑥②">(3)</a> <a href="#ref-for-credential⑥③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-id">
   <b><a href="#dom-credential-id">#dom-credential-id</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-id">2.2. The Credential Interface</a>
    <li><a href="#ref-for-dom-credential-id①">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credential-id②">(2)</a> <a href="#ref-for-dom-credential-id③">(3)</a> <a href="#ref-for-dom-credential-id④">(4)</a>
    <li><a href="#ref-for-dom-credential-id⑤">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
    <li><a href="#ref-for-dom-credential-id⑥">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credential-id⑦">(2)</a> <a href="#ref-for-dom-credential-id⑧">(3)</a> <a href="#ref-for-dom-credential-id⑨">(4)</a>
    <li><a href="#ref-for-dom-credential-id①⓪">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-type">
   <b><a href="#dom-credential-type">#dom-credential-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-type">2.2. The Credential Interface</a>
    <li><a href="#ref-for-dom-credential-type①">3.1.1. Password-based Sign-in</a> <a href="#ref-for-dom-credential-type②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-type-slot">
   <b><a href="#dom-credential-type-slot">#dom-credential-type-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-type-slot">2.2. The Credential Interface</a> <a href="#ref-for-dom-credential-type-slot①">(2)</a>
    <li><a href="#ref-for-dom-credential-type-slot②">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-dom-credential-type-slot③">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dom-credential-type-slot④">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dom-credential-type-slot⑤">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credential-credential-type">
   <b><a href="#credential-credential-type">#credential-credential-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credential-credential-type">2.2. The Credential Interface</a>
    <li><a href="#ref-for-credential-credential-type①">2.2.1.4. [[Create]] internal method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-discovery-slot">
   <b><a href="#dom-credential-discovery-slot">#dom-credential-discovery-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-discovery-slot">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-dom-credential-discovery-slot①">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dom-credential-discovery-slot②">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dom-credential-discovery-slot③">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-discovery-credential-store">
   <b><a href="#dom-credential-discovery-credential-store">#dom-credential-discovery-credential-store</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-discovery-credential-store">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-dom-credential-discovery-credential-store①">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dom-credential-discovery-credential-store②">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dom-credential-discovery-credential-store③">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credential-origin-bound">
   <b><a href="#credential-origin-bound">#credential-origin-bound</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credential-origin-bound">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-credential-origin-bound①">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-origin-slot">
   <b><a href="#dom-credential-origin-slot">#dom-credential-origin-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-origin-slot">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-dom-credential-origin-slot①">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credential-origin-slot②">(2)</a> <a href="#ref-for-dom-credential-origin-slot③">(3)</a> <a href="#ref-for-dom-credential-origin-slot④">(4)</a>
    <li><a href="#ref-for-dom-credential-origin-slot⑤">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
    <li><a href="#ref-for-dom-credential-origin-slot⑥">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-dom-credential-origin-slot⑦">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credential-origin-slot⑧">(2)</a> <a href="#ref-for-dom-credential-origin-slot⑨">(3)</a> <a href="#ref-for-dom-credential-origin-slot①⓪">(4)</a>
    <li><a href="#ref-for-dom-credential-origin-slot①①">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a>
    <li><a href="#ref-for-dom-credential-origin-slot①②">6.1. Cross-domain credential access</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-collectfromcredentialstore-slot">
   <b><a href="#dom-credential-collectfromcredentialstore-slot">#dom-credential-collectfromcredentialstore-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-collectfromcredentialstore-slot">2.2.1.1. [[CollectFromCredentialStore]] internal method</a>
    <li><a href="#ref-for-dom-credential-collectfromcredentialstore-slot①">2.5.2. Collect Credentials from the credential store</a>
    <li><a href="#ref-for-dom-credential-collectfromcredentialstore-slot②">6.4. Origin Confusion</a>
    <li><a href="#ref-for-dom-credential-collectfromcredentialstore-slot③">7.2. Extension Points</a> <a href="#ref-for-dom-credential-collectfromcredentialstore-slot④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-discoverfromexternalsource-slot">
   <b><a href="#dom-credential-discoverfromexternalsource-slot">#dom-credential-discoverfromexternalsource-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-discoverfromexternalsource-slot">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-dom-credential-discoverfromexternalsource-slot①">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-dom-credential-discoverfromexternalsource-slot②">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dom-credential-discoverfromexternalsource-slot③">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dom-credential-discoverfromexternalsource-slot④">6.4. Origin Confusion</a>
    <li><a href="#ref-for-dom-credential-discoverfromexternalsource-slot⑤">7.2. Extension Points</a> <a href="#ref-for-dom-credential-discoverfromexternalsource-slot⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-store-slot">
   <b><a href="#dom-credential-store-slot">#dom-credential-store-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-store-slot">2.2.1.3. [[Store]] internal method</a>
    <li><a href="#ref-for-dom-credential-store-slot①">2.5.3. Store a Credential</a>
    <li><a href="#ref-for-dom-credential-store-slot②">6.4. Origin Confusion</a>
    <li><a href="#ref-for-dom-credential-store-slot③">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-create-slot">
   <b><a href="#dom-credential-create-slot">#dom-credential-create-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-create-slot">2.2.1.4. [[Create]] internal method</a>
    <li><a href="#ref-for-dom-credential-create-slot①">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-dom-credential-create-slot②">6.4. Origin Confusion</a>
    <li><a href="#ref-for-dom-credential-create-slot③">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credentialuserdata">
   <b><a href="#credentialuserdata">#credentialuserdata</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credentialuserdata">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-credentialuserdata①">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialuserdata-name">
   <b><a href="#dom-credentialuserdata-name">#dom-credentialuserdata-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialuserdata-name">2.2.2. CredentialUserData Mixin</a>
    <li><a href="#ref-for-dom-credentialuserdata-name①">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credentialuserdata-name②">(2)</a> <a href="#ref-for-dom-credentialuserdata-name③">(3)</a> <a href="#ref-for-dom-credentialuserdata-name④">(4)</a>
    <li><a href="#ref-for-dom-credentialuserdata-name⑤">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
    <li><a href="#ref-for-dom-credentialuserdata-name⑥">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
    <li><a href="#ref-for-dom-credentialuserdata-name⑦">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credentialuserdata-name⑧">(2)</a>
    <li><a href="#ref-for-dom-credentialuserdata-name⑨">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a> <a href="#ref-for-dom-credentialuserdata-name①⓪">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialuserdata-iconurl">
   <b><a href="#dom-credentialuserdata-iconurl">#dom-credentialuserdata-iconurl</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialuserdata-iconurl">2.2.2. CredentialUserData Mixin</a>
    <li><a href="#ref-for-dom-credentialuserdata-iconurl①">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credentialuserdata-iconurl②">(2)</a> <a href="#ref-for-dom-credentialuserdata-iconurl③">(3)</a> <a href="#ref-for-dom-credentialuserdata-iconurl④">(4)</a>
    <li><a href="#ref-for-dom-credentialuserdata-iconurl⑤">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
    <li><a href="#ref-for-dom-credentialuserdata-iconurl⑥">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
    <li><a href="#ref-for-dom-credentialuserdata-iconurl⑦">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credentialuserdata-iconurl⑧">(2)</a>
    <li><a href="#ref-for-dom-credentialuserdata-iconurl⑨">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a> <a href="#ref-for-dom-credentialuserdata-iconurl①⓪">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-navigator-credentials">
   <b><a href="#dom-navigator-credentials">#dom-navigator-credentials</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-navigator-credentials">2.3. navigator.credentials</a> <a href="#ref-for-dom-navigator-credentials①">(2)</a>
    <li><a href="#ref-for-dom-navigator-credentials②">2.3.2.1. Examples</a> <a href="#ref-for-dom-navigator-credentials③">(2)</a> <a href="#ref-for-dom-navigator-credentials④">(3)</a> <a href="#ref-for-dom-navigator-credentials⑤">(4)</a>
    <li><a href="#ref-for-dom-navigator-credentials⑥">3.1.1. Password-based Sign-in</a> <a href="#ref-for-dom-navigator-credentials⑦">(2)</a> <a href="#ref-for-dom-navigator-credentials⑧">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credentialscontainer">
   <b><a href="#credentialscontainer">#credentialscontainer</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credentialscontainer">2. Core API</a>
    <li><a href="#ref-for-credentialscontainer①">2.3. navigator.credentials</a> <a href="#ref-for-credentialscontainer②">(2)</a> <a href="#ref-for-credentialscontainer③">(3)</a> <a href="#ref-for-credentialscontainer④">(4)</a>
    <li><a href="#ref-for-credentialscontainer⑤">6.6. Signing-Out</a>
    <li><a href="#ref-for-credentialscontainer⑥">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-credentialdata">
   <b><a href="#dictdef-credentialdata">#dictdef-credentialdata</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-credentialdata">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dictdef-credentialdata①">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialdata-id">
   <b><a href="#dom-credentialdata-id">#dom-credentialdata-id</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialdata-id">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
    <li><a href="#ref-for-dom-credentialdata-id①">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a> <a href="#ref-for-dom-credentialdata-id②">(2)</a>
    <li><a href="#ref-for-dom-credentialdata-id③">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a> <a href="#ref-for-dom-credentialdata-id④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialscontainer-get">
   <b><a href="#dom-credentialscontainer-get">#dom-credentialscontainer-get</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialscontainer-get">2.3. navigator.credentials</a> <a href="#ref-for-dom-credentialscontainer-get①">(2)</a> <a href="#ref-for-dom-credentialscontainer-get②">(3)</a>
    <li><a href="#ref-for-dom-credentialscontainer-get③">2.3.1. The CredentialRequestOptions Dictionary</a> <a href="#ref-for-dom-credentialscontainer-get④">(2)</a> <a href="#ref-for-dom-credentialscontainer-get⑤">(3)</a>
    <li><a href="#ref-for-dom-credentialscontainer-get⑥">2.3.2. Mediation Requirements</a> <a href="#ref-for-dom-credentialscontainer-get⑦">(2)</a>
    <li><a href="#ref-for-dom-credentialscontainer-get⑧">2.3.2.1. Examples</a> <a href="#ref-for-dom-credentialscontainer-get⑨">(2)</a> <a href="#ref-for-dom-credentialscontainer-get①⓪">(3)</a> <a href="#ref-for-dom-credentialscontainer-get①①">(4)</a> <a href="#ref-for-dom-credentialscontainer-get①②">(5)</a> <a href="#ref-for-dom-credentialscontainer-get①③">(6)</a> <a href="#ref-for-dom-credentialscontainer-get①④">(7)</a>
    <li><a href="#ref-for-dom-credentialscontainer-get①⑤">3.1.1. Password-based Sign-in</a> <a href="#ref-for-dom-credentialscontainer-get①⑥">(2)</a> <a href="#ref-for-dom-credentialscontainer-get①⑦">(3)</a> <a href="#ref-for-dom-credentialscontainer-get①⑧">(4)</a>
    <li><a href="#ref-for-dom-credentialscontainer-get①⑨">3.3.6. 
    CredentialRequestOptions Matching for PasswordCredential </a>
    <li><a href="#ref-for-dom-credentialscontainer-get②⓪">5.3. Credential Selection</a>
    <li><a href="#ref-for-dom-credentialscontainer-get②①">6.1. Cross-domain credential access</a> <a href="#ref-for-dom-credentialscontainer-get②②">(2)</a> <a href="#ref-for-dom-credentialscontainer-get②③">(3)</a>
    <li><a href="#ref-for-dom-credentialscontainer-get②④">6.5. Timing Attacks</a>
    <li><a href="#ref-for-dom-credentialscontainer-get②⑤">7.2. Extension Points</a>
    <li><a href="#ref-for-dom-credentialscontainer-get②⑥">7.3. Browser Extensions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialscontainer-get-options-options">
   <b><a href="#dom-credentialscontainer-get-options-options">#dom-credentialscontainer-get-options-options</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialscontainer-get-options-options">2.3. navigator.credentials</a> <a href="#ref-for-dom-credentialscontainer-get-options-options①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialscontainer-store">
   <b><a href="#dom-credentialscontainer-store">#dom-credentialscontainer-store</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialscontainer-store">2. Core API</a>
    <li><a href="#ref-for-dom-credentialscontainer-store①">2.3. navigator.credentials</a> <a href="#ref-for-dom-credentialscontainer-store②">(2)</a> <a href="#ref-for-dom-credentialscontainer-store③">(3)</a>
    <li><a href="#ref-for-dom-credentialscontainer-store④">3.1.1. Password-based Sign-in</a> <a href="#ref-for-dom-credentialscontainer-store⑤">(2)</a> <a href="#ref-for-dom-credentialscontainer-store⑥">(3)</a> <a href="#ref-for-dom-credentialscontainer-store⑦">(4)</a>
    <li><a href="#ref-for-dom-credentialscontainer-store⑧">3.1.2. Post-sign-in Confirmation</a> <a href="#ref-for-dom-credentialscontainer-store⑨">(2)</a>
    <li><a href="#ref-for-dom-credentialscontainer-store①⓪">3.1.3. Change Password</a> <a href="#ref-for-dom-credentialscontainer-store①①">(2)</a>
    <li><a href="#ref-for-dom-credentialscontainer-store①②">5.1. Storing and Updating Credentials</a>
    <li><a href="#ref-for-dom-credentialscontainer-store①③">7.3. Browser Extensions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialscontainer-store-credential-credential">
   <b><a href="#dom-credentialscontainer-store-credential-credential">#dom-credentialscontainer-store-credential-credential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialscontainer-store-credential-credential">2.3. navigator.credentials</a> <a href="#ref-for-dom-credentialscontainer-store-credential-credential①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialscontainer-create">
   <b><a href="#dom-credentialscontainer-create">#dom-credentialscontainer-create</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialscontainer-create">2.3. navigator.credentials</a> <a href="#ref-for-dom-credentialscontainer-create①">(2)</a> <a href="#ref-for-dom-credentialscontainer-create②">(3)</a>
    <li><a href="#ref-for-dom-credentialscontainer-create③">2.4. The CredentialCreationOptions Dictionary</a> <a href="#ref-for-dom-credentialscontainer-create④">(2)</a>
    <li><a href="#ref-for-dom-credentialscontainer-create⑤">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dom-credentialscontainer-create⑥">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dom-credentialscontainer-create⑦">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialscontainer-create-options-options">
   <b><a href="#dom-credentialscontainer-create-options-options">#dom-credentialscontainer-create-options-options</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialscontainer-create-options-options">2.3. navigator.credentials</a> <a href="#ref-for-dom-credentialscontainer-create-options-options①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialscontainer-preventsilentaccess">
   <b><a href="#dom-credentialscontainer-preventsilentaccess">#dom-credentialscontainer-preventsilentaccess</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialscontainer-preventsilentaccess">2.3. navigator.credentials</a> <a href="#ref-for-dom-credentialscontainer-preventsilentaccess①">(2)</a>
    <li><a href="#ref-for-dom-credentialscontainer-preventsilentaccess②">2.3.2. Mediation Requirements</a>
    <li><a href="#ref-for-dom-credentialscontainer-preventsilentaccess③">6.6. Signing-Out</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-credentialrequestoptions">
   <b><a href="#dictdef-credentialrequestoptions">#dictdef-credentialrequestoptions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-credentialrequestoptions">2.2.1.1. [[CollectFromCredentialStore]] internal method</a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions①">2.2.1.2. [[DiscoverFromExternalSource]] internal method</a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions②">2.3. navigator.credentials</a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions③">2.3.1. The CredentialRequestOptions Dictionary</a> <a href="#ref-for-dictdef-credentialrequestoptions④">(2)</a> <a href="#ref-for-dictdef-credentialrequestoptions⑤">(3)</a> <a href="#ref-for-dictdef-credentialrequestoptions⑥">(4)</a> <a href="#ref-for-dictdef-credentialrequestoptions⑦">(5)</a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions⑧">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions⑨">2.5.2. Collect Credentials from the credential store</a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions①⓪">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions①①">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions①②">3.3.6. 
    CredentialRequestOptions Matching for PasswordCredential </a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions①③">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions①④">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions①⑤">5.3. Credential Selection</a>
    <li><a href="#ref-for-dictdef-credentialrequestoptions①⑥">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialrequestoptions-mediation">
   <b><a href="#dom-credentialrequestoptions-mediation">#dom-credentialrequestoptions-mediation</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialrequestoptions-mediation">2.3.1. The CredentialRequestOptions Dictionary</a> <a href="#ref-for-dom-credentialrequestoptions-mediation①">(2)</a> <a href="#ref-for-dom-credentialrequestoptions-mediation②">(3)</a> <a href="#ref-for-dom-credentialrequestoptions-mediation③">(4)</a>
    <li><a href="#ref-for-dom-credentialrequestoptions-mediation④">2.3.2.1. Examples</a> <a href="#ref-for-dom-credentialrequestoptions-mediation⑤">(2)</a> <a href="#ref-for-dom-credentialrequestoptions-mediation⑥">(3)</a> <a href="#ref-for-dom-credentialrequestoptions-mediation⑦">(4)</a> <a href="#ref-for-dom-credentialrequestoptions-mediation⑧">(5)</a> <a href="#ref-for-dom-credentialrequestoptions-mediation⑨">(6)</a> <a href="#ref-for-dom-credentialrequestoptions-mediation①⓪">(7)</a> <a href="#ref-for-dom-credentialrequestoptions-mediation①①">(8)</a>
    <li><a href="#ref-for-dom-credentialrequestoptions-mediation①②">2.5.1. Request a Credential</a> <a href="#ref-for-dom-credentialrequestoptions-mediation①③">(2)</a>
    <li><a href="#ref-for-dom-credentialrequestoptions-mediation①④">7.1. Website Authors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialrequestoptions-signal">
   <b><a href="#dom-credentialrequestoptions-signal">#dom-credentialrequestoptions-signal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialrequestoptions-signal">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-dom-credentialrequestoptions-signal①">2.5.1. Request a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credentialrequestoptions-relevant-credential-interface-objects">
   <b><a href="#credentialrequestoptions-relevant-credential-interface-objects">#credentialrequestoptions-relevant-credential-interface-objects</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credentialrequestoptions-relevant-credential-interface-objects">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-credentialrequestoptions-relevant-credential-interface-objects①">2.5.2. Collect Credentials from the credential store</a>
    <li><a href="#ref-for-credentialrequestoptions-relevant-credential-interface-objects②">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-credentialrequestoptions-relevant-credential-interface-objects③">5.3. Credential Selection</a> <a href="#ref-for-credentialrequestoptions-relevant-credential-interface-objects④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credentialrequestoptions-matchable-a-priori">
   <b><a href="#credentialrequestoptions-matchable-a-priori">#credentialrequestoptions-matchable-a-priori</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credentialrequestoptions-matchable-a-priori">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-credentialrequestoptions-matchable-a-priori①">2.5.1. Request a Credential</a>
    <li><a href="#ref-for-credentialrequestoptions-matchable-a-priori②">5.3. Credential Selection</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-credentialmediationrequirement">
   <b><a href="#enumdef-credentialmediationrequirement">#enumdef-credentialmediationrequirement</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-credentialmediationrequirement">2.3.1. The CredentialRequestOptions Dictionary</a> <a href="#ref-for-enumdef-credentialmediationrequirement①">(2)</a> <a href="#ref-for-enumdef-credentialmediationrequirement②">(3)</a>
    <li><a href="#ref-for-enumdef-credentialmediationrequirement③">2.3.2. Mediation Requirements</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialmediationrequirement-silent">
   <b><a href="#dom-credentialmediationrequirement-silent">#dom-credentialmediationrequirement-silent</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialmediationrequirement-silent">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-dom-credentialmediationrequirement-silent①">2.3.2. Mediation Requirements</a>
    <li><a href="#ref-for-dom-credentialmediationrequirement-silent②">2.3.2.1. Examples</a> <a href="#ref-for-dom-credentialmediationrequirement-silent③">(2)</a>
    <li><a href="#ref-for-dom-credentialmediationrequirement-silent④">2.5.1. Request a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialmediationrequirement-optional">
   <b><a href="#dom-credentialmediationrequirement-optional">#dom-credentialmediationrequirement-optional</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialmediationrequirement-optional">2.3.1. The CredentialRequestOptions Dictionary</a>
    <li><a href="#ref-for-dom-credentialmediationrequirement-optional①">2.3.2. Mediation Requirements</a>
    <li><a href="#ref-for-dom-credentialmediationrequirement-optional②">2.3.2.1. Examples</a> <a href="#ref-for-dom-credentialmediationrequirement-optional③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialmediationrequirement-required">
   <b><a href="#dom-credentialmediationrequirement-required">#dom-credentialmediationrequirement-required</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialmediationrequirement-required">2.3.2. Mediation Requirements</a>
    <li><a href="#ref-for-dom-credentialmediationrequirement-required①">2.3.2.1. Examples</a> <a href="#ref-for-dom-credentialmediationrequirement-required②">(2)</a> <a href="#ref-for-dom-credentialmediationrequirement-required③">(3)</a> <a href="#ref-for-dom-credentialmediationrequirement-required④">(4)</a>
    <li><a href="#ref-for-dom-credentialmediationrequirement-required⑤">2.5.1. Request a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-credentialcreationoptions">
   <b><a href="#dictdef-credentialcreationoptions">#dictdef-credentialcreationoptions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-credentialcreationoptions">2.2.1.4. [[Create]] internal method</a>
    <li><a href="#ref-for-dictdef-credentialcreationoptions①">2.3. navigator.credentials</a>
    <li><a href="#ref-for-dictdef-credentialcreationoptions②">2.4. The CredentialCreationOptions Dictionary</a> <a href="#ref-for-dictdef-credentialcreationoptions③">(2)</a>
    <li><a href="#ref-for-dictdef-credentialcreationoptions④">2.5.4. Create a Credential</a>
    <li><a href="#ref-for-dictdef-credentialcreationoptions⑤">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dictdef-credentialcreationoptions⑥">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-dictdef-credentialcreationoptions⑦">(2)</a>
    <li><a href="#ref-for-dictdef-credentialcreationoptions⑧">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dictdef-credentialcreationoptions⑨">4.2.2. 
    FederatedCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-dictdef-credentialcreationoptions①⓪">7.2. Extension Points</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialcreationoptions-signal">
   <b><a href="#dom-credentialcreationoptions-signal">#dom-credentialcreationoptions-signal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialcreationoptions-signal">2.4. The CredentialCreationOptions Dictionary</a>
    <li><a href="#ref-for-dom-credentialcreationoptions-signal①">2.5.4. Create a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-request-a-credential">
   <b><a href="#abstract-opdef-request-a-credential">#abstract-opdef-request-a-credential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-request-a-credential">2.3. navigator.credentials</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-collect-credentials-from-the-credential-store">
   <b><a href="#abstract-opdef-collect-credentials-from-the-credential-store">#abstract-opdef-collect-credentials-from-the-credential-store</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-collect-credentials-from-the-credential-store">2.5.1. Request a Credential</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-store-a-credential">
   <b><a href="#abstract-opdef-store-a-credential">#abstract-opdef-store-a-credential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-store-a-credential">2.3. navigator.credentials</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-create-a-credential">
   <b><a href="#abstract-opdef-create-a-credential">#abstract-opdef-create-a-credential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-create-a-credential">2.3. navigator.credentials</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-prevent-silent-access">
   <b><a href="#abstract-opdef-prevent-silent-access">#abstract-opdef-prevent-silent-access</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-prevent-silent-access">2.3. navigator.credentials</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="passwordcredential">
   <b><a href="#passwordcredential">#passwordcredential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-passwordcredential">2. Core API</a>
    <li><a href="#ref-for-passwordcredential①">3. Password Credentials</a>
    <li><a href="#ref-for-passwordcredential②">3.1.2. Post-sign-in Confirmation</a> <a href="#ref-for-passwordcredential③">(2)</a>
    <li><a href="#ref-for-passwordcredential④">3.1.3. Change Password</a> <a href="#ref-for-passwordcredential⑤">(2)</a>
    <li><a href="#ref-for-passwordcredential⑥">3.2. The PasswordCredential Interface</a> <a href="#ref-for-passwordcredential⑦">(2)</a> <a href="#ref-for-passwordcredential⑧">(3)</a> <a href="#ref-for-passwordcredential⑨">(4)</a> <a href="#ref-for-passwordcredential①⓪">(5)</a> <a href="#ref-for-passwordcredential①①">(6)</a>
    <li><a href="#ref-for-passwordcredential①②">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-passwordcredential①③">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-passwordcredential①④">(2)</a>
    <li><a href="#ref-for-passwordcredential①⑤">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-passwordcredential①⑥">(2)</a> <a href="#ref-for-passwordcredential①⑦">(3)</a>
    <li><a href="#ref-for-passwordcredential①⑧">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
    <li><a href="#ref-for-passwordcredential①⑨">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
    <li><a href="#ref-for-passwordcredential②⓪">3.3.6. 
    CredentialRequestOptions Matching for PasswordCredential </a>
    <li><a href="#ref-for-passwordcredential②①">6.4. Origin Confusion</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialrequestoptions-password">
   <b><a href="#dom-credentialrequestoptions-password">#dom-credentialrequestoptions-password</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialrequestoptions-password">3.1.1. Password-based Sign-in</a> <a href="#ref-for-dom-credentialrequestoptions-password①">(2)</a>
    <li><a href="#ref-for-dom-credentialrequestoptions-password②">3.3.1. 
    PasswordCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credentialrequestoptions-password③">(2)</a>
    <li><a href="#ref-for-dom-credentialrequestoptions-password④">3.3.6. 
    CredentialRequestOptions Matching for PasswordCredential </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredential-password">
   <b><a href="#dom-passwordcredential-password">#dom-passwordcredential-password</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredential-password">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dom-passwordcredential-password①">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-passwordcredential-password②">(2)</a> <a href="#ref-for-dom-passwordcredential-password③">(3)</a> <a href="#ref-for-dom-passwordcredential-password④">(4)</a>
    <li><a href="#ref-for-dom-passwordcredential-password⑤">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credential-type-password">
   <b><a href="#dom-credential-type-password">#dom-credential-type-password</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credential-type-password">3.1.1. Password-based Sign-in</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredential-passwordcredential">
   <b><a href="#dom-passwordcredential-passwordcredential">#dom-passwordcredential-passwordcredential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredential-passwordcredential">3.1.2. Post-sign-in Confirmation</a>
    <li><a href="#ref-for-dom-passwordcredential-passwordcredential①">3.1.3. Change Password</a>
    <li><a href="#ref-for-dom-passwordcredential-passwordcredential②">3.2. The PasswordCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredential-passwordcredential-data">
   <b><a href="#dom-passwordcredential-passwordcredential-data">#dom-passwordcredential-passwordcredential-data</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredential-passwordcredential-data">3.2. The PasswordCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-passwordcredentialdata">
   <b><a href="#dictdef-passwordcredentialdata">#dictdef-passwordcredentialdata</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-passwordcredentialdata">3.2. The PasswordCredential Interface</a> <a href="#ref-for-dictdef-passwordcredentialdata①">(2)</a> <a href="#ref-for-dictdef-passwordcredentialdata②">(3)</a> <a href="#ref-for-dictdef-passwordcredentialdata③">(4)</a>
    <li><a href="#ref-for-dictdef-passwordcredentialdata④">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-dictdef-passwordcredentialdata⑤">(2)</a>
    <li><a href="#ref-for-dictdef-passwordcredentialdata⑥">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
    <li><a href="#ref-for-dictdef-passwordcredentialdata⑦">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredentialdata-name">
   <b><a href="#dom-passwordcredentialdata-name">#dom-passwordcredentialdata-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredentialdata-name">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredentialdata-iconurl">
   <b><a href="#dom-passwordcredentialdata-iconurl">#dom-passwordcredentialdata-iconurl</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredentialdata-iconurl">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredentialdata-origin">
   <b><a href="#dom-passwordcredentialdata-origin">#dom-passwordcredentialdata-origin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredentialdata-origin">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
    <li><a href="#ref-for-dom-passwordcredentialdata-origin①">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a> <a href="#ref-for-dom-passwordcredentialdata-origin②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredentialdata-password">
   <b><a href="#dom-passwordcredentialdata-password">#dom-passwordcredentialdata-password</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredentialdata-password">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a> <a href="#ref-for-dom-passwordcredentialdata-password①">(2)</a>
    <li><a href="#ref-for-dom-passwordcredentialdata-password②">3.3.5. 
    Create a PasswordCredential from PasswordCredentialData </a> <a href="#ref-for-dom-passwordcredentialdata-password③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedefdef-passwordcredentialinit">
   <b><a href="#typedefdef-passwordcredentialinit">#typedefdef-passwordcredentialinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedefdef-passwordcredentialinit">3.2. The PasswordCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialcreationoptions-password">
   <b><a href="#dom-credentialcreationoptions-password">#dom-credentialcreationoptions-password</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialcreationoptions-password">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credentialcreationoptions-password①">(2)</a> <a href="#ref-for-dom-credentialcreationoptions-password②">(3)</a> <a href="#ref-for-dom-credentialcreationoptions-password③">(4)</a> <a href="#ref-for-dom-credentialcreationoptions-password④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredential-collectfromcredentialstore-slot">
   <b><a href="#dom-passwordcredential-collectfromcredentialstore-slot">#dom-passwordcredential-collectfromcredentialstore-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredential-collectfromcredentialstore-slot">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-dom-passwordcredential-collectfromcredentialstore-slot①">6.4. Origin Confusion</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredential-create-slot">
   <b><a href="#dom-passwordcredential-create-slot">#dom-passwordcredential-create-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredential-create-slot">3.2. The PasswordCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-passwordcredential-store-slot">
   <b><a href="#dom-passwordcredential-store-slot">#dom-passwordcredential-store-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-passwordcredential-store-slot">3.2. The PasswordCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-create-a-passwordcredential-from-an-htmlformelement">
   <b><a href="#abstract-opdef-create-a-passwordcredential-from-an-htmlformelement">#abstract-opdef-create-a-passwordcredential-from-an-htmlformelement</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-create-a-passwordcredential-from-an-htmlformelement">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-abstract-opdef-create-a-passwordcredential-from-an-htmlformelement①">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata">
   <b><a href="#abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata">#abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata">3.2. The PasswordCredential Interface</a>
    <li><a href="#ref-for-abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata①">3.3.2. 
    PasswordCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-abstract-opdef-create-a-passwordcredential-from-passwordcredentialdata②">3.3.4. 
    Create a PasswordCredential from an HTMLFormElement </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="federatedcredential">
   <b><a href="#federatedcredential">#federatedcredential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-federatedcredential">2. Core API</a>
    <li><a href="#ref-for-federatedcredential①">4.1. The FederatedCredential Interface</a> <a href="#ref-for-federatedcredential②">(2)</a> <a href="#ref-for-federatedcredential③">(3)</a> <a href="#ref-for-federatedcredential④">(4)</a> <a href="#ref-for-federatedcredential⑤">(5)</a> <a href="#ref-for-federatedcredential⑥">(6)</a>
    <li><a href="#ref-for-federatedcredential⑦">4.1.1. Identifying Providers</a>
    <li><a href="#ref-for-federatedcredential⑧">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-federatedcredential⑨">4.2.2. 
    FederatedCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-federatedcredential①⓪">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-federatedcredential①①">(2)</a> <a href="#ref-for-federatedcredential①②">(3)</a>
    <li><a href="#ref-for-federatedcredential①③">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a>
    <li><a href="#ref-for-federatedcredential①④">8. Future Work</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-federatedcredentialrequestoptions">
   <b><a href="#dictdef-federatedcredentialrequestoptions">#dictdef-federatedcredentialrequestoptions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-federatedcredentialrequestoptions">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dictdef-federatedcredentialrequestoptions①">4.1.1. Identifying Providers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredentialrequestoptions-providers">
   <b><a href="#dom-federatedcredentialrequestoptions-providers">#dom-federatedcredentialrequestoptions-providers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredentialrequestoptions-providers">4.1.1. Identifying Providers</a>
    <li><a href="#ref-for-dom-federatedcredentialrequestoptions-providers①">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredentialrequestoptions-protocols">
   <b><a href="#dom-federatedcredentialrequestoptions-protocols">#dom-federatedcredentialrequestoptions-protocols</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredentialrequestoptions-protocols">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialrequestoptions-federated">
   <b><a href="#dom-credentialrequestoptions-federated">#dom-credentialrequestoptions-federated</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialrequestoptions-federated">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credentialrequestoptions-federated①">(2)</a> <a href="#ref-for-dom-credentialrequestoptions-federated②">(3)</a> <a href="#ref-for-dom-credentialrequestoptions-federated③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredential-provider">
   <b><a href="#dom-federatedcredential-provider">#dom-federatedcredential-provider</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredential-provider">4.1. The FederatedCredential Interface</a> <a href="#ref-for-dom-federatedcredential-provider①">(2)</a>
    <li><a href="#ref-for-dom-federatedcredential-provider②">4.1.1. Identifying Providers</a>
    <li><a href="#ref-for-dom-federatedcredential-provider③">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-dom-federatedcredential-provider④">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-federatedcredential-provider⑤">(2)</a> <a href="#ref-for-dom-federatedcredential-provider⑥">(3)</a> <a href="#ref-for-dom-federatedcredential-provider⑦">(4)</a>
    <li><a href="#ref-for-dom-federatedcredential-provider⑧">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredential-protocol">
   <b><a href="#dom-federatedcredential-protocol">#dom-federatedcredential-protocol</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredential-protocol">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-dom-federatedcredential-protocol①">4.2.1. 
    FederatedCredential's [[CollectFromCredentialStore]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-dom-federatedcredential-protocol②">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-dom-federatedcredential-protocol③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredential-federatedcredential">
   <b><a href="#dom-federatedcredential-federatedcredential">#dom-federatedcredential-federatedcredential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredential-federatedcredential">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-federatedcredentialinit">
   <b><a href="#dictdef-federatedcredentialinit">#dictdef-federatedcredentialinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-federatedcredentialinit">4.1. The FederatedCredential Interface</a> <a href="#ref-for-dictdef-federatedcredentialinit①">(2)</a> <a href="#ref-for-dictdef-federatedcredentialinit②">(3)</a> <a href="#ref-for-dictdef-federatedcredentialinit③">(4)</a>
    <li><a href="#ref-for-dictdef-federatedcredentialinit④">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredentialinit-origin">
   <b><a href="#dom-federatedcredentialinit-origin">#dom-federatedcredentialinit-origin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredentialinit-origin">4.2.2. 
    FederatedCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-dom-federatedcredentialinit-origin①">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredentialinit-provider">
   <b><a href="#dom-federatedcredentialinit-provider">#dom-federatedcredentialinit-provider</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredentialinit-provider">4.2.4. 
    Create a FederatedCredential from FederatedCredentialInit </a> <a href="#ref-for-dom-federatedcredentialinit-provider①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-credentialcreationoptions-federated">
   <b><a href="#dom-credentialcreationoptions-federated">#dom-credentialcreationoptions-federated</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-credentialcreationoptions-federated">4.2.2. 
    FederatedCredential's [[Create]](origin, options, sameOriginWithAncestors) </a> <a href="#ref-for-dom-credentialcreationoptions-federated①">(2)</a> <a href="#ref-for-dom-credentialcreationoptions-federated②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredential-collectfromcredentialstore-slot">
   <b><a href="#dom-federatedcredential-collectfromcredentialstore-slot">#dom-federatedcredential-collectfromcredentialstore-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredential-collectfromcredentialstore-slot">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredential-create-slot">
   <b><a href="#dom-federatedcredential-create-slot">#dom-federatedcredential-create-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredential-create-slot">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-federatedcredential-store-slot">
   <b><a href="#dom-federatedcredential-store-slot">#dom-federatedcredential-store-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-federatedcredential-store-slot">4.1. The FederatedCredential Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit">
   <b><a href="#abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit">#abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit">4.1. The FederatedCredential Interface</a>
    <li><a href="#ref-for-abstract-opdef-create-a-federatedcredential-from-federatedcredentialinit①">4.2.2. 
    FederatedCredential's [[Create]](origin, options, sameOriginWithAncestors) </a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="user-mediated">
   <b><a href="#user-mediated">#user-mediated</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-user-mediated">2.3.1. The CredentialRequestOptions Dictionary</a> <a href="#ref-for-user-mediated①">(2)</a>
    <li><a href="#ref-for-user-mediated②">2.3.2. Mediation Requirements</a> <a href="#ref-for-user-mediated③">(2)</a>
    <li><a href="#ref-for-user-mediated④">2.3.2.1. Examples</a> <a href="#ref-for-user-mediated⑤">(2)</a>
    <li><a href="#ref-for-user-mediated⑥">3.3.3. 
    PasswordCredential's [[Store]](credential, sameOriginWithAncestors) </a> <a href="#ref-for-user-mediated⑦">(2)</a>
    <li><a href="#ref-for-user-mediated⑧">4.2.3. 
    FederatedCredential's [[Store]](credential, sameOriginWithAncestors) </a>
    <li><a href="#ref-for-user-mediated⑨">5. User Mediation</a>
    <li><a href="#ref-for-user-mediated①⓪">5.1. Storing and Updating Credentials</a>
    <li><a href="#ref-for-user-mediated①①">5.2. Requiring User Mediation</a> <a href="#ref-for-user-mediated①②">(2)</a> <a href="#ref-for-user-mediated①③">(3)</a>
    <li><a href="#ref-for-user-mediated①④">5.3. Credential Selection</a>
    <li><a href="#ref-for-user-mediated①⑤">6.1. Cross-domain credential access</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credential-chooser">
   <b><a href="#credential-chooser">#credential-chooser</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credential-chooser">2.2.2. CredentialUserData Mixin</a> <a href="#ref-for-credential-chooser①">(2)</a> <a href="#ref-for-credential-chooser②">(3)</a>
    <li><a href="#ref-for-credential-chooser③">2.3.2. Mediation Requirements</a>
    <li><a href="#ref-for-credential-chooser④">2.3.2.1. Examples</a> <a href="#ref-for-credential-chooser⑤">(2)</a>
    <li><a href="#ref-for-credential-chooser⑥">3. Password Credentials</a>
    <li><a href="#ref-for-credential-chooser⑦">3.1.1. Password-based Sign-in</a>
    <li><a href="#ref-for-credential-chooser⑧">5. User Mediation</a>
    <li><a href="#ref-for-credential-chooser⑨">5.2. Requiring User Mediation</a>
    <li><a href="#ref-for-credential-chooser①⓪">6.7. Chooser Leakage</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abstract-opdef-ask-the-user-to-choose-a-credential">
   <b><a href="#abstract-opdef-ask-the-user-to-choose-a-credential">#abstract-opdef-ask-the-user-to-choose-a-credential</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abstract-opdef-ask-the-user-to-choose-a-credential">2.5.1. Request a Credential</a>
   </ul>
  </aside>
<script>/* script-var-click-highlighting */

    document.addEventListener("click", e=>{
        if(e.target.nodeName == "VAR") {
            highlightSameAlgoVars(e.target);
        }
    });
    {
        const indexCounts = new Map();
        const indexNames = new Map();
        function highlightSameAlgoVars(v) {
            // Find the algorithm container.
            let algoContainer = null;
            let searchEl = v;
            while(algoContainer == null && searchEl != document.body) {
                searchEl = searchEl.parentNode;
                if(searchEl.hasAttribute("data-algorithm")) {
                    algoContainer = searchEl;
                }
            }

            // Not highlighting document-global vars,
            // too likely to be unrelated.
            if(algoContainer == null) return;

            const algoName = algoContainer.getAttribute("data-algorithm");
            const varName = getVarName(v);
            const addClass = !v.classList.contains("selected");
            let highlightClass = null;
            if(addClass) {
                const index = chooseHighlightIndex(algoName, varName);
                indexCounts.get(algoName)[index] += 1;
                indexNames.set(algoName+"///"+varName, index);
                highlightClass = nameFromIndex(index);
            } else {
                const index = previousHighlightIndex(algoName, varName);
                indexCounts.get(algoName)[index] -= 1;
                highlightClass = nameFromIndex(index);
            }

            // Find all same-name vars, and toggle their class appropriately.
            for(const el of algoContainer.querySelectorAll("var")) {
                if(getVarName(el) == varName) {
                    el.classList.toggle("selected", addClass);
                    el.classList.toggle(highlightClass, addClass);
                }
            }
        }
        function getVarName(el) {
            return el.textContent.replace(/(\s| )+/, " ").trim();
        }
        function chooseHighlightIndex(algoName, varName) {
            let indexes = null;
            if(indexCounts.has(algoName)) {
                indexes = indexCounts.get(algoName);
            } else {
                // 7 classes right now
                indexes = [0,0,0,0,0,0,0];
                indexCounts.set(algoName, indexes);
            }

            // If the element was recently unclicked,
            // *and* that color is still unclaimed,
            // give it back the same color.
            const lastIndex = previousHighlightIndex(algoName, varName);
            if(indexes[lastIndex] === 0) return lastIndex;

            // Find the earliest index with the lowest count.
            const minCount = Math.min.apply(null, indexes);
            let index = null;
            for(var i = 0; i < indexes.length; i++) {
                if(indexes[i] == minCount) {
                    return i;
                }
            }
        }
        function previousHighlightIndex(algoName, varName) {
            return indexNames.get(algoName+"///"+varName);
        }
        function nameFromIndex(index) {
            return "selected" + index;
        }
    }
    </script>
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