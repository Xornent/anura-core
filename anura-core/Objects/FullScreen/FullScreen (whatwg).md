<!doctype html><html lang="en">
 <head>
  <meta charset="utf-8">
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="#3c790a" name="theme-color">
  <title>Fullscreen API Standard</title>
  <link crossorigin href="https://resources.whatwg.org/spec.css" rel="stylesheet">
  <link crossorigin href="https://resources.whatwg.org/standard.css" rel="stylesheet">
  <link crossorigin href="https://resources.whatwg.org/standard-shared-with-dev.css" rel="stylesheet">
  <link crossorigin href="https://resources.whatwg.org/logo-fullscreen.svg" rel="icon">
<script async crossorigin src="https://resources.whatwg.org/file-issue.js"></script>
<script async crossorigin src="https://resources.whatwg.org/commit-snapshot-shortcut-key.js"></script>
  <meta content="Bikeshed version c80ee3ab, updated Thu Mar 26 10:21:28 2020 -0700" name="generator">
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
 <body class="h-entry status-LS">
  <div class="head">
   <p data-fill-with="logo"><a class="logo" href="https://whatwg.org/"> <img alt="WHATWG" crossorigin height="100" src="https://resources.whatwg.org/logo-fullscreen.svg"> </a> </p>
   <hgroup>
    <h1 class="p-name no-ref" id="title">Fullscreen API</h1>
    <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Living Standard — Last Updated <time class="dt-updated" datetime="2020-04-01">1 April 2020</time></span></h2>
   </hgroup>
   <div data-fill-with="spec-metadata">
    <dl>
     <dt>Participate:
     <dd><a href="https://github.com/whatwg/fullscreen">GitHub whatwg/fullscreen</a> (<a href="https://github.com/whatwg/fullscreen/issues/new">new issue</a>, <a href="https://github.com/whatwg/fullscreen/issues">open issues</a>)
     <dd><a href="https://wiki.whatwg.org/wiki/IRC">IRC: #whatwg on Freenode</a>
     <dt>Commits:
     <dd><a href="https://github.com/whatwg/fullscreen/commits">GitHub whatwg/fullscreen/commits</a>
     <dd><a href="/commit-snapshots/7200301bcbe2b324af0e0906d5a4feede99830d7/" id="commit-snapshot-link">Snapshot as of this commit</a>
     <dd><a href="https://twitter.com/fullscreenapi">@fullscreenapi</a>
     <dt>Tests:
     <dd><a href="https://github.com/web-platform-tests/wpt/tree/master/fullscreen">web-platform-tests fullscreen/</a> (<a href="https://github.com/web-platform-tests/wpt/labels/fullscreen">ongoing work</a>)
     <dt>Translations <small>(non-normative)</small>:
     <dd><span title="Japanese"><a href="https://triple-underscore.github.io/fullscreen-ja.html" hreflang="ja" lang="ja" rel="alternate">日本語</a></span>
    </dl>
   </div>
   <div data-fill-with="warning"></div>
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>The Fullscreen API standard defines an API for elements to display themselves fullscreen.</p>
  </div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li><a href="#terminology"><span class="secno">1</span> <span class="content">Terminology</span></a>
    <li><a href="#model"><span class="secno">2</span> <span class="content">Model</span></a>
    <li><a href="#api"><span class="secno">3</span> <span class="content">API</span></a>
    <li><a href="#ui"><span class="secno">4</span> <span class="content">UI</span></a>
    <li>
     <a href="#rendering"><span class="secno">5</span> <span class="content">Rendering</span></a>
     <ol class="toc">
      <li><a href="#new-stacking-layer"><span class="secno">5.1</span> <span class="content">New stacking layer</span></a>
      <li><a href="#::backdrop-pseudo-element"><span class="secno">5.2</span> <span class="content"><code>::backdrop</code> pseudo-element</span></a>
      <li><a href="#:fullscreen-pseudo-class"><span class="secno">5.3</span> <span class="content"><code>:fullscreen</code> pseudo-class</span></a>
      <li><a href="#user-agent-level-style-sheet-defaults"><span class="secno">5.4</span> <span class="content">User-agent level style sheet defaults</span></a>
     </ol>
    <li><a href="#feature-policy-integration"><span class="secno">6</span> <span class="content">Feature Policy Integration</span></a>
    <li><a href="#security-and-privacy-considerations"><span class="secno">7</span> <span class="content">Security and Privacy Considerations</span></a>
    <li><a href="#acknowledgments"><span class="secno"></span> <span class="content">Acknowledgments</span></a>
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
     </ol>
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
   </ol>
  </nav>
  <main>
   <h2 class="heading settled" data-level="1" id="terminology"><span class="secno">1. </span><span class="content">Terminology</span><a class="self-link" href="#terminology"></a></h2>
   <p>This specification depends on the Infra Standard. <a data-link-type="biblio" href="#biblio-infra">[INFRA]</a> </p>
   <p>Most terminology used in this specification is from CSS, DOM, HTML, and Web IDL. <a data-link-type="biblio" href="#biblio-css">[CSS]</a> <a data-link-type="biblio" href="#biblio-dom">[DOM]</a> <a data-link-type="biblio" href="#biblio-html">[HTML]</a> <a data-link-type="biblio" href="#biblio-webidl">[WEBIDL]</a> </p>
   <p>A <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context" id="ref-for-browsing-context">browsing context</a> <var>A</var> is called a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="descendant-browsing-context">descendant browsing context</dfn> of a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context" id="ref-for-browsing-context①">browsing context</a> <var>B</var> if and only if <var>B</var> is an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#ancestor-browsing-context" id="ref-for-ancestor-browsing-context">ancestor browsing context</a> of <var>A</var>. </p>
   <h2 class="heading settled" data-level="2" id="model"><span class="secno">2. </span><span class="content">Model</span><a class="self-link" href="#model"></a></h2>
   <p>All <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element">elements</a> have an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="fullscreen-flag">fullscreen flag</dfn>. Unless stated otherwise it is
unset. </p>
   <p>All <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#the-iframe-element" id="ref-for-the-iframe-element">iframe</a></code> <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element①">elements</a> have an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="iframe-fullscreen-flag">iframe fullscreen flag</dfn>. Unless
stated otherwise it is unset. </p>
   <p>All <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document">documents</a> have an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="fullscreen-element">fullscreen element</dfn>. The <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element">fullscreen element</a> is the topmost <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element②">element</a> in the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document①">document</a>’s <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer">top layer</a> whose <a data-link-type="dfn" href="#fullscreen-flag" id="ref-for-fullscreen-flag">fullscreen flag</a> is set, if any, and null otherwise. </p>
   <p>All <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document②">documents</a> have an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="list-of-pending-fullscreen-events">list of pending fullscreen events</dfn>, which
is an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-set" id="ref-for-ordered-set">ordered set</a> of (<a data-link-type="dfn" href="https://infra.spec.whatwg.org/#string" id="ref-for-string">string</a>, <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element③">element</a>) <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#pair" id="ref-for-pair">pairs</a>. It is initially empty. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="fullscreen-an-element">fullscreen an <var>element</var></dfn>, set <var>element</var>’s <a data-link-type="dfn" href="#fullscreen-flag" id="ref-for-fullscreen-flag①">fullscreen flag</a> and <a data-link-type="dfn" href="#top-layer-add" id="ref-for-top-layer-add">add</a> it to its <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document">node document</a>’s <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer①">top layer</a>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="unfullscreen-an-element">unfullscreen an <var>element</var></dfn>, unset <var>element</var>’s <a data-link-type="dfn" href="#fullscreen-flag" id="ref-for-fullscreen-flag②">fullscreen flag</a> and <a data-link-type="dfn" href="#iframe-fullscreen-flag" id="ref-for-iframe-fullscreen-flag">iframe fullscreen flag</a> (if any), and <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-remove" id="ref-for-list-remove">remove</a> it from
its <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document①">node document</a>’s <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer②">top layer</a>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="unfullscreen-a-document">unfullscreen a <var>document</var></dfn>, <a data-link-type="dfn" href="#unfullscreen-an-element" id="ref-for-unfullscreen-an-element">unfullscreen</a> all <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element④">elements</a>, within <var>document</var>’s <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer③">top layer</a>, whose <a data-link-type="dfn" href="#fullscreen-flag" id="ref-for-fullscreen-flag③">fullscreen flag</a> is set. </p>
   <hr>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="fully-exit-fullscreen">fully exit fullscreen</dfn> a <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document③">document</a> <var>document</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>document</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①">fullscreen element</a> is null, terminate these steps. </p>
    <li>
     <p><a data-link-type="dfn" href="#unfullscreen-an-element" id="ref-for-unfullscreen-an-element①">Unfullscreen elements</a> whose <a data-link-type="dfn" href="#fullscreen-flag" id="ref-for-fullscreen-flag④">fullscreen flag</a> is
 set, within <var>document</var>’s <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer④">top layer</a>, except for <var>document</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element②">fullscreen element</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="#exit-fullscreen" id="ref-for-exit-fullscreen">Exit fullscreen</a> <var>document</var>. </p>
   </ol>
   <p id="removing-steps">Whenever the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-remove-ext" id="ref-for-concept-node-remove-ext">removing steps</a> run with a <var>removedNode</var>, run
these steps: </p>
   <ol>
    <li>
     <p>Let <var>document</var> be <var>removedNode</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document②">node document</a>. </p>
    <li>
     <p>Let <var>nodes</var> be <var>removedNode</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-shadow-including-inclusive-descendant" id="ref-for-concept-shadow-including-inclusive-descendant">shadow-including inclusive descendants</a> that have their <a data-link-type="dfn" href="#fullscreen-flag" id="ref-for-fullscreen-flag⑤">fullscreen flag</a> set, in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-shadow-including-tree-order" id="ref-for-concept-shadow-including-tree-order">shadow-including tree order</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate">For each</a> <var>node</var> in <var>nodes</var>: </p>
     <ol>
      <li>
       <p>If <var>node</var> is <var>document</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element③">fullscreen element</a>, <a data-link-type="dfn" href="#exit-fullscreen" id="ref-for-exit-fullscreen①">exit fullscreen</a> <var>document</var>. </p>
      <li>
       <p>Otherwise, <a data-link-type="dfn" href="#unfullscreen-an-element" id="ref-for-unfullscreen-an-element②">unfullscreen <var>node</var></a>. </p>
      <li>
       <p>If <var>document</var>’s <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer⑤">top layer</a> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-contain" id="ref-for-list-contain">contains</a> <var>node</var>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-remove" id="ref-for-list-remove①">remove</a> <var>node</var> from <var>document</var>’s <var>top layer</var>. </p>
       <p class="note" role="note">Other specifications can add and remove elements from <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer⑥">top layer</a>, so <var>node</var> might not be <var>document</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element④">fullscreen element</a>. For example, <var>node</var> could be an open <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/interactive-elements.html#the-dialog-element" id="ref-for-the-dialog-element">dialog</a></code> element. </p>
     </ol>
   </ol>
   <p>Whenever the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsing-the-web.html#unloading-document-cleanup-steps" id="ref-for-unloading-document-cleanup-steps">unloading document cleanup steps</a> run with a <var>document</var>, <a data-link-type="dfn" href="#fully-exit-fullscreen" id="ref-for-fully-exit-fullscreen">fully exit fullscreen</a> <var>document</var>. </p>
   <hr>
   <p><dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="fullscreen-is-supported">Fullscreen is supported</dfn> if there is no previously-established user preference,
security risk, or platform limitation. </p>
   <hr>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="run-the-fullscreen-steps">run the fullscreen steps</dfn> for a <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document④">document</a> <var>document</var>, run these
steps: </p>
   <ol>
    <li>
     <p>Let <var>pairs</var> be <var>document</var>’s <a data-link-type="dfn" href="#list-of-pending-fullscreen-events" id="ref-for-list-of-pending-fullscreen-events">list of pending fullscreen events</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-empty" id="ref-for-list-empty">Empty</a> <var>document</var>’s <a data-link-type="dfn" href="#list-of-pending-fullscreen-events" id="ref-for-list-of-pending-fullscreen-events①">list of pending fullscreen events</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate①">For each</a> (<var>type</var>, <var>element</var>) in <var>pairs</var>: </p>
     <ol>
      <li>
       <p>Let <var>target</var> be <var>element</var> if <var>element</var> is <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#connected" id="ref-for-connected">connected</a> and its <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document③">node document</a> is <var>document</var>, and otherwise let <var>target</var> be <var>document</var>. </p>
      <li>
       <p><a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-event-fire" id="ref-for-concept-event-fire">Fire an event</a> named <var>type</var>, with its <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#dom-event-bubbles" id="ref-for-dom-event-bubbles">bubbles</a></code> and <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#dom-event-composed" id="ref-for-dom-event-composed">composed</a></code> attributes set to true, at <var>target</var>. </p>
     </ol>
   </ol>
   <p class="note" role="note">These steps integrate with the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-loop" id="ref-for-event-loop">event loop</a> defined in HTML. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> </p>
   <h2 class="heading settled" data-level="3" id="api"><span class="secno">3. </span><span class="content">API</span><a class="self-link" href="#api"></a></h2>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-fullscreennavigationui"><code><c- g>FullscreenNavigationUI</c-></code></dfn> {
  <dfn class="idl-code" data-dfn-for="FullscreenNavigationUI" data-dfn-type="enum-value" data-export id="dom-fullscreennavigationui-auto"><code><c- s>"auto"</c-></code><a class="self-link" href="#dom-fullscreennavigationui-auto"></a></dfn>,
  <dfn class="idl-code" data-dfn-for="FullscreenNavigationUI" data-dfn-type="enum-value" data-export id="dom-fullscreennavigationui-show"><code><c- s>"show"</c-></code><a class="self-link" href="#dom-fullscreennavigationui-show"></a></dfn>,
  <dfn class="idl-code" data-dfn-for="FullscreenNavigationUI" data-dfn-type="enum-value" data-export id="dom-fullscreennavigationui-hide"><code><c- s>"hide"</c-></code><a class="self-link" href="#dom-fullscreennavigationui-hide"></a></dfn>
};

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-fullscreenoptions"><code><c- g>FullscreenOptions</c-></code></dfn> {
  <a class="n" data-link-type="idl-name" href="#enumdef-fullscreennavigationui" id="ref-for-enumdef-fullscreennavigationui"><c- n>FullscreenNavigationUI</c-></a> <dfn class="idl-code" data-default="&quot;auto&quot;" data-dfn-for="FullscreenOptions" data-dfn-type="dict-member" data-export data-type="FullscreenNavigationUI " id="dom-fullscreenoptions-navigationui"><code><c- g>navigationUI</c-></code><a class="self-link" href="#dom-fullscreenoptions-navigationui"></a></dfn> = "auto";
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#element" id="ref-for-element"><c- g>Element</c-></a> {
  <c- b>Promise</c->&lt;<c- b>void</c->> <a class="idl-code" data-link-type="method" href="#dom-element-requestfullscreen" id="ref-for-dom-element-requestfullscreen"><c- g>requestFullscreen</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-fullscreenoptions" id="ref-for-dictdef-fullscreenoptions"><c- n>FullscreenOptions</c-></a> <dfn class="idl-code" data-dfn-for="Element/requestFullscreen(options), Element/requestFullscreen()" data-dfn-type="argument" data-export id="dom-element-requestfullscreen-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-element-requestfullscreen-options-options"></a></dfn> = {});

  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler"><c- n>EventHandler</c-></a> <dfn class="idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-element-onfullscreenchange"><code><c- g>onfullscreenchange</c-></code><a class="self-link" href="#dom-element-onfullscreenchange"></a></dfn>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler①"><c- n>EventHandler</c-></a> <dfn class="idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-element-onfullscreenerror"><code><c- g>onfullscreenerror</c-></code><a class="self-link" href="#dom-element-onfullscreenerror"></a></dfn>;
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#document" id="ref-for-document"><c- g>Document</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#LenientSetter" id="ref-for-LenientSetter"><c- g>LenientSetter</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-document-fullscreenenabled" id="ref-for-dom-document-fullscreenenabled"><c- g>fullscreenEnabled</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#LenientSetter" id="ref-for-LenientSetter①"><c- g>LenientSetter</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Unscopable" id="ref-for-Unscopable"><c- g>Unscopable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean①"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-document-fullscreen" id="ref-for-dom-document-fullscreen"><c- g>fullscreen</c-></a>; // historical

  <c- b>Promise</c->&lt;<c- b>void</c->> <a class="idl-code" data-link-type="method" href="#dom-document-exitfullscreen" id="ref-for-dom-document-exitfullscreen"><c- g>exitFullscreen</c-></a>();

  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler②"><c- n>EventHandler</c-></a> <a class="idl-code" data-link-type="attribute" data-type="EventHandler" href="#handler-document-onfullscreenchange" id="ref-for-handler-document-onfullscreenchange"><c- g>onfullscreenchange</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler③"><c- n>EventHandler</c-></a> <a class="idl-code" data-link-type="attribute" data-type="EventHandler" href="#handler-document-onfullscreenerror" id="ref-for-handler-document-onfullscreenerror"><c- g>onfullscreenerror</c-></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#documentorshadowroot" id="ref-for-documentorshadowroot"><c- g>DocumentOrShadowRoot</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#LenientSetter" id="ref-for-LenientSetter②"><c- g>LenientSetter</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element" id="ref-for-element①"><c- n>Element</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="Element?" href="#dom-document-fullscreenelement" id="ref-for-dom-document-fullscreenelement"><c- g>fullscreenElement</c-></a>;
};
</pre>
   <dl class="domintro">
    <dt><code><var>promise</var> = <var>element</var> . <a class="idl-code" data-link-type="method" href="#dom-element-requestfullscreen" id="ref-for-dom-element-requestfullscreen①">requestFullscreen([<var>options</var>])</a></code> 
    <dd>
      Displays <var>element</var> fullscreen and resolves <var>promise</var> when done. 
     <p>When supplied, <var>options</var>’s <code>navigationUI</code> member indicates whether showing
  navigation UI while in fullscreen is preferred or not. If set to "<code>show</code>", navigation
  simplicity is preferred over screen space, and if set to "<code>hide</code>", more screen space
  is preferred. User agents are always free to honor user preference over the application’s. The
  default value "<code>auto</code>" indicates no application preference.</p>
    <dt><code><var>document</var> . <code class="idl"><a data-link-type="idl" href="#dom-document-fullscreenenabled" id="ref-for-dom-document-fullscreenenabled①">fullscreenEnabled</a></code></code> 
    <dd>
     <p>Returns true if <var>document</var> has the ability to display <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element⑤">elements</a> fullscreen
 and <a data-link-type="dfn" href="#fullscreen-is-supported" id="ref-for-fullscreen-is-supported">fullscreen is supported</a>, or false otherwise. </p>
    <dt><code><var>promise</var> = <var>document</var> . <code class="idl"><a data-link-type="idl" href="#dom-document-exitfullscreen" id="ref-for-dom-document-exitfullscreen①">exitFullscreen()</a></code></code> 
    <dd>
     <p>Stops <var>document</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element⑤">fullscreen element</a> from being displayed fullscreen and
 resolves <var>promise</var> when done. </p>
    <dt><code><var>document</var> . <code class="idl"><a data-link-type="idl" href="#dom-document-fullscreenelement" id="ref-for-dom-document-fullscreenelement①">fullscreenElement</a></code></code> 
    <dd>
     <p>Returns <var>document</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element⑥">fullscreen element</a>. </p>
    <dt><code><var>shadowroot</var> . <code class="idl"><a data-link-type="idl" href="#dom-document-fullscreenelement" id="ref-for-dom-document-fullscreenelement②">fullscreenElement</a></code></code> 
    <dd>
     <p>Returns <var>shadowroot</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element⑦">fullscreen element</a>. </p>
   </dl>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="fullscreen-element-ready-check">fullscreen element ready check</dfn> for an <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element⑥">element</a> <var>element</var> returns true
if all of the following are true, and false otherwise: </p>
   <ul>
    <li>
     <p><var>element</var> is <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#connected" id="ref-for-connected①">connected</a>. </p>
    <li>
     <p><var>element</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document④">node document</a> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#allowed-to-use" id="ref-for-allowed-to-use">allowed to use</a> the "<code><a data-link-type="dfn" href="#fullscreen-feature" id="ref-for-fullscreen-feature">fullscreen</a></code>" feature. </p>
   </ul>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="method" data-export data-lt="requestFullscreen(options)|requestFullscreen()" id="dom-element-requestfullscreen"><code>requestFullscreen(<var>options</var>)</code></dfn> method,
when invoked, must run these steps: </p>
   <ol>
    <li>
     <p>Let <var>pending</var> be the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object">context object</a>. </p>
    <li>
     <p>Let <var>pendingDoc</var> be <var>pending</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document⑤">node document</a>. </p>
    <li>
     <p>Let <var>promise</var> be a new promise. </p>
    <li>
     <p>If <var>pendingDoc</var> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#fully-active" id="ref-for-fully-active">fully active</a>, then reject <var>promise</var> with a <code>TypeError</code> exception and return <var>promise</var>. </p>
    <li>
     <p>Let <var>error</var> be false. </p>
    <li>
     <p>If any of the following conditions are false, then set <var>error</var> to true: </p>
     <ul>
      <li>
       <p><var>pending</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element-namespace" id="ref-for-concept-element-namespace">namespace</a> is the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#html-namespace" id="ref-for-html-namespace">HTML namespace</a> or <var>pending</var> is an <a href="https://www.w3.org/TR/SVG11/struct.html#SVGElement">SVG <code>svg</code></a> or <a href="https://www.w3.org/Math/draft-spec/chapter2.html#interf.toplevel">MathML <code>math</code></a> element. <a data-link-type="biblio" href="#biblio-svg">[SVG]</a> <a data-link-type="biblio" href="#biblio-mathml">[MATHML]</a> </p>
      <li>
       <p><var>pending</var> is not a <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/interactive-elements.html#the-dialog-element" id="ref-for-the-dialog-element①">dialog</a></code> element. </p>
      <li>
       <p>The <a data-link-type="dfn" href="#fullscreen-element-ready-check" id="ref-for-fullscreen-element-ready-check">fullscreen element ready check</a> for <var>pending</var> returns true. </p>
      <li>
       <p><a data-link-type="dfn" href="#fullscreen-is-supported" id="ref-for-fullscreen-is-supported①">Fullscreen is supported</a>. </p>
      <li>
       <p><var>pending</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-relevant-global" id="ref-for-concept-relevant-global">relevant global object</a> has <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/interaction.html#transient-activation" id="ref-for-transient-activation">transient activation</a> or the
   algorithm is <a data-link-type="dfn" href="https://w3c.github.io/screen-orientation/#dfn-triggered-by-a-user-generated-orientation-change" id="ref-for-dfn-triggered-by-a-user-generated-orientation-change">triggered by a user generated orientation change</a>. </p>
     </ul>
    <li>
     <p>Return <var>promise</var>, and run the remaining steps <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel">in parallel</a>. </p>
    <li>
     <p>If <var>error</var> is false, then resize <var>pendingDoc</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#top-level-browsing-context" id="ref-for-top-level-browsing-context">top-level browsing context</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document">active document</a>’s viewport’s dimensions, optionally
  taking into account <var>options</var>’s <code>navigationUI</code> member: </p>
     <table>
      <thead>
       <tr>
        <th>value
        <th>viewport dimensions
      <tbody>
       <tr>
        <td>"<code>hide</code>"
        <td>full dimensions of the screen of the output device
       <tr>
        <td>"<code>show</code>"
        <td>dimensions of the screen of the output device clamped to allow the user agent to show page navigation controls
       <tr>
        <td>"<code>auto</code>"
        <td>user-agent defined, but matching one of the above
     </table>
     <p>Optionally display a message how the end user can revert this. </p>
    <li>
     <p>If any of the following conditions are false, then set <var>error</var> to true: </p>
     <ul>
      <li>
       <p><var>pending</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document⑥">node document</a> is <var>pendingDoc</var>. </p>
      <li>
       <p>The <a data-link-type="dfn" href="#fullscreen-element-ready-check" id="ref-for-fullscreen-element-ready-check①">fullscreen element ready check</a> for <var>pending</var> returns true. </p>
     </ul>
    <li>
     <p>If <var>error</var> is true: </p>
     <ol>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append">Append</a> (<code>fullscreenerror</code>, <var>pending</var>) to <var>pendingDoc</var>’s <a data-link-type="dfn" href="#list-of-pending-fullscreen-events" id="ref-for-list-of-pending-fullscreen-events②">list of pending fullscreen events</a>. </p>
      <li>
       <p>Reject <var>promise</var> with a <code>TypeError</code> exception and terminate these
   steps. </p>
     </ol>
    <li>
     <p>Let <var>fullscreenElements</var> be an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-set" id="ref-for-ordered-set①">ordered set</a> initially consisting of <var>pending</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-while" id="ref-for-iteration-while">While</a> the last element in <var>fullscreenElements</var> is in a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#nested-browsing-context" id="ref-for-nested-browsing-context">nested browsing context</a>: <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append①">append</a> its <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context-container" id="ref-for-browsing-context-container">browsing context container</a> to <var>fullscreenElements</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate②">For each</a> <var>element</var> in <var>fullscreenElements</var>: </p>
     <ol>
      <li>
       <p>Let <var>doc</var> be <var>element</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document⑦">node document</a>. </p>
      <li>
       <p>If <var>element</var> is <var>doc</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element⑧">fullscreen element</a>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-continue" id="ref-for-iteration-continue">continue</a>. </p>
       <p class="note" role="note">No need to notify observers when nothing has changed. </p>
      <li>
       <p>If <var>element</var> is <var>pending</var> and <var>pending</var> is an <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#the-iframe-element" id="ref-for-the-iframe-element①">iframe</a></code> <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element⑦">element</a>, then set <var>element</var>’s <a data-link-type="dfn" href="#iframe-fullscreen-flag" id="ref-for-iframe-fullscreen-flag①">iframe fullscreen flag</a>. </p>
      <li>
       <p><a data-link-type="dfn" href="#fullscreen-an-element" id="ref-for-fullscreen-an-element">Fullscreen <var>element</var></a> within <var>doc</var>. </p>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append②">Append</a> (<code>fullscreenchange</code>, <var>element</var>) to <var>doc</var>’s <a data-link-type="dfn" href="#list-of-pending-fullscreen-events" id="ref-for-list-of-pending-fullscreen-events③">list of pending fullscreen events</a>. </p>
     </ol>
     <p class="note" role="note">The order in which elements are <a data-link-type="dfn" href="#fullscreen-an-element" id="ref-for-fullscreen-an-element①">fullscreened</a> is not observable, because <a data-link-type="dfn" href="#run-the-fullscreen-steps" id="ref-for-run-the-fullscreen-steps">run the fullscreen steps</a> is invoked in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-tree-order" id="ref-for-concept-tree-order">tree order</a>. </p>
    <li>
     <p>Resolve <var>promise</var> with undefined. </p>
   </ol>
   <p class="note" role="note">Implementations with out-of-process <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context" id="ref-for-browsing-context②">browsing contexts</a> are left as an
exercise to the reader. Input welcome on potential improvements. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Document" data-dfn-type="attribute" data-export id="dom-document-fullscreenenabled"><code>fullscreenEnabled</code></dfn> attribute’s getter must
return true if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①">context object</a> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#allowed-to-use" id="ref-for-allowed-to-use①">allowed to use</a> the "<code><a data-link-type="dfn" href="#fullscreen-feature" id="ref-for-fullscreen-feature①">fullscreen</a></code>" feature and <a data-link-type="dfn" href="#fullscreen-is-supported" id="ref-for-fullscreen-is-supported②">fullscreen is supported</a>, and
false otherwise. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Document" data-dfn-type="attribute" data-export id="dom-document-fullscreen"><code>fullscreen</code></dfn> attribute’s getter must return
false if <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②">context object</a>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element⑨">fullscreen element</a> is null, and true otherwise. </p>
   <p class="note" role="note">Use the <code class="idl"><a data-link-type="idl" href="#dom-document-fullscreenelement" id="ref-for-dom-document-fullscreenelement③">fullscreenElement</a></code> attribute instead. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="DocumentOrShadowRoot" data-dfn-type="attribute" data-export id="dom-document-fullscreenelement"><code>fullscreenElement</code></dfn> attribute’s getter must run these steps: </p>
   <ol>
    <li>
     <p>If the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③">context object</a> is a <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-shadow-root" id="ref-for-concept-shadow-root">shadow root</a> and its <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-documentfragment-host" id="ref-for-concept-documentfragment-host">host</a> is not <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#connected" id="ref-for-connected②">connected</a>, then return null.</p>
    <li>
     <p>Let <var>candidate</var> be the result of <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#retarget" id="ref-for-retarget">retargeting</a> <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①⓪">fullscreen element</a> against the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④">context object</a>. </p>
    <li>
     <p>If <var>candidate</var> and the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑤">context object</a> are in the same <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-tree" id="ref-for-concept-tree">tree</a>, then
 return <var>candidate</var>. </p>
    <li>
     <p>Return null. </p>
   </ol>
   <p>A <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document⑤">document</a> is said to be a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="simple-fullscreen-document">simple fullscreen document</dfn> if there is exactly one <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element⑧">element</a> in its <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer⑦">top layer</a> that has its <a data-link-type="dfn" href="#fullscreen-flag" id="ref-for-fullscreen-flag⑥">fullscreen flag</a> set. </p>
   <p class="note" role="note">A <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document⑥">document</a> with two <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element⑨">elements</a> in its <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer⑧">top layer</a> can be a <a data-link-type="dfn" href="#simple-fullscreen-document" id="ref-for-simple-fullscreen-document">simple fullscreen document</a>. For example, in addition to the <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①①">fullscreen element</a> there
could be an open <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/interactive-elements.html#the-dialog-element" id="ref-for-the-dialog-element②">dialog</a></code> element. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="collect-documents-to-unfullscreen">collect documents to unfullscreen</dfn> given <var>doc</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>docs</var> be an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-set" id="ref-for-ordered-set②">ordered set</a> consisting of <var>doc</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-while" id="ref-for-iteration-while①">While</a> true: </p>
     <ol>
      <li>
       <p>Let <var>lastDoc</var> be <var>docs</var>’s last <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document⑦">document</a>. </p>
      <li>
       <p>Assert: <var>lastDoc</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①②">fullscreen element</a> is not null. </p>
      <li>
       <p>If <var>lastDoc</var> is not a <a data-link-type="dfn" href="#simple-fullscreen-document" id="ref-for-simple-fullscreen-document①">simple fullscreen document</a>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-break" id="ref-for-iteration-break">break</a>. </p>
      <li>
       <p>Let <var>container</var> be <var>lastDoc</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context-container" id="ref-for-browsing-context-container①">browsing context container</a>, if
   any, and otherwise <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-break" id="ref-for-iteration-break①">break</a>. </p>
      <li>
       <p>If <var>container</var>’s <a data-link-type="dfn" href="#iframe-fullscreen-flag" id="ref-for-iframe-fullscreen-flag②">iframe fullscreen flag</a> is set, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-break" id="ref-for-iteration-break②">break</a>. </p>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append③">Append</a> <var>container</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document⑧">node document</a> to <var>docs</var>. </p>
     </ol>
    <li>
     <p>Return <var>docs</var>. </p>
     <p class="note" role="note">This is the set of documents for which the <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①③">fullscreen element</a> will be <a data-link-type="dfn" href="#unfullscreen-an-element" id="ref-for-unfullscreen-an-element③">unfullscreened</a>, but the last document in <var>docs</var> might
 have more than one <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element①⓪">element</a> in its <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer⑨">top layer</a> with the <a data-link-type="dfn" href="#fullscreen-flag" id="ref-for-fullscreen-flag⑦">fullscreen flag</a> set,
 in which case that document will still remain in fullscreen. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="exit-fullscreen">exit fullscreen</dfn> a <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document⑧">document</a> <var>doc</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>promise</var> be a new promise. </p>
    <li>
     <p>If <var>doc</var> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#fully-active" id="ref-for-fully-active①">fully active</a> or <var>doc</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①④">fullscreen element</a> is null, then reject <var>promise</var> with a <code>TypeError</code> exception and return <var>promise</var>. </p>
    <li>
     <p>Let <var>resize</var> be false. </p>
    <li>
     <p>Let <var>docs</var> be the result of <a data-link-type="dfn" href="#collect-documents-to-unfullscreen" id="ref-for-collect-documents-to-unfullscreen">collecting documents to unfullscreen</a> given <var>doc</var>. </p>
    <li>
     <p>Let <var>topLevelDoc</var> be <var>doc</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#top-level-browsing-context" id="ref-for-top-level-browsing-context①">top-level browsing context</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document①">active document</a>. </p>
    <li>
     <p>If <var>topLevelDoc</var> is in <var>docs</var>, and it is a <a data-link-type="dfn" href="#simple-fullscreen-document" id="ref-for-simple-fullscreen-document②">simple fullscreen document</a>, then set <var>doc</var> to <var>topLevelDoc</var> and <var>resize</var> to true. </p>
    <li>
     <p>If <var>doc</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①⑤">fullscreen element</a> is not <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#connected" id="ref-for-connected③">connected</a>: </p>
     <ol>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append④">Append</a> (<code>fullscreenchange</code>, <var>doc</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①⑥">fullscreen element</a>) to <var>doc</var>’s <a data-link-type="dfn" href="#list-of-pending-fullscreen-events" id="ref-for-list-of-pending-fullscreen-events④">list of pending fullscreen events</a>. </p>
     </ol>
    <li>
     <p>Return <var>promise</var>, and run the remaining steps <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel①">in parallel</a>. </p>
    <li>
     <p>If <var>resize</var> is true, resize <var>doc</var>’s viewport to its "normal" dimensions. </p>
    <li>
     <p>If <var>doc</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①⑦">fullscreen element</a> is null, then resolve <var>promise</var> with
 undefined and terminate these steps. </p>
    <li>
     <p>Let <var>exitDocs</var> be the result of <a data-link-type="dfn" href="#collect-documents-to-unfullscreen" id="ref-for-collect-documents-to-unfullscreen①">collecting documents to unfullscreen</a> given <var>doc</var>. </p>
    <li>
     <p>Let <var>descendantDocs</var> be an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-set" id="ref-for-ordered-set③">ordered set</a> consisting of <var>doc</var>’s <a data-link-type="dfn" href="#descendant-browsing-context" id="ref-for-descendant-browsing-context">descendant browsing contexts</a>' <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document②">active documents</a> whose <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①⑧">fullscreen element</a> is
 non-null, if any, in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-tree-order" id="ref-for-concept-tree-order①">tree order</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate③">For each</a> <var>exitDoc</var> in <var>exitDocs</var>: </p>
     <ol>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append⑤">Append</a> (<code>fullscreenchange</code>, <var>exitDoc</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element①⑨">fullscreen element</a>) to <var>exitDoc</var>’s <a data-link-type="dfn" href="#list-of-pending-fullscreen-events" id="ref-for-list-of-pending-fullscreen-events⑤">list of pending fullscreen events</a>. </p>
      <li>
       <p>If <var>resize</var> is true, <a data-link-type="dfn" href="#unfullscreen-a-document" id="ref-for-unfullscreen-a-document">unfullscreen <var>exitDoc</var></a>. </p>
      <li>
       <p>Otherwise, <a data-link-type="dfn" href="#unfullscreen-an-element" id="ref-for-unfullscreen-an-element④">unfullscreen</a> <var>exitDoc</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element②⓪">fullscreen element</a>. </p>
     </ol>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate④">For each</a> <var>descendantDoc</var> in <var>descendantDocs</var>: </p>
     <ol>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append⑥">Append</a> (<code>fullscreenchange</code>, <var>descendantDoc</var>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element②①">fullscreen element</a>) to <var>descendantDoc</var>’s <a data-link-type="dfn" href="#list-of-pending-fullscreen-events" id="ref-for-list-of-pending-fullscreen-events⑥">list of pending fullscreen events</a>. </p>
      <li>
       <p><a data-link-type="dfn" href="#unfullscreen-a-document" id="ref-for-unfullscreen-a-document①">Unfullscreen <var>descendantDoc</var></a>. </p>
     </ol>
     <p class="note" role="note">The order in which documents are <a data-link-type="dfn" href="#unfullscreen-a-document" id="ref-for-unfullscreen-a-document②">unfullscreened</a> is not observable, because <a data-link-type="dfn" href="#run-the-fullscreen-steps" id="ref-for-run-the-fullscreen-steps①">run the fullscreen steps</a> is invoked in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-tree-order" id="ref-for-concept-tree-order②">tree order</a>. </p>
    <li>
     <p>Resolve <var>promise</var> with undefined. </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Document" data-dfn-type="method" data-export id="dom-document-exitfullscreen"><code>exitFullscreen()</code></dfn> method, when invoked, must
return the result of running <a data-link-type="dfn" href="#exit-fullscreen" id="ref-for-exit-fullscreen②">exit fullscreen</a> on the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑥">context object</a>. </p>
   <hr>
   <p>The following are the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers" id="ref-for-event-handlers">event handlers</a> (and their corresponding <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type" id="ref-for-event-handler-event-type">event handler event types</a>) that must be supported by <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element②">Element</a></code> and <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①">Document</a></code> objects as <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes" id="ref-for-event-handler-idl-attributes">event handler IDL attributes</a>: </p>
   <table>
    <thead>
     <tr>
      <th><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers" id="ref-for-event-handlers①">event handler</a> 
      <th><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type" id="ref-for-event-handler-event-type①">event handler event type</a> 
    <tbody>
     <tr>
      <td><dfn class="dfn-paneled idl-code" data-dfn-for="Document" data-dfn-type="attribute" data-export id="handler-document-onfullscreenchange"><code>onfullscreenchange</code></dfn> 
      <td><code>fullscreenchange</code> 
     <tr>
      <td><dfn class="dfn-paneled idl-code" data-dfn-for="Document" data-dfn-type="attribute" data-export id="handler-document-onfullscreenerror"><code>onfullscreenerror</code></dfn> 
      <td><code>fullscreenerror</code> 
   </table>
   <p class="note" role="note">These are not supported by <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#shadowroot" id="ref-for-shadowroot">ShadowRoot</a></code> or <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window">Window</a></code> objects, and there are no
corresponding <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-content-attributes" id="ref-for-event-handler-content-attributes">event handler content attributes</a> for <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element③">Element</a></code> objects in any namespace. </p>
   <h2 class="heading settled" data-level="4" id="ui"><span class="secno">4. </span><span class="content">UI</span><a class="self-link" href="#ui"></a></h2>
   <p>User agents are encouraged to implement native media fullscreen controls in terms of <code class="idl"><a data-link-type="idl" href="#dom-element-requestfullscreen" id="ref-for-dom-element-requestfullscreen②">requestFullscreen()</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-document-exitfullscreen" id="ref-for-dom-document-exitfullscreen②">exitFullscreen()</a></code>. </p>
   <p>If the end user instructs the user agent to end a fullscreen session initiated via <code class="idl"><a data-link-type="idl" href="#dom-element-requestfullscreen" id="ref-for-dom-element-requestfullscreen③">requestFullscreen()</a></code>, <a data-link-type="dfn" href="#fully-exit-fullscreen" id="ref-for-fully-exit-fullscreen①">fully exit fullscreen</a> the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#top-level-browsing-context" id="ref-for-top-level-browsing-context②">top-level browsing context</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document③">active document</a>. </p>
   <p>The user agent may end any fullscreen session without instruction from the end user
or call to <code class="idl"><a data-link-type="idl" href="#dom-document-exitfullscreen" id="ref-for-dom-document-exitfullscreen③">exitFullscreen()</a></code> whenever the user agent deems it necessary. </p>
   <h2 class="heading settled" data-level="5" id="rendering"><span class="secno">5. </span><span class="content">Rendering</span><a class="self-link" href="#rendering"></a></h2>
   <p>This section is to be interpreted equivalently to the Rendering section of HTML. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> </p>
   <p class="XXX">Long term CSS will define the <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer①⓪">top layer</a> concept and its associated <a class="css" data-link-type="selector" href="#css-pe-backdrop" id="ref-for-css-pe-backdrop"><code>::backdrop</code></a> pseudo-element as part of CSS' stacking context model. Patching CSS
as done here is sketchy as hell. </p>
   <h3 class="heading settled" data-level="5.1" id="new-stacking-layer"><span class="secno">5.1. </span><span class="content">New stacking layer</span><a class="self-link" href="#new-stacking-layer"></a></h3>
   <p>This specification introduces a new stacking layer to the <a href="https://www.w3.org/TR/CSS2/zindex.html">Elaborate description of Stacking Contexts</a> of CSS
2.1. It is called the <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="top-layer">top layer</dfn>, comes after step 10 in the painting order, and is
therefore rendered closest to the user within a viewport. Each <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document⑨">document</a> has one
associated viewport and therefore also one <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer①①">top layer</a>. <a data-link-type="biblio" href="#biblio-css">[CSS]</a> </p>
   <p class="note" role="note">The terminology used in this and following subsection attempts to match CSS 2.1
Appendix E. </p>
   <p>The <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer①②">top layer</a> is an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-set" id="ref-for-ordered-set④">ordered set</a> of elements, rendered in the order they appear in
the set. The last element in the set is rendered last, and thus appears on top. </p>
   <p class="note" role="note">The <code>z-index</code> property has no effect in the <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer①③">top layer</a>. </p>
   <p>Each element and <a class="css" data-link-type="selector" href="#css-pe-backdrop" id="ref-for-css-pe-backdrop①"><code>::backdrop</code></a> pseudo-element in a <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer①④">top layer</a> has the
following characteristics: </p>
   <ul>
    <li>
     <p>It generates a new stacking context. </p>
    <li>
     <p>Its parent stacking context is the root stacking context. </p>
    <li>
     <p>If it consists of multiple layout boxes, the first box is used. </p>
    <li>
     <p>It is rendered as an atomic unit as if it were a sibling of its <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-tree-root" id="ref-for-concept-tree-root">root</a>. </p>
     <p class="note" role="note"><a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-tree-ancestor" id="ref-for-concept-tree-ancestor">Ancestor</a> elements with overflow, opacity, masks, etc. cannot affect
  it. </p>
    <li>
     <p>If its <code>position</code> property computes to <code>fixed</code>, its containing block
 is the viewport, and the initial containing block otherwise. </p>
    <li>
     <p>If it is an element, it and its <a class="css" data-link-type="selector" href="#css-pe-backdrop" id="ref-for-css-pe-backdrop②"><code>::backdrop</code></a> pseudo-element are not
 rendered if its <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-shadow-including-inclusive-ancestor" id="ref-for-concept-shadow-including-inclusive-ancestor">shadow-including inclusive ancestor</a> has the <code>display</code> property
 set to <code>none</code>. </p>
    <li>
     <p>If its specified <code>display</code> property is <code>contents</code>, it computes to <code>block</code>. </p>
    <li>
     <p>If its specified <code>position</code> property is not <code>absolute</code> or <code>fixed</code>, it computes to <code>absolute</code>. </p>
    <li>
     <p>Its outline, if any, is to be rendered before step 10 in the painting order. </p>
    <li>
     <p>Unless overridden by another specification, its static position for <code>left</code>, <code>right</code>, and <code>top</code> is zero. </p>
   </ul>
   <p>To <dfn class="dfn-paneled" data-dfn-for="top layer" data-dfn-type="dfn" data-export id="top-layer-add">add</dfn> an <var>element</var> to a <var>top layer</var>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-remove" id="ref-for-list-remove②">remove</a> it from <var>top layer</var> and then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append⑦">append</a> it to <var>top layer</var>. </p>
   <p class="note" role="note">In other words, <var>element</var> is moved to the end of <var>top layer</var> if it
is already present. </p>
   <h3 class="heading settled" data-level="5.2" id="::backdrop-pseudo-element"><span class="secno">5.2. </span><span class="content"><code>::backdrop</code> pseudo-element</span><a class="self-link" href="#::backdrop-pseudo-element"></a></h3>
   <p>Each element in a <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer①⑤">top layer</a> has a <dfn class="dfn-paneled css" data-dfn-type="selector" data-export id="css-pe-backdrop"><code>::backdrop</code></dfn> pseudo-element. This pseudo-element
is a box rendered immediately below the element (and above the element before the element in the
set, if any), within the same <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer①⑥">top layer</a>. </p>
   <p class="note" role="note">The <a class="css" data-link-type="selector" href="#css-pe-backdrop" id="ref-for-css-pe-backdrop③"><code>::backdrop</code></a> pseudo-element can be used to create a backdrop
that hides the underlying document for an element in a <a data-link-type="dfn" href="#top-layer" id="ref-for-top-layer①⑦">top layer</a> (such as an element that is
displayed fullscreen). </p>
   <p>It does not inherit from any element and is not inherited from. No restrictions are made on what
properties apply to this pseudo-element either. </p>
   <h3 class="heading settled" data-level="5.3" id=":fullscreen-pseudo-class"><span class="secno">5.3. </span><span class="content"><code>:fullscreen</code> pseudo-class</span><a class="self-link" href="#:fullscreen-pseudo-class"></a></h3>
   <p>The <dfn class="css" data-dfn-type="selector" data-export id="css-pc-fullscreen"><code>:fullscreen</code><a class="self-link" href="#css-pc-fullscreen"></a></dfn> pseudo-class must match any <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element" id="ref-for-concept-element①①">element</a> <var>element</var> for which one of the following conditions is true: </p>
   <ul>
    <li>
     <p><var>element</var>’s <a data-link-type="dfn" href="#fullscreen-flag" id="ref-for-fullscreen-flag⑧">fullscreen flag</a> is set. </p>
    <li>
     <p><var>element</var> is a <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#element-shadow-host" id="ref-for-element-shadow-host">shadow host</a> and the result of <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#retarget" id="ref-for-retarget①">retargeting</a> its <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document⑨">node document</a>’s <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element②②">fullscreen element</a> against <var>element</var> is <var>element</var>. </p>
   </ul>
   <p class="note no-backref" role="note">This makes it different from the <code class="idl"><a data-link-type="idl" href="#dom-document-fullscreenelement" id="ref-for-dom-document-fullscreenelement④">fullscreenElement</a></code> API, which returns the topmost <a data-link-type="dfn" href="#fullscreen-element" id="ref-for-fullscreen-element②③">fullscreen element</a>. </p>
   <h3 class="heading settled" data-level="5.4" id="user-agent-level-style-sheet-defaults"><span class="secno">5.4. </span><span class="content">User-agent level style sheet defaults</span><a class="self-link" href="#user-agent-level-style-sheet-defaults"></a></h3>
<pre class="css">@namespace "http://www.w3.org/1999/xhtml";

*|*:not(:root):fullscreen {
  position:fixed !important;
  top:0 !important; right:0 !important; bottom:0 !important; left:0 !important;
  margin:0 !important;
  box-sizing:border-box !important;
  min-width:0 !important;
  max-width:none !important;
  min-height:0 !important;
  max-height:none !important;
  width:100% !important;
  height:100% !important;
  transform:none !important;

  /* intentionally not !important */
  object-fit:contain;
}

iframe:fullscreen {
  border:none !important;
  padding:0 !important;
}

::backdrop {
  position:fixed;
  top:0; right:0; bottom:0; left:0;
}

*|*:not(:root):fullscreen::backdrop {
  background:black;
}
</pre>
   <h2 class="heading settled" data-level="6" id="feature-policy-integration"><span class="secno">6. </span><span class="content">Feature Policy Integration</span><a class="self-link" href="#feature-policy-integration"></a></h2>
   <p>This specification defines a <a data-link-type="dfn" href="https://wicg.github.io/feature-policy/#policy-controlled-feature" id="ref-for-policy-controlled-feature">policy-controlled feature</a> identified by the string
"<code><dfn class="dfn-paneled" data-dfn-type="dfn" data-lt="fullscreen-feature" data-noexport id="fullscreen-feature">fullscreen</dfn></code>". Its <a data-link-type="dfn" href="https://wicg.github.io/feature-policy/#default-allowlist" id="ref-for-default-allowlist">default allowlist</a> is <code>'self'</code>. </p>
   <div class="note" role="note">
    <p>A <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document①⓪">document</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/dom.html#concept-document-feature-policy" id="ref-for-concept-document-feature-policy">feature policy</a> determines whether any content in that document is allowed to
go fullscreen. If disabled in any document, no content in the document will be <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#allowed-to-use" id="ref-for-allowed-to-use②">allowed to use</a> fullscreen. </p>
    <p>The <code><a data-link-type="element-sub" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#attr-iframe-allowfullscreen" id="ref-for-attr-iframe-allowfullscreen">allowfullscreen</a></code> attribute of the HTML <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#the-iframe-element" id="ref-for-the-iframe-element②">iframe</a></code> element affects the <a data-link-type="dfn" href="https://wicg.github.io/feature-policy/#container-policy" id="ref-for-container-policy">container
policy</a> for any document nested in that iframe. Unless overridden by the <code><a data-link-type="element-sub" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#attr-iframe-allow" id="ref-for-attr-iframe-allow">allow</a></code> attribute, setting <code><a data-link-type="element-sub" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#attr-iframe-allowfullscreen" id="ref-for-attr-iframe-allowfullscreen①">allowfullscreen</a></code> on an iframe is equivalent to <code>&lt;iframe
allow="fullscreen *"></code>, as described in <a href="https://wicg.github.io/feature-policy/#iframe-allowfullscreen-attribute">Feature Policy §6.3.1 allowfullscreen</a>. </p>
   </div>
   <h2 class="heading settled" data-level="7" id="security-and-privacy-considerations"><span class="secno">7. </span><span class="content">Security and Privacy Considerations</span><a class="self-link" href="#security-and-privacy-considerations"></a></h2>
   <p>User agents should ensure, e.g. by means of an overlay, that the end user is aware something is
displayed fullscreen. User agents should provide a means of exiting fullscreen that always works and
advertise this to the user. This is to prevent a site from spoofing the end user by recreating the
user agent or even operating system environment when fullscreen. See also the definition of <code class="idl"><a data-link-type="idl" href="#dom-element-requestfullscreen" id="ref-for-dom-element-requestfullscreen④">requestFullscreen()</a></code>. </p>
   <p>To enable content in a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#nested-browsing-context" id="ref-for-nested-browsing-context①">nested browsing context</a> to go fullscreen, it needs to be
specifically allowed via feature policy, either through the <code><a data-link-type="element-sub" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#attr-iframe-allowfullscreen" id="ref-for-attr-iframe-allowfullscreen②">allowfullscreen</a></code> attribute of
the HTML <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#the-iframe-element" id="ref-for-the-iframe-element③">iframe</a></code> element, or an appropriate declaration in the <code><a data-link-type="element-sub" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#attr-iframe-allow" id="ref-for-attr-iframe-allow①">allow</a></code> attribute of the
HTML <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#the-iframe-element" id="ref-for-the-iframe-element④">iframe</a></code> element, or through a `<a data-link-type="http-header" href="https://wicg.github.io/feature-policy/#feature-policy-header" id="ref-for-feature-policy-header"><code>Feature-Policy</code></a>` HTTP header
delivered with the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document①①">document</a> through which it is nested. </p>
   <p>This prevents e.g. content from third parties to go fullscreen without explicit permission. </p>
   <h2 class="no-num heading settled" id="acknowledgments"><span class="content">Acknowledgments</span><a class="self-link" href="#acknowledgments"></a></h2>
   <p>Many thanks to Robert O’Callahan for designing the initial model and being awesome. </p>
   <p>Thanks to
Andy Earnshaw,
Changwan Hong,
Chris Pearce,
Darin Fisher,
Dave Tapuska, <i>fantasai</i>,
Giuseppe Pascale,
Glenn Maynard,
Ian Clelland,
Ian Hickson,
Ignacio Solla,
João Eiras,
Josh Soref,
Kagami Sascha Rosylight,
Matt Falkenhagen,
Mihai Balan,
Mounir Lamouri,
Øyvind Stenhaug,
Pat Ladd,
Rafał Chłodnicki,
Riff Jiang,
Rune Lillesveen,
Sigbjørn Vik,
Simon Pieters,
Tab Atkins,
Takayoshi Kochi,
Theresa O’Connor,
triple-underscore,
Vincent Scheib, and
Xidorn Quan
for also being awesome. </p>
   <p>This standard is edited by <a href="https://foolip.org/" lang="sv">Philip Jägenstedt</a> (<a href="https://google.com/">Google</a>, <a href="mailto:philip@foolip.org">philip@foolip.org</a>). It was originally written by <a href="https://annevankesteren.nl/" lang="nl">Anne van Kesteren</a> (<a href="https://www.mozilla.org/">Mozilla</a>, <a href="mailto:annevk@annevk.nl">annevk@annevk.nl</a>). <a href="http://tantek.com/" lang="tr">Tantek Çelik</a> (<a class="p-org org h-org h-card" href="https://www.mozilla.org/">Mozilla</a>, <a href="mailto:tantek@cs.stanford.edu">tantek@cs.stanford.edu</a>) sorted out legal hassles. </p>
   <p>Copyright © 2020 WHATWG (Apple, Google, Mozilla, Microsoft). This work is licensed under a <a href="https://creativecommons.org/licenses/by/4.0/" rel="license">Creative Commons Attribution
4.0 International License</a>. </p>
  </main>
<script>
"use strict";
if ("serviceWorker" in navigator) {
  navigator.serviceWorker.register("/service-worker.js");
}
</script>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#top-layer-add">add</a><span>, in §5.1</span>
   <li><a href="#dom-fullscreennavigationui-auto">"auto"</a><span>, in §3</span>
   <li><a href="#css-pe-backdrop">::backdrop</a><span>, in §5.2</span>
   <li><a href="#collect-documents-to-unfullscreen">collect documents to unfullscreen</a><span>, in §3</span>
   <li><a href="#descendant-browsing-context">descendant browsing context</a><span>, in §1</span>
   <li><a href="#exit-fullscreen">exit fullscreen</a><span>, in §3</span>
   <li><a href="#dom-document-exitfullscreen">exitFullscreen()</a><span>, in §3</span>
   <li><a href="#css-pc-fullscreen">:fullscreen</a><span>, in §5.3</span>
   <li><a href="#dom-document-fullscreen">fullscreen</a><span>, in §3</span>
   <li><a href="#fullscreen-an-element">fullscreen an element</a><span>, in §2</span>
   <li><a href="#fullscreen-element">fullscreen element</a><span>, in §2</span>
   <li><a href="#dom-document-fullscreenelement">fullscreenElement</a><span>, in §3</span>
   <li><a href="#fullscreen-element-ready-check">fullscreen element ready check</a><span>, in §3</span>
   <li><a href="#dom-document-fullscreenenabled">fullscreenEnabled</a><span>, in §3</span>
   <li><a href="#fullscreen-feature">fullscreen-feature</a><span>, in §6</span>
   <li><a href="#fullscreen-flag">fullscreen flag</a><span>, in §2</span>
   <li><a href="#fullscreen-is-supported">Fullscreen is supported</a><span>, in §2</span>
   <li><a href="#enumdef-fullscreennavigationui">FullscreenNavigationUI</a><span>, in §3</span>
   <li><a href="#dictdef-fullscreenoptions">FullscreenOptions</a><span>, in §3</span>
   <li><a href="#fully-exit-fullscreen">fully exit fullscreen</a><span>, in §2</span>
   <li><a href="#dom-fullscreennavigationui-hide">"hide"</a><span>, in §3</span>
   <li><a href="#iframe-fullscreen-flag">iframe fullscreen flag</a><span>, in §2</span>
   <li><a href="#list-of-pending-fullscreen-events">list of pending fullscreen events</a><span>, in §2</span>
   <li><a href="#dom-fullscreenoptions-navigationui">navigationUI</a><span>, in §3</span>
   <li>
    onfullscreenchange
    <ul>
     <li><a href="#handler-document-onfullscreenchange">attribute for Document</a><span>, in §3</span>
     <li><a href="#dom-element-onfullscreenchange">attribute for Element</a><span>, in §3</span>
    </ul>
   <li>
    onfullscreenerror
    <ul>
     <li><a href="#handler-document-onfullscreenerror">attribute for Document</a><span>, in §3</span>
     <li><a href="#dom-element-onfullscreenerror">attribute for Element</a><span>, in §3</span>
    </ul>
   <li><a href="#dom-element-requestfullscreen">requestFullscreen()</a><span>, in §3</span>
   <li><a href="#dom-element-requestfullscreen">requestFullscreen(options)</a><span>, in §3</span>
   <li><a href="#run-the-fullscreen-steps">run the fullscreen steps</a><span>, in §2</span>
   <li><a href="#dom-fullscreennavigationui-show">"show"</a><span>, in §3</span>
   <li><a href="#simple-fullscreen-document">simple fullscreen document</a><span>, in §3</span>
   <li><a href="#top-layer">top layer</a><span>, in §5.1</span>
   <li><a href="#unfullscreen-a-document">unfullscreen a document</a><span>, in §2</span>
   <li><a href="#unfullscreen-an-element">unfullscreen an element</a><span>, in §2</span>
  </ul>
  <aside class="dfn-panel" data-for="term-for-document">
   <a href="https://dom.spec.whatwg.org/#document">https://dom.spec.whatwg.org/#document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-document">3. API</a> <a href="#ref-for-document①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-documentorshadowroot">
   <a href="https://dom.spec.whatwg.org/#documentorshadowroot">https://dom.spec.whatwg.org/#documentorshadowroot</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-documentorshadowroot">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-element">
   <a href="https://dom.spec.whatwg.org/#element">https://dom.spec.whatwg.org/#element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-element">3. API</a> <a href="#ref-for-element①">(2)</a> <a href="#ref-for-element②">(3)</a> <a href="#ref-for-element③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-shadowroot">
   <a href="https://dom.spec.whatwg.org/#shadowroot">https://dom.spec.whatwg.org/#shadowroot</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-shadowroot">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-tree-ancestor">
   <a href="https://dom.spec.whatwg.org/#concept-tree-ancestor">https://dom.spec.whatwg.org/#concept-tree-ancestor</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-tree-ancestor">5.1. New stacking layer</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-event-bubbles">
   <a href="https://dom.spec.whatwg.org/#dom-event-bubbles">https://dom.spec.whatwg.org/#dom-event-bubbles</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-event-bubbles">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-event-composed">
   <a href="https://dom.spec.whatwg.org/#dom-event-composed">https://dom.spec.whatwg.org/#dom-event-composed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-event-composed">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-connected">
   <a href="https://dom.spec.whatwg.org/#connected">https://dom.spec.whatwg.org/#connected</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-connected">2. Model</a>
    <li><a href="#ref-for-connected①">3. API</a> <a href="#ref-for-connected②">(2)</a> <a href="#ref-for-connected③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-context-object">
   <a href="https://dom.spec.whatwg.org/#context-object">https://dom.spec.whatwg.org/#context-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-context-object">3. API</a> <a href="#ref-for-context-object①">(2)</a> <a href="#ref-for-context-object②">(3)</a> <a href="#ref-for-context-object③">(4)</a> <a href="#ref-for-context-object④">(5)</a> <a href="#ref-for-context-object⑤">(6)</a> <a href="#ref-for-context-object⑥">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-document">
   <a href="https://dom.spec.whatwg.org/#concept-document">https://dom.spec.whatwg.org/#concept-document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-document">2. Model</a> <a href="#ref-for-concept-document①">(2)</a> <a href="#ref-for-concept-document②">(3)</a> <a href="#ref-for-concept-document③">(4)</a> <a href="#ref-for-concept-document④">(5)</a>
    <li><a href="#ref-for-concept-document⑤">3. API</a> <a href="#ref-for-concept-document⑥">(2)</a> <a href="#ref-for-concept-document⑦">(3)</a> <a href="#ref-for-concept-document⑧">(4)</a>
    <li><a href="#ref-for-concept-document⑨">5.1. New stacking layer</a>
    <li><a href="#ref-for-concept-document①⓪">6. Feature Policy Integration</a>
    <li><a href="#ref-for-concept-document①①">7. Security and Privacy Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-element">
   <a href="https://dom.spec.whatwg.org/#concept-element">https://dom.spec.whatwg.org/#concept-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-element">2. Model</a> <a href="#ref-for-concept-element①">(2)</a> <a href="#ref-for-concept-element②">(3)</a> <a href="#ref-for-concept-element③">(4)</a> <a href="#ref-for-concept-element④">(5)</a>
    <li><a href="#ref-for-concept-element⑤">3. API</a> <a href="#ref-for-concept-element⑥">(2)</a> <a href="#ref-for-concept-element⑦">(3)</a> <a href="#ref-for-concept-element⑧">(4)</a> <a href="#ref-for-concept-element⑨">(5)</a> <a href="#ref-for-concept-element①⓪">(6)</a>
    <li><a href="#ref-for-concept-element①①">5.3. :fullscreen pseudo-class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-event-fire">
   <a href="https://dom.spec.whatwg.org/#concept-event-fire">https://dom.spec.whatwg.org/#concept-event-fire</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-event-fire">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-documentfragment-host">
   <a href="https://dom.spec.whatwg.org/#concept-documentfragment-host">https://dom.spec.whatwg.org/#concept-documentfragment-host</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-documentfragment-host">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-element-namespace">
   <a href="https://dom.spec.whatwg.org/#concept-element-namespace">https://dom.spec.whatwg.org/#concept-element-namespace</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-element-namespace">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-node-document">
   <a href="https://dom.spec.whatwg.org/#concept-node-document">https://dom.spec.whatwg.org/#concept-node-document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-node-document">2. Model</a> <a href="#ref-for-concept-node-document①">(2)</a> <a href="#ref-for-concept-node-document②">(3)</a> <a href="#ref-for-concept-node-document③">(4)</a>
    <li><a href="#ref-for-concept-node-document④">3. API</a> <a href="#ref-for-concept-node-document⑤">(2)</a> <a href="#ref-for-concept-node-document⑥">(3)</a> <a href="#ref-for-concept-node-document⑦">(4)</a> <a href="#ref-for-concept-node-document⑧">(5)</a>
    <li><a href="#ref-for-concept-node-document⑨">5.3. :fullscreen pseudo-class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-node-remove-ext">
   <a href="https://dom.spec.whatwg.org/#concept-node-remove-ext">https://dom.spec.whatwg.org/#concept-node-remove-ext</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-node-remove-ext">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-retarget">
   <a href="https://dom.spec.whatwg.org/#retarget">https://dom.spec.whatwg.org/#retarget</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-retarget">3. API</a>
    <li><a href="#ref-for-retarget①">5.3. :fullscreen pseudo-class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-tree-root">
   <a href="https://dom.spec.whatwg.org/#concept-tree-root">https://dom.spec.whatwg.org/#concept-tree-root</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-tree-root">5.1. New stacking layer</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-element-shadow-host">
   <a href="https://dom.spec.whatwg.org/#element-shadow-host">https://dom.spec.whatwg.org/#element-shadow-host</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-element-shadow-host">5.3. :fullscreen pseudo-class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-shadow-root">
   <a href="https://dom.spec.whatwg.org/#concept-shadow-root">https://dom.spec.whatwg.org/#concept-shadow-root</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-shadow-root">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-shadow-including-inclusive-ancestor">
   <a href="https://dom.spec.whatwg.org/#concept-shadow-including-inclusive-ancestor">https://dom.spec.whatwg.org/#concept-shadow-including-inclusive-ancestor</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-shadow-including-inclusive-ancestor">5.1. New stacking layer</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-shadow-including-inclusive-descendant">
   <a href="https://dom.spec.whatwg.org/#concept-shadow-including-inclusive-descendant">https://dom.spec.whatwg.org/#concept-shadow-including-inclusive-descendant</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-shadow-including-inclusive-descendant">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-shadow-including-tree-order">
   <a href="https://dom.spec.whatwg.org/#concept-shadow-including-tree-order">https://dom.spec.whatwg.org/#concept-shadow-including-tree-order</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-shadow-including-tree-order">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-tree">
   <a href="https://dom.spec.whatwg.org/#concept-tree">https://dom.spec.whatwg.org/#concept-tree</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-tree">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-tree-order">
   <a href="https://dom.spec.whatwg.org/#concept-tree-order">https://dom.spec.whatwg.org/#concept-tree-order</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-tree-order">3. API</a> <a href="#ref-for-concept-tree-order①">(2)</a> <a href="#ref-for-concept-tree-order②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-container-policy">
   <a href="https://wicg.github.io/feature-policy/#container-policy">https://wicg.github.io/feature-policy/#container-policy</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-container-policy">6. Feature Policy Integration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-default-allowlist">
   <a href="https://wicg.github.io/feature-policy/#default-allowlist">https://wicg.github.io/feature-policy/#default-allowlist</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-default-allowlist">6. Feature Policy Integration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-feature-policy-header">
   <a href="https://wicg.github.io/feature-policy/#feature-policy-header">https://wicg.github.io/feature-policy/#feature-policy-header</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-feature-policy-header">7. Security and Privacy Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-policy-controlled-feature">
   <a href="https://wicg.github.io/feature-policy/#policy-controlled-feature">https://wicg.github.io/feature-policy/#policy-controlled-feature</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-policy-controlled-feature">6. Feature Policy Integration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-eventhandler">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler">https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventhandler">3. API</a> <a href="#ref-for-eventhandler①">(2)</a> <a href="#ref-for-eventhandler②">(3)</a> <a href="#ref-for-eventhandler③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-window">
   <a href="https://html.spec.whatwg.org/multipage/window-object.html#window">https://html.spec.whatwg.org/multipage/window-object.html#window</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-window">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-active-document">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#active-document">https://html.spec.whatwg.org/multipage/browsers.html#active-document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-active-document">3. API</a> <a href="#ref-for-active-document①">(2)</a> <a href="#ref-for-active-document②">(3)</a>
    <li><a href="#ref-for-active-document③">4. UI</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-attr-iframe-allow">
   <a href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#attr-iframe-allow">https://html.spec.whatwg.org/multipage/iframe-embed-object.html#attr-iframe-allow</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-attr-iframe-allow">6. Feature Policy Integration</a>
    <li><a href="#ref-for-attr-iframe-allow①">7. Security and Privacy Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-allowed-to-use">
   <a href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#allowed-to-use">https://html.spec.whatwg.org/multipage/iframe-embed-object.html#allowed-to-use</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-allowed-to-use">3. API</a> <a href="#ref-for-allowed-to-use①">(2)</a>
    <li><a href="#ref-for-allowed-to-use②">6. Feature Policy Integration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-attr-iframe-allowfullscreen">
   <a href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#attr-iframe-allowfullscreen">https://html.spec.whatwg.org/multipage/iframe-embed-object.html#attr-iframe-allowfullscreen</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-attr-iframe-allowfullscreen">6. Feature Policy Integration</a> <a href="#ref-for-attr-iframe-allowfullscreen①">(2)</a>
    <li><a href="#ref-for-attr-iframe-allowfullscreen②">7. Security and Privacy Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ancestor-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#ancestor-browsing-context">https://html.spec.whatwg.org/multipage/browsers.html#ancestor-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ancestor-browsing-context">1. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context">https://html.spec.whatwg.org/multipage/browsers.html#browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-browsing-context">1. Terminology</a> <a href="#ref-for-browsing-context①">(2)</a>
    <li><a href="#ref-for-browsing-context②">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-browsing-context-container">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context-container">https://html.spec.whatwg.org/multipage/browsers.html#browsing-context-container</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-browsing-context-container">3. API</a> <a href="#ref-for-browsing-context-container①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-the-dialog-element">
   <a href="https://html.spec.whatwg.org/multipage/interactive-elements.html#the-dialog-element">https://html.spec.whatwg.org/multipage/interactive-elements.html#the-dialog-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-dialog-element">2. Model</a>
    <li><a href="#ref-for-the-dialog-element①">3. API</a> <a href="#ref-for-the-dialog-element②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handlers">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers">https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handlers">3. API</a> <a href="#ref-for-event-handlers①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handler-content-attributes">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-content-attributes">https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-content-attributes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handler-content-attributes">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handler-event-type">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type">https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handler-event-type">3. API</a> <a href="#ref-for-event-handler-event-type①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handler-idl-attributes">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes">https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handler-idl-attributes">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-loop">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-loop">https://html.spec.whatwg.org/multipage/webappapis.html#event-loop</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-loop">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-document-feature-policy">
   <a href="https://html.spec.whatwg.org/multipage/dom.html#concept-document-feature-policy">https://html.spec.whatwg.org/multipage/dom.html#concept-document-feature-policy</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-document-feature-policy">6. Feature Policy Integration</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-fully-active">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#fully-active">https://html.spec.whatwg.org/multipage/browsers.html#fully-active</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fully-active">3. API</a> <a href="#ref-for-fully-active①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-the-iframe-element">
   <a href="https://html.spec.whatwg.org/multipage/iframe-embed-object.html#the-iframe-element">https://html.spec.whatwg.org/multipage/iframe-embed-object.html#the-iframe-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-iframe-element">2. Model</a>
    <li><a href="#ref-for-the-iframe-element①">3. API</a>
    <li><a href="#ref-for-the-iframe-element②">6. Feature Policy Integration</a>
    <li><a href="#ref-for-the-iframe-element③">7. Security and Privacy Considerations</a> <a href="#ref-for-the-iframe-element④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-in-parallel">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel">https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-in-parallel">3. API</a> <a href="#ref-for-in-parallel①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-nested-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#nested-browsing-context">https://html.spec.whatwg.org/multipage/browsers.html#nested-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-nested-browsing-context">3. API</a>
    <li><a href="#ref-for-nested-browsing-context①">7. Security and Privacy Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-relevant-global">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-relevant-global">https://html.spec.whatwg.org/multipage/webappapis.html#concept-relevant-global</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-relevant-global">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-top-level-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#top-level-browsing-context">https://html.spec.whatwg.org/multipage/browsers.html#top-level-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-top-level-browsing-context">3. API</a> <a href="#ref-for-top-level-browsing-context①">(2)</a>
    <li><a href="#ref-for-top-level-browsing-context②">4. UI</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-transient-activation">
   <a href="https://html.spec.whatwg.org/multipage/interaction.html#transient-activation">https://html.spec.whatwg.org/multipage/interaction.html#transient-activation</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transient-activation">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-unloading-document-cleanup-steps">
   <a href="https://html.spec.whatwg.org/multipage/browsing-the-web.html#unloading-document-cleanup-steps">https://html.spec.whatwg.org/multipage/browsing-the-web.html#unloading-document-cleanup-steps</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-unloading-document-cleanup-steps">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-set-append">
   <a href="https://infra.spec.whatwg.org/#set-append">https://infra.spec.whatwg.org/#set-append</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-set-append">3. API</a> <a href="#ref-for-set-append①">(2)</a> <a href="#ref-for-set-append②">(3)</a> <a href="#ref-for-set-append③">(4)</a> <a href="#ref-for-set-append④">(5)</a> <a href="#ref-for-set-append⑤">(6)</a> <a href="#ref-for-set-append⑥">(7)</a>
    <li><a href="#ref-for-set-append⑦">5.1. New stacking layer</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-iteration-break">
   <a href="https://infra.spec.whatwg.org/#iteration-break">https://infra.spec.whatwg.org/#iteration-break</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-iteration-break">3. API</a> <a href="#ref-for-iteration-break①">(2)</a> <a href="#ref-for-iteration-break②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-contain">
   <a href="https://infra.spec.whatwg.org/#list-contain">https://infra.spec.whatwg.org/#list-contain</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-contain">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-iteration-continue">
   <a href="https://infra.spec.whatwg.org/#iteration-continue">https://infra.spec.whatwg.org/#iteration-continue</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-iteration-continue">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-empty">
   <a href="https://infra.spec.whatwg.org/#list-empty">https://infra.spec.whatwg.org/#list-empty</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-empty">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-iterate">
   <a href="https://infra.spec.whatwg.org/#list-iterate">https://infra.spec.whatwg.org/#list-iterate</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-iterate">2. Model</a> <a href="#ref-for-list-iterate①">(2)</a>
    <li><a href="#ref-for-list-iterate②">3. API</a> <a href="#ref-for-list-iterate③">(2)</a> <a href="#ref-for-list-iterate④">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-html-namespace">
   <a href="https://infra.spec.whatwg.org/#html-namespace">https://infra.spec.whatwg.org/#html-namespace</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-html-namespace">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ordered-set">
   <a href="https://infra.spec.whatwg.org/#ordered-set">https://infra.spec.whatwg.org/#ordered-set</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ordered-set">2. Model</a>
    <li><a href="#ref-for-ordered-set①">3. API</a> <a href="#ref-for-ordered-set②">(2)</a> <a href="#ref-for-ordered-set③">(3)</a>
    <li><a href="#ref-for-ordered-set④">5.1. New stacking layer</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-pair">
   <a href="https://infra.spec.whatwg.org/#pair">https://infra.spec.whatwg.org/#pair</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-pair">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-remove">
   <a href="https://infra.spec.whatwg.org/#list-remove">https://infra.spec.whatwg.org/#list-remove</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-remove">2. Model</a> <a href="#ref-for-list-remove①">(2)</a>
    <li><a href="#ref-for-list-remove②">5.1. New stacking layer</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-string">
   <a href="https://infra.spec.whatwg.org/#string">https://infra.spec.whatwg.org/#string</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-string">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-iteration-while">
   <a href="https://infra.spec.whatwg.org/#iteration-while">https://infra.spec.whatwg.org/#iteration-while</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-iteration-while">3. API</a> <a href="#ref-for-iteration-while①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-LenientSetter">
   <a href="https://heycam.github.io/webidl/#LenientSetter">https://heycam.github.io/webidl/#LenientSetter</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-LenientSetter">3. API</a> <a href="#ref-for-LenientSetter①">(2)</a> <a href="#ref-for-LenientSetter②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Unscopable">
   <a href="https://heycam.github.io/webidl/#Unscopable">https://heycam.github.io/webidl/#Unscopable</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Unscopable">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-boolean">
   <a href="https://heycam.github.io/webidl/#idl-boolean">https://heycam.github.io/webidl/#idl-boolean</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-boolean">3. API</a> <a href="#ref-for-idl-boolean①">(2)</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[DOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-document" style="color:initial">Document</span>
     <li><span class="dfn-paneled" id="term-for-documentorshadowroot" style="color:initial">DocumentOrShadowRoot</span>
     <li><span class="dfn-paneled" id="term-for-element" style="color:initial">Element</span>
     <li><span class="dfn-paneled" id="term-for-shadowroot" style="color:initial">ShadowRoot</span>
     <li><span class="dfn-paneled" id="term-for-concept-tree-ancestor" style="color:initial">ancestor</span>
     <li><span class="dfn-paneled" id="term-for-dom-event-bubbles" style="color:initial">bubbles</span>
     <li><span class="dfn-paneled" id="term-for-dom-event-composed" style="color:initial">composed</span>
     <li><span class="dfn-paneled" id="term-for-connected" style="color:initial">connected</span>
     <li><span class="dfn-paneled" id="term-for-context-object" style="color:initial">context object</span>
     <li><span class="dfn-paneled" id="term-for-concept-document" style="color:initial">document</span>
     <li><span class="dfn-paneled" id="term-for-concept-element" style="color:initial">element</span>
     <li><span class="dfn-paneled" id="term-for-concept-event-fire" style="color:initial">fire an event</span>
     <li><span class="dfn-paneled" id="term-for-concept-documentfragment-host" style="color:initial">host</span>
     <li><span class="dfn-paneled" id="term-for-concept-element-namespace" style="color:initial">namespace</span>
     <li><span class="dfn-paneled" id="term-for-concept-node-document" style="color:initial">node document</span>
     <li><span class="dfn-paneled" id="term-for-concept-node-remove-ext" style="color:initial">removing steps</span>
     <li><span class="dfn-paneled" id="term-for-retarget" style="color:initial">retargeting</span>
     <li><span class="dfn-paneled" id="term-for-concept-tree-root" style="color:initial">root</span>
     <li><span class="dfn-paneled" id="term-for-element-shadow-host" style="color:initial">shadow host</span>
     <li><span class="dfn-paneled" id="term-for-concept-shadow-root" style="color:initial">shadow root</span>
     <li><span class="dfn-paneled" id="term-for-concept-shadow-including-inclusive-ancestor" style="color:initial">shadow-including inclusive ancestor</span>
     <li><span class="dfn-paneled" id="term-for-concept-shadow-including-inclusive-descendant" style="color:initial">shadow-including inclusive descendant</span>
     <li><span class="dfn-paneled" id="term-for-concept-shadow-including-tree-order" style="color:initial">shadow-including tree order</span>
     <li><span class="dfn-paneled" id="term-for-concept-tree" style="color:initial">tree</span>
     <li><span class="dfn-paneled" id="term-for-concept-tree-order" style="color:initial">tree order</span>
    </ul>
   <li>
    <a data-link-type="biblio">[feature-policy-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-container-policy" style="color:initial">container policy</span>
     <li><span class="dfn-paneled" id="term-for-default-allowlist" style="color:initial">default allowlist</span>
     <li><span class="dfn-paneled" id="term-for-feature-policy-header" style="color:initial">feature-policy</span>
     <li><span class="dfn-paneled" id="term-for-policy-controlled-feature" style="color:initial">policy-controlled feature</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-eventhandler" style="color:initial">EventHandler</span>
     <li><span class="dfn-paneled" id="term-for-window" style="color:initial">Window</span>
     <li><span class="dfn-paneled" id="term-for-active-document" style="color:initial">active document</span>
     <li><span class="dfn-paneled" id="term-for-attr-iframe-allow" style="color:initial">allow</span>
     <li><span class="dfn-paneled" id="term-for-allowed-to-use" style="color:initial">allowed to use</span>
     <li><span class="dfn-paneled" id="term-for-attr-iframe-allowfullscreen" style="color:initial">allowfullscreen</span>
     <li><span class="dfn-paneled" id="term-for-ancestor-browsing-context" style="color:initial">ancestor browsing context</span>
     <li><span class="dfn-paneled" id="term-for-browsing-context" style="color:initial">browsing context</span>
     <li><span class="dfn-paneled" id="term-for-browsing-context-container" style="color:initial">browsing context container</span>
     <li><span class="dfn-paneled" id="term-for-the-dialog-element" style="color:initial">dialog</span>
     <li><span class="dfn-paneled" id="term-for-event-handlers" style="color:initial">event handler</span>
     <li><span class="dfn-paneled" id="term-for-event-handler-content-attributes" style="color:initial">event handler content attribute</span>
     <li><span class="dfn-paneled" id="term-for-event-handler-event-type" style="color:initial">event handler event type</span>
     <li><span class="dfn-paneled" id="term-for-event-handler-idl-attributes" style="color:initial">event handler idl attribute</span>
     <li><span class="dfn-paneled" id="term-for-event-loop" style="color:initial">event loop</span>
     <li><span class="dfn-paneled" id="term-for-concept-document-feature-policy" style="color:initial">feature policy</span>
     <li><span class="dfn-paneled" id="term-for-fully-active" style="color:initial">fully active</span>
     <li><span class="dfn-paneled" id="term-for-the-iframe-element" style="color:initial">iframe</span>
     <li><span class="dfn-paneled" id="term-for-in-parallel" style="color:initial">in parallel</span>
     <li><span class="dfn-paneled" id="term-for-nested-browsing-context" style="color:initial">nested browsing context</span>
     <li><span class="dfn-paneled" id="term-for-concept-relevant-global" style="color:initial">relevant global object</span>
     <li><span class="dfn-paneled" id="term-for-top-level-browsing-context" style="color:initial">top-level browsing context</span>
     <li><span class="dfn-paneled" id="term-for-transient-activation" style="color:initial">transient activation</span>
     <li><span class="dfn-paneled" id="term-for-unloading-document-cleanup-steps" style="color:initial">unloading document cleanup steps</span>
    </ul>
   <li>
    <a data-link-type="biblio">[INFRA]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-set-append" style="color:initial">append</span>
     <li><span class="dfn-paneled" id="term-for-iteration-break" style="color:initial">break</span>
     <li><span class="dfn-paneled" id="term-for-list-contain" style="color:initial">contain</span>
     <li><span class="dfn-paneled" id="term-for-iteration-continue" style="color:initial">continue</span>
     <li><span class="dfn-paneled" id="term-for-list-empty" style="color:initial">empty</span>
     <li><span class="dfn-paneled" id="term-for-list-iterate" style="color:initial">for each</span>
     <li><span class="dfn-paneled" id="term-for-html-namespace" style="color:initial">html namespace</span>
     <li><span class="dfn-paneled" id="term-for-ordered-set" style="color:initial">ordered set</span>
     <li><span class="dfn-paneled" id="term-for-pair" style="color:initial">pair</span>
     <li><span class="dfn-paneled" id="term-for-list-remove" style="color:initial">remove</span>
     <li><span class="dfn-paneled" id="term-for-string" style="color:initial">string</span>
     <li><span class="dfn-paneled" id="term-for-iteration-while" style="color:initial">while</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WEBIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-LenientSetter" style="color:initial">LenientSetter</span>
     <li><span class="dfn-paneled" id="term-for-Unscopable" style="color:initial">Unscopable</span>
     <li><span class="dfn-paneled" id="term-for-idl-boolean" style="color:initial">boolean</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-css">[CSS]
   <dd>Bert Bos; et al. <a href="http://dev.w3.org/csswg/css2/">Cascading Style Sheets Level 2 Revision 1 (CSS 2.1) Specification</a>. URL: <a href="http://dev.w3.org/csswg/css2/">http://dev.w3.org/csswg/css2/</a>
   <dt id="biblio-dom">[DOM]
   <dd>Anne van Kesteren. <a href="https://dom.spec.whatwg.org/">DOM Standard</a>. Living Standard. URL: <a href="https://dom.spec.whatwg.org/">https://dom.spec.whatwg.org/</a>
   <dt id="biblio-feature-policy-1">[FEATURE-POLICY-1]
   <dd>Ian Clelland. <a href="https://w3c.github.io/webappsec-feature-policy/">Feature Policy</a>. URL: <a href="https://w3c.github.io/webappsec-feature-policy/">https://w3c.github.io/webappsec-feature-policy/</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-infra">[INFRA]
   <dd>Anne van Kesteren; Domenic Denicola. <a href="https://infra.spec.whatwg.org/">Infra Standard</a>. Living Standard. URL: <a href="https://infra.spec.whatwg.org/">https://infra.spec.whatwg.org/</a>
   <dt id="biblio-mathml">[MATHML]
   <dd>Patrick D F Ion; Robert R Miner. <a href="https://www.w3.org/TR/REC-MathML/">Mathematical Markup Language (MathML) 1.01 Specification</a>. 7 July 1999. REC. URL: <a href="https://www.w3.org/TR/REC-MathML/">https://www.w3.org/TR/REC-MathML/</a>
   <dt id="biblio-svg">[SVG]
   <dd>Erik Dahlström; et al. <a href="https://www.w3.org/TR/SVG11/">Scalable Vector Graphics (SVG) 1.1 (Second Edition)</a>. 16 August 2011. REC. URL: <a href="https://www.w3.org/TR/SVG11/">https://www.w3.org/TR/SVG11/</a>
   <dt id="biblio-webidl">[WEBIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def"><c- b>enum</c-> <a href="#enumdef-fullscreennavigationui"><code><c- g>FullscreenNavigationUI</c-></code></a> {
  <a href="#dom-fullscreennavigationui-auto"><code><c- s>"auto"</c-></code></a>,
  <a href="#dom-fullscreennavigationui-show"><code><c- s>"show"</c-></code></a>,
  <a href="#dom-fullscreennavigationui-hide"><code><c- s>"hide"</c-></code></a>
};

<c- b>dictionary</c-> <a href="#dictdef-fullscreenoptions"><code><c- g>FullscreenOptions</c-></code></a> {
  <a class="n" data-link-type="idl-name" href="#enumdef-fullscreennavigationui"><c- n>FullscreenNavigationUI</c-></a> <a data-default="&quot;auto&quot;" data-type="FullscreenNavigationUI " href="#dom-fullscreenoptions-navigationui"><code><c- g>navigationUI</c-></code></a> = "auto";
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#element"><c- g>Element</c-></a> {
  <c- b>Promise</c->&lt;<c- b>void</c->> <a class="idl-code" data-link-type="method" href="#dom-element-requestfullscreen"><c- g>requestFullscreen</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-fullscreenoptions"><c- n>FullscreenOptions</c-></a> <a href="#dom-element-requestfullscreen-options-options"><code><c- g>options</c-></code></a> = {});

  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-element-onfullscreenchange"><code><c- g>onfullscreenchange</c-></code></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-element-onfullscreenerror"><code><c- g>onfullscreenerror</c-></code></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#document"><c- g>Document</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#LenientSetter"><c- g>LenientSetter</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-document-fullscreenenabled"><c- g>fullscreenEnabled</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#LenientSetter"><c- g>LenientSetter</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Unscopable"><c- g>Unscopable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-document-fullscreen"><c- g>fullscreen</c-></a>; // historical

  <c- b>Promise</c->&lt;<c- b>void</c->> <a class="idl-code" data-link-type="method" href="#dom-document-exitfullscreen"><c- g>exitFullscreen</c-></a>();

  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a class="idl-code" data-link-type="attribute" data-type="EventHandler" href="#handler-document-onfullscreenchange"><c- g>onfullscreenchange</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a class="idl-code" data-link-type="attribute" data-type="EventHandler" href="#handler-document-onfullscreenerror"><c- g>onfullscreenerror</c-></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#documentorshadowroot"><c- g>DocumentOrShadowRoot</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#LenientSetter"><c- g>LenientSetter</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element"><c- n>Element</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="Element?" href="#dom-document-fullscreenelement"><c- g>fullscreenElement</c-></a>;
};

</pre>
  <aside class="dfn-panel" data-for="descendant-browsing-context">
   <b><a href="#descendant-browsing-context">#descendant-browsing-context</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descendant-browsing-context">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fullscreen-flag">
   <b><a href="#fullscreen-flag">#fullscreen-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fullscreen-flag">2. Model</a> <a href="#ref-for-fullscreen-flag①">(2)</a> <a href="#ref-for-fullscreen-flag②">(3)</a> <a href="#ref-for-fullscreen-flag③">(4)</a> <a href="#ref-for-fullscreen-flag④">(5)</a> <a href="#ref-for-fullscreen-flag⑤">(6)</a>
    <li><a href="#ref-for-fullscreen-flag⑥">3. API</a> <a href="#ref-for-fullscreen-flag⑦">(2)</a>
    <li><a href="#ref-for-fullscreen-flag⑧">5.3. :fullscreen pseudo-class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="iframe-fullscreen-flag">
   <b><a href="#iframe-fullscreen-flag">#iframe-fullscreen-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-iframe-fullscreen-flag">2. Model</a>
    <li><a href="#ref-for-iframe-fullscreen-flag①">3. API</a> <a href="#ref-for-iframe-fullscreen-flag②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fullscreen-element">
   <b><a href="#fullscreen-element">#fullscreen-element</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fullscreen-element">2. Model</a> <a href="#ref-for-fullscreen-element①">(2)</a> <a href="#ref-for-fullscreen-element②">(3)</a> <a href="#ref-for-fullscreen-element③">(4)</a> <a href="#ref-for-fullscreen-element④">(5)</a>
    <li><a href="#ref-for-fullscreen-element⑤">3. API</a> <a href="#ref-for-fullscreen-element⑥">(2)</a> <a href="#ref-for-fullscreen-element⑦">(3)</a> <a href="#ref-for-fullscreen-element⑧">(4)</a> <a href="#ref-for-fullscreen-element⑨">(5)</a> <a href="#ref-for-fullscreen-element①⓪">(6)</a> <a href="#ref-for-fullscreen-element①①">(7)</a> <a href="#ref-for-fullscreen-element①②">(8)</a> <a href="#ref-for-fullscreen-element①③">(9)</a> <a href="#ref-for-fullscreen-element①④">(10)</a> <a href="#ref-for-fullscreen-element①⑤">(11)</a> <a href="#ref-for-fullscreen-element①⑥">(12)</a> <a href="#ref-for-fullscreen-element①⑦">(13)</a> <a href="#ref-for-fullscreen-element①⑧">(14)</a> <a href="#ref-for-fullscreen-element①⑨">(15)</a> <a href="#ref-for-fullscreen-element②⓪">(16)</a> <a href="#ref-for-fullscreen-element②①">(17)</a>
    <li><a href="#ref-for-fullscreen-element②②">5.3. :fullscreen pseudo-class</a> <a href="#ref-for-fullscreen-element②③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="list-of-pending-fullscreen-events">
   <b><a href="#list-of-pending-fullscreen-events">#list-of-pending-fullscreen-events</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-of-pending-fullscreen-events">2. Model</a> <a href="#ref-for-list-of-pending-fullscreen-events①">(2)</a>
    <li><a href="#ref-for-list-of-pending-fullscreen-events②">3. API</a> <a href="#ref-for-list-of-pending-fullscreen-events③">(2)</a> <a href="#ref-for-list-of-pending-fullscreen-events④">(3)</a> <a href="#ref-for-list-of-pending-fullscreen-events⑤">(4)</a> <a href="#ref-for-list-of-pending-fullscreen-events⑥">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fullscreen-an-element">
   <b><a href="#fullscreen-an-element">#fullscreen-an-element</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fullscreen-an-element">3. API</a> <a href="#ref-for-fullscreen-an-element①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="unfullscreen-an-element">
   <b><a href="#unfullscreen-an-element">#unfullscreen-an-element</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-unfullscreen-an-element">2. Model</a> <a href="#ref-for-unfullscreen-an-element①">(2)</a> <a href="#ref-for-unfullscreen-an-element②">(3)</a>
    <li><a href="#ref-for-unfullscreen-an-element③">3. API</a> <a href="#ref-for-unfullscreen-an-element④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="unfullscreen-a-document">
   <b><a href="#unfullscreen-a-document">#unfullscreen-a-document</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-unfullscreen-a-document">3. API</a> <a href="#ref-for-unfullscreen-a-document①">(2)</a> <a href="#ref-for-unfullscreen-a-document②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fully-exit-fullscreen">
   <b><a href="#fully-exit-fullscreen">#fully-exit-fullscreen</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fully-exit-fullscreen">2. Model</a>
    <li><a href="#ref-for-fully-exit-fullscreen①">4. UI</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fullscreen-is-supported">
   <b><a href="#fullscreen-is-supported">#fullscreen-is-supported</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fullscreen-is-supported">3. API</a> <a href="#ref-for-fullscreen-is-supported①">(2)</a> <a href="#ref-for-fullscreen-is-supported②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="run-the-fullscreen-steps">
   <b><a href="#run-the-fullscreen-steps">#run-the-fullscreen-steps</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-run-the-fullscreen-steps">3. API</a> <a href="#ref-for-run-the-fullscreen-steps①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-fullscreennavigationui">
   <b><a href="#enumdef-fullscreennavigationui">#enumdef-fullscreennavigationui</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-fullscreennavigationui">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-fullscreenoptions">
   <b><a href="#dictdef-fullscreenoptions">#dictdef-fullscreenoptions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-fullscreenoptions">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fullscreen-element-ready-check">
   <b><a href="#fullscreen-element-ready-check">#fullscreen-element-ready-check</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fullscreen-element-ready-check">3. API</a> <a href="#ref-for-fullscreen-element-ready-check①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-requestfullscreen">
   <b><a href="#dom-element-requestfullscreen">#dom-element-requestfullscreen</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-requestfullscreen">3. API</a> <a href="#ref-for-dom-element-requestfullscreen①">(2)</a>
    <li><a href="#ref-for-dom-element-requestfullscreen②">4. UI</a> <a href="#ref-for-dom-element-requestfullscreen③">(2)</a>
    <li><a href="#ref-for-dom-element-requestfullscreen④">7. Security and Privacy Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-document-fullscreenenabled">
   <b><a href="#dom-document-fullscreenenabled">#dom-document-fullscreenenabled</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-document-fullscreenenabled">3. API</a> <a href="#ref-for-dom-document-fullscreenenabled①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-document-fullscreen">
   <b><a href="#dom-document-fullscreen">#dom-document-fullscreen</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-document-fullscreen">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-document-fullscreenelement">
   <b><a href="#dom-document-fullscreenelement">#dom-document-fullscreenelement</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-document-fullscreenelement">3. API</a> <a href="#ref-for-dom-document-fullscreenelement①">(2)</a> <a href="#ref-for-dom-document-fullscreenelement②">(3)</a> <a href="#ref-for-dom-document-fullscreenelement③">(4)</a>
    <li><a href="#ref-for-dom-document-fullscreenelement④">5.3. :fullscreen pseudo-class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="simple-fullscreen-document">
   <b><a href="#simple-fullscreen-document">#simple-fullscreen-document</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-simple-fullscreen-document">3. API</a> <a href="#ref-for-simple-fullscreen-document①">(2)</a> <a href="#ref-for-simple-fullscreen-document②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="collect-documents-to-unfullscreen">
   <b><a href="#collect-documents-to-unfullscreen">#collect-documents-to-unfullscreen</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-collect-documents-to-unfullscreen">3. API</a> <a href="#ref-for-collect-documents-to-unfullscreen①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="exit-fullscreen">
   <b><a href="#exit-fullscreen">#exit-fullscreen</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-exit-fullscreen">2. Model</a> <a href="#ref-for-exit-fullscreen①">(2)</a>
    <li><a href="#ref-for-exit-fullscreen②">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-document-exitfullscreen">
   <b><a href="#dom-document-exitfullscreen">#dom-document-exitfullscreen</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-document-exitfullscreen">3. API</a> <a href="#ref-for-dom-document-exitfullscreen①">(2)</a>
    <li><a href="#ref-for-dom-document-exitfullscreen②">4. UI</a> <a href="#ref-for-dom-document-exitfullscreen③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="handler-document-onfullscreenchange">
   <b><a href="#handler-document-onfullscreenchange">#handler-document-onfullscreenchange</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-handler-document-onfullscreenchange">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="handler-document-onfullscreenerror">
   <b><a href="#handler-document-onfullscreenerror">#handler-document-onfullscreenerror</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-handler-document-onfullscreenerror">3. API</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="top-layer">
   <b><a href="#top-layer">#top-layer</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-top-layer">2. Model</a> <a href="#ref-for-top-layer①">(2)</a> <a href="#ref-for-top-layer②">(3)</a> <a href="#ref-for-top-layer③">(4)</a> <a href="#ref-for-top-layer④">(5)</a> <a href="#ref-for-top-layer⑤">(6)</a> <a href="#ref-for-top-layer⑥">(7)</a>
    <li><a href="#ref-for-top-layer⑦">3. API</a> <a href="#ref-for-top-layer⑧">(2)</a> <a href="#ref-for-top-layer⑨">(3)</a>
    <li><a href="#ref-for-top-layer①⓪">5. Rendering</a>
    <li><a href="#ref-for-top-layer①①">5.1. New stacking layer</a> <a href="#ref-for-top-layer①②">(2)</a> <a href="#ref-for-top-layer①③">(3)</a> <a href="#ref-for-top-layer①④">(4)</a>
    <li><a href="#ref-for-top-layer①⑤">5.2. ::backdrop pseudo-element</a> <a href="#ref-for-top-layer①⑥">(2)</a> <a href="#ref-for-top-layer①⑦">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="top-layer-add">
   <b><a href="#top-layer-add">#top-layer-add</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-top-layer-add">2. Model</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-pe-backdrop">
   <b><a href="#css-pe-backdrop">#css-pe-backdrop</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-pe-backdrop">5. Rendering</a>
    <li><a href="#ref-for-css-pe-backdrop①">5.1. New stacking layer</a> <a href="#ref-for-css-pe-backdrop②">(2)</a>
    <li><a href="#ref-for-css-pe-backdrop③">5.2. ::backdrop pseudo-element</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fullscreen-feature">
   <b><a href="#fullscreen-feature">#fullscreen-feature</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fullscreen-feature">3. API</a> <a href="#ref-for-fullscreen-feature①">(2)</a>
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