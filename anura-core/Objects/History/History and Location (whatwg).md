<!DOCTYPE html><html class=split lang=en-US-x-hixie><script src=/link-fixup.js defer=""></script><meta charset=utf-8><meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name=viewport><title>HTML Standard</title><meta content=#3c790a name=theme-color><link rel=stylesheet href=https://resources.whatwg.org/spec.css crossorigin=""><link rel=stylesheet href=https://resources.whatwg.org/standard.css crossorigin=""><link rel=stylesheet href=https://resources.whatwg.org/standard-shared-with-dev.css crossorigin=""><link rel=icon href=https://resources.whatwg.org/logo.svg crossorigin=""><script>
   function toggleStatus(div) {
     div.parentNode.classList.toggle('wrapped');
   }
   function setLinkFragment(link) {
     link.hash = location.hash;
   }
  </script><style>
   .bad, .bad *:not(.X\58X) { color: gray; }

   .applies .yes, .yesno .yes { background: yellow; }
   .yesno .yes, .yesno .no { text-align: center; }

   .applies thead th > * { display: block; }
   .applies thead code { display: block; }
   .applies td { text-align: center; }

   .matrix, .matrix td { border: hidden; text-align: right; }
   .matrix, .equations { margin-left: 2em; }

   .vertical-summary-table tr > th[rowspan="2"]:first-child + th,
   .vertical-summary-table tr > td[rowspan="2"]:first-child + td { border-bottom: hidden; }

   .dice-example { border-collapse: collapse; border-style: hidden solid solid hidden; border-width: thin; margin-left: 3em; }
   .dice-example caption { width: 30em; font-size: smaller; font-style: italic; padding: 0.75em 0; text-align: left; }
   .dice-example td, .dice-example th { border: solid thin; width: 1.35em; height: 1.05em; text-align: center; padding: 0; }

   td.eg { border-width: thin; text-align: center; }

   #table-example-1 { border: solid thin; border-collapse: collapse; margin-left: 3em; }
   #table-example-1 caption { padding-bottom: 0.5em; }
   #table-example-1 thead, #table-example-1 tbody { border: none; }
   #table-example-1 th, #table-example-1 td { border: solid thin; }
   #table-example-1 th { font-weight: normal; }
   #table-example-1 td { border-style: none solid; vertical-align: top; }
   #table-example-1 th { padding: 0.5em; vertical-align: middle; text-align: center; }
   #table-example-1 tbody tr:first-child td { padding-top: 0.5em; }
   #table-example-1 tbody tr:last-child td { padding-bottom: 1.5em; }
   #table-example-1 tbody td:first-child { padding-left: 2.5em; padding-right: 0; width: 9em; }
   #table-example-1 tbody td:first-child::after { content: leader(". "); }
   #table-example-1 tbody td { padding-left: 2em; padding-right: 2em; }
   #table-example-1 tbody td:first-child + td { width: 10em; }
   #table-example-1 tbody td:first-child + td ~ td { width: 2.5em; }
   #table-example-1 tbody td:first-child + td + td + td ~ td { width: 1.25em; }

   .apple-table-examples { border: none; border-collapse: separate; border-spacing: 1.5em 0em; width: 40em; margin-left: 3em; }
   .apple-table-examples * { font-family: "Times", serif; }
   .apple-table-examples td, .apple-table-examples th { border: none; white-space: nowrap; padding-top: 0; padding-bottom: 0; }
   .apple-table-examples tbody th:first-child { border-left: none; width: 100%; }
   .apple-table-examples thead th:first-child ~ th { font-size: smaller; font-weight: bolder; border-bottom: solid 2px; text-align: center; }
   .apple-table-examples tbody th::after, .apple-table-examples tfoot th::after { content: leader(". ") }
   .apple-table-examples tbody th, .apple-table-examples tfoot th { font: inherit; text-align: left; }
   .apple-table-examples td { text-align: right; vertical-align: top; }
   .apple-table-examples.e1 tbody tr:last-child td { border-bottom: solid 1px; }
   .apple-table-examples.e1 tbody + tbody tr:last-child td { border-bottom: double 3px; }
   .apple-table-examples.e2 th[scope=row] { padding-left: 1em; }
   .apple-table-examples sup { line-height: 0; }

   .three-column-nowrap tr > td:first-child,
   .three-column-nowrap tr > td:first-child + td,
   .three-column-nowrap tr > td:first-child + td + td { white-space: nowrap; }

   .details-example img { vertical-align: top; }

   .parse-error-table td > p:first-child { margin-top: 0; }

   #named-character-references-table {
     white-space: nowrap;
     font-size: 0.6em;
     column-width: 30em;
     column-gap: 1em;
     -moz-column-width: 30em;
     -moz-column-gap: 1em;
     -webkit-column-width: 30em;
     -webkit-column-gap: 1em;
   }
   #named-character-references-table > table > tbody > tr > td:first-child + td,
   #named-character-references-table > table > tbody > tr > td:last-child { text-align: center; }
   #named-character-references-table > table > tbody > tr > td:last-child:hover > span { position: absolute; top: auto; left: auto; margin-left: 0.5em; line-height: 1.2; font-size: 5em; border: outset; padding: 0.25em 0.5em; background: white; width: 1.25em; height: auto; text-align: center; }
   #named-character-references-table > table > tbody > tr#entity-CounterClockwiseContourIntegral > td:first-child { font-size: 0.5em; }

   .glyph.control { color: red; }

   #table-example-1 * { font-family: "Essays1743", serif; line-height: 1.01em; }
   @font-face {
     font-family: 'Essays1743';
     src: url('/fonts/Essays1743.ttf');
   }
   @font-face {
     font-family: 'Essays1743';
     font-weight: bold;
     src: url('/fonts/Essays1743-Bold.ttf');
   }
   @font-face {
     font-family: 'Essays1743';
     font-style: italic;
     src: url('/fonts/Essays1743-Italic.ttf');
   }
   @font-face {
     font-family: 'Essays1743';
     font-style: italic;
     font-weight: bold;
     src: url('/fonts/Essays1743-BoldItalic.ttf');
   }

   @media (max-width: 767px) {
     #abstractimg { width: 100%; }
   }
   #abstractimg, #abstractimg text { font: inherit; }
   #abstractimg rect { fill: #424242; }
   #abstractimg text { fill: #ffffff; font-size: 18px }
   #abstractimg .top { word-spacing: 50px; text-anchor: middle; }
   #abstractimg .left, #abstractimg .bottom { word-spacing: 12px; }
   #abstractimg .right { font-size: 25px; }
  </style><body>
  
  <script async="" crossorigin="" src=/html-dfn.js></script>
  <script data-file-issue-url=https://github.com/whatwg/html/issues/new async="" crossorigin="" src=https://resources.whatwg.org/file-issue.js></script>
  
  <header id=head class="head with-buttons">
   <a href=https://whatwg.org/ class=logo><img width=100 alt=WHATWG crossorigin="" src=https://resources.whatwg.org/logo.svg height=100></a>
   <hgroup><h1 class=allcaps>HTML</h1><h2 id=living-standard class="no-num no-toc">Living Standard — Last Updated <span class=pubdate>9 April 2020</span></h2></hgroup>
   
   

   
  </header>

  

  

  

  
  

  
  

  

  <nav><a href=origin.html>← 7.5 Origin</a> — <a href=./>Table of Contents</a> — <a href=browsing-the-web.html>7.8 Browsing the Web →</a></nav><ol class=toc><li id=toc-browsers><ol><li><a href=history.html#history><span class=secno>7.7</span> Session history and navigation</a><ol><li><a href=history.html#the-session-history-of-browsing-contexts><span class=secno>7.7.1</span> The session history of browsing contexts</a><li><a href=history.html#the-history-interface><span class=secno>7.7.2</span> The <code>History</code> interface</a><li><a href=history.html#history-notes><span class=secno>7.7.3</span> Implementation notes for session history</a><li><a href=history.html#the-location-interface><span class=secno>7.7.4</span> The <code>Location</code> interface</a><ol><li><a href=history.html#location-getprototypeof><span class=secno>7.7.4.1</span> [[GetPrototypeOf]] ( )</a><li><a href=history.html#location-setprototypeof><span class=secno>7.7.4.2</span> [[SetPrototypeOf]] ( <var>V</var> )</a><li><a href=history.html#location-isextensible><span class=secno>7.7.4.3</span> [[IsExtensible]] ( )</a><li><a href=history.html#location-preventextensions><span class=secno>7.7.4.4</span> [[PreventExtensions]] ( )</a><li><a href=history.html#location-getownproperty><span class=secno>7.7.4.5</span> [[GetOwnProperty]] ( <var>P</var> )</a><li><a href=history.html#location-defineownproperty><span class=secno>7.7.4.6</span> [[DefineOwnProperty]] ( <var>P</var>, <var>Desc</var> )</a><li><a href=history.html#location-get><span class=secno>7.7.4.7</span> [[Get]] ( <var>P</var>, <var>Receiver</var> )</a><li><a href=history.html#location-set><span class=secno>7.7.4.8</span> [[Set]] ( <var>P</var>, <var>V</var>, <var>Receiver</var> )</a><li><a href=history.html#location-delete><span class=secno>7.7.4.9</span> [[Delete]] ( <var>P</var> )</a><li><a href=history.html#location-ownpropertykeys><span class=secno>7.7.4.10</span> [[OwnPropertyKeys]] ( )</a></ol></ol></ol></ol><h3 id=history><span class=secno>7.7</span> Session history and navigation<a href=#history class=self-link></a></h3><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/History/back title="The History.back() method causes the browser to move back one page in the session history.">History/back</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/History/forward title="The History.forward() method causes the browser to move forward one page in the session history. It has the same effect as calling history.go(1).">History/forward</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside>

  <h4 id=the-session-history-of-browsing-contexts><span class=secno>7.7.1</span> The session history of browsing contexts<a href=#the-session-history-of-browsing-contexts class=self-link></a></h4>

  <p>The sequence of <code id=the-session-history-of-browsing-contexts:document><a href=dom.html#document>Document</a></code>s in a <a id=the-session-history-of-browsing-contexts:browsing-context href=browsers.html#browsing-context>browsing context</a> is its <dfn id=session-history>session
  history</dfn>. Each <a id=the-session-history-of-browsing-contexts:browsing-context-2 href=browsers.html#browsing-context>browsing context</a>, including <a href=browsers.html#child-browsing-context id=the-session-history-of-browsing-contexts:child-browsing-context>child browsing contexts</a>, has a distinct session history. A <a id=the-session-history-of-browsing-contexts:browsing-context-3 href=browsers.html#browsing-context>browsing
  context</a>'s session history consists of a flat list of <a href=#session-history-entry id=the-session-history-of-browsing-contexts:session-history-entry>session history entries</a>. Each <dfn id=session-history-entry>session history entry</dfn> consists, at a
  minimum, of a <a id=the-session-history-of-browsing-contexts:url href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a>, and each entry may in addition have <a href=#serialized-state id=the-session-history-of-browsing-contexts:serialized-state>serialized state</a>,
  a title, a <code id=the-session-history-of-browsing-contexts:document-2><a href=dom.html#document>Document</a></code> object, form data, a <a href=#scroll-restoration-mode id=the-session-history-of-browsing-contexts:scroll-restoration-mode>scroll restoration mode</a>, a
  scroll position, a <a id=the-session-history-of-browsing-contexts:browsing-context-name href=browsers.html#browsing-context-name>browsing context name</a>, and other information associated with
  it.</p>

  <p class=note>Each entry, when first created, has a <code id=the-session-history-of-browsing-contexts:document-3><a href=dom.html#document>Document</a></code>. However, when a
  <code id=the-session-history-of-browsing-contexts:document-4><a href=dom.html#document>Document</a></code> is not <a href=browsers.html#fully-active id=the-session-history-of-browsing-contexts:fully-active>active</a>, it's possible for it to be
  <a href=window-object.html#discard-a-document id=the-session-history-of-browsing-contexts:discard-a-document>discarded</a> to free resources. The <a id=the-session-history-of-browsing-contexts:url-2 href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a> and
  other data in a <a href=#session-history-entry id=the-session-history-of-browsing-contexts:session-history-entry-2>session history entry</a> is then used to bring a new
  <code id=the-session-history-of-browsing-contexts:document-5><a href=dom.html#document>Document</a></code> into being to take the place of the original, in case the user agent finds
  itself having to reactivate that <code id=the-session-history-of-browsing-contexts:document-6><a href=dom.html#document>Document</a></code>.</p>

  <p class=note>Titles associated with <a href=#session-history-entry id=the-session-history-of-browsing-contexts:session-history-entry-3>session history
  entries</a> need not have any relation with the current <code id=the-session-history-of-browsing-contexts:the-title-element><a href=semantics.html#the-title-element>title</a></code> of the
  <code id=the-session-history-of-browsing-contexts:document-7><a href=dom.html#document>Document</a></code>. The title of a <a href=#session-history-entry id=the-session-history-of-browsing-contexts:session-history-entry-4>session history entry</a> is intended to explain
  the state of the document at that point, so that the user can navigate the document's history.</p>

  <p>URLs without associated <a href=#serialized-state id=the-session-history-of-browsing-contexts:serialized-state-2>serialized state</a> are added to the session history as the
  user (or script) navigates from page to page.</p>

  <hr>

  <p>Each <code id=the-session-history-of-browsing-contexts:document-8><a href=dom.html#document>Document</a></code> object in a <a id=the-session-history-of-browsing-contexts:browsing-context-4 href=browsers.html#browsing-context>browsing context</a>'s <a href=#session-history id=the-session-history-of-browsing-contexts:session-history>session
  history</a> is associated with a unique <code id=the-session-history-of-browsing-contexts:history-3><a href=#history-3>History</a></code> object which must all model the
  same underlying <a href=#session-history id=the-session-history-of-browsing-contexts:session-history-2>session history</a>.</p>

  

  <p>The <dfn id=dom-history><code>history</code></dfn> attribute of the <code id=the-session-history-of-browsing-contexts:window><a href=window-object.html#window>Window</a></code>
  interface must return the object implementing the <code id=the-session-history-of-browsing-contexts:history-3-2><a href=#history-3>History</a></code> interface for this
  <code id=the-session-history-of-browsing-contexts:window-2><a href=window-object.html#window>Window</a></code> object's <a href=window-object.html#concept-document-window id=the-session-history-of-browsing-contexts:concept-document-window>associated
  <code>Document</code></a>.</p>

  

  <hr>

  <p id=state-object><dfn id=serialized-state>Serialized state</dfn> is a serialization (via
  <a id=the-session-history-of-browsing-contexts:structuredserializeforstorage href=structured-data.html#structuredserializeforstorage>StructuredSerializeForStorage</a>) of an object representing a user interface state. We
  sometimes informally refer to "state objects", which are the objects representing user interface
  state supplied by the author, or alternately the objects created by deserializing (via
  <a id=the-session-history-of-browsing-contexts:structureddeserialize href=structured-data.html#structureddeserialize>StructuredDeserialize</a>) serialized state.</p>

  <p>Pages can <a href=#dom-history-pushstate id=the-session-history-of-browsing-contexts:dom-history-pushstate>add</a> <a href=#serialized-state id=the-session-history-of-browsing-contexts:serialized-state-3>serialized state</a> to the
  session history. These are then <a href=structured-data.html#structureddeserialize id=the-session-history-of-browsing-contexts:structureddeserialize-2>deserialized</a> and <a href=indices.html#event-popstate id=the-session-history-of-browsing-contexts:event-popstate>returned to the script</a> when the user (or script) goes back in the
  history, thus enabling authors to use the "navigation" metaphor even in one-page applications.</p>

  <div class=note>

   <p><a href=#serialized-state id=the-session-history-of-browsing-contexts:serialized-state-4>Serialized state</a> is intended to be used for two main purposes: first, storing a
   preparsed description of the state in the <a id=the-session-history-of-browsing-contexts:url-3 href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a> so that in the simple case an author
   doesn't have to do the parsing (though one would still need the parsing for handling <a href=https://url.spec.whatwg.org/#concept-url id=the-session-history-of-browsing-contexts:url-4 data-x-internal=url>URLs</a> passed around by users, so it's only a minor optimization). Second, so
   that the author can store state that one wouldn't store in the URL because it only applies to the
   current <code id=the-session-history-of-browsing-contexts:document-9><a href=dom.html#document>Document</a></code> instance and it would have to be reconstructed if a new
   <code id=the-session-history-of-browsing-contexts:document-10><a href=dom.html#document>Document</a></code> were opened.</p>

   <p>An example of the latter would be something like keeping track of the precise coordinate from
   which a pop-up <code id=the-session-history-of-browsing-contexts:the-div-element><a href=grouping-content.html#the-div-element>div</a></code> was made to animate, so that if the user goes back, it can be
   made to animate to the same location. Or alternatively, it could be used to keep a pointer into a
   cache of data that would be fetched from the server based on the information in the
   <a id=the-session-history-of-browsing-contexts:url-5 href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a>, so that when going back and forward, the information doesn't have to be fetched
   again.</p>

  </div>

  <hr>

  <p>At any point, one of the entries in the session history is the <dfn id=current-entry>current entry</dfn>. This
  is the entry representing the <a id=the-session-history-of-browsing-contexts:active-document href=browsers.html#active-document>active document</a> of the <a id=the-session-history-of-browsing-contexts:browsing-context-5 href=browsers.html#browsing-context>browsing context</a>.
  Which entry is the <a href=#current-entry id=the-session-history-of-browsing-contexts:current-entry>current entry</a> is changed by the algorithms defined in this
  specification, e.g. during <a href=browsing-the-web.html#traverse-the-history id=the-session-history-of-browsing-contexts:traverse-the-history>session history
  traversal</a>.</p>

  <p class=note>The <a href=#current-entry id=the-session-history-of-browsing-contexts:current-entry-2>current entry</a> is usually an entry for the <a href=https://dom.spec.whatwg.org/#concept-document-url id="the-session-history-of-browsing-contexts:the-document's-address" data-x-internal="the-document's-address">URL</a> of the <code id=the-session-history-of-browsing-contexts:document-11><a href=dom.html#document>Document</a></code>. However, it can also be one
  of the entries for <a href=#serialized-state id=the-session-history-of-browsing-contexts:serialized-state-5>serialized state</a> added to the history by that document.</p>

  <p><dfn id=an-entry-with-persisted-user-state>An entry with persisted user state</dfn> is one that also has user-agent defined state.
  This specification does not specify what kind of state can be stored.</p>

  <p class=example>For example, some user agents might want to persist the scroll position, or the
  values of form controls.</p>

  <p class=note>User agents that persist the value of form controls are encouraged to also persist
  their directionality (the value of the element's <code id=the-session-history-of-browsing-contexts:the-dir-attribute><a href=dom.html#the-dir-attribute>dir</a></code> attribute).
  This prevents values from being displayed incorrectly after a history traversal when the user had
  originally entered the values with an explicit, non-default directionality.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/History/scrollRestoration title="The scrollRestoration property of History interface allows web applications to explicitly set default scroll restoration behavior on history navigation.">History/scrollRestoration</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>46+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>46+</span></span><hr><span class="opera yes"><span>Opera</span><span>33+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>46+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>An entry's <dfn id=scroll-restoration-mode>scroll restoration mode</dfn> indicates whether the user agent should
  restore the persisted scroll position (if any) when traversing to it. The scroll restoration
  mode may be one of the following:</p>

  <dl><dt>"<dfn id=dom-scrollrestoration-auto><code>auto</code></dfn>"<dd>The user agent is responsible for restoring the scroll position upon navigation.<dt>"<dfn id=dom-scrollrestoration-manual><code>manual</code></dfn>"<dd>The page is responsible for restoring the scroll position and the user agent does not
   attempt to do so automatically</dl>

  <p>If unspecified, the <a href=#scroll-restoration-mode id=the-session-history-of-browsing-contexts:scroll-restoration-mode-2>scroll restoration mode</a> of a new entry must be set to
  "<code id=the-session-history-of-browsing-contexts:dom-scrollrestoration-auto><a href=#dom-scrollrestoration-auto>auto</a></code>".</p>

  <p>Entries that contain <a href=#serialized-state id=the-session-history-of-browsing-contexts:serialized-state-6>serialized state</a> share the same <code id=the-session-history-of-browsing-contexts:document-12><a href=dom.html#document>Document</a></code> as the
  entry for the page that was active when they were added.</p>

  <p>Contiguous entries that differ just by their <a href=https://url.spec.whatwg.org/#concept-url id=the-session-history-of-browsing-contexts:url-6 data-x-internal=url>URLs</a>' <a href=https://url.spec.whatwg.org/#concept-url-fragment id=the-session-history-of-browsing-contexts:concept-url-fragment data-x-internal=concept-url-fragment>fragments</a> also share the same <code id=the-session-history-of-browsing-contexts:document-13><a href=dom.html#document>Document</a></code>.</p>

  <p class=note>All entries that share the same <code id=the-session-history-of-browsing-contexts:document-14><a href=dom.html#document>Document</a></code> (and that are therefore
  merely different states of one particular document) are contiguous by definition.</p>

  <p>Each <code id=the-session-history-of-browsing-contexts:document-15><a href=dom.html#document>Document</a></code> in a <a id=the-session-history-of-browsing-contexts:browsing-context-6 href=browsers.html#browsing-context>browsing context</a> can also have a <dfn id=latest-entry>latest
  entry</dfn>. This is the entry for that <code id=the-session-history-of-browsing-contexts:document-16><a href=dom.html#document>Document</a></code> to which the <a id=the-session-history-of-browsing-contexts:browsing-context-7 href=browsers.html#browsing-context>browsing
  context</a>'s <a href=#session-history id=the-session-history-of-browsing-contexts:session-history-3>session history</a> was most recently traversed. When a
  <code id=the-session-history-of-browsing-contexts:document-17><a href=dom.html#document>Document</a></code> is created, it initially has no <a href=#latest-entry id=the-session-history-of-browsing-contexts:latest-entry>latest entry</a>.</p>

  

  <p>User agents may <a href=window-object.html#discard-a-document id=the-session-history-of-browsing-contexts:discard-a-document-2>discard</a> the <code id=the-session-history-of-browsing-contexts:document-18><a href=dom.html#document>Document</a></code>
  objects of entries other than the <a href=#current-entry id=the-session-history-of-browsing-contexts:current-entry-3>current entry</a> that are not referenced from any
  script, reloading the pages afresh when the user or script navigates back to such pages. This
  specification does not specify when user agents should discard <code id=the-session-history-of-browsing-contexts:document-19><a href=dom.html#document>Document</a></code> objects and
  when they should cache them.</p>

  <p>Entries that have had their <code id=the-session-history-of-browsing-contexts:document-20><a href=dom.html#document>Document</a></code> objects discarded must, for the purposes of
  the algorithms given below, act as if they had not. When the user or script navigates back or
  forwards to a page which has no in-memory DOM objects, any other entries that shared the same
  <code id=the-session-history-of-browsing-contexts:document-21><a href=dom.html#document>Document</a></code> object with it must share the new object as well.</p>

  



  <h4 id=the-history-interface><span class=secno>7.7.2</span> The <code id=the-history-interface:history-3><a href=#history-3>History</a></code> interface<a href=#the-history-interface class=self-link></a></h4><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/History title="The History interface allows manipulation of the browser session history, that is the pages visited in the tab or frame that the current page is loaded in.">History</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Window/history title="The Window.history read-only property returns a reference to the History object, which provides an interface for manipulating the browser session history (pages visited in the tab or frame that the current page is loaded in).">Window/history</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>4+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside>

  <pre><code class='idl'><c- b>enum</c-> <dfn id='scrollrestoration'><c- g>ScrollRestoration</c-></dfn> { <c- s>&quot;</c-><a href='#dom-scrollrestoration-auto' id='the-history-interface:dom-scrollrestoration-auto'><c- s>auto</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-scrollrestoration-manual' id='the-history-interface:dom-scrollrestoration-manual'><c- s>manual</c-></a><c- s>&quot;</c-> };

[<c- g>Exposed</c->=<c- n>Window</c->]
<c- b>interface</c-> <dfn id='history-3'><c- g>History</c-></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>unsigned</c-> <c- b>long</c-> <a href='#dom-history-length' id='the-history-interface:dom-history-length'><c- g>length</c-></a>;
  <c- b>attribute</c-> <a href='#scrollrestoration' id='the-history-interface:scrollrestoration'><c- n>ScrollRestoration</c-></a> <a href='#dom-history-scroll-restoration' id='the-history-interface:dom-history-scroll-restoration'><c- g>scrollRestoration</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>any</c-> <a href='#dom-history-state' id='the-history-interface:dom-history-state'><c- g>state</c-></a>;
  <c- b>void</c-> <a href='#dom-history-go' id='the-history-interface:dom-history-go'><c- g>go</c-></a>(<c- b>optional</c-> <c- b>long</c-> <c- g>delta</c-> = 0);
  <c- b>void</c-> <a href='#dom-history-back' id='the-history-interface:dom-history-back'><c- g>back</c-></a>();
  <c- b>void</c-> <a href='#dom-history-forward' id='the-history-interface:dom-history-forward'><c- g>forward</c-></a>();
  <c- b>void</c-> <a href='#dom-history-pushstate' id='the-history-interface:dom-history-pushstate'><c- g>pushState</c-></a>(<c- b>any</c-> <c- g>data</c->, <c- b>DOMString</c-> <c- g>title</c->, <c- b>optional</c-> <c- b>USVString</c->? <c- g>url</c-> = <c- b>null</c->);
  <c- b>void</c-> <a href='#dom-history-replacestate' id='the-history-interface:dom-history-replacestate'><c- g>replaceState</c-></a>(<c- b>any</c-> <c- g>data</c->, <c- b>DOMString</c-> <c- g>title</c->, <c- b>optional</c-> <c- b>USVString</c->? <c- g>url</c-> = <c- b>null</c->);
};</code></pre>

  <dl class=domintro><dt><var>window</var> . <code id=dom-history-dev><a href=#dom-history>history</a></code> . <code id=dom-history-length-dev><a href=#dom-history-length>length</a></code><dd>
    <p>Returns the number of entries in the <a href=#joint-session-history id=the-history-interface:joint-session-history>joint session history</a>.</p>
   <dt><var>window</var> . <code id=the-history-interface:dom-history><a href=#dom-history>history</a></code> . <code id=dom-history-scroll-restoration-dev><a href=#dom-history-scroll-restoration>scrollRestoration</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the <a href=#scroll-restoration-mode id=the-history-interface:scroll-restoration-mode>scroll restoration mode</a> of the current entry in the <a href=#session-history id=the-history-interface:session-history>session
    history</a>.</p>

    <p>Can be set, to change the <a href=#scroll-restoration-mode id=the-history-interface:scroll-restoration-mode-2>scroll restoration mode</a> of the current entry in the <a href=#session-history id=the-history-interface:session-history-2>session history</a>.</p>
   <dt><var>window</var> . <code id=the-history-interface:dom-history-2><a href=#dom-history>history</a></code> . <code id=dom-history-state-dev><a href=#dom-history-state>state</a></code><dd>
    <p>Returns the current <a href=#serialized-state id=the-history-interface:serialized-state>serialized state</a>, deserialized into an object.</p>
   <dt><var>window</var> . <code id=the-history-interface:dom-history-3><a href=#dom-history>history</a></code> . <code id=dom-history-go-dev><a href=#dom-history-go>go</a></code>( [ <var>delta</var> ] )<dd>
    <p>Goes back or forward the specified number of steps in the <a href=#joint-session-history id=the-history-interface:joint-session-history-2>joint session history</a>.</p>

    <p>A zero delta will reload the current page.</p>

    <p>If the delta is out of range, does nothing.</p>
   <dt><var>window</var> . <code id=the-history-interface:dom-history-4><a href=#dom-history>history</a></code> . <code id=dom-history-back-dev><a href=#dom-history-back>back</a></code>()<dd>
    <p>Goes back one step in the <a href=#joint-session-history id=the-history-interface:joint-session-history-3>joint session history</a>.</p>

    <p>If there is no previous page, does nothing.</p>
   <dt><var>window</var> . <code id=the-history-interface:dom-history-5><a href=#dom-history>history</a></code> . <code id=dom-history-forward-dev><a href=#dom-history-forward>forward</a></code>()<dd>
    <p>Goes forward one step in the <a href=#joint-session-history id=the-history-interface:joint-session-history-4>joint session history</a>.</p>

    <p>If there is no next page, does nothing.</p>
   <dt><var>window</var> . <code id=the-history-interface:dom-history-6><a href=#dom-history>history</a></code> . <code id=dom-history-pushstate-dev><a href=#dom-history-pushstate>pushState</a></code>(<var>data</var>, <var>title</var> [, <var>url</var> ] )<dd>
    <p>Pushes the given data onto the session history, with the given title, and, if provided and
    not null, the given URL.</p>
   <dt><var>window</var> . <code id=the-history-interface:dom-history-7><a href=#dom-history>history</a></code> . <code id=dom-history-replacestate-dev><a href=#dom-history-replacestate>replaceState</a></code>(<var>data</var>, <var>title</var> [, <var>url</var> ] )<dd>
    <p>Updates the current entry in the session history to have the given data, title, and, if
    provided and not null, URL.</p>
   </dl>


  <p>The <dfn id=joint-session-history>joint session history</dfn> of a <a id=the-history-interface:top-level-browsing-context href=browsers.html#top-level-browsing-context>top-level browsing context</a> is the union
  of all the <a href=#session-history id=the-history-interface:session-history-3>session histories</a> of all <a href=browsers.html#concept-document-bc id=the-history-interface:concept-document-bc>browsing contexts</a> of all the <a id=the-history-interface:fully-active href=browsers.html#fully-active>fully active</a>
  <code id=the-history-interface:document><a href=dom.html#document>Document</a></code> objects that share that <a id=the-history-interface:top-level-browsing-context-2 href=browsers.html#top-level-browsing-context>top-level browsing context</a>, with all
  the entries that are <a href=#current-entry id=the-history-interface:current-entry>current entries</a> in their respective <a href=#session-history id=the-history-interface:session-history-4>session histories</a> removed except for the <a href=#current-entry-of-the-joint-session-history id=the-history-interface:current-entry-of-the-joint-session-history>current entry of
  the joint session history</a>.</p>

  <p>The <dfn id=current-entry-of-the-joint-session-history>current entry of the joint session history</dfn> is the entry that most recently
  became a <a href=#current-entry id=the-history-interface:current-entry-2>current entry</a> in its <a href=#session-history id=the-history-interface:session-history-5>session history</a>.</p>

  <p>Entries in the <a href=#joint-session-history id=the-history-interface:joint-session-history-5>joint session history</a> are ordered chronologically by the time they
  were added to their respective <a href=#session-history id=the-history-interface:session-history-6>session histories</a>. Each entry
  has an index; the earliest entry has index 0, and the subsequent entries are numbered with
  consecutively increasing integers (1, 2, 3, etc).</p>

  <p class=note>Since each <code id=the-history-interface:document-2><a href=dom.html#document>Document</a></code> in a <a id=the-history-interface:browsing-context href=browsers.html#browsing-context>browsing context</a> might have a
  different <a id=the-history-interface:event-loop href=webappapis.html#event-loop>event loop</a>, the actual state of the <a href=#joint-session-history id=the-history-interface:joint-session-history-6>joint session history</a> can
  be somewhat nebulous. For example, two sibling <code id=the-history-interface:the-iframe-element><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code> elements could both <a href=browsing-the-web.html#traverse-the-history id=the-history-interface:traverse-the-history>traverse</a> from one unique origin to another at the same time,
  so their precise order might not be well-defined; similarly, since they might only find out about
  each other later, they might disagree about the length of the <a href=#joint-session-history id=the-history-interface:joint-session-history-7>joint session
  history</a>.</p>


  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/History/length title="The History.length read-only property returns an integer representing the number of elements in the session history, including the currently loaded page.">History/length</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-history-length><code>length</code></dfn> attribute of the
  <code id=the-history-interface:history-3-2><a href=#history-3>History</a></code> interface, on getting, must return the number of entries in the
  <a id=the-history-interface:top-level-browsing-context-3 href=browsers.html#top-level-browsing-context>top-level browsing context</a>'s <a href=#joint-session-history id=the-history-interface:joint-session-history-8>joint session history</a>. If this
  <code id=the-history-interface:history-3-3><a href=#history-3>History</a></code> object is associated with a <code id=the-history-interface:document-3><a href=dom.html#document>Document</a></code> that is not
  <a id=the-history-interface:fully-active-2 href=browsers.html#fully-active>fully active</a>, getting must instead throw a <a id=the-history-interface:securityerror href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a>
  <code id=the-history-interface:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</p>

  <p>The actual entries are not accessible from script.</p>

  <p>The <dfn id=dom-history-scroll-restoration><code>scrollRestoration</code></dfn> attribute
  of the History interface, on getting, must return the <a href=#scroll-restoration-mode id=the-history-interface:scroll-restoration-mode-3>scroll restoration mode</a> of the
  current entry in the <a href=#session-history id=the-history-interface:session-history-7>session history</a>. On setting, the <a href=#scroll-restoration-mode id=the-history-interface:scroll-restoration-mode-4>scroll restoration mode
  </a> of the current entry in the <a href=#session-history id=the-history-interface:session-history-8>session history</a> must be set to the new
  value.  If this <code id=the-history-interface:history-3-4><a href=#history-3>History</a></code> object is associated with a <code id=the-history-interface:document-4><a href=dom.html#document>Document</a></code> that is
  not <a id=the-history-interface:fully-active-3 href=browsers.html#fully-active>fully active</a>, both getting and setting must instead throw a
  <a id=the-history-interface:securityerror-2 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-history-interface:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</p>

  <p>The <dfn id=dom-history-state><code>state</code></dfn> attribute of the
  <code id=the-history-interface:history-3-5><a href=#history-3>History</a></code> interface, on getting, must return the last value it was set to by the user
  agent. If this <code id=the-history-interface:history-3-6><a href=#history-3>History</a></code> object is associated with a <code id=the-history-interface:document-5><a href=dom.html#document>Document</a></code> that is
  not <a id=the-history-interface:fully-active-4 href=browsers.html#fully-active>fully active</a>, getting must instead throw a
  <a id=the-history-interface:securityerror-3 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-history-interface:domexception-3><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>. Initially, its value must be
  null.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/History/go title="The History.go() method loads a specific page from the session history. You can use it to move forwards and backwards through the history depending on the value of a parameter.">History/go</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>When the <dfn id=dom-history-go><code>go(<var>delta</var>)</code></dfn> method is
  invoked:</p>

  <ol><li><p>Let <var>document</var> be this <code id=the-history-interface:history-3-7><a href=#history-3>History</a></code> object's associated
   <code id=the-history-interface:document-6><a href=dom.html#document>Document</a></code>.<li><p>If <var>document</var> is not <a id=the-history-interface:fully-active-5 href=browsers.html#fully-active>fully active</a>, then throw a
   <a id=the-history-interface:securityerror-4 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a>
   <code id=the-history-interface:domexception-4><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If <var>delta</var> is 0, then act as if the <code id=the-history-interface:dom-location-reload><a href=#dom-location-reload>location.reload()</a></code> method was called, and return.<li><p><a href=#traverse-the-history-by-a-delta id=the-history-interface:traverse-the-history-by-a-delta>Traverse the history by a delta</a> with <var>delta</var> and
   <var>document</var>'s <a href=browsers.html#concept-document-bc id=the-history-interface:concept-document-bc-2>browsing context</a>.</ol>

  <p>When the <dfn id=dom-history-back><code>back()</code></dfn> method is invoked:</p>

  <ol><li><p>Let <var>document</var> be this <code id=the-history-interface:history-3-8><a href=#history-3>History</a></code> object's associated
   <code id=the-history-interface:document-7><a href=dom.html#document>Document</a></code>.<li><p>If <var>document</var> is not <a id=the-history-interface:fully-active-6 href=browsers.html#fully-active>fully active</a>, then throw a
   <a id=the-history-interface:securityerror-5 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a>
   <code id=the-history-interface:domexception-5><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p><a href=#traverse-the-history-by-a-delta id=the-history-interface:traverse-the-history-by-a-delta-2>Traverse the history by a delta</a> with −1 and
   <var>document</var>'s <a href=browsers.html#concept-document-bc id=the-history-interface:concept-document-bc-3>browsing context</a>.</ol>

  <p>When the <dfn id=dom-history-forward><code>forward()</code></dfn> method is invoked:</p>


  <ol><li><p>Let <var>document</var> be this <code id=the-history-interface:history-3-9><a href=#history-3>History</a></code> object's associated
   <code id=the-history-interface:document-8><a href=dom.html#document>Document</a></code>.<li><p>If <var>document</var> is not <a id=the-history-interface:fully-active-7 href=browsers.html#fully-active>fully active</a>, then throw a
   <a id=the-history-interface:securityerror-6 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a>
   <code id=the-history-interface:domexception-6><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p><a href=#traverse-the-history-by-a-delta id=the-history-interface:traverse-the-history-by-a-delta-3>Traverse the history by a delta</a> with +1 and
   <var>document</var>'s <a href=browsers.html#concept-document-bc id=the-history-interface:concept-document-bc-4>browsing context</a>.</ol>


  <hr>

  <p>Each <a id=the-history-interface:top-level-browsing-context-4 href=browsers.html#top-level-browsing-context>top-level browsing context</a> has a <dfn id=session-history-traversal-queue>session history traversal queue</dfn>,
  initially empty, to which <a href=webappapis.html#concept-task id=the-history-interface:concept-task>tasks</a> can be added.</p>

  <p>Each <a id=the-history-interface:top-level-browsing-context-5 href=browsers.html#top-level-browsing-context>top-level browsing context</a>, when created, must begin running
  the following algorithm, known as the <dfn id=session-history-event-loop>session history event loop</dfn> for that
  <a id=the-history-interface:top-level-browsing-context-6 href=browsers.html#top-level-browsing-context>top-level browsing context</a>, <a id=the-history-interface:in-parallel href=infrastructure.html#in-parallel>in parallel</a>:</p>

  <ol><li><p>Wait until this <a id=the-history-interface:top-level-browsing-context-7 href=browsers.html#top-level-browsing-context>top-level browsing context</a>'s <a href=#session-history-traversal-queue id=the-history-interface:session-history-traversal-queue>session history traversal
   queue</a> is not empty.<li><p>Pull the first <a href=webappapis.html#concept-task id=the-history-interface:concept-task-2>task</a> from this <a id=the-history-interface:top-level-browsing-context-8 href=browsers.html#top-level-browsing-context>top-level browsing
   context</a>'s <a href=#session-history-traversal-queue id=the-history-interface:session-history-traversal-queue-2>session history traversal queue</a>, and execute it.<li><p>Return to the first step of this algorithm.</p>
  </ol>

  <p>The <a href=#session-history-event-loop id=the-history-interface:session-history-event-loop>session history event loop</a> helps coordinate cross-browsing-context transitions
  of the <a href=#joint-session-history id=the-history-interface:joint-session-history-9>joint session history</a>: since each <a id=the-history-interface:browsing-context-2 href=browsers.html#browsing-context>browsing context</a> might, at any
  particular time, have a different <a id=the-history-interface:event-loop-2 href=webappapis.html#event-loop>event loop</a> (this can happen if the user navigates
  from <code>example.com</code> to <code>shop.example</code>), transitions would
  otherwise have to involve cross-event-loop synchronization.</p>

  <hr>

  <p>To <dfn id=traverse-the-history-by-a-delta>traverse the history by a delta</dfn> given <var>delta</var> and <a id=the-history-interface:browsing-context-3 href=browsers.html#browsing-context>browsing
  context</a> <var>source browsing context</var>, the user agent must append a <a href=webappapis.html#concept-task id=the-history-interface:concept-task-3>task</a> to this <a id=the-history-interface:top-level-browsing-context-9 href=browsers.html#top-level-browsing-context>top-level browsing context</a>'s <a href=#session-history-traversal-queue id=the-history-interface:session-history-traversal-queue-3>session
  history traversal queue</a>, the <a href=webappapis.html#concept-task id=the-history-interface:concept-task-4>task</a> consisting of running
  the following steps:</p>

  <ol><li><p>If the index of the <a href=#current-entry-of-the-joint-session-history id=the-history-interface:current-entry-of-the-joint-session-history-2>current entry of the joint session history</a> plus
   <var>delta</var> is less than zero or greater than or equal to the number of items in the
   <a href=#joint-session-history id=the-history-interface:joint-session-history-10>joint session history</a>, then return.</p>

   <li><p>Let <var>specified entry</var> be the entry in the <a href=#joint-session-history id=the-history-interface:joint-session-history-11>joint session
   history</a> whose index is the sum of <var>delta</var> and the index of the
   <a href=#current-entry-of-the-joint-session-history id=the-history-interface:current-entry-of-the-joint-session-history-3>current entry of the joint session history</a>.<li><p>Let <var>specified browsing context</var> be the <a id=the-history-interface:browsing-context-4 href=browsers.html#browsing-context>browsing context</a> of
   the <var>specified entry</var>.<li><p>If <var>source browsing context</var> is not <a id=the-history-interface:allowed-to-navigate href=browsers.html#allowed-to-navigate>allowed to navigate</a>
   <var>specified browsing context</var>, then return.<li><p>If the <var>specified browsing context</var>'s <a id=the-history-interface:active-document href=browsers.html#active-document>active document</a>'s
   <a id=the-history-interface:unload-a-document href=browsing-the-web.html#unload-a-document>unload a document</a> algorithm is currently running, return.<li>
    <p><a id=the-history-interface:queue-a-task href=webappapis.html#queue-a-task>Queue a task</a> that consists of running the following substeps. The relevant
    <a id=the-history-interface:event-loop-3 href=webappapis.html#event-loop>event loop</a> is that of the <var>specified browsing context</var>'s
    <a id=the-history-interface:active-document-2 href=browsers.html#active-document>active document</a>. The <a id=the-history-interface:task-source href=webappapis.html#task-source>task source</a> for the queued task is the
    <a id=the-history-interface:history-traversal-task-source href=webappapis.html#history-traversal-task-source>history traversal task source</a>.</p>

    <ol><li><p>If there is an ongoing attempt to navigate <var>specified browsing context</var>
     that has not yet <a href=browsing-the-web.html#concept-navigate-mature id=the-history-interface:concept-navigate-mature>matured</a> (i.e. it has not passed the
     point of making its <code id=the-history-interface:document-9><a href=dom.html#document>Document</a></code> the <a id=the-history-interface:active-document-3 href=browsers.html#active-document>active document</a>), then cancel that
     attempt to navigate the <a id=the-history-interface:browsing-context-5 href=browsers.html#browsing-context>browsing context</a>.<li>
      <p>If the <var>specified browsing context</var>'s <a id=the-history-interface:active-document-4 href=browsers.html#active-document>active document</a> is not
      the same <code id=the-history-interface:document-10><a href=dom.html#document>Document</a></code> as the <code id=the-history-interface:document-11><a href=dom.html#document>Document</a></code> of the <var>specified
      entry</var>, then run these substeps:</p>

      <ol><li><p><a id=the-history-interface:prompt-to-unload-a-document href=browsing-the-web.html#prompt-to-unload-a-document>Prompt to unload</a> the <a id=the-history-interface:active-document-5 href=browsers.html#active-document>active document</a> of the <var>specified
       browsing context</var>. If the user <a id=the-history-interface:refused-to-allow-the-document-to-be-unloaded href=browsing-the-web.html#refused-to-allow-the-document-to-be-unloaded>refused to allow the document to be
       unloaded</a>, then return.<li><p><a href=browsing-the-web.html#unload-a-document id=the-history-interface:unload-a-document-2>Unload</a> the <a id=the-history-interface:active-document-6 href=browsers.html#active-document>active document</a> of the
       <var>specified browsing context</var>.</ol>
     <li><p><a id=the-history-interface:traverse-the-history-2 href=browsing-the-web.html#traverse-the-history>Traverse the history</a> of the <var>specified browsing context</var> to
     the <var>specified entry</var> with the <i id=the-history-interface:history-navigation-flag><a href=browsing-the-web.html#history-navigation-flag>history-navigation
     flag</a></i> set.</p>
    </ol>
   </ol>

  <p>When the user navigates through a <a id=the-history-interface:browsing-context-6 href=browsers.html#browsing-context>browsing context</a>, e.g. using a browser's back
  and forward buttons, the user agent must <a href=#traverse-the-history-by-a-delta id=the-history-interface:traverse-the-history-by-a-delta-4>traverse the history by a delta</a> with a delta
  equivalent to the action specified by the user and the browsing context being operated on.</p>

  <hr id=history-1>

  <p>The <dfn id=url-and-history-update-steps>URL and history update steps</dfn>, given a <code id=the-history-interface:document-12><a href=dom.html#document>Document</a></code> object
  <var>document</var>, a <a id=the-history-interface:url href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a> <var>newURL</var>, an optional <a href=#serialized-state id=the-history-interface:serialized-state-2>serialized
  state</a> <var>serializedData</var>, and an optional string <var>title</var>, optionally with a
  <var>state push flag</var>, are:</p>

  <ol><li><p>Let <var>browsingContext</var> be <var>document</var>'s <a href=browsers.html#concept-document-bc id=the-history-interface:concept-document-bc-5>browsing context</a>.<li>
    <p>If the <var>state push flag</var> is set, then:</p>

    <ol><li>
      <p>Remove all the entries in <var>browsingContext</var>'s <a href=#session-history id=the-history-interface:session-history-9>session history</a> after
      the <a href=#current-entry id=the-history-interface:current-entry-3>current entry</a>. If the <a href=#current-entry id=the-history-interface:current-entry-4>current entry</a> is the last entry in the
      session history, then no entries are removed.</p>

      <p class=note>This <a href=#history-notes>doesn't necessarily have to affect</a> the user
      agent's user interface.</p>
     <li><p>Remove any <a href=webappapis.html#concept-task id=the-history-interface:concept-task-5>tasks</a> queued by the <a id=the-history-interface:history-traversal-task-source-2 href=webappapis.html#history-traversal-task-source>history
     traversal task source</a> that are associated with any <code id=the-history-interface:document-13><a href=dom.html#document>Document</a></code> objects in the
     <a id=the-history-interface:top-level-browsing-context-10 href=browsers.html#top-level-browsing-context>top-level browsing context</a>'s <a id=the-history-interface:document-family href=browsers.html#document-family>document family</a>.<li><p>If appropriate, update the <a href=#current-entry id=the-history-interface:current-entry-5>current entry</a> to reflect any state that the user
     agent wishes to persist. The entry is then said to be <a href=#an-entry-with-persisted-user-state id=the-history-interface:an-entry-with-persisted-user-state>an entry with persisted user
     state</a>.<li>
      <p>Add a <a href=#session-history-entry id=the-history-interface:session-history-entry>session history entry</a> entry to the session history, after the
      <a href=#current-entry id=the-history-interface:current-entry-6>current entry</a>, with</p>

      <ul><li><p><var>newURL</var> as the <a id=the-history-interface:url-2 href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a>;<li><p>the <a href=#scroll-restoration-mode id=the-history-interface:scroll-restoration-mode-5>scroll restoration mode</a> of the current entry in the <a href=#session-history id=the-history-interface:session-history-10>session
       history</a> as the scroll restoration mode;<li><p><var>serializedData</var> as the <a href=#serialized-state id=the-history-interface:serialized-state-3>serialized state</a>, if it is
       given;<li><p><var>title</var> as the title, if it is given.</ul>
     <li><p>Update the <a href=#current-entry id=the-history-interface:current-entry-7>current entry</a> to be this newly added entry.</ol>
   <li>
    <p>Otherwise, update the <a href=#current-entry id=the-history-interface:current-entry-8>current entry</a> in <var>browsingContext</var>'s
    <a href=#session-history id=the-history-interface:session-history-11>session history</a> so that:</p>

    <ul><li><p><var>newURL</var> is the entry's new <a id=the-history-interface:url-3 href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a>;<li><p><var>serializedData</var> is the entry's new <a href=#serialized-state id=the-history-interface:serialized-state-4>serialized state</a>, if it is
     given; otherwise, the <a href=#current-entry id=the-history-interface:current-entry-9>current entry</a>'s current <a href=#serialized-state id=the-history-interface:serialized-state-5>serialized state</a> is
     kept;<li><p><var>title</var> is the entry's new title, if it is given; otherwise, the entry does not
     have a title;<li><p>it represents a GET request, if it currently represents a non-GET request (e.g. it was
     the result of a POST submission).</ul>
   <li>
    <p>Set <var>document</var>'s <a href=https://dom.spec.whatwg.org/#concept-document-url id="the-history-interface:the-document's-address" data-x-internal="the-document's-address">URL</a> to
    <var>newURL</var>.</p>

    <p class=note>Since this is neither a <a href=browsing-the-web.html#navigate id=the-history-interface:navigate>navigation</a> of the
    <a id=the-history-interface:browsing-context-7 href=browsers.html#browsing-context>browsing context</a> nor a <a href=browsing-the-web.html#traverse-the-history id=the-history-interface:traverse-the-history-3>history traversal</a>,
    it does not cause a <code id=the-history-interface:event-hashchange><a href=indices.html#event-hashchange>hashchange</a></code> event to be fired.</p>
   </ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/History/pushState title="In an HTML document, the history.pushState() method adds a state to the browser's session history stack.">History/pushState</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>4+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>5+</span></span><hr><span class="opera yes"><span>Opera</span><span>11.5+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>4.3+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11.5+</span></span></div></div></aside><p>The <dfn id=dom-history-pushstate><code>pushState(<var>data</var>, <var>title</var>, <var>url</var>)</code></dfn> method adds a state object entry to
  the history.<div class=status><input onclick=toggleStatus(this) value=⋰ type=button><p class=support><strong>Support:</strong> history<span class="and_chr yes"><span>Chrome for Android</span> <span>80+</span></span><span class="chrome yes"><span>Chrome</span> <span>5+</span></span><span class="ios_saf yes"><span>iOS Safari</span> <span>5.0+</span></span><span class="firefox yes"><span>Firefox</span> <span>4+</span></span><span class="safari yes"><span>Safari</span> <span>6+</span></span><span class="samsung yes"><span>Samsung Internet</span> <span>4+</span></span><span class="and_uc yes"><span>UC Browser for Android</span> <span>12.12+</span></span><span class="edge yes"><span>Edge</span> <span>12+</span></span><span class="ie yes"><span>IE</span> <span>10+</span></span><span class="opera yes"><span>Opera</span> <span>11.5+</span></span><span class="op_mini no"><span>Opera Mini</span> <span>None</span></span><span class="android yes"><span>Android Browser</span> <span>4.2+</span></span><p class=caniuse>Source: <a href="https://caniuse.com/#feat=history">caniuse.com</a></div>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/History/replaceState title="The History.replaceState() method modifies the current history entry, replacing it with the stateObj, title, and URL passed in the method parameters. This method is particularly useful when you want to update the state object or URL of the current history entry in response to some user action.">History/replaceState</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>4+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>5+</span></span><hr><span class="opera yes"><span>Opera</span><span>11.5+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>4.3+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11.5+</span></span></div></div></aside><p>The <dfn id=dom-history-replacestate><code>replaceState(<var>data</var>, <var>title</var>, <var>url</var>)</code></dfn> method updates the state object,
  title, and optionally the <a id=the-history-interface:url-4 href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a> of the <a href=#current-entry id=the-history-interface:current-entry-10>current entry</a> in the history.</p>

  <p>When either of these methods is invoked, the user agent must run the following steps:</p>

  <ol><li><p>Let <var>document</var> be the unique <code id=the-history-interface:document-14><a href=dom.html#document>Document</a></code> object this
   <code id=the-history-interface:history-3-10><a href=#history-3>History</a></code> object is associated with.<li><p>If <var>document</var> is not <a id=the-history-interface:fully-active-8 href=browsers.html#fully-active>fully active</a>, throw a
   <a id=the-history-interface:securityerror-7 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-history-interface:domexception-7><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Optionally, return. (For example, the user agent might disallow calls to these
   methods that are invoked on a timer, or from event listeners that are not triggered in response
   to a clear user action, or that are invoked in rapid succession.)<li><p>Let <var>targetRealm</var> be this <code id=the-history-interface:history-3-11><a href=#history-3>History</a></code> object's <a href=webappapis.html#concept-relevant-realm id=the-history-interface:concept-relevant-realm>relevant Realm</a>.<li><p>Let <var>serializedData</var> be
   <a id=the-history-interface:structuredserializeforstorage href=structured-data.html#structuredserializeforstorage>StructuredSerializeForStorage</a>(<var>data</var>). Rethrow any exceptions.<li><p>Let <var>newURL</var> be the <a id=the-history-interface:url-5 href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a> of the <a href=#current-entry id=the-history-interface:current-entry-11>current entry</a> in
   <var>browsingContext</var>'s <a href=#session-history id=the-history-interface:session-history-12>session history</a>.<li>
    <p>If <var>url</var> is not null, then:</p>

    <ol><li><p><a href=urls-and-fetching.html#parse-a-url id=the-history-interface:parse-a-url>Parse</a> <var>url</var>, relative to the <a id=the-history-interface:relevant-settings-object href=webappapis.html#relevant-settings-object>relevant
     settings object</a> of this <code id=the-history-interface:history-3-12><a href=#history-3>History</a></code> object.<li><p>If that fails, then throw a <a id=the-history-interface:securityerror-8 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a>
     <code id=the-history-interface:domexception-8><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Set <var>newURL</var> to the <a id=the-history-interface:resulting-url-record href=urls-and-fetching.html#resulting-url-record>resulting URL record</a>.<li><p>Compare <var>newURL</var> to <var>document</var>'s <a href=https://dom.spec.whatwg.org/#concept-document-url id="the-history-interface:the-document's-address-2" data-x-internal="the-document's-address">URL</a>. If any component of these two <a href=https://url.spec.whatwg.org/#concept-url id=the-history-interface:url-record data-x-internal=url-record>URL records</a> differ other than the <a href=https://url.spec.whatwg.org/#concept-url-path id=the-history-interface:concept-url-path data-x-internal=concept-url-path>path</a>,
     <a href=https://url.spec.whatwg.org/#concept-url-query id=the-history-interface:concept-url-query data-x-internal=concept-url-query>query</a>, and <a href=https://url.spec.whatwg.org/#concept-url-fragment id=the-history-interface:concept-url-fragment data-x-internal=concept-url-fragment>fragment</a> components, then throw a
     <a id=the-history-interface:securityerror-9 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-history-interface:domexception-9><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If the <a href=https://url.spec.whatwg.org/#concept-url-origin id=the-history-interface:concept-url-origin data-x-internal=concept-url-origin>origin</a> of <var>newURL</var> is not
     <a id=the-history-interface:same-origin href=origin.html#same-origin>same origin</a> with the <a id=the-history-interface:concept-origin href=origin.html#concept-origin>origin</a> of <var>document</var>, and either the
     <a href=https://url.spec.whatwg.org/#concept-url-path id=the-history-interface:concept-url-path-2 data-x-internal=concept-url-path>path</a> or <a href=https://url.spec.whatwg.org/#concept-url-query id=the-history-interface:concept-url-query-2 data-x-internal=concept-url-query>query</a>
     components of the two <a href=https://url.spec.whatwg.org/#concept-url id=the-history-interface:url-record-2 data-x-internal=url-record>URL records</a> compared in the previous
     step differ, throw a <a id=the-history-interface:securityerror-10 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-history-interface:domexception-10><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>. (This
     prevents sandboxed content from spoofing other pages on the same origin.)</ol>
   <li><p>Run the <a href=#url-and-history-update-steps id=the-history-interface:url-and-history-update-steps>URL and history update steps</a> given <var>document</var>,
   <var>newURL</var>, <var>serializedData</var>, and <var>title</var>, with the <var>state push
   flag</var> set if the method invoked was the <code id=the-history-interface:dom-history-pushstate-2><a href=#dom-history-pushstate>pushState()</a></code> method.<li><p>Let <var>state</var> be <a id=the-history-interface:structureddeserialize href=structured-data.html#structureddeserialize>StructuredDeserialize</a>(<var>serializedData</var>,
   <var>targetRealm</var>). If this throws an exception, catch it, ignore the exception, and set
   <var>state</var> to null.<li><p>Set <code id=the-history-interface:dom-history-state-2><a href=#dom-history-state>history.state</a></code> to <var>state</var>.<li><p>Set the <a href=#current-entry id=the-history-interface:current-entry-12>current entry</a>'s <code id=the-history-interface:document-15><a href=dom.html#document>Document</a></code> object's <a href=#latest-entry id=the-history-interface:latest-entry>latest
   entry</a> to the <a href=#current-entry id=the-history-interface:current-entry-13>current entry</a>.</ol>

  <p class=note>The <var>title</var> is purely advisory. User agents might use the title
  in the user interface.</p>

  <p>User agents may limit the number of state objects added to the session history per page. If a
  page hits the UA-defined limit, user agents must remove the entry immediately after the first
  entry for that <code id=the-history-interface:document-16><a href=dom.html#document>Document</a></code> object in the session history after having added the new
  entry. (Thus the state history acts as a FIFO buffer for eviction, but as a LIFO buffer for
  navigation.)</p>

  

  <div class=example>

   <p>Consider a game where the user can navigate along a line, such that the user is always at some
   coordinate, and such that the user can bookmark the page corresponding to a particular
   coordinate, to return to it later.</p>

   <p>A static page implementing the x=5 position in such a game could look like the following:</p>

   <pre><code class='html'><c- cp>&lt;!DOCTYPE HTML&gt;</c->
<c- c>&lt;!-- this is https://example.com/line?x=5 --&gt;</c->
<c- p>&lt;</c-><c- f>html</c-> <c- e>lang</c-><c- o>=</c-><c- s>&quot;en&quot;</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>title</c-><c- p>&gt;</c->Line Game - 5<c- p>&lt;/</c-><c- f>title</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>p</c-><c- p>&gt;</c->You are at coordinate 5 on the line.<c- p>&lt;/</c-><c- f>p</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>p</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>a</c-> <c- e>href</c-><c- o>=</c-><c- s>&quot;?x=6&quot;</c-><c- p>&gt;</c->Advance to 6<c- p>&lt;/</c-><c- f>a</c-><c- p>&gt;</c-> or
 <c- p>&lt;</c-><c- f>a</c-> <c- e>href</c-><c- o>=</c-><c- s>&quot;?x=4&quot;</c-><c- p>&gt;</c->retreat to 4<c- p>&lt;/</c-><c- f>a</c-><c- p>&gt;</c->?
<c- p>&lt;/</c-><c- f>p</c-><c- p>&gt;</c-></code></pre>

   <p>The problem with such a system is that each time the user clicks, the whole page has to be
   reloaded. Here instead is another way of doing it, using script:</p>

   <pre><code class='html'><c- cp>&lt;!DOCTYPE HTML&gt;</c->
<c- c>&lt;!-- this starts off as https://example.com/line?x=5 --&gt;</c->
<c- p>&lt;</c-><c- f>html</c-> <c- e>lang</c-><c- o>=</c-><c- s>&quot;en&quot;</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>title</c-><c- p>&gt;</c->Line Game - 5<c- p>&lt;/</c-><c- f>title</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>p</c-><c- p>&gt;</c->You are at coordinate <c- p>&lt;</c-><c- f>span</c-> <c- e>id</c-><c- o>=</c-><c- s>&quot;coord&quot;</c-><c- p>&gt;</c->5<c- p>&lt;/</c-><c- f>span</c-><c- p>&gt;</c-> on the line.<c- p>&lt;/</c-><c- f>p</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>p</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>a</c-> <c- e>href</c-><c- o>=</c-><c- s>&quot;?x=6&quot;</c-> <c- e>onclick</c-><c- o>=</c-><c- s>&quot;go(1); return false;&quot;</c-><c- p>&gt;</c->Advance to 6<c- p>&lt;/</c-><c- f>a</c-><c- p>&gt;</c-> or
 <c- p>&lt;</c-><c- f>a</c-> <c- e>href</c-><c- o>=</c-><c- s>&quot;?x=4&quot;</c-> <c- e>onclick</c-><c- o>=</c-><c- s>&quot;go(-1); return false;&quot;</c-><c- p>&gt;</c->retreat to 4<c- p>&lt;/</c-><c- f>a</c-><c- p>&gt;</c->?
<c- p>&lt;/</c-><c- f>p</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
 <c- a>var</c-> currentPage <c- o>=</c-> <c- mi>5</c-><c- p>;</c-> <c- c1>// prefilled by server</c->
 <c- a>function</c-> go<c- p>(</c->d<c- p>)</c-> <c- p>{</c->
   setupPage<c- p>(</c->currentPage <c- o>+</c-> d<c- p>);</c->
   history<c- p>.</c->pushState<c- p>(</c->currentPage<c- p>,</c-> document<c- p>.</c->title<c- p>,</c-> <c- t>&apos;?x=&apos;</c-> <c- o>+</c-> currentPage<c- p>);</c->
 <c- p>}</c->
 onpopstate <c- o>=</c-> <c- a>function</c-><c- p>(</c->event<c- p>)</c-> <c- p>{</c->
   setupPage<c- p>(</c->event<c- p>.</c->state<c- p>);</c->
 <c- p>}</c->
 <c- a>function</c-> setupPage<c- p>(</c->page<c- p>)</c-> <c- p>{</c->
   currentPage <c- o>=</c-> page<c- p>;</c->
   document<c- p>.</c->title <c- o>=</c-> <c- t>&apos;Line Game - &apos;</c-> <c- o>+</c-> currentPage<c- p>;</c->
   document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;coord&apos;</c-><c- p>).</c->textContent <c- o>=</c-> currentPage<c- p>;</c->
   document<c- p>.</c->links<c- p>[</c-><c- mi>0</c-><c- p>].</c->href <c- o>=</c-> <c- t>&apos;?x=&apos;</c-> <c- o>+</c-> <c- p>(</c->currentPage<c- o>+</c-><c- mi>1</c-><c- p>);</c->
   document<c- p>.</c->links<c- p>[</c-><c- mi>0</c-><c- p>].</c->textContent <c- o>=</c-> <c- t>&apos;Advance to &apos;</c-> <c- o>+</c-> <c- p>(</c->currentPage<c- o>+</c-><c- mi>1</c-><c- p>);</c->
   document<c- p>.</c->links<c- p>[</c-><c- mi>1</c-><c- p>].</c->href <c- o>=</c-> <c- t>&apos;?x=&apos;</c-> <c- o>+</c-> <c- p>(</c->currentPage<c- o>-</c-><c- mi>1</c-><c- p>);</c->
   document<c- p>.</c->links<c- p>[</c-><c- mi>1</c-><c- p>].</c->textContent <c- o>=</c-> <c- t>&apos;retreat to &apos;</c-> <c- o>+</c-> <c- p>(</c->currentPage<c- o>-</c-><c- mi>1</c-><c- p>);</c->
 <c- p>}</c->
<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c-></code></pre>

   <p>In systems without script, this still works like the previous example. However, users that
   <em>do</em> have script support can now navigate much faster, since there is no network access
   for the same experience. Furthermore, contrary to the experience the user would have with just a
   naïve script-based approach, bookmarking and navigating the session history still work.</p>

   <p>In the example above, the <var>data</var> argument to the <code id=the-history-interface:dom-history-pushstate-3><a href=#dom-history-pushstate>pushState()</a></code> method is the same information as would be sent
   to the server, but in a more convenient form, so that the script doesn't have to parse the URL
   each time the user navigates.</p>

  </div>

  <div class=example>

   <p>Applications might not use the same title for a <a href=#session-history-entry id=the-history-interface:session-history-entry-2>session history entry</a> as the
   value of the document's <code id=the-history-interface:the-title-element><a href=semantics.html#the-title-element>title</a></code> element at that time. For example, here is a simple
   page that shows a block in the <code id=the-history-interface:the-title-element-2><a href=semantics.html#the-title-element>title</a></code> element. Clearly, when navigating backwards to
   a previous state the user does not go back in time, and therefore it would be inappropriate to
   put the time in the session history title.</p>

   <pre><code class='html'><c- cp>&lt;!DOCTYPE HTML&gt;</c->
<c- p>&lt;</c-><c- f>HTML</c-> <c- e>LANG</c-><c- o>=</c-><c- s>EN</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>TITLE</c-><c- p>&gt;</c->Line<c- p>&lt;/</c-><c- f>TITLE</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>SCRIPT</c-><c- p>&gt;</c->
 setInterval<c- p>(</c-><c- a>function</c-> <c- p>()</c-> <c- p>{</c-> document<c- p>.</c->title <c- o>=</c-> <c- t>&apos;Line - &apos;</c-> <c- o>+</c-> <c- k>new</c-> Date<c- p>();</c-> <c- p>},</c-> <c- mi>1000</c-><c- p>);</c->
 <c- a>var</c-> i <c- o>=</c-> <c- mi>1</c-><c- p>;</c->
 <c- a>function</c-> inc<c- p>()</c-> <c- p>{</c->
   set<c- p>(</c->i<c- o>+</c-><c- mi>1</c-><c- p>);</c->
   history<c- p>.</c->pushState<c- p>(</c->i<c- p>,</c-> <c- t>&apos;Line - &apos;</c-> <c- o>+</c-> i<c- p>);</c->
 <c- p>}</c->
 <c- a>function</c-> set<c- p>(</c->newI<c- p>)</c-> <c- p>{</c->
   i <c- o>=</c-> newI<c- p>;</c->
   document<c- p>.</c->forms<c- p>.</c->F<c- p>.</c->I<c- p>.</c->value <c- o>=</c-> newI<c- p>;</c->
 <c- p>}</c->
<c- p>&lt;/</c-><c- f>SCRIPT</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>BODY</c-> <c- e>ONPOPSTATE</c-><c- o>=</c-><c- s>&quot;set(event.state)&quot;</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>FORM</c-> <c- e>NAME</c-><c- o>=</c-><c- s>F</c-><c- p>&gt;</c->
State: <c- p>&lt;</c-><c- f>OUTPUT</c-> <c- e>NAME</c-><c- o>=</c-><c- s>I</c-><c- p>&gt;</c->1<c- p>&lt;/</c-><c- f>OUTPUT</c-><c- p>&gt;</c-> <c- p>&lt;</c-><c- f>INPUT</c-> <c- e>VALUE</c-><c- o>=</c-><c- s>&quot;Increment&quot;</c-> <c- e>TYPE</c-><c- o>=</c-><c- s>BUTTON</c-> <c- e>ONCLICK</c-><c- o>=</c-><c- s>&quot;inc()&quot;</c-><c- p>&gt;</c->
<c- p>&lt;/</c-><c- f>FORM</c-><c- p>&gt;</c-></code></pre>

  </div>

  <div class=example>
   <p>Most applications want to use the same <a href=#scroll-restoration-mode id=the-history-interface:scroll-restoration-mode-6>scroll restoration mode</a> value for all of
   their history entries. To achieve this they can set the <code id=the-history-interface:dom-history-scroll-restoration-2><a href=#dom-history-scroll-restoration>scrollRestoration</a></code> attribute as soon as possible
   (e.g., in the first <code id=the-history-interface:the-script-element><a href=scripting.html#the-script-element>script</a></code> element in the document's <code id=the-history-interface:the-head-element><a href=semantics.html#the-head-element>head</a></code> element) to
   ensure that any entry added to the history session gets the desired scroll restoration mode.</p>

   <pre><code class='html'><c- p>&lt;</c-><c- f>head</c-><c- p>&gt;</c->
  <c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
       <c- k>if</c-> <c- p>(</c-><c- t>&apos;scrollRestoration&apos;</c-> <c- k>in</c-> history<c- p>)</c->
            history<c- p>.</c->scrollRestoration <c- o>=</c-> <c- t>&apos;manual&apos;</c-><c- p>;</c->
  <c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c->
<c- p>&lt;/</c-><c- f>head</c-><c- p>&gt;</c->
   </code></pre>
  </div>


  

  <h4 id=history-notes><span class=secno>7.7.3</span> Implementation notes for session history<a href=#history-notes class=self-link></a></h4>
  

  <p><i>This section is non-normative.</i></p>

  <p>The <code id=history-notes:history-3><a href=#history-3>History</a></code> interface is not meant to place restrictions on how implementations
  represent the session history to the user.</p>

  <p>For example, session history could be implemented in a tree-like manner, with each page having
  multiple "forward" pages. This specification doesn't define how the linear list of pages in the
  <code id=history-notes:dom-history><a href=#dom-history>history</a></code> object are derived from the actual session history as
  seen from the user's perspective.</p>

  <p>Similarly, a page containing two <code id=history-notes:the-iframe-element><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code>s has a <code id=history-notes:dom-history-2><a href=#dom-history>history</a></code> object distinct from the <code id=history-notes:the-iframe-element-2><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code>s' <code id=history-notes:dom-history-3><a href=#dom-history>history</a></code> objects, despite the fact that typical Web browsers present the
  user with just one "Back" button, with a session history that interleaves the navigation of the
  two inner frames and the outer page.</p>


  <p><strong>Security</strong>: It is suggested that to avoid letting a page "hijack" the history
  navigation facilities of a UA by abusing <code id=history-notes:dom-history-pushstate><a href=#dom-history-pushstate>pushState()</a></code>,
  the UA provide the user with a way to jump back to the previous page (rather than just going back
  to the previous state). For example, the back button could have a drop down showing just the pages
  in the session history, and not showing any of the states. Similarly, an aural browser could have
  two "back" commands, one that goes back to the previous state, and one that jumps straight back to
  the previous page.</p>

  <p>For both <code id=history-notes:dom-history-pushstate-2><a href=#dom-history-pushstate>pushState()</a></code> and <code id=history-notes:dom-history-replacestate><a href=#dom-history-replacestate>replaceState()</a></code>, user agents are encouraged to prevent
  abuse of these APIs via too-frequent calls or over-large state objects. As detailed above, the
  algorithm explicitly allows user agents to ignore any such calls when appropriate.</p>


  


  <h4 id=the-location-interface><span class=secno>7.7.4</span> The <code id=the-location-interface:location><a href=#location>Location</a></code> interface<a href=#the-location-interface class=self-link></a></h4><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Document/location title="The Document.location read-only property returns a Location object, which contains information about the URL of the document and provides methods for changing that URL and loading another URL.">Document/location</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>4+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location title="The Location interface represents the location (URL) of the object it is linked to. Changes done on it are reflected on the object it relates to. Both the Document and Window interface have such a linked Location, accessible via Document.location and Window.location respectively.">Location</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>3+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Window/location title="The Window.location read-only property returns a Location object with information about the current location of the document.">Window/location</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>4+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside>

  <p>Each <code id=the-location-interface:window><a href=window-object.html#window>Window</a></code> object is associated with a unique instance of a <code id=the-location-interface:location-2><a href=#location>Location</a></code>
  object, allocated when the <code id=the-location-interface:window-2><a href=window-object.html#window>Window</a></code> object is created.</p>

  

  <p class=warning>The <code id=the-location-interface:location-3><a href=#location>Location</a></code> exotic object is defined through a mishmash of IDL,
  invocation of JavaScript internal methods post-creation, and overridden JavaScript internal
  methods. Coupled with its scary security policy, please take extra care while implementing
  this excrescence.</p>

  <p>To create a <code id=the-location-interface:location-4><a href=#location>Location</a></code> object, run these steps:</p>

  <ol><li><p>Let <var>location</var> be a new <code id=the-location-interface:location-5><a href=#location>Location</a></code> <a id=the-location-interface:platform-object href=https://heycam.github.io/webidl/#dfn-platform-object data-x-internal=platform-object>platform
   object</a>.<li><p>Let <var>valueOf</var> be <var>location</var>'s <a href=webappapis.html#concept-relevant-realm id=the-location-interface:concept-relevant-realm>relevant
   Realm</a>.[[Intrinsics]].[[<a id=the-location-interface:objproto_valueof href=https://tc39.es/ecma262/#sec-object.prototype.valueof data-x-internal=objproto_valueof>%ObjProto_valueOf%</a>]].<li><p>Perform ! <var>location</var>.[[DefineOwnProperty]]("<code>valueOf</code>", {
   [[Value]]: <var>valueOf</var>,
   [[Writable]]: false,
   [[Enumerable]]: false,
   [[Configurable]]: false }).<li><p>Perform ! <var>location</var>.[[DefineOwnProperty]](<a id=the-location-interface:@@toprimitive href=infrastructure.html#@@toprimitive>@@toPrimitive</a>, {
   [[Value]]: undefined,
   [[Writable]]: false,
   [[Enumerable]]: false,
   [[Configurable]]: false }).<li><p>Set the value of the <a href=#defaultproperties id=the-location-interface:defaultproperties>[[DefaultProperties]]</a> internal slot of
   <var>location</var> to <var>location</var>.[[OwnPropertyKeys]]().<li><p>Return <var>location</var>.</ol>

  <p class=note>The addition of <code>valueOf</code> and <a id=the-location-interface:@@toprimitive-2 href=infrastructure.html#@@toprimitive>@@toPrimitive</a> own
  data properties, as well as the fact that all of <code id=the-location-interface:location-6><a href=#location>Location</a></code>'s IDL attributes are marked
  <code>[Unforgeable]</code>, is required by legacy code that consulted the
  <code id=the-location-interface:location-7><a href=#location>Location</a></code> interface, or stringified it, to determine the <a href=https://dom.spec.whatwg.org/#concept-document-url id="the-location-interface:the-document's-address" data-x-internal="the-document's-address">document URL</a>, and then used it in a security-sensitive way.
  In particular, the <code>valueOf</code>, <a id=the-location-interface:@@toprimitive-3 href=infrastructure.html#@@toprimitive>@@toPrimitive</a>, and <code>[Unforgeable]</code> stringifier mitigations ensure that code such as <code>foo[location] = bar</code> or <code>location + ""</code> cannot be
  misdirected.</p>

  

  <dl class=domintro><dt><var>document</var> . <code id=dom-document-location-dev><a href=#dom-document-location>location</a></code> [ = <var>value</var> ]<dt><var>window</var> . <code id=dom-location-dev><a href=#dom-location>location</a></code> [ = <var>value</var> ]<dd>
    <p>Returns a <code id=the-location-interface:location-8><a href=#location>Location</a></code> object with the current page's location.</p>

    <p>Can be set, to navigate to another page.</p>
   </dl>

  

  <p>The <code id=the-location-interface:document><a href=dom.html#document>Document</a></code> object's <dfn id=dom-document-location><code>location</code></dfn> attribute's getter must return this
  <code id=the-location-interface:document-2><a href=dom.html#document>Document</a></code> object's <a id=the-location-interface:concept-relevant-global href=webappapis.html#concept-relevant-global>relevant global object</a>'s <code id=the-location-interface:location-9><a href=#location>Location</a></code> object,
  if this <code id=the-location-interface:document-3><a href=dom.html#document>Document</a></code> object is <a id=the-location-interface:fully-active href=browsers.html#fully-active>fully active</a>, and null otherwise.</p>

  <p>The <code id=the-location-interface:window-3><a href=window-object.html#window>Window</a></code> object's <dfn id=dom-location><code>location</code></dfn>
  attribute's getter must return this <code id=the-location-interface:window-4><a href=window-object.html#window>Window</a></code> object's <code id=the-location-interface:location-10><a href=#location>Location</a></code> object.</p>

  

  <p><code id=the-location-interface:location-11><a href=#location>Location</a></code> objects provide a representation of the <a href=https://dom.spec.whatwg.org/#concept-document-url id="the-location-interface:the-document's-address-2" data-x-internal="the-document's-address">URL</a> of the <a id=the-location-interface:active-document href=browsers.html#active-document>active document</a> of their
  <code id=the-location-interface:document-4><a href=dom.html#document>Document</a></code>'s <a href=browsers.html#concept-document-bc id=the-location-interface:concept-document-bc>browsing context</a>, and allow the
  <a href=#current-entry id=the-location-interface:current-entry>current entry</a> of the <a id=the-location-interface:browsing-context href=browsers.html#browsing-context>browsing context</a>'s session history to be changed,
  by adding or replacing entries in the <code id=the-location-interface:dom-history><a href=#dom-history>history</a></code> object.</p>

  <pre><code class='idl'>[<c- g>Exposed</c->=<c- n>Window</c->]
<c- b>interface</c-> <dfn id='location'><c- g>Location</c-></dfn> { // but see also <a href='#the-location-interface'>additional creation steps</a> and <a href='#location-internal-methods'>overridden internal methods</a>
  [<c- g>Unforgeable</c->] <c- b>stringifier</c-> <c- b>attribute</c-> <c- b>USVString</c-> <a href='#dom-location-href' id='the-location-interface:dom-location-href'><c- g>href</c-></a>;
  [<c- g>Unforgeable</c->] <c- b>readonly</c-> <c- b>attribute</c-> <c- b>USVString</c-> <a href='#dom-location-origin' id='the-location-interface:dom-location-origin'><c- g>origin</c-></a>;
  [<c- g>Unforgeable</c->] <c- b>attribute</c-> <c- b>USVString</c-> <a href='#dom-location-protocol' id='the-location-interface:dom-location-protocol'><c- g>protocol</c-></a>;
  [<c- g>Unforgeable</c->] <c- b>attribute</c-> <c- b>USVString</c-> <a href='#dom-location-host' id='the-location-interface:dom-location-host'><c- g>host</c-></a>;
  [<c- g>Unforgeable</c->] <c- b>attribute</c-> <c- b>USVString</c-> <a href='#dom-location-hostname' id='the-location-interface:dom-location-hostname'><c- g>hostname</c-></a>;
  [<c- g>Unforgeable</c->] <c- b>attribute</c-> <c- b>USVString</c-> <a href='#dom-location-port' id='the-location-interface:dom-location-port'><c- g>port</c-></a>;
  [<c- g>Unforgeable</c->] <c- b>attribute</c-> <c- b>USVString</c-> <a href='#dom-location-pathname' id='the-location-interface:dom-location-pathname'><c- g>pathname</c-></a>;
  [<c- g>Unforgeable</c->] <c- b>attribute</c-> <c- b>USVString</c-> <a href='#dom-location-search' id='the-location-interface:dom-location-search'><c- g>search</c-></a>;
  [<c- g>Unforgeable</c->] <c- b>attribute</c-> <c- b>USVString</c-> <a href='#dom-location-hash' id='the-location-interface:dom-location-hash'><c- g>hash</c-></a>;

  [<c- g>Unforgeable</c->] <c- b>void</c-> <a href='#dom-location-assign' id='the-location-interface:dom-location-assign'><c- g>assign</c-></a>(<c- b>USVString</c-> <c- g>url</c->);
  [<c- g>Unforgeable</c->] <c- b>void</c-> <a href='#dom-location-replace' id='the-location-interface:dom-location-replace'><c- g>replace</c-></a>(<c- b>USVString</c-> <c- g>url</c->);
  [<c- g>Unforgeable</c->] <c- b>void</c-> <a href='#dom-location-reload' id='the-location-interface:dom-location-reload'><c- g>reload</c-></a>();

  [<c- g>Unforgeable</c->, <c- g>SameObject</c->] <c- b>readonly</c-> <c- b>attribute</c-> <a href='common-dom-interfaces.html#domstringlist' id='the-location-interface:domstringlist'><c- n>DOMStringList</c-></a> <a href='#dom-location-ancestororigins' id='the-location-interface:dom-location-ancestororigins'><c- g>ancestorOrigins</c-></a>;
};</code></pre>

  <dl class=domintro><dt><var>location</var> . <code>toString()</code><dt><var>location</var> . <code id=dom-location-href-dev><a href=#dom-location-href>href</a></code><dd>
    <p>Returns the <code id=the-location-interface:location-12><a href=#location>Location</a></code> object's URL.</p>
    <p>Can be set, to navigate to the given URL.</p>
   <dt><var>location</var> . <code id=dom-location-origin-dev><a href=#dom-location-origin>origin</a></code><dd>
    <p>Returns the <code id=the-location-interface:location-13><a href=#location>Location</a></code> object's URL's origin.</p>
   <dt><var>location</var> . <code id=dom-location-protocol-dev><a href=#dom-location-protocol>protocol</a></code><dd>
    <p>Returns the <code id=the-location-interface:location-14><a href=#location>Location</a></code> object's URL's scheme.</p>
    <p>Can be set, to navigate to the same URL with a changed scheme.</p>
   <dt><var>location</var> . <code id=dom-location-host-dev><a href=#dom-location-host>host</a></code><dd>
    <p>Returns the <code id=the-location-interface:location-15><a href=#location>Location</a></code> object's URL's host and port (if different from the default
    port for the scheme).</p>
    <p>Can be set, to navigate to the same URL with a changed host and port.</p>
   <dt><var>location</var> . <code id=dom-location-hostname-dev><a href=#dom-location-hostname>hostname</a></code><dd>
    <p>Returns the <code id=the-location-interface:location-16><a href=#location>Location</a></code> object's URL's host.</p>
    <p>Can be set, to navigate to the same URL with a changed host.</p>
   <dt><var>location</var> . <code id=dom-location-port-dev><a href=#dom-location-port>port</a></code><dd>
    <p>Returns the <code id=the-location-interface:location-17><a href=#location>Location</a></code> object's URL's port.</p>
    <p>Can be set, to navigate to the same URL with a changed port.</p>
   <dt><var>location</var> . <code id=dom-location-pathname-dev><a href=#dom-location-pathname>pathname</a></code><dd>
    <p>Returns the <code id=the-location-interface:location-18><a href=#location>Location</a></code> object's URL's path.</p>
    <p>Can be set, to navigate to the same URL with a changed path.</p>
   <dt><var>location</var> . <code id=dom-location-search-dev><a href=#dom-location-search>search</a></code><dd>
    <p>Returns the <code id=the-location-interface:location-19><a href=#location>Location</a></code> object's URL's query (includes leading "<code>?</code>" if non-empty).</p>
    <p>Can be set, to navigate to the same URL with a changed query (ignores leading "<code>?</code>").</p>
   <dt><var>location</var> . <code id=dom-location-hash-dev><a href=#dom-location-hash>hash</a></code><dd>
    <p>Returns the <code id=the-location-interface:location-20><a href=#location>Location</a></code> object's URL's fragment (includes leading "<code>#</code>" if non-empty).</p>
    <p>Can be set, to navigate to the same URL with a changed fragment (ignores leading "<code>#</code>").</p>
   <dt><var>location</var> . <code id=dom-location-assign-dev><a href=#dom-location-assign>assign</a></code>(<var>url</var>)<dd>
    <p>Navigates to the given URL.</p>
   <dt><var>location</var> . <code id=dom-location-replace-dev><a href=#dom-location-replace>replace</a></code>(<var>url</var>)<dd>
    <p>Removes the current page from the session history and navigates to the given URL.</p>
   <dt><var>location</var> . <code id=dom-location-reload-dev><a href=#dom-location-reload>reload</a></code>()<dd>
    <p>Reloads the current page.</p>
   <dt><var>location</var> . <code id=dom-location-ancestororigins-dev><a href=#dom-location-ancestororigins>ancestorOrigins</a></code><dd>
    <p>Returns a <code id=the-location-interface:domstringlist-2><a href=common-dom-interfaces.html#domstringlist>DOMStringList</a></code> object listing the origins of the ancestor <a href=browsers.html#browsing-context id=the-location-interface:browsing-context-2>browsing contexts</a>, from the <a id=the-location-interface:parent-browsing-context href=browsers.html#parent-browsing-context>parent browsing
    context</a> to the <a id=the-location-interface:top-level-browsing-context href=browsers.html#top-level-browsing-context>top-level browsing context</a>.</p>
   </dl>

  

  <p>A <code id=the-location-interface:location-21><a href=#location>Location</a></code> object has an associated <dfn id=relevant-document>relevant <code>Document</code></dfn>,
  which is this <code id=the-location-interface:location-22><a href=#location>Location</a></code> object's <a id=the-location-interface:concept-relevant-global-2 href=webappapis.html#concept-relevant-global>relevant global object</a>'s <a href=window-object.html#window-bc id=the-location-interface:window-bc>browsing context</a>'s <a id=the-location-interface:active-document-2 href=browsers.html#active-document>active document</a>, if this
  <code id=the-location-interface:location-23><a href=#location>Location</a></code> object's <a id=the-location-interface:concept-relevant-global-3 href=webappapis.html#concept-relevant-global>relevant global object</a>'s <a href=window-object.html#window-bc id=the-location-interface:window-bc-2>browsing context</a> is non-null, and null otherwise.</p>

  <p>A <code id=the-location-interface:location-24><a href=#location>Location</a></code> object has an associated <dfn id=concept-location-url>url</dfn>,
  which is this <code id=the-location-interface:location-25><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document>relevant <code>Document</code></a>'s <a href=https://dom.spec.whatwg.org/#concept-document-url id="the-location-interface:the-document's-address-3" data-x-internal="the-document's-address">URL</a>, if this <code id=the-location-interface:location-26><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-2>relevant
  <code>Document</code></a> is non-null, and <code id=the-location-interface:about:blank><a href=infrastructure.html#about:blank>about:blank</a></code> otherwise.</p>

  <p>A <code id=the-location-interface:location-27><a href=#location>Location</a></code> object has an associated <dfn id=concept-location-ancestor-origins-list>ancestor origins list</dfn>. When a
  <code id=the-location-interface:location-28><a href=#location>Location</a></code> object is created, its <a href=#concept-location-ancestor-origins-list id=the-location-interface:concept-location-ancestor-origins-list>ancestor origins list</a> must be set to a
  <code id=the-location-interface:domstringlist-3><a href=common-dom-interfaces.html#domstringlist>DOMStringList</a></code> object whose associated list is the <a id=the-location-interface:list href=https://infra.spec.whatwg.org/#list data-x-internal=list>list</a> of strings that
  the following steps would produce:</p>

  <ol><li><p>Let <var>output</var> be a new <a id=the-location-interface:list-2 href=https://infra.spec.whatwg.org/#list data-x-internal=list>list</a> of strings.<li><p>Let <var>current</var> be the <a href=browsers.html#concept-document-bc id=the-location-interface:concept-document-bc-2>browsing context</a>
   of the <code id=the-location-interface:document-5><a href=dom.html#document>Document</a></code> with which this <code id=the-location-interface:location-29><a href=#location>Location</a></code> object is associated.<li><p><i>Loop</i>: If <var>current</var> has no <a id=the-location-interface:parent-browsing-context-2 href=browsers.html#parent-browsing-context>parent browsing context</a>, jump to
   the step labeled <i>end</i>.<li><p>Let <var>current</var> be <var>current</var>'s <a id=the-location-interface:parent-browsing-context-3 href=browsers.html#parent-browsing-context>parent browsing
   context</a>.<li><p><a href=https://infra.spec.whatwg.org/#list-append id=the-location-interface:list-append data-x-internal=list-append>Append</a> the <a href=origin.html#ascii-serialisation-of-an-origin id=the-location-interface:ascii-serialisation-of-an-origin>serialization</a> of <var>current</var>'s <a id=the-location-interface:active-document-3 href=browsers.html#active-document>active document</a>'s
   <a id=the-location-interface:concept-origin href=origin.html#concept-origin>origin</a> to <var>output</var>.<li><p>Return to the step labeled <i>loop</i>.<li><p><i>End</i>: Return <var>output</var>.</ol>

  <p>A <code id=the-location-interface:location-30><a href=#location>Location</a></code> object has an associated <dfn id=location-object-setter-navigate><code>Location</code>-object-setter
  navigate</dfn> algorithm, which given a <var>url</var>, runs these steps:</p>

  <ol><li>
    <p>If any of the following conditions are met, let <var>replacement flag</var> be unset;
    otherwise, let it be set:</p>

    <ul class=brief><li>This <code id=the-location-interface:location-31><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-3>relevant <code>Document</code></a> has
     <a id=the-location-interface:completely-loaded href=parsing.html#completely-loaded>completely loaded</a>, or<li>In the <a href=webappapis.html#concept-task id=the-location-interface:concept-task>task</a> in which the algorithm is running, an
     <a id=the-location-interface:activation-behaviour href=https://dom.spec.whatwg.org/#eventtarget-activation-behavior data-x-internal=activation-behaviour>activation behavior</a> is currently being processed whose <code id=the-location-interface:event-click><a data-x-internal=event-click href=https://w3c.github.io/uievents/#event-type-click>click</a></code> event's <code id=the-location-interface:dom-event-istrusted><a data-x-internal=dom-event-istrusted href=https://dom.spec.whatwg.org/#dom-event-istrusted>isTrusted</a></code>
     attribute is true, or<li>In the <a href=webappapis.html#concept-task id=the-location-interface:concept-task-2>task</a> in which the algorithm is running, the event
     listener for a <code id=the-location-interface:event-click-2><a data-x-internal=event-click href=https://w3c.github.io/uievents/#event-type-click>click</a></code> event, whose <code id=the-location-interface:dom-event-istrusted-2><a data-x-internal=dom-event-istrusted href=https://dom.spec.whatwg.org/#dom-event-istrusted>isTrusted</a></code> attribute is true, is being handled.</ul>
   <li><p><a href=#location-object-navigate id=the-location-interface:location-object-navigate><code>Location</code>-object navigate</a>, given <var>url</var> and
   <var>replacement flag</var>.</ol>

  <p>To <dfn id=location-object-navigate><code>Location</code>-object navigate</dfn>, given a <var>url</var> and
  <var>replacement flag</var>, run these steps:</p>

  <ol><li><p>The <a id=the-location-interface:source-browsing-context href=browsing-the-web.html#source-browsing-context>source browsing context</a> is the <a href=webappapis.html#concept-incumbent-global id=the-location-interface:concept-incumbent-global>incumbent global object</a>'s <a href=window-object.html#window-bc id=the-location-interface:window-bc-3>browsing context</a>.<li>
    <p><a id=the-location-interface:navigate href=browsing-the-web.html#navigate>Navigate</a> the <a id=the-location-interface:browsing-context-3 href=browsers.html#browsing-context>browsing context</a> to
    <var>url</var>, with the <var><a id=the-location-interface:exceptions-enabled href=browsing-the-web.html#exceptions-enabled>exceptions enabled flag</a></var> set. Rethrow any
    exceptions.</p>

    <p>If the <var>replacement flag</var> is set or the <a id=the-location-interface:browsing-context-4 href=browsers.html#browsing-context>browsing context</a>'s
    <a href=#session-history id=the-location-interface:session-history>session history</a> contains only one <code id=the-location-interface:document-6><a href=dom.html#document>Document</a></code>, and that was the
    <code id=the-location-interface:about:blank-2><a href=infrastructure.html#about:blank>about:blank</a></code> <code id=the-location-interface:document-7><a href=dom.html#document>Document</a></code> created when the <a id=the-location-interface:browsing-context-5 href=browsers.html#browsing-context>browsing context</a>
    was created, then the navigation must be done with <a id=the-location-interface:replacement-enabled href=browsing-the-web.html#replacement-enabled>replacement enabled</a>.</p>
    
   </ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/href title="The href property of the Location interface is a stringifier that returns a USVString containing the whole URL, and allows the href to be updated.">Location/href</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>22+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-location-href><code>href</code></dfn> attribute's getter must run these
  steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-32><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-4>relevant <code>Document</code></a> is
   non-null and its <a id=the-location-interface:concept-origin-2 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin>origin</a>, then throw
   a <a id=the-location-interface:securityerror href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Return this <code id=the-location-interface:location-33><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url>url</a>,
   <a href=https://url.spec.whatwg.org/#concept-url-serializer id=the-location-interface:concept-url-serializer data-x-internal=concept-url-serializer>serialized</a>.</ol>

  <p>The <code id=the-location-interface:dom-location-href-2><a href=#dom-location-href>href</a></code> attribute's setter must run these steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-34><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-5>relevant <code>Document</code></a> is
   null, then return.<li><p><a href=urls-and-fetching.html#parse-a-url id=the-location-interface:parse-a-url>Parse</a> the given value relative to the <a id=the-location-interface:entry-settings-object-2 href=webappapis.html#entry-settings-object>entry
   settings object</a>. If that failed, throw a <code id=the-location-interface:typeerror><a data-x-internal=typeerror href=https://tc39.es/ecma262/#sec-native-error-types-used-in-this-standard-typeerror>TypeError</a></code> exception.<li><p><a href=#location-object-setter-navigate id=the-location-interface:location-object-setter-navigate><code>Location</code>-object-setter navigate</a> to the <a id=the-location-interface:resulting-url-record href=urls-and-fetching.html#resulting-url-record>resulting URL
   record</a>.</ol>

  <p class=note>The <code id=the-location-interface:dom-location-href-3><a href=#dom-location-href>href</a></code> attribute setter intentionally
  has no security check.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/origin title="The origin read-only property of the Location interface is a USVString containing the Unicode serialization of the origin of the represented URL">Location/origin</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>26+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>10+</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>11</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>26+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div></aside><p>The <dfn id=dom-location-origin><code>origin</code></dfn> attribute's getter must run
  these steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-35><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-6>relevant <code>Document</code></a> is
   non-null and its <a id=the-location-interface:concept-origin-3 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-2 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-3 href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-2>origin</a>, then throw
   a <a id=the-location-interface:securityerror-2 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Return the <a href=origin.html#ascii-serialisation-of-an-origin id=the-location-interface:ascii-serialisation-of-an-origin-2>serialization</a> of this
   <code id=the-location-interface:location-36><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-2>url</a>'s <a href=https://url.spec.whatwg.org/#concept-url-origin id=the-location-interface:concept-url-origin data-x-internal=concept-url-origin>origin</a>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/protocol title="The protocol property of the Location interface is a USVString representing the protocol scheme of the URL, including the final ':'.">Location/protocol</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>22+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-location-protocol><code>protocol</code></dfn> attribute's getter must run
  these steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-37><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-7>relevant <code>Document</code></a> is
   non-null and its <a id=the-location-interface:concept-origin-4 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-3 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-4 href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-3>origin</a>, then throw
   a <a id=the-location-interface:securityerror-3 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-3><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Return this <code id=the-location-interface:location-38><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-3>url</a>'s <a href=https://url.spec.whatwg.org/#concept-url-scheme id=the-location-interface:concept-url-scheme data-x-internal=concept-url-scheme>scheme</a>,
   followed by "<code>:</code>".</ol>

  <p>The <code id=the-location-interface:dom-location-protocol-2><a href=#dom-location-protocol>protocol</a></code> attribute's setter must run these
  steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-39><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-8>relevant <code>Document</code></a> is
   null, then return.<li><p>If this <code id=the-location-interface:location-40><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-9>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-5 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-4 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-5 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-4>origin</a>, then throw a
   <a id=the-location-interface:securityerror-4 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-4><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>copyURL</var> be a copy of this <code id=the-location-interface:location-41><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-4>url</a>.<li>
    <p>Let <var>possibleFailure</var> be the result of <a href=https://url.spec.whatwg.org/#concept-basic-url-parser id=the-location-interface:basic-url-parser data-x-internal=basic-url-parser>basic URL
    parsing</a> the given value, followed by "<code>:</code>", with <var>copyURL</var>
    as <var>url</var> and <a id=the-location-interface:scheme-start-state href=https://url.spec.whatwg.org/#scheme-start-state data-x-internal=scheme-start-state>scheme start state</a> as <var>state override</var>.</p>

    <p class=note>Because the URL parser ignores multiple consecutive colons, providing a value
    of "<code>https:</code>" (or even "<code>https::::</code>") is the same as
    providing a value of "<code>https</code>".</p>
   <li><p>If <var>possibleFailure</var> is failure, then throw a
   <a id=the-location-interface:syntaxerror href=https://heycam.github.io/webidl/#syntaxerror data-x-internal=syntaxerror>"<code>SyntaxError</code>"</a> <code id=the-location-interface:domexception-5><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If <var>copyURL</var>'s <a href=https://url.spec.whatwg.org/#concept-url-scheme id=the-location-interface:concept-url-scheme-2 data-x-internal=concept-url-scheme>scheme</a> is not an
   <a id=the-location-interface:http(s)-scheme href=https://fetch.spec.whatwg.org/#http-scheme data-x-internal=http(s)-scheme>HTTP(S) scheme</a>, then terminate these steps.<li><p><a href=#location-object-setter-navigate id=the-location-interface:location-object-setter-navigate-2><code>Location</code>-object-setter navigate</a> to <var>copyURL</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/host title="The host property of the Location interface is a USVString containing the host, that is the hostname, and then, if the port of the URL is nonempty, a ':', and the port of the URL.">Location/host</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>22+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-location-host><code>host</code></dfn> attribute's getter must run these
  steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-42><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-10>relevant <code>Document</code></a> is
   non-null and its <a id=the-location-interface:concept-origin-6 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-5 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-6 href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-5>origin</a>, then throw
   a <a id=the-location-interface:securityerror-5 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-6><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>url</var> be this <code id=the-location-interface:location-43><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-5>url</a>.<li><p>If <var>url</var>'s <a href=https://url.spec.whatwg.org/#concept-url-host id=the-location-interface:concept-url-host data-x-internal=concept-url-host>host</a> is null, return the empty
   string.<li><p>If <var>url</var>'s <a href=https://url.spec.whatwg.org/#concept-url-port id=the-location-interface:concept-url-port data-x-internal=concept-url-port>port</a> is null, return
   <var>url</var>'s <a href=https://url.spec.whatwg.org/#concept-url-host id=the-location-interface:concept-url-host-2 data-x-internal=concept-url-host>host</a>, <a href=https://url.spec.whatwg.org/#concept-host-serializer id=the-location-interface:host-serializer data-x-internal=host-serializer>serialized</a>.<li><p>Return <var>url</var>'s <a href=https://url.spec.whatwg.org/#concept-url-host id=the-location-interface:concept-url-host-3 data-x-internal=concept-url-host>host</a>, <a href=https://url.spec.whatwg.org/#concept-host-serializer id=the-location-interface:host-serializer-2 data-x-internal=host-serializer>serialized</a>, followed by "<code>:</code>" and <var>url</var>'s <a href=https://url.spec.whatwg.org/#concept-url-port id=the-location-interface:concept-url-port-2 data-x-internal=concept-url-port>port</a>, <a href=https://url.spec.whatwg.org/#serialize-an-integer id=the-location-interface:serialize-an-integer data-x-internal=serialize-an-integer>serialized</a>.</ol>

  <p>The <code id=the-location-interface:dom-location-host-2><a href=#dom-location-host>host</a></code> attribute's setter must run these steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-44><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-11>relevant <code>Document</code></a> is
   null, then return.<li><p>If this <code id=the-location-interface:location-45><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-12>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-7 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-6 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-7 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-6>origin</a>, then throw a
   <a id=the-location-interface:securityerror-6 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-7><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>copyURL</var> be a copy of this <code id=the-location-interface:location-46><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-6>url</a>.<li><p>If <var>copyURL</var>'s <a id=the-location-interface:cannot-be-a-base-url-flag href=https://url.spec.whatwg.org/#url-cannot-be-a-base-url-flag data-x-internal=cannot-be-a-base-url-flag>cannot-be-a-base-URL flag</a> is set, terminate these
   steps.<li><p><a href=https://url.spec.whatwg.org/#concept-basic-url-parser id=the-location-interface:basic-url-parser-2 data-x-internal=basic-url-parser>Basic URL parse</a> the given value, with
   <var>copyURL</var> as <var>url</var> and <a id=the-location-interface:host-state href=https://url.spec.whatwg.org/#host-state data-x-internal=host-state>host state</a> as <var>state
   override</var>.<li><p><a href=#location-object-setter-navigate id=the-location-interface:location-object-setter-navigate-3><code>Location</code>-object-setter navigate</a> to <var>copyURL</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/hostname title="The hostname property of the Location interface is a USVString containing the domain of the URL.">Location/hostname</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera no"><span>Opera</span><span>No</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>22+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-location-hostname><code>hostname</code></dfn> attribute's getter must
  run these steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-47><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-13>relevant <code>Document</code></a> is
   non-null and its <a id=the-location-interface:concept-origin-8 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-7 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-8 href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-7>origin</a>, then throw
   a <a id=the-location-interface:securityerror-7 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-8><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If this <code id=the-location-interface:location-48><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-7>url</a>'s
   <a href=https://url.spec.whatwg.org/#concept-url-host id=the-location-interface:concept-url-host-4 data-x-internal=concept-url-host>host</a> is null, return the empty string.<li><p>Return this <code id=the-location-interface:location-49><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-8>url</a>'s <a href=https://url.spec.whatwg.org/#concept-url-host id=the-location-interface:concept-url-host-5 data-x-internal=concept-url-host>host</a>, <a href=https://url.spec.whatwg.org/#concept-host-serializer id=the-location-interface:host-serializer-3 data-x-internal=host-serializer>serialized</a>.</ol>

  <p>The <code id=the-location-interface:dom-location-hostname-2><a href=#dom-location-hostname>hostname</a></code> attribute's setter must run these
  steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-50><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-14>relevant <code>Document</code></a> is
   null, then return.<li><p>If this <code id=the-location-interface:location-51><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-15>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-9 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-8 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-9 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-8>origin</a>, then throw a
   <a id=the-location-interface:securityerror-8 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-9><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>copyURL</var> be a copy of this <code id=the-location-interface:location-52><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-9>url</a>.<li><p>If <var>copyURL</var>'s <a id=the-location-interface:cannot-be-a-base-url-flag-2 href=https://url.spec.whatwg.org/#url-cannot-be-a-base-url-flag data-x-internal=cannot-be-a-base-url-flag>cannot-be-a-base-URL flag</a> is set, terminate these
   steps.<li><p><a href=https://url.spec.whatwg.org/#concept-basic-url-parser id=the-location-interface:basic-url-parser-3 data-x-internal=basic-url-parser>Basic URL parse</a> the given value, with
   <var>copyURL</var> as <var>url</var> and <a id=the-location-interface:hostname-state href=https://url.spec.whatwg.org/#hostname-state data-x-internal=hostname-state>hostname state</a> as <var>state
   override</var>.<li><p><a href=#location-object-setter-navigate id=the-location-interface:location-object-setter-navigate-4><code>Location</code>-object-setter navigate</a> to <var>copyURL</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/port title="The port property of the Location interface is a USVString containing the port number of the URL. If the URL does not contain an explicit port number, it will be set to ''.">Location/port</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>22+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-location-port><code>port</code></dfn> attribute's getter must run these
  steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-53><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-16>relevant <code>Document</code></a> is
   non-null and its <a id=the-location-interface:concept-origin-10 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-9 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-10 href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-9>origin</a>, then throw
   a <a id=the-location-interface:securityerror-9 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-10><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If this <code id=the-location-interface:location-54><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-10>url</a>'s
   <a href=https://url.spec.whatwg.org/#concept-url-port id=the-location-interface:concept-url-port-3 data-x-internal=concept-url-port>port</a> is null, return the empty string.<li><p>Return this <code id=the-location-interface:location-55><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-11>url</a>'s <a href=https://url.spec.whatwg.org/#concept-url-port id=the-location-interface:concept-url-port-4 data-x-internal=concept-url-port>port</a>, <a href=https://url.spec.whatwg.org/#serialize-an-integer id=the-location-interface:serialize-an-integer-2 data-x-internal=serialize-an-integer>serialized</a>.</ol>

  <p>The <code id=the-location-interface:dom-location-port-2><a href=#dom-location-port>port</a></code> attribute's setter must run these steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-56><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-17>relevant <code>Document</code></a> is
   null, then return.<li><p>If this <code id=the-location-interface:location-57><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-18>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-11 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-10 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-11 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-10>origin</a>, then throw a
   <a id=the-location-interface:securityerror-10 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-11><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>copyURL</var> be a copy of this <code id=the-location-interface:location-58><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-12>url</a>.<li><p>If <var>copyURL</var> <a id=the-location-interface:cannot-have-a-username/password/port href=https://url.spec.whatwg.org/#cannot-have-a-username-password-port data-x-internal=cannot-have-a-username/password/port>cannot have a username/password/port</a>, then
   return.<li><p>If the given value is the empty string, then set <var>copyURL</var>'s <a href=https://url.spec.whatwg.org/#concept-url-port id=the-location-interface:concept-url-port-5 data-x-internal=concept-url-port>port</a> to null.<li><p>Otherwise, <a href=https://url.spec.whatwg.org/#concept-basic-url-parser id=the-location-interface:basic-url-parser-4 data-x-internal=basic-url-parser>basic URL parse</a> the given value, with
   <var>copyURL</var> as <var>url</var> and <a id=the-location-interface:port-state href=https://url.spec.whatwg.org/#port-state data-x-internal=port-state>port state</a> as <var>state
   override</var>.<li><p><a href=#location-object-setter-navigate id=the-location-interface:location-object-setter-navigate-5><code>Location</code>-object-setter navigate</a> to <var>copyURL</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/pathname title="The pathname property of the Location interface is a USVString containing an initial '/' followed by the path of the URL (or the empty string if there is no path).">Location/pathname</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>22+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-location-pathname><code>pathname</code></dfn> attribute's getter must
  run these steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-59><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-19>relevant <code>Document</code></a> is
   non-null and its <a id=the-location-interface:concept-origin-12 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-11 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-12 href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-11>origin</a>, then throw
   a <a id=the-location-interface:securityerror-11 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-12><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>url</var> be this <code id=the-location-interface:location-60><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-13>url</a>.<li><p>If <var>url</var>'s <a id=the-location-interface:cannot-be-a-base-url-flag-3 href=https://url.spec.whatwg.org/#url-cannot-be-a-base-url-flag data-x-internal=cannot-be-a-base-url-flag>cannot-be-a-base-URL flag</a> is set, return the first string
   in <var>url</var>'s <a href=https://url.spec.whatwg.org/#concept-url-path id=the-location-interface:concept-url-path data-x-internal=concept-url-path>path</a>.<li><p>If <var>url</var>'s <a href=https://url.spec.whatwg.org/#concept-url-path id=the-location-interface:concept-url-path-2 data-x-internal=concept-url-path>path</a> is empty, then return the
   empty string.<li><p>Return "<code>/</code>", followed by the strings in <var>url</var>'s <a href=https://url.spec.whatwg.org/#concept-url-path id=the-location-interface:concept-url-path-3 data-x-internal=concept-url-path>path</a> (including empty strings), separated from each other by
   "<code>/</code>".</ol>

  <p>The <code id=the-location-interface:dom-location-pathname-2><a href=#dom-location-pathname>pathname</a></code> attribute's setter must run these
  steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-61><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-20>relevant <code>Document</code></a> is
   null, then return.<li><p>If this <code id=the-location-interface:location-62><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-21>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-13 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-12 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-13 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-12>origin</a>, then throw a
   <a id=the-location-interface:securityerror-12 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-13><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>copyURL</var> be a copy of this <code id=the-location-interface:location-63><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-14>url</a>.<li><p>If <var>copyURL</var>'s <a id=the-location-interface:cannot-be-a-base-url-flag-4 href=https://url.spec.whatwg.org/#url-cannot-be-a-base-url-flag data-x-internal=cannot-be-a-base-url-flag>cannot-be-a-base-URL flag</a> is set, terminate these
   steps.<li><p>Set <var>copyURL</var>'s <a href=https://url.spec.whatwg.org/#concept-url-path id=the-location-interface:concept-url-path-4 data-x-internal=concept-url-path>path</a> to the empty
   list.<li><p><a href=https://url.spec.whatwg.org/#concept-basic-url-parser id=the-location-interface:basic-url-parser-5 data-x-internal=basic-url-parser>Basic URL parse</a> the given value, with
   <var>copyURL</var> as <var>url</var> and <a id=the-location-interface:path-start-state href=https://url.spec.whatwg.org/#path-start-state data-x-internal=path-start-state>path start state</a> as <var>state
   override</var>.<li><p><a href=#location-object-setter-navigate id=the-location-interface:location-object-setter-navigate-6><code>Location</code>-object-setter navigate</a> to <var>copyURL</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/search title="The search property of the Location interface is a search string, also called a query string; that is, a USVString containing a '?' followed by the parameters of the URL.">Location/search</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>22+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-location-search><code>search</code></dfn> attribute's getter must run
  these steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-64><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-22>relevant <code>Document</code></a> is
   non-null and its <a id=the-location-interface:concept-origin-14 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-13 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-14 href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-13>origin</a>, then throw
   a <a id=the-location-interface:securityerror-13 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-14><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If this <code id=the-location-interface:location-65><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-15>url</a>'s
   <a href=https://url.spec.whatwg.org/#concept-url-query id=the-location-interface:concept-url-query data-x-internal=concept-url-query>query</a> is either null or the empty string, return the
   empty string.<li><p>Return "<code>?</code>", followed by this <code id=the-location-interface:location-66><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-16>url</a>'s <a href=https://url.spec.whatwg.org/#concept-url-query id=the-location-interface:concept-url-query-2 data-x-internal=concept-url-query>query</a>.</ol>

  <p>The <code id=the-location-interface:dom-location-search-2><a href=#dom-location-search>search</a></code> attribute's setter must run these
  steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-67><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-23>relevant <code>Document</code></a> is
   null, then return.<li><p>If this <code id=the-location-interface:location-68><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-24>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-15 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-14 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-15 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-14>origin</a>, then throw a
   <a id=the-location-interface:securityerror-14 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-15><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>copyURL</var> be a copy of this <code id=the-location-interface:location-69><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-17>url</a>.<li><p>If the given value is the empty string, set <var>copyURL</var>'s <a href=https://url.spec.whatwg.org/#concept-url-query id=the-location-interface:concept-url-query-3 data-x-internal=concept-url-query>query</a> to null.

   <li>
    <p>Otherwise, run these substeps:</p>

    <ol><li><p>Let <var>input</var> be the given value with a single leading "<code>?</code>"
     removed, if any.<li><p>Set <var>copyURL</var>'s <a href=https://url.spec.whatwg.org/#concept-url-query id=the-location-interface:concept-url-query-4 data-x-internal=concept-url-query>query</a> to the empty
     string.<li><p><a href=https://url.spec.whatwg.org/#concept-basic-url-parser id=the-location-interface:basic-url-parser-6 data-x-internal=basic-url-parser>Basic URL parse</a> <var>input</var>, with
     <var>copyURL</var> as <var>url</var> and <a id=the-location-interface:query-state href=https://url.spec.whatwg.org/#query-state data-x-internal=query-state>query state</a> as <var>state override</var>,
     and the <a href=#relevant-document id=the-location-interface:relevant-document-25>relevant <code>Document</code></a>'s <a id="the-location-interface:document's-character-encoding" href=https://dom.spec.whatwg.org/#concept-document-encoding data-x-internal="document's-character-encoding">document's character
     encoding</a> as <var>encoding override</var>.</ol>
   <li><p><a href=#location-object-setter-navigate id=the-location-interface:location-object-setter-navigate-7><code>Location</code>-object-setter navigate</a> to <var>copyURL</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/hash title="The hash property of the Location interface returns a USVString containing a '#' followed by the fragment identifier of the URL.">Location/hash</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>22+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-location-hash><code>hash</code></dfn> attribute's getter must run these
  steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-70><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-26>relevant <code>Document</code></a> is
   non-null and its <a id=the-location-interface:concept-origin-16 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-15 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-16 href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-15>origin</a>, then throw
   a <a id=the-location-interface:securityerror-15 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-16><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If this <code id=the-location-interface:location-71><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-18>url</a>'s
   <a href=https://url.spec.whatwg.org/#concept-url-fragment id=the-location-interface:concept-url-fragment data-x-internal=concept-url-fragment>fragment</a> is either null or the empty string, return
   the empty string.<li><p>Return "<code>#</code>", followed by this <code id=the-location-interface:location-72><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-19>url</a>'s <a href=https://url.spec.whatwg.org/#concept-url-fragment id=the-location-interface:concept-url-fragment-2 data-x-internal=concept-url-fragment>fragment</a>.</ol>

  <p>The <code id=the-location-interface:dom-location-hash-2><a href=#dom-location-hash>hash</a></code> attribute's setter must run these steps:</p>

  <ol><li><p>If this <code id=the-location-interface:location-73><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-27>relevant <code>Document</code></a> is
   null, then return.<li><p>If this <code id=the-location-interface:location-74><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-28>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-17 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-16 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-17 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-16>origin</a>, then throw a
   <a id=the-location-interface:securityerror-16 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-17><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>copyURL</var> be a copy of this <code id=the-location-interface:location-75><a href=#location>Location</a></code> object's <a href=#concept-location-url id=the-location-interface:concept-location-url-20>url</a>.<li><p>Let <var>input</var> be the given value with a single leading "<code>#</code>"
   removed, if any.<li><p>Set <var>copyURL</var>'s <a href=https://url.spec.whatwg.org/#concept-url-fragment id=the-location-interface:concept-url-fragment-3 data-x-internal=concept-url-fragment>fragment</a> to the empty
   string.<li><p><a href=https://url.spec.whatwg.org/#concept-basic-url-parser id=the-location-interface:basic-url-parser-7 data-x-internal=basic-url-parser>Basic URL parse</a> <var>input</var>, with
   <var>copyURL</var> as <var>url</var> and <a id=the-location-interface:fragment-state href=https://url.spec.whatwg.org/#fragment-state data-x-internal=fragment-state>fragment state</a> as <var>state
   override</var>.<li><p><a href=#location-object-setter-navigate id=the-location-interface:location-object-setter-navigate-8><code>Location</code>-object-setter navigate</a> to <var>copyURL</var>.</ol>

  <p class=note>Unlike the equivalent API for the <code id=the-location-interface:the-a-element><a href=text-level-semantics.html#the-a-element>a</a></code> and <code id=the-location-interface:the-area-element><a href=image-maps.html#the-area-element>area</a></code> elements,
  the <code id=the-location-interface:dom-location-hash-3><a href=#dom-location-hash>hash</a></code> attribute's setter does not special case the
  empty string to remain compatible with deployed scripts.</p>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/assign title="The Location.assign() method causes the window to load and display the document at the URL specified.">Location/assign</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>5.5+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>When the <dfn id=dom-location-assign><code>assign(<var>url</var>)</code></dfn>
  method is invoked, the user agent must run the following steps:

  <ol><li><p>If this <code id=the-location-interface:location-76><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-29>relevant <code>Document</code></a> is
   null, then return.<li><p>If this <code id=the-location-interface:location-77><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-30>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-18 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-17 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-18 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-17>origin</a>, then throw a
   <a id=the-location-interface:securityerror-17 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-18><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p><a href=urls-and-fetching.html#parse-a-url id=the-location-interface:parse-a-url-2>Parse</a> <var>url</var> relative to the <a id=the-location-interface:entry-settings-object-19 href=webappapis.html#entry-settings-object>entry
   settings object</a>. If that failed, throw a <a id=the-location-interface:syntaxerror-2 href=https://heycam.github.io/webidl/#syntaxerror data-x-internal=syntaxerror>"<code>SyntaxError</code>"</a>
   <code id=the-location-interface:domexception-19><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p><a href=#location-object-navigate id=the-location-interface:location-object-navigate-2><code>Location</code>-object navigate</a> to the <a id=the-location-interface:resulting-url-record-2 href=urls-and-fetching.html#resulting-url-record>resulting URL
   record</a>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/replace title="The Location.replace() method replaces the current resource with the one at the provided URL. The difference from the assign() method is that after using replace() the current page will not be saved in session History, meaning the user won't be able to use the back button to navigate to it.">Location/replace</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>5.5+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>When the <dfn id=dom-location-replace><code>replace(<var>url</var>)</code></dfn>
  method is invoked, the user agent must run the following steps:

  <ol><li><p>If this <code id=the-location-interface:location-78><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-31>relevant <code>Document</code></a> is
   null, then return.<li><p><a href=urls-and-fetching.html#parse-a-url id=the-location-interface:parse-a-url-3>Parse</a> <var>url</var> relative to the <a id=the-location-interface:entry-settings-object-20 href=webappapis.html#entry-settings-object>entry
   settings object</a>. If that failed, throw a <a id=the-location-interface:syntaxerror-3 href=https://heycam.github.io/webidl/#syntaxerror data-x-internal=syntaxerror>"<code>SyntaxError</code>"</a>
   <code id=the-location-interface:domexception-20><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p><a href=#location-object-navigate id=the-location-interface:location-object-navigate-3><code>Location</code>-object navigate</a> to the <a id=the-location-interface:resulting-url-record-3 href=urls-and-fetching.html#resulting-url-record>resulting URL
   record</a> with the <var>replacement flag</var> set.</ol>

  <p class=note>The <code id=the-location-interface:dom-location-replace-2><a href=#dom-location-replace>replace()</a></code> method intentionally has
  no security check.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Location/reload title="The Location.reload() method reloads the current URL, like the Refresh button.">Location/reload</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>5.5+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>When the <dfn id=dom-location-reload><code>reload()</code></dfn> method is invoked, the
  user agent must run the appropriate steps from the following list:</p>

  <dl class=switch><dt>If this <code id=the-location-interface:location-79><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-32>relevant <code>Document</code></a> is
   null<dd><p>Return.<dt>If this <code id=the-location-interface:location-80><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-33>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-19 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-18 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-21 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-18>origin</a><dd><p>Throw a <a id=the-location-interface:securityerror-18 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-21><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<dt>If the currently executing <a href=webappapis.html#concept-task id=the-location-interface:concept-task-3>task</a> is the dispatch of a <code id=the-location-interface:event-resize><a data-x-internal=event-resize href=https://drafts.csswg.org/cssom-view/#eventdef-window-resize>resize</a></code> event in response to the user resizing the <a id=the-location-interface:browsing-context-6 href=browsers.html#browsing-context>browsing
   context</a><dd><p>Repaint the <a id=the-location-interface:browsing-context-7 href=browsers.html#browsing-context>browsing context</a> and return.<dt>If the <a id=the-location-interface:browsing-context-8 href=browsers.html#browsing-context>browsing context</a>'s <a id=the-location-interface:active-document-4 href=browsers.html#active-document>active document</a> is <a id=the-location-interface:an-iframe-srcdoc-document href=iframe-embed-object.html#an-iframe-srcdoc-document>an
   <code>iframe</code> <code>srcdoc</code> document</a><dd><p><a href=iframe-embed-object.html#process-the-iframe-attributes id=the-location-interface:process-the-iframe-attributes>Reprocess the <code>iframe</code>
   attributes</a> of the <a id=the-location-interface:browsing-context-9 href=browsers.html#browsing-context>browsing context</a>'s <a href=browsers.html#bc-container id=the-location-interface:bc-container>container</a>.<dt>Otherwise<dd><p><a id=the-location-interface:navigate-2 href=browsing-the-web.html#navigate>Navigate</a> the <a id=the-location-interface:browsing-context-10 href=browsers.html#browsing-context>browsing context</a> to
   this <code id=the-location-interface:location-81><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-34>relevant <code>Document</code></a>'s <a href=https://dom.spec.whatwg.org/#concept-document-url id="the-location-interface:the-document's-address-4" data-x-internal="the-document's-address">URL</a> to perform an <a id=the-location-interface:entry-update href=browsing-the-web.html#entry-update>entry update</a> of the
   <a id=the-location-interface:browsing-context-11 href=browsers.html#browsing-context>browsing context</a>'s <a href=#current-entry id=the-location-interface:current-entry-2>current entry</a>, with the <var><a id=the-location-interface:exceptions-enabled-2 href=browsing-the-web.html#exceptions-enabled>exceptions
   enabled flag</a></var> set. The <a id=the-location-interface:source-browsing-context-2 href=browsing-the-web.html#source-browsing-context>source browsing context</a> must be the
   <a id=the-location-interface:browsing-context-12 href=browsers.html#browsing-context>browsing context</a> being navigated. This is a <a id=the-location-interface:reload-triggered-navigation href=browsing-the-web.html#reload-triggered-navigation>reload-triggered
   navigation</a>. Rethrow any exceptions.</dl>

  <p>When a user requests that the <a id=the-location-interface:active-document-5 href=browsers.html#active-document>active document</a> of a <a id=the-location-interface:browsing-context-13 href=browsers.html#browsing-context>browsing context</a>
  be reloaded through a user interface element, the user agent should <a id=the-location-interface:navigate-3 href=browsing-the-web.html#navigate>navigate</a> the <a id=the-location-interface:browsing-context-14 href=browsers.html#browsing-context>browsing context</a> to the same resource as that
  <code id=the-location-interface:document-8><a href=dom.html#document>Document</a></code>, to perform an <a id=the-location-interface:entry-update-2 href=browsing-the-web.html#entry-update>entry update</a> of the <a id=the-location-interface:browsing-context-15 href=browsers.html#browsing-context>browsing
  context</a>'s <a href=#current-entry id=the-location-interface:current-entry-3>current entry</a>. This is a <a id=the-location-interface:reload-triggered-navigation-2 href=browsing-the-web.html#reload-triggered-navigation>reload-triggered navigation</a>.
  In the case of non-idempotent methods (e.g. HTTP POST), the user agent should prompt the user to
  confirm the operation first, since otherwise transactions (e.g. purchases or database
  modifications) could be repeated. User agents may allow the user to explicitly override any caches
  when reloading.</p>

  <hr>

  <p>The <dfn id=dom-location-ancestororigins><code>ancestorOrigins</code></dfn> attribute's
  getter must run these steps:

  <ol><li><p>If this <code id=the-location-interface:location-82><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-35>relevant <code>Document</code></a> is
   null, then return an empty <a id=the-location-interface:list-3 href=https://infra.spec.whatwg.org/#list data-x-internal=list>list</a>.<li><p>If this <code id=the-location-interface:location-83><a href=#location>Location</a></code> object's <a href=#relevant-document id=the-location-interface:relevant-document-36>relevant <code>Document</code></a>'s
   <a id=the-location-interface:concept-origin-20 href=origin.html#concept-origin>origin</a> is not <a id=the-location-interface:same-origin-domain-19 href=origin.html#same-origin-domain>same origin-domain</a> with the <a id=the-location-interface:entry-settings-object-22 href=webappapis.html#entry-settings-object>entry settings
   object</a>'s <a href=webappapis.html#concept-settings-object-origin id=the-location-interface:concept-settings-object-origin-19>origin</a>, then throw a
   <a id=the-location-interface:securityerror-19 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-location-interface:domexception-22><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Otherwise, return this <code id=the-location-interface:location-84><a href=#location>Location</a></code> object's <a href=#concept-location-ancestor-origins-list id=the-location-interface:concept-location-ancestor-origins-list-2>ancestor origins list</a>.</ol>

  <p class=warning>The details of how the <code id=the-location-interface:dom-location-ancestororigins-2><a href=#dom-location-ancestororigins>ancestorOrigins</a></code> attribute works are still
  controversial and might change. See <a href=https://github.com/whatwg/html/issues/1918>issue
  #1918</a> for more information.</p>

  <hr>

  <p id=location-internal-methods>As explained earlier, the <code id=the-location-interface:location-85><a href=#location>Location</a></code> exotic object
  requires additional logic beyond IDL for security purposes. The <code id=the-location-interface:location-86><a href=#location>Location</a></code> object must
  use the ordinary internal methods except where it is explicitly specified otherwise below.</p>

  <p>Also, every <code id=the-location-interface:location-87><a href=#location>Location</a></code> object has a <dfn id=defaultproperties>[[DefaultProperties]]</dfn> internal slot
  representing its own properties at time of its creation.</p>

  <h5 id=location-getprototypeof><span class=secno>7.7.4.1</span> [[GetPrototypeOf]] ( )<a href=#location-getprototypeof class=self-link></a></h5>

  <ol><li><p>If ! <a id=location-getprototypeof:isplatformobjectsameorigin-(-o-) href=browsers.html#isplatformobjectsameorigin-(-o-)>IsPlatformObjectSameOrigin</a>(<b>this</b>) is true, then return !
   <a id=location-getprototypeof:ordinarygetprototypeof href=https://tc39.es/ecma262/#sec-ordinarygetprototypeof data-x-internal=ordinarygetprototypeof>OrdinaryGetPrototypeOf</a>(<b>this</b>).<li><p>Return null.</ol>

  <h5 id=location-setprototypeof><span class=secno>7.7.4.2</span> [[SetPrototypeOf]] ( <var>V</var> )<a href=#location-setprototypeof class=self-link></a></h5>

  <ol><li><p>Return ! <a id=location-setprototypeof:setimmutableprototype href=https://tc39.es/ecma262/#sec-set-immutable-prototype data-x-internal=setimmutableprototype>SetImmutablePrototype</a>(<b>this</b>, <var>V</var>).</ol>

  <h5 id=location-isextensible><span class=secno>7.7.4.3</span> [[IsExtensible]] ( )<a href=#location-isextensible class=self-link></a></h5>

  <ol><li><p>Return true.</ol>

  <h5 id=location-preventextensions><span class=secno>7.7.4.4</span> [[PreventExtensions]] ( )<a href=#location-preventextensions class=self-link></a></h5>

  <ol><li><p>Return false.</ol>

  <h5 id=location-getownproperty><span class=secno>7.7.4.5</span> [[GetOwnProperty]] ( <var>P</var> )<a href=#location-getownproperty class=self-link></a></h5>

  <ol><li>
    <p>If ! <a id=location-getownproperty:isplatformobjectsameorigin-(-o-) href=browsers.html#isplatformobjectsameorigin-(-o-)>IsPlatformObjectSameOrigin</a>(<b>this</b>) is true, then:</p>

    <ol><li><p>Let <var>desc</var> be ! <a id=location-getownproperty:ordinarygetownproperty href=https://tc39.es/ecma262/#sec-ordinarygetownproperty data-x-internal=ordinarygetownproperty>OrdinaryGetOwnProperty</a>(<b>this</b>,
     <var>P</var>).<li><p>If the value of the <a href=#defaultproperties id=location-getownproperty:defaultproperties>[[DefaultProperties]]</a> internal slot of <b>this</b>
     contains <var>P</var>, then set <var>desc</var>.[[Configurable]] to true.<li><p>Return <var>desc</var>.</ol>
   <li><p>Let <var>property</var> be ! <a id=location-getownproperty:crossorigingetownpropertyhelper-(-o,-p-) href=browsers.html#crossorigingetownpropertyhelper-(-o,-p-)>CrossOriginGetOwnPropertyHelper</a>(<b>this</b>,
   <var>P</var>).<li><p>If <var>property</var> is not undefined, then return <var>property</var>.<li><p>Return ? <a id=location-getownproperty:crossoriginpropertyfallback-(-p-) href=browsers.html#crossoriginpropertyfallback-(-p-)>CrossOriginPropertyFallback</a>(<var>P</var>).</ol>

  <h5 id=location-defineownproperty><span class=secno>7.7.4.6</span> [[DefineOwnProperty]] ( <var>P</var>, <var>Desc</var> )<a href=#location-defineownproperty class=self-link></a></h5>

  <ol><li>
    <p>If ! <a id=location-defineownproperty:isplatformobjectsameorigin-(-o-) href=browsers.html#isplatformobjectsameorigin-(-o-)>IsPlatformObjectSameOrigin</a>(<b>this</b>) is true, then:</p>

    <ol><li><p>If the value of the <a href=#defaultproperties id=location-defineownproperty:defaultproperties>[[DefaultProperties]]</a> internal slot of <b>this</b>
     contains <var>P</var>, then return false.<li><p>Return ? <a id=location-defineownproperty:ordinarydefineownproperty href=https://tc39.es/ecma262/#sec-ordinarydefineownproperty data-x-internal=ordinarydefineownproperty>OrdinaryDefineOwnProperty</a>(<b>this</b>, <var>P</var>,
     <var>Desc</var>).</ol>
   <li><p>Throw a <a id=location-defineownproperty:securityerror href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=location-defineownproperty:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</ol>

  <h5 id=location-get><span class=secno>7.7.4.7</span> [[Get]] ( <var>P</var>, <var>Receiver</var> )<a href=#location-get class=self-link></a></h5>

  <ol><li><p>If ! <a id=location-get:isplatformobjectsameorigin-(-o-) href=browsers.html#isplatformobjectsameorigin-(-o-)>IsPlatformObjectSameOrigin</a>(<b>this</b>) is true, then return ?
   <a id=location-get:ordinaryget href=https://tc39.es/ecma262/#sec-ordinaryget data-x-internal=ordinaryget>OrdinaryGet</a>(<b>this</b>, <var>P</var>, <var>Receiver</var>).<li><p>Return ? <a id=location-get:crossoriginget-(-o,-p,-receiver-) href=browsers.html#crossoriginget-(-o,-p,-receiver-)>CrossOriginGet</a>(<b>this</b>, <var>P</var>,
   <var>Receiver</var>).</ol>

  <h5 id=location-set><span class=secno>7.7.4.8</span> [[Set]] ( <var>P</var>, <var>V</var>, <var>Receiver</var> )<a href=#location-set class=self-link></a></h5>

  <ol><li><p>If ! <a id=location-set:isplatformobjectsameorigin-(-o-) href=browsers.html#isplatformobjectsameorigin-(-o-)>IsPlatformObjectSameOrigin</a>(<b>this</b>) is true, then return ?
   <a id=location-set:ordinaryset href=https://tc39.es/ecma262/#sec-ordinaryset data-x-internal=ordinaryset>OrdinarySet</a>(<b>this</b>, <var>P</var>, <var>Receiver</var>).<li><p>Return ? <a id=location-set:crossoriginset-(-o,-p,-v,-receiver-) href=browsers.html#crossoriginset-(-o,-p,-v,-receiver-)>CrossOriginSet</a>(<b>this</b>, <var>P</var>, <var>V</var>,
   <var>Receiver</var>).</ol>

  <h5 id=location-delete><span class=secno>7.7.4.9</span> [[Delete]] ( <var>P</var> )<a href=#location-delete class=self-link></a></h5>

  <ol><li><p>If ! <a id=location-delete:isplatformobjectsameorigin-(-o-) href=browsers.html#isplatformobjectsameorigin-(-o-)>IsPlatformObjectSameOrigin</a>(<b>this</b>) is true, then return ?
   <a id=location-delete:ordinarydelete href=https://tc39.es/ecma262/#sec-ordinarydelete data-x-internal=ordinarydelete>OrdinaryDelete</a>(<b>this</b>, <var>P</var>).<li><p>Throw a <a id=location-delete:securityerror href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=location-delete:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</ol>

  <h5 id=location-ownpropertykeys><span class=secno>7.7.4.10</span> [[OwnPropertyKeys]] ( )<a href=#location-ownpropertykeys class=self-link></a></h5>

  <ol><li><p>If ! <a id=location-ownpropertykeys:isplatformobjectsameorigin-(-o-) href=browsers.html#isplatformobjectsameorigin-(-o-)>IsPlatformObjectSameOrigin</a>(<b>this</b>) is true, then return !
   <a id=location-ownpropertykeys:ordinaryownpropertykeys href=https://tc39.es/ecma262/#sec-ordinaryownpropertykeys data-x-internal=ordinaryownpropertykeys>OrdinaryOwnPropertyKeys</a>(<b>this</b>).<li><p>Return ! <a id=location-ownpropertykeys:crossoriginownpropertykeys-(-o-) href=browsers.html#crossoriginownpropertykeys-(-o-)>CrossOriginOwnPropertyKeys</a>(<b>this</b>).</ol>

  


  <nav><a href=origin.html>← 7.5 Origin</a> — <a href=./>Table of Contents</a> — <a href=browsing-the-web.html>7.8 Browsing the Web →</a></nav>