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

  

  

  

  
  

  
  

  

  <nav><a href=web-sockets.html>← 9.3 Web sockets</a> — <a href=./>Table of Contents</a> — <a href=workers.html>10 Web workers →</a></nav><ol class=toc><li id=toc-comms><ol><li><a href=web-messaging.html#web-messaging><span class=secno>9.4</span> Cross-document messaging</a><ol><li><a href=web-messaging.html#introduction-12><span class=secno>9.4.1</span> Introduction</a><li><a href=web-messaging.html#security-postmsg><span class=secno>9.4.2</span> Security</a><ol><li><a href=web-messaging.html#authors><span class=secno>9.4.2.1</span> Authors</a><li><a href=web-messaging.html#user-agents><span class=secno>9.4.2.2</span> User agents</a></ol><li><a href=web-messaging.html#posting-messages><span class=secno>9.4.3</span> Posting messages</a></ol><li><a href=web-messaging.html#channel-messaging><span class=secno>9.5</span> Channel messaging</a><ol><li><a href=web-messaging.html#introduction-13><span class=secno>9.5.1</span> Introduction</a><ol><li><a href=web-messaging.html#examples-5><span class=secno>9.5.1.1</span> Examples</a><li><a href=web-messaging.html#ports-as-the-basis-of-an-object-capability-model-on-the-web><span class=secno>9.5.1.2</span> Ports as the basis of an object-capability model on the Web</a><li><a href=web-messaging.html#ports-as-the-basis-of-abstracting-out-service-implementations><span class=secno>9.5.1.3</span> Ports as the basis of abstracting out service implementations</a></ol><li><a href=web-messaging.html#message-channels><span class=secno>9.5.2</span> Message channels</a><li><a href=web-messaging.html#message-ports><span class=secno>9.5.3</span> Message ports</a><li><a href=web-messaging.html#broadcasting-to-many-ports><span class=secno>9.5.4</span> Broadcasting to many ports</a><li><a href=web-messaging.html#ports-and-garbage-collection><span class=secno>9.5.5</span> Ports and garbage collection</a></ol><li><a href=web-messaging.html#broadcasting-to-other-browsing-contexts><span class=secno>9.6</span> Broadcasting to other browsing contexts</a></ol></ol><h3 id=web-messaging><span class=secno>9.4</span> <dfn id=crossDocumentMessages>Cross-document messaging</dfn><a href=#web-messaging class=self-link></a></h3><div class=status><input onclick=toggleStatus(this) value=⋰ type=button><p class=support><strong>Support:</strong> x-doc-messaging<span class="and_chr yes"><span>Chrome for Android</span> <span>80+</span></span><span class="chrome yes"><span>Chrome</span> <span>4+</span></span><span class="ios_saf yes"><span>iOS Safari</span> <span>3.2+</span></span><span class="firefox yes"><span>Firefox</span> <span>3+</span></span><span class="safari yes"><span>Safari</span> <span>4+</span></span><span class="samsung yes"><span>Samsung Internet</span> <span>4+</span></span><span class="and_uc yes"><span>UC Browser for Android</span> <span>12.12+</span></span><span class="edge yes"><span>Edge</span> <span>12+</span></span><span class="ie partial"><span>IE (limited)</span> <span>8+</span></span><span class="opera yes"><span>Opera</span> <span>9.5+</span></span><span class="op_mini yes"><span>Opera Mini</span> <span>all+</span></span><span class="android yes"><span>Android Browser</span> <span>2.1+</span></span><p class=caniuse>Source: <a href="https://caniuse.com/#feat=x-doc-messaging">caniuse.com</a></div>

  <p>Web browsers, for security and privacy reasons, prevent documents in different domains from
  affecting each other; that is, cross-site scripting is disallowed.</p>

  <p>While this is an important security feature, it prevents pages from different domains from
  communicating even when those pages are not hostile. This section introduces a messaging system
  that allows documents to communicate with each other regardless of their source domain, in a way
  designed to not enable cross-site scripting attacks.</p>

  <p id=fingerprint-postMessage class=note>
  
  The <code id=web-messaging:dom-window-postmessage><a href=#dom-window-postmessage>postMessage()</a></code> API can be used as a <a id=web-messaging:tracking-vector href=https://infra.spec.whatwg.org/#tracking-vector data-x-internal=tracking-vector>tracking
  vector</a>.</p>


  <h4 id=introduction-12><span class=secno>9.4.1</span> Introduction<a href=#introduction-12 class=self-link></a></h4>

  <p><i>This section is non-normative.</i></p>

  <div class=example>

   <p>For example, if document A contains an <code id=introduction-12:the-iframe-element><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code> element that contains document B,
   and script in document A calls <code id=introduction-12:dom-window-postmessage><a href=#dom-window-postmessage>postMessage()</a></code> on the
   <code id=introduction-12:window><a href=window-object.html#window>Window</a></code> object of document B, then a message event will be fired on that object,
   marked as originating from the <code id=introduction-12:window-2><a href=window-object.html#window>Window</a></code> of document A. The script in document A might
   look like:</p>

   <pre><code class='js'><c- a>var</c-> o <c- o>=</c-> document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;iframe&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>];</c->
o<c- p>.</c->contentWindow<c- p>.</c->postMessage<c- p>(</c-><c- t>&apos;Hello world&apos;</c-><c- p>,</c-> <c- t>&apos;https://b.example.org/&apos;</c-><c- p>);</c-></code></pre>

   <p>To register an event handler for incoming events, the script would use <code>addEventListener()</code> (or similar mechanisms). For example, the script in document B
   might look like:</p>

   <pre><code class='js'>window<c- p>.</c->addEventListener<c- p>(</c-><c- t>&apos;message&apos;</c-><c- p>,</c-> receiver<c- p>,</c-> <c- kc>false</c-><c- p>);</c->
<c- a>function</c-> receiver<c- p>(</c->e<c- p>)</c-> <c- p>{</c->
  <c- k>if</c-> <c- p>(</c->e<c- p>.</c->origin <c- o>==</c-> <c- t>&apos;https://example.com&apos;</c-><c- p>)</c-> <c- p>{</c->
    <c- k>if</c-> <c- p>(</c->e<c- p>.</c->data <c- o>==</c-> <c- t>&apos;Hello world&apos;</c-><c- p>)</c-> <c- p>{</c->
      e<c- p>.</c->source<c- p>.</c->postMessage<c- p>(</c-><c- t>&apos;Hello&apos;</c-><c- p>,</c-> e<c- p>.</c->origin<c- p>);</c->
    <c- p>}</c-> <c- k>else</c-> <c- p>{</c->
      alert<c- p>(</c->e<c- p>.</c->data<c- p>);</c->
    <c- p>}</c->
  <c- p>}</c->
<c- p>}</c-></code></pre>

   <p>This script first checks the domain is the expected domain, and then looks at the message,
   which it either displays to the user, or responds to by sending a message back to the document
   which sent the message in the first place.</p>

  </div>



  <h4 id=security-postmsg><span class=secno>9.4.2</span> Security<a href=#security-postmsg class=self-link></a></h4>

  

  <h5 id=authors><span class=secno>9.4.2.1</span> Authors<a href=#authors class=self-link></a></h5>

  

  <p id=security-4 class=warning>Use of this API requires extra care to protect users from
  hostile entities abusing a site for their own purposes.</p>

  <p>Authors should check the <code id=authors:dom-messageevent-origin><a href=comms.html#dom-messageevent-origin>origin</a></code> attribute to
  ensure that messages are only accepted from domains that they expect to receive messages from.
  Otherwise, bugs in the author's message handling code could be exploited by hostile sites.</p>

  <p>Furthermore, even after checking the <code id=authors:dom-messageevent-origin-2><a href=comms.html#dom-messageevent-origin>origin</a></code>
  attribute, authors should also check that the data in question is of the expected format.
  Otherwise, if the source of the event has been attacked using a cross-site scripting flaw, further
  unchecked processing of information sent using the <code id=authors:dom-window-postmessage><a href=#dom-window-postmessage>postMessage()</a></code> method could result in the attack being
  propagated into the receiver.</p>

  <p>Authors should not use the wildcard keyword (*) in the <var>targetOrigin</var>
  argument in messages that contain any confidential information, as otherwise there is no way to
  guarantee that the message is only delivered to the recipient to which it was intended.</p>

  <hr>

  <p>Authors who accept messages from any origin are encouraged to consider the risks of a
  denial-of-service attack. An attacker could send a high volume of messages; if the receiving page
  performs expensive computation or causes network traffic to be sent for each such message, the
  attacker's message could be multiplied into a denial-of-service attack. Authors are encouraged to
  employ rate limiting (only accepting a certain number of messages per minute) to make such attacks
  impractical.</p>


  

  <h5 id=user-agents><span class=secno>9.4.2.2</span> User agents<a href=#user-agents class=self-link></a></h5>

  <p>The integrity of this API is based on the inability for scripts of one <a id=user-agents:concept-origin href=origin.html#concept-origin>origin</a> to
  post arbitrary events (using <code>dispatchEvent()</code> or otherwise) to objects in
  other origins (those that are not the <a href=origin.html#same-origin id=user-agents:same-origin>same</a>).</p>

  <p class=note>Implementors are urged to take extra care in the implementation of this feature.
  It allows authors to transmit information from one domain to another domain, which is normally
  disallowed for security reasons. It also requires that UAs be careful to allow access to certain
  properties but not others.</p>

  <hr>

  <p>User agents are also encouraged to consider rate-limiting message traffic between different
  <a href=origin.html#concept-origin id=user-agents:concept-origin-2>origins</a>, to protect naïve sites from denial-of-service
  attacks.</p>

  




  <h4 id=posting-messages><span class=secno>9.4.3</span> Posting messages<a href=#posting-messages class=self-link></a></h4>

  <dl class=domintro><dt><var>window</var> . <code id=dom-window-postmessage-options-dev><a href=#dom-window-postmessage-options>postMessage</a></code>(<var>message</var> [, <var>options</var> ] )<dd>
    <p>Posts a message to the given window. Messages can be structured objects, e.g. nested objects
    and arrays, can contain JavaScript values (strings, numbers, <code id=posting-messages:date><a data-x-internal=date href=https://tc39.es/ecma262/#sec-date-objects>Date</a></code>
    objects, etc), and can contain certain data objects such as <code id=posting-messages:file><a data-x-internal=file href=https://w3c.github.io/FileAPI/#dfn-file>File</a></code> <code id=posting-messages:blob><a data-x-internal=blob href=https://w3c.github.io/FileAPI/#dfn-Blob>Blob</a></code>,
    <code id=posting-messages:filelist><a data-x-internal=filelist href=https://w3c.github.io/FileAPI/#filelist-section>FileList</a></code>, and <code id=posting-messages:idl-arraybuffer><a data-x-internal=idl-arraybuffer href=https://heycam.github.io/webidl/#idl-ArrayBuffer>ArrayBuffer</a></code> objects.</p>

    <p>Objects listed in the <code>transfer</code> member of <var>options</var> are
    transferred, not just cloned, meaning that they are no longer usable on the sending side.</p>

    <p>A target origin can be specified using the <code>targetOrigin</code> member of
    <var>options</var>. If not provided, it defaults to "<code>/</code>". This default
    restricts the message to same-origin targets only.</p>

    <p>If the origin of the target window doesn't match the given target origin, the message is
    discarded, to avoid information leakage. To send the message to the target regardless of origin,
    set the target origin to "<code>*</code>".</p>

    <p>Throws a <a id=posting-messages:datacloneerror href=https://heycam.github.io/webidl/#datacloneerror data-x-internal=datacloneerror>"<code>DataCloneError</code>"</a> <code id=posting-messages:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if
    <var>transfer</var> array contains duplicate objects or if <var>message</var> could not be
    cloned.</p>
   <dt><var>window</var> . <code id=posting-messages:dom-window-postmessage><a href=#dom-window-postmessage>postMessage</a></code>(<var>message</var>, <var>targetOrigin</var> [, <var>transfer</var> ] )<dd><p>This is an alternate version of <code id=posting-messages:dom-window-postmessage-options><a href=#dom-window-postmessage-options>postMessage()</a></code> where the target origin is specified
   as a parameter. Calling <code>window.postMessage(message, target, transfer)</code> is
   equivalent to <code>window.postMessage(message, {targetOrigin, transfer})</code>.</dl>

  <p class=note>When posting a message to a <code id=posting-messages:window><a href=window-object.html#window>Window</a></code> of a <a id=posting-messages:browsing-context href=browsers.html#browsing-context>browsing context</a>
  that has just been navigated to a new <code id=posting-messages:document><a href=dom.html#document>Document</a></code> is likely to result in the message not
  receiving its intended recipient: the scripts in the target <a id=posting-messages:browsing-context-2 href=browsers.html#browsing-context>browsing context</a> have to
  have had time to set up listeners for the messages. Thus, for instance, in situations where a
  message is to be sent to the <code id=posting-messages:window-2><a href=window-object.html#window>Window</a></code> of newly created child <code id=posting-messages:the-iframe-element><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code>,
  authors are advised to have the child <code id=posting-messages:document-2><a href=dom.html#document>Document</a></code> post a message to their parent
  announcing their readiness to receive messages, and for the parent to wait for this message before
  beginning posting messages.</p>

  

  <p>The <dfn id=window-post-message-steps>window post message steps</dfn>, given a <var>targetWindow</var>, <var>message</var>,
  and <var>options</var>, are as follows:</p>

  <ol><li><p>Let <var>targetRealm</var> be <var>targetWindow</var>'s <a href=webappapis.html#concept-global-object-realm id=posting-messages:concept-global-object-realm>Realm</a>.<li><p>Let <var>incumbentSettings</var> be the <a id=posting-messages:incumbent-settings-object href=webappapis.html#incumbent-settings-object>incumbent settings object</a>.<li><p>Let <var>targetOrigin</var> be <var>options</var>["<code>targetOrigin</code>"].<li><p>If <var>targetOrigin</var> is a single U+002F SOLIDUS character (/), then set
   <var>targetOrigin</var> to <var>incumbentSettings</var>'s <a href=webappapis.html#concept-settings-object-origin id=posting-messages:concept-settings-object-origin>origin</a>.</p>

   <li>
    <p>Otherwise, if <var>targetOrigin</var> is not a single U+002A ASTERISK character (*),
    then:</p>

    <ol><li><p>Let <var>parsedURL</var> be the result of running the <a id=posting-messages:url-parser href=https://url.spec.whatwg.org/#concept-url-parser data-x-internal=url-parser>URL parser</a> on
     <var>targetOrigin</var>.<li><p>If <var>parsedURL</var> is failure, then throw a <a id=posting-messages:syntaxerror href=https://heycam.github.io/webidl/#syntaxerror data-x-internal=syntaxerror>"<code>SyntaxError</code>"</a>
     <code id=posting-messages:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Set <var>targetOrigin</var> to <var>parsedURL</var>'s <a href=https://url.spec.whatwg.org/#concept-url-origin id=posting-messages:concept-url-origin data-x-internal=concept-url-origin>origin</a>.</ol>
   <li><p>Let <var>transfer</var> be <var>options</var>["<code>transfer</code>"].<li><p>Let <var>serializeWithTransferResult</var> be
   <a id=posting-messages:structuredserializewithtransfer href=structured-data.html#structuredserializewithtransfer>StructuredSerializeWithTransfer</a>(<var>message</var>, <var>transfer</var>). Rethrow
   any exceptions.<li>
    <p><a id=posting-messages:queue-a-task href=webappapis.html#queue-a-task>Queue a task</a> on the <dfn id=posted-message-task-source>posted message task source</dfn> of
    <var>targetWindow</var>'s <a id=posting-messages:relevant-agent href=webappapis.html#relevant-agent>relevant agent</a>'s <a href=webappapis.html#concept-agent-event-loop id=posting-messages:concept-agent-event-loop>event loop</a> to run the following steps:</p>

    <ol><li><p>If the <var>targetOrigin</var> argument is not a single literal U+002A ASTERISK character
     (*) and <var>targetWindow</var>'s <a href=window-object.html#concept-document-window id=posting-messages:concept-document-window>associated
     <code>Document</code></a>'s <a id=posting-messages:concept-origin href=origin.html#concept-origin>origin</a> is not <a id=posting-messages:same-origin href=origin.html#same-origin>same origin</a> with
     <var>targetOrigin</var>, then return.<li><p>Let <var>origin</var> be the <a href=origin.html#ascii-serialisation-of-an-origin id=posting-messages:ascii-serialisation-of-an-origin>serialization</a> of <var>incumbentSettings</var>'s <a href=webappapis.html#concept-settings-object-origin id=posting-messages:concept-settings-object-origin-2>origin</a>.<li><p>Let <var>source</var> be the <code id=posting-messages:windowproxy><a href=window-object.html#windowproxy>WindowProxy</a></code> object corresponding to
     <var>incumbentSettings</var>'s <a href=webappapis.html#concept-settings-object-global id=posting-messages:concept-settings-object-global>global
     object</a> (a <code id=posting-messages:window-3><a href=window-object.html#window>Window</a></code> object).<li>
      <p>Let <var>deserializeRecord</var> be
      <a id=posting-messages:structureddeserializewithtransfer href=structured-data.html#structureddeserializewithtransfer>StructuredDeserializeWithTransfer</a>(<var>serializeWithTransferResult</var>,
      <var>targetRealm</var>).</p>

      <p>If this throws an exception, catch it, <a href=https://dom.spec.whatwg.org/#concept-event-fire id=posting-messages:concept-event-fire data-x-internal=concept-event-fire>fire an
      event</a> named <code id=posting-messages:event-messageerror><a href=indices.html#event-messageerror>messageerror</a></code> at
      <var>targetWindow</var>, using <code id=posting-messages:messageevent><a href=comms.html#messageevent>MessageEvent</a></code>, with the <code id=posting-messages:dom-messageevent-origin><a href=comms.html#dom-messageevent-origin>origin</a></code> attribute initialized to <var>origin</var> and
      the <code id=posting-messages:dom-messageevent-source><a href=comms.html#dom-messageevent-source>source</a></code> attribute initialized to
      <var>source</var>, and then return.</p>
     <li><p>Let <var>messageClone</var> be <var>deserializeRecord</var>.[[Deserialized]].<li><p>Let <var>newPorts</var> be a new <a id=posting-messages:frozen-array href=https://heycam.github.io/webidl/#dfn-frozen-array-type data-x-internal=frozen-array>frozen array</a> consisting of all
     <code id=posting-messages:messageport><a href=#messageport>MessagePort</a></code> objects in <var>deserializeRecord</var>.[[TransferredValues]], if any,
     maintaining their relative order.<li><p><a href=https://dom.spec.whatwg.org/#concept-event-fire id=posting-messages:concept-event-fire-2 data-x-internal=concept-event-fire>Fire an event</a> named <code id=posting-messages:event-message><a href=indices.html#event-message>message</a></code> at <var>targetWindow</var>, using
     <code id=posting-messages:messageevent-2><a href=comms.html#messageevent>MessageEvent</a></code>, with the <code id=posting-messages:dom-messageevent-origin-2><a href=comms.html#dom-messageevent-origin>origin</a></code>
     attribute initialized to <var>origin</var>, the <code id=posting-messages:dom-messageevent-source-2><a href=comms.html#dom-messageevent-source>source</a></code> attribute initialized to <var>source</var>, the
     <code id=posting-messages:dom-messageevent-data><a href=comms.html#dom-messageevent-data>data</a></code> attribute initialized to
     <var>messageClone</var>, and the <code id=posting-messages:dom-messageevent-ports><a href=comms.html#dom-messageevent-ports>ports</a></code> attribute
     initialized to <var>newPorts</var>.</ol>
   </ol>

  <p>The <dfn id=dom-window-postmessage-options><code>postMessage(<var>message</var>,
  <var>options</var>)</code></dfn> method, when invoked on a
  <code id=posting-messages:window-4><a href=window-object.html#window>Window</a></code> object, must run the following steps:</p>
  <ol><li><p>Let <var>targetWindow</var> be this <code id=posting-messages:window-5><a href=window-object.html#window>Window</a></code> object.<li><p>Run the <a href=#window-post-message-steps id=posting-messages:window-post-message-steps>window post message steps</a> providing <var>targetWindow</var>,
   <var>message</var>, and <var>options</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Window/postMessage title="The window.postMessage() method safely enables cross-origin communication between Window objects; e.g., between a page and a pop-up that it spawned, or between a page and an iframe embedded within it.">Window/postMessage</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>8+</span></span><span class="safari yes"><span>Safari</span><span>4+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9.5+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>8+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>3.2+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>The <dfn id=dom-window-postmessage><code>postMessage(<var>message</var>,
  <var>targetOrigin</var>, <var>transfer</var>)</code></dfn> method, when invoked on a
  <code id=posting-messages:window-6><a href=window-object.html#window>Window</a></code> object, must run the following steps:</p>

  <ol><li><p>Let <var>targetWindow</var> be this <code id=posting-messages:window-7><a href=window-object.html#window>Window</a></code> object.<li><p>Let <var>options</var> be «[ "<code>targetOrigin</code>" →
   <var>targetOrigin</var>, "<code>transfer</code>" → <var>transfer</var> ]».<li><p>Run the <a href=#window-post-message-steps id=posting-messages:window-post-message-steps-2>window post message steps</a> providing <var>targetWindow</var>,
   <var>message</var>, and <var>options</var>.</ol>

  




  <h3 id=channel-messaging><span class=secno>9.5</span> <dfn>Channel messaging</dfn><a href=#channel-messaging class=self-link></a></h3><div class=status><input onclick=toggleStatus(this) value=⋰ type=button><p class=support><strong>Support:</strong> channel-messaging<span class="and_chr yes"><span>Chrome for Android</span> <span>80+</span></span><span class="chrome yes"><span>Chrome</span> <span>4+</span></span><span class="ios_saf yes"><span>iOS Safari</span> <span>5.0+</span></span><span class="firefox yes"><span>Firefox</span> <span>41+</span></span><span class="safari yes"><span>Safari</span> <span>5+</span></span><span class="samsung yes"><span>Samsung Internet</span> <span>4+</span></span><span class="and_uc yes"><span>UC Browser for Android</span> <span>12.12+</span></span><span class="edge yes"><span>Edge</span> <span>12+</span></span><span class="ie yes"><span>IE</span> <span>10+</span></span><span class="opera yes"><span>Opera</span> <span>10.6+</span></span><span class="op_mini no"><span>Opera Mini</span> <span>None</span></span><span class="android yes"><span>Android Browser</span> <span>4.4+</span></span><p class=caniuse>Source: <a href="https://caniuse.com/#feat=channel-messaging">caniuse.com</a></div><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Channel_Messaging_API title="The Channel Messaging API allows two separate scripts running in different browsing contexts attached to the same document (e.g., two IFrames, or the main document and an IFrame, two documents via a SharedWorker, or two workers) to communicate directly, passing messages between one another through two-way channels (or pipes) with a port at each end.">Channel_Messaging_API</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>41+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Channel_Messaging_API/Using_channel_messaging title="The Channel Messaging API allows two separate scripts running in different browsing contexts attached to the same document (e.g., two IFrames, or the main document and an IFrame, or two documents via a SharedWorker) to communicate directly, passing messages between one another through two-way channels (or pipes) with a port at each end.">Channel_Messaging_API/Using_channel_messaging</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>41+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div></aside>

  <h4 id=introduction-13><span class=secno>9.5.1</span> Introduction<a href=#introduction-13 class=self-link></a></h4>

  <p><i>This section is non-normative.</i></p>

  <p>To enable independent pieces of code (e.g. running in different <a href=browsers.html#browsing-context id=introduction-13:browsing-context>browsing contexts</a>) to communicate directly, authors can use <a href=#channel-messaging id=introduction-13:channel-messaging>channel
  messaging</a>.</p>

  <p>Communication channels in this mechanism are implemented as two-ways pipes, with a port at each
  end. Messages sent in one port are delivered at the other port, and vice-versa. Messages are
  delivered as DOM events, without interrupting or blocking running <a href=webappapis.html#concept-task id=introduction-13:concept-task>tasks</a>.</p>

  <p>To create a connection (two "entangled" ports), the <code>MessageChannel()</code>
  constructor is called:</p>

  <pre><code class='js'><c- a>var</c-> channel <c- o>=</c-> <c- k>new</c-> MessageChannel<c- p>();</c-></code></pre>

  <p>One of the ports is kept as the local port, and the other port is sent to the remote code, e.g.
  using <code id=introduction-13:dom-window-postmessage><a href=#dom-window-postmessage>postMessage()</a></code>:</p>

  <pre><code class='js'>otherWindow<c- p>.</c->postMessage<c- p>(</c-><c- t>&apos;hello&apos;</c-><c- p>,</c-> <c- t>&apos;https://example.com&apos;</c-><c- p>,</c-> <c- p>[</c->channel<c- p>.</c->port2<c- p>]);</c-></code></pre>

  <p>To send messages, the <code id=introduction-13:dom-messageport-postmessage><a href=#dom-messageport-postmessage>postMessage()</a></code> method on
  the port is used:</p>

  <pre><code class='js'>channel<c- p>.</c->port1<c- p>.</c->postMessage<c- p>(</c-><c- t>&apos;hello&apos;</c-><c- p>);</c-></code></pre>

  <p>To receive messages, one listens to <code id=introduction-13:event-message><a href=indices.html#event-message>message</a></code> events:</p>

  <pre><code class='js'>channel<c- p>.</c->port1<c- p>.</c->onmessage <c- o>=</c-> handleMessage<c- p>;</c->
<c- a>function</c-> handleMessage<c- p>(</c->event<c- p>)</c-> <c- p>{</c->
  <c- c1>// message is in event.data</c->
  <c- c1>// ...</c->
<c- p>}</c-></code></pre>

  <p>Data sent on a port can be structured data; for example here an array of strings is passed on a
  <code id=introduction-13:messageport><a href=#messageport>MessagePort</a></code>:</p>

  <pre><code class='js'>port1<c- p>.</c->postMessage<c- p>([</c-><c- t>&apos;hello&apos;</c-><c- p>,</c-> <c- t>&apos;world&apos;</c-><c- p>]);</c-></code></pre>


  <h5 id=examples-5><span class=secno>9.5.1.1</span> Examples<a href=#examples-5 class=self-link></a></h5>

  <p><i>This section is non-normative.</i></p>

  <div class=example>

   <p>In this example, two JavaScript libraries are connected to each other using
   <code id=examples-5:messageport><a href=#messageport>MessagePort</a></code>s. This allows the libraries to later be hosted in different frames, or
   in <code id=examples-5:worker><a href=workers.html#worker>Worker</a></code> objects, without any change to the APIs.</p>

   <pre><code class='html'><c- p>&lt;</c-><c- f>script</c-> <c- e>src</c-><c- o>=</c-><c- s>&quot;contacts.js&quot;</c-><c- p>&gt;&lt;/</c-><c- f>script</c-><c- p>&gt;</c-> <c- c>&lt;!-- exposes a contacts object --&gt;</c->
<c- p>&lt;</c-><c- f>script</c-> <c- e>src</c-><c- o>=</c-><c- s>&quot;compose-mail.js&quot;</c-><c- p>&gt;&lt;/</c-><c- f>script</c-><c- p>&gt;</c-> <c- c>&lt;!-- exposes a composer object --&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
 <c- a>var</c-> channel <c- o>=</c-> <c- k>new</c-> MessageChannel<c- p>();</c->
 composer<c- p>.</c->addContactsProvider<c- p>(</c->channel<c- p>.</c->port1<c- p>);</c->
 contacts<c- p>.</c->registerConsumer<c- p>(</c->channel<c- p>.</c->port2<c- p>);</c->
<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c-></code></pre>

   <p>Here's what the "addContactsProvider()" function's implementation could look like:</p>

   <pre><code class='js'><c- a>function</c-> addContactsProvider<c- p>(</c->port<c- p>)</c-> <c- p>{</c->
  port<c- p>.</c->onmessage <c- o>=</c-> <c- a>function</c-> <c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- k>switch</c-> <c- p>(</c->event<c- p>.</c->data<c- p>.</c->messageType<c- p>)</c-> <c- p>{</c->
      <c- t>&apos;search-result&apos;</c-><c- o>:</c-> handleSearchResult<c- p>(</c->event<c- p>.</c->data<c- p>.</c->results<c- p>);</c-> <c- k>break</c-><c- p>;</c->
      <c- t>&apos;search-done&apos;</c-><c- o>:</c-> handleSearchDone<c- p>();</c-> <c- k>break</c-><c- p>;</c->
      <c- t>&apos;search-error&apos;</c-><c- o>:</c-> handleSearchError<c- p>(</c->event<c- p>.</c->data<c- p>.</c->message<c- p>);</c-> <c- k>break</c-><c- p>;</c->
      <c- c1>// ...</c->
    <c- p>}</c->
  <c- p>};</c->
<c- p>};</c-></code></pre>

   <p>Alternatively, it could be implemented as follows:</p>

   <pre><code class='js'><c- a>function</c-> addContactsProvider<c- p>(</c->port<c- p>)</c-> <c- p>{</c->
  port<c- p>.</c->addEventListener<c- p>(</c-><c- t>&apos;message&apos;</c-><c- p>,</c-> <c- a>function</c-> <c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- k>if</c-> <c- p>(</c->event<c- p>.</c->data<c- p>.</c->messageType <c- o>==</c-> <c- t>&apos;search-result&apos;</c-><c- p>)</c->
      handleSearchResult<c- p>(</c->event<c- p>.</c->data<c- p>.</c->results<c- p>);</c->
  <c- p>});</c->
  port<c- p>.</c->addEventListener<c- p>(</c-><c- t>&apos;message&apos;</c-><c- p>,</c-> <c- a>function</c-> <c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- k>if</c-> <c- p>(</c->event<c- p>.</c->data<c- p>.</c->messageType <c- o>==</c-> <c- t>&apos;search-done&apos;</c-><c- p>)</c->
      handleSearchDone<c- p>();</c->
  <c- p>});</c->
  port<c- p>.</c->addEventListener<c- p>(</c-><c- t>&apos;message&apos;</c-><c- p>,</c-> <c- a>function</c-> <c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- k>if</c-> <c- p>(</c->event<c- p>.</c->data<c- p>.</c->messageType <c- o>==</c-> <c- t>&apos;search-error&apos;</c-><c- p>)</c->
      handleSearchError<c- p>(</c->event<c- p>.</c->data<c- p>.</c->message<c- p>);</c->
  <c- p>});</c->
  <c- c1>// ...</c->
  port<c- p>.</c->start<c- p>();</c->
<c- p>};</c-></code></pre>

   <p>The key difference is that when using <code id=examples-5:dom-eventtarget-addeventlistener><a data-x-internal=dom-eventtarget-addeventlistener href=https://dom.spec.whatwg.org/#dom-eventtarget-addeventlistener>addEventListener()</a></code>, the <code id=examples-5:dom-messageport-start><a href=#dom-messageport-start>start()</a></code> method must also be invoked. When using <code id=examples-5:handler-messageport-onmessage><a href=#handler-messageport-onmessage>onmessage</a></code>, the call to <code id=examples-5:dom-messageport-start-2><a href=#dom-messageport-start>start()</a></code> is implied.</p>

   <p>The <code id=examples-5:dom-messageport-start-3><a href=#dom-messageport-start>start()</a></code> method, whether called explicitly or
   implicitly (by setting <code id=examples-5:handler-messageport-onmessage-2><a href=#handler-messageport-onmessage>onmessage</a></code>), starts the
   flow of messages: messages posted on message ports are initially paused, so that they don't get
   dropped on the floor before the script has had a chance to set up its handlers.</p>

  </div>


  <h5 id=ports-as-the-basis-of-an-object-capability-model-on-the-web><span class=secno>9.5.1.2</span> Ports as the basis of an object-capability model on the Web<a href=#ports-as-the-basis-of-an-object-capability-model-on-the-web class=self-link></a></h5>

  <p><i>This section is non-normative.</i></p>

  <p>Ports can be viewed as a way to expose limited capabilities (in the object-capability model
  sense) to other actors in the system. This can either be a weak capability system, where the ports
  are merely used as a convenient model within a particular origin, or as a strong capability model,
  where they are provided by one origin <var>provider</var> as the only mechanism by which
  another origin <var>consumer</var> can effect change in or obtain information from <var>provider</var>.</p>

  <p>For example, consider a situation in which a social Web site embeds in one <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:the-iframe-element><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code>
  the user's e-mail contacts provider (an address book site, from a second origin), and in a second
  <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:the-iframe-element-2><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code> a game (from a third origin). The outer social site and the game in the second
  <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:the-iframe-element-3><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code> cannot access anything inside the first <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:the-iframe-element-4><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code>; together they can
  only:</p>

  <ul class=brief><li><a id=ports-as-the-basis-of-an-object-capability-model-on-the-web:navigate href=browsing-the-web.html#navigate>Navigate</a> the <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:the-iframe-element-5><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code> to a new <a id=ports-as-the-basis-of-an-object-capability-model-on-the-web:url href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a>, such as the same
   <a id=ports-as-the-basis-of-an-object-capability-model-on-the-web:url-2 href=https://url.spec.whatwg.org/#concept-url data-x-internal=url>URL</a> but with a different <a href=https://url.spec.whatwg.org/#concept-url-fragment id=ports-as-the-basis-of-an-object-capability-model-on-the-web:concept-url-fragment data-x-internal=concept-url-fragment>fragment</a>,
   causing the <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:window><a href=window-object.html#window>Window</a></code> in the <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:the-iframe-element-6><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code> to receive a <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:event-hashchange><a href=indices.html#event-hashchange>hashchange</a></code> event.<li>Resize the <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:the-iframe-element-7><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code>, causing the <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:window-2><a href=window-object.html#window>Window</a></code> in the <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:the-iframe-element-8><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code> to
   receive a <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:event-resize><a data-x-internal=event-resize href=https://drafts.csswg.org/cssom-view/#eventdef-window-resize>resize</a></code> event.<li>Send a <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:event-message><a href=indices.html#event-message>message</a></code> event to the <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:window-3><a href=window-object.html#window>Window</a></code> in the
   <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:the-iframe-element-9><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code> using the <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:dom-window-postmessage><a href=#dom-window-postmessage>window.postMessage()</a></code>
   API.</ul>

  <p>The contacts provider can use these methods, most particularly the third one, to provide an API
  that can be accessed by other origins to manipulate the user's address book. For example, it could
  respond to a message "<code>add-contact Guillaume Tell
  &lt;tell@pomme.example.net></code>" by adding the given person and e-mail address to the user's
  address book.</p>

  <p>To avoid any site on the Web being able to manipulate the user's contacts, the contacts
  provider might only allow certain trusted sites, such as the social site, to do this.</p>

  <p>Now suppose the game wanted to add a contact to the user's address book, and that the social
  site was willing to allow it to do so on its behalf, essentially "sharing" the trust that the
  contacts provider had with the social site. There are several ways it could do this; most simply,
  it could just proxy messages between the game site and the contacts site. However, this solution
  has a number of difficulties: it requires the social site to either completely trust the game site
  not to abuse the privilege, or it requires that the social site verify each request to make sure
  it's not a request that it doesn't want to allow (such as adding multiple contacts, reading the
  contacts, or deleting them); it also requires some additional complexity if there's ever the
  possibility of multiple games simultaneously trying to interact with the contacts provider.</p>

  <p>Using message channels and <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:messageport><a href=#messageport>MessagePort</a></code> objects, however, all of these problems can
  go away. When the game tells the social site that it wants to add a contact, the social site can
  ask the contacts provider not for it to add a contact, but for the <em>capability</em> to add a
  single contact. The contacts provider then creates a pair of <code id=ports-as-the-basis-of-an-object-capability-model-on-the-web:messageport-2><a href=#messageport>MessagePort</a></code> objects, and
  sends one of them back to the social site, who forwards it on to the game. The game and the
  contacts provider then have a direct connection, and the contacts provider knows to only honor a
  single "add contact" request, nothing else. In other words, the game has been granted the
  capability to add a single contact.</p>


  <h5 id=ports-as-the-basis-of-abstracting-out-service-implementations><span class=secno>9.5.1.3</span> Ports as the basis of abstracting out service implementations<a href=#ports-as-the-basis-of-abstracting-out-service-implementations class=self-link></a></h5>

  <p><i>This section is non-normative.</i></p>

  <p>Continuing the example from the previous section, consider the contacts provider in particular.
  While an initial implementation might have simply used <code id=ports-as-the-basis-of-abstracting-out-service-implementations:xmlhttprequest><a data-x-internal=xmlhttprequest href=https://xhr.spec.whatwg.org/#xmlhttprequest>XMLHttpRequest</a></code> objects in the
  service's <code id=ports-as-the-basis-of-abstracting-out-service-implementations:the-iframe-element><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code>, an evolution of the service might instead want to use a <a href=workers.html#sharedworker id=ports-as-the-basis-of-abstracting-out-service-implementations:sharedworker>shared worker</a> with a single <code id=ports-as-the-basis-of-abstracting-out-service-implementations:websocket><a href=web-sockets.html#websocket>WebSocket</a></code> connection.</p>

  <p>If the initial design used <code id=ports-as-the-basis-of-abstracting-out-service-implementations:messageport><a href=#messageport>MessagePort</a></code> objects to grant capabilities, or even just
  to allow multiple simultaneous independent sessions, the service implementation can switch from
  the <code id=ports-as-the-basis-of-abstracting-out-service-implementations:xmlhttprequest-2><a data-x-internal=xmlhttprequest href=https://xhr.spec.whatwg.org/#xmlhttprequest>XMLHttpRequest</a></code>s-in-each-<code id=ports-as-the-basis-of-abstracting-out-service-implementations:the-iframe-element-2><a href=iframe-embed-object.html#the-iframe-element>iframe</a></code> model to the
  shared-<code id=ports-as-the-basis-of-abstracting-out-service-implementations:websocket-2><a href=web-sockets.html#websocket>WebSocket</a></code> model without changing the API at all: the ports on the service
  provider side can all be forwarded to the shared worker without it affecting the users of the API
  in the slightest.</p>



  <h4 id=message-channels><span class=secno>9.5.2</span> Message channels<a href=#message-channels class=self-link></a></h4><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessageChannel title="The MessageChannel interface of the Channel Messaging API allows us to create a new message channel and send data through it via its two MessagePort properties.">MessageChannel</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>41+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div></aside>

  <pre><code class='idl'>[<a href='#dom-messagechannel' id='message-channels:dom-messagechannel'><c- g>Constructor</c-></a>, <c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn id='messagechannel'><c- g>MessageChannel</c-></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a href='#messageport' id='message-channels:messageport'><c- n>MessagePort</c-></a> <a href='#dom-messagechannel-port1' id='message-channels:dom-messagechannel-port1'><c- g>port1</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a href='#messageport' id='message-channels:messageport-2'><c- n>MessagePort</c-></a> <a href='#dom-messagechannel-port2' id='message-channels:dom-messagechannel-port2'><c- g>port2</c-></a>;
};</code></pre>

  <dl class=domintro><dt><var>channel</var> = new <code id=dom-messagechannel-dev><a href=#dom-messagechannel>MessageChannel</a></code>()<dd>
    <p>Returns a new <code id=message-channels:messagechannel><a href=#messagechannel>MessageChannel</a></code> object with two new <code id=message-channels:messageport-3><a href=#messageport>MessagePort</a></code> objects.</p>
   <dt><var>channel</var> . <code id=dom-messagechannel-port1-dev><a href=#dom-messagechannel-port1>port1</a></code><dd>
    <p>Returns the first <code id=message-channels:messageport-4><a href=#messageport>MessagePort</a></code> object.</p>
   <dt><var>channel</var> . <code id=dom-messagechannel-port2-dev><a href=#dom-messagechannel-port2>port2</a></code><dd>
    <p>Returns the second <code id=message-channels:messageport-5><a href=#messageport>MessagePort</a></code> object.</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessageChannel/MessageChannel title="The MessageChannel() constructor of the MessageChannel interface returns a new MessageChannel object with two new MessagePort objects.">MessageChannel/MessageChannel</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>41+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div></aside><p>When the <dfn id=dom-messagechannel><code>MessageChannel()</code></dfn> constructor is
  called, it must run the following algorithm:</p>

  <ol><li><p><a href=#create-a-new-messageport-object id=message-channels:create-a-new-messageport-object>Create a new <code>MessagePort</code> object</a> whose <a href=#concept-port-owner id=message-channels:concept-port-owner>owner</a> is the <a id=message-channels:incumbent-settings-object href=webappapis.html#incumbent-settings-object>incumbent settings object</a>, and let
   <var>port1</var> be that object.<li><p><a href=#create-a-new-messageport-object id=message-channels:create-a-new-messageport-object-2>Create a new <code>MessagePort</code> object</a> whose <a href=#concept-port-owner id=message-channels:concept-port-owner-2>owner</a> is the <a id=message-channels:incumbent-settings-object-2 href=webappapis.html#incumbent-settings-object>incumbent settings object</a>, and let
   <var>port2</var> be that object.<li><p><a href=#entangle id=message-channels:entangle>Entangle</a> the <var>port1</var> and <var>port2</var> objects.<li><p>Instantiate a new <code id=message-channels:messagechannel-2><a href=#messagechannel>MessageChannel</a></code> object, and let <var>channel</var> be that
   object.<li><p>Let the <code id=message-channels:dom-messagechannel-port1-2><a href=#dom-messagechannel-port1>port1</a></code> attribute of the
   <var>channel</var> object be <var>port1</var>.</p>

   <li><p>Let the <code id=message-channels:dom-messagechannel-port2-2><a href=#dom-messagechannel-port2>port2</a></code> attribute of the
   <var>channel</var> object be <var>port2</var>.</p>

   <li><p>Return <var>channel</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessageChannel/port1 title="The port1 read-only property of the MessageChannel interface returns the first port of the message channel — the port attached to the context that originated the channel.">MessageChannel/port1</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>41+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessageChannel/port2 title="The port2 read-only property of the MessageChannel interface returns the second port of the message channel — the port attached to the context at the other end of the channel, which the message is initially sent to.">MessageChannel/port2</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>41+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div></aside><p>The <dfn id=dom-messagechannel-port1><code>port1</code></dfn> and <dfn id=dom-messagechannel-port2><code>port2</code></dfn> attributes must return the values they were
  assigned when the <code id=message-channels:messagechannel-3><a href=#messagechannel>MessageChannel</a></code> object was created.</p>

  



  <h4 id=message-ports><span class=secno>9.5.3</span> Message ports<a href=#message-ports class=self-link></a></h4><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessagePort title="The MessagePort interface of the Channel Messaging API represents one of the two ports of a MessageChannel, allowing messages to be sent from one port and listening out for them arriving at the other.">MessagePort</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div></aside>

  <p>Each channel has two message ports. Data sent through one port is received by the other port,
  and vice versa.</p>

  <pre><code class='idl'>[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->,<c- n>AudioWorklet</c->), <a href='structured-data.html#transferable' id='message-ports:transferable'><c- g>Transferable</c-></a>]
<c- b>interface</c-> <dfn id='messageport'><c- g>MessagePort</c-></dfn> : <a href='https://dom.spec.whatwg.org/#interface-eventtarget' data-x-internal='eventtarget' id='message-ports:eventtarget'><c- n>EventTarget</c-></a> {
  <c- b>void</c-> <a href='#dom-messageport-postmessage' id='message-ports:dom-messageport-postmessage'><c- g>postMessage</c-></a>(<c- b>any</c-> <c- g>message</c->, <c- b>sequence</c->&lt;<a href='https://heycam.github.io/webidl/#idl-object' data-x-internal='idl-object' id='message-ports:idl-object'><c- b>object</c-></a>&gt; <c- g>transfer</c->);
  <c- b>void</c-> <a href='#dom-messageport-postmessage-options' id='message-ports:dom-messageport-postmessage-options'><c- g>postMessage</c-></a>(<c- b>any</c-> <c- g>message</c->, <c- b>optional</c-> <a href='#postmessageoptions' id='message-ports:postmessageoptions'><c- n>PostMessageOptions</c-></a> <c- g>options</c-> = {});
  <c- b>void</c-> <a href='#dom-messageport-start' id='message-ports:dom-messageport-start'><c- g>start</c-></a>();
  <c- b>void</c-> <a href='#dom-messageport-close' id='message-ports:dom-messageport-close'><c- g>close</c-></a>();

  // event handlers
  <c- b>attribute</c-> <a href='webappapis.html#eventhandler' id='message-ports:eventhandler'><c- n>EventHandler</c-></a> <a href='#handler-messageport-onmessage' id='message-ports:handler-messageport-onmessage'><c- g>onmessage</c-></a>;
  <c- b>attribute</c-> <a href='webappapis.html#eventhandler' id='message-ports:eventhandler-2'><c- n>EventHandler</c-></a> <a href='#handler-messageport-onmessageerror' id='message-ports:handler-messageport-onmessageerror'><c- g>onmessageerror</c-></a>;
};

<c- b>dictionary</c-> <dfn id='postmessageoptions'><c- g>PostMessageOptions</c-></dfn> {
  <c- b>sequence</c->&lt;<a href='https://heycam.github.io/webidl/#idl-object' data-x-internal='idl-object' id='message-ports:idl-object-2'><c- b>object</c-></a>&gt; <c- g>transfer</c-> = [];
};</code></pre>

  <dl class=domintro><dt><var>port</var> . <code id=dom-messageport-postmessage-dev><a href=#dom-messageport-postmessage>postMessage</a></code>(<var>message</var> [, <var>transfer</var>] )<dt><var>port</var> . <code id=dom-messageport-postmessage-options-dev><a href=#dom-messageport-postmessage-options>postMessage</a></code>(<var>message</var> [, { <code>transfer</code> }] )<dd>
    <p>Posts a message through the channel. Objects listed in <var>transfer</var> are
    transferred, not just cloned, meaning that they are no longer usable on the sending side.</p>

    <p>Throws a <a id=message-ports:datacloneerror href=https://heycam.github.io/webidl/#datacloneerror data-x-internal=datacloneerror>"<code>DataCloneError</code>"</a> <code id=message-ports:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if
    <var>transfer</var> contains duplicate objects or <var>port</var>, or if <var>message</var>
    could not be cloned.</p>
   <dt><var>port</var> . <code id=dom-messageport-start-dev><a href=#dom-messageport-start>start</a></code>()<dd><p>Begins dispatching messages received on the port.<dt><var>port</var> . <code id=dom-messageport-close-dev><a href=#dom-messageport-close>close</a></code>()<dd><p>Disconnects the port, so that it is no longer active.</dl>

  

  <p>Each <code id=message-ports:messageport><a href=#messageport>MessagePort</a></code> object can be entangled with another (a symmetric relationship).
  Each <code id=message-ports:messageport-2><a href=#messageport>MessagePort</a></code> object also has a <a id=message-ports:task-source href=webappapis.html#task-source>task source</a> called the <dfn id=port-message-queue>port
  message queue</dfn>, initially empty. A <a href=#port-message-queue id=message-ports:port-message-queue>port message queue</a> can be enabled or
  disabled, and is initially disabled. Once enabled, a port can never be disabled again (though
  messages in the queue can get moved to another queue or removed altogether, which has much the
  same effect). A <code id=message-ports:messageport-3><a href=#messageport>MessagePort</a></code> also has a <dfn id=has-been-shipped>has been shipped</dfn> flag, which must
  initially be false, and an <dfn id=concept-port-owner>owner</dfn>, which is a <a id=message-ports:settings-object href=webappapis.html#settings-object>settings
  object</a> set when the object is created, as described below.</p>

  <p>When a port's <a href=#port-message-queue id=message-ports:port-message-queue-2>port message queue</a> is enabled, the <a id=message-ports:event-loop href=webappapis.html#event-loop>event loop</a> must use
  it as one of its <a href=webappapis.html#task-source id=message-ports:task-source-2>task sources</a>. When a port's <a href=#concept-port-owner id=message-ports:concept-port-owner>owner</a>'s <a id=message-ports:responsible-event-loop href=webappapis.html#responsible-event-loop>responsible event loop</a> is a <a id=message-ports:window-event-loop href=webappapis.html#window-event-loop>window
  event loop</a>, all <a href=webappapis.html#concept-task id=message-ports:concept-task>tasks</a> <a href=webappapis.html#queue-a-task id=message-ports:queue-a-task>queued</a> on its <a href=#port-message-queue id=message-ports:port-message-queue-3>port message queue</a> must be associated with the port's
  <a href=#concept-port-owner id=message-ports:concept-port-owner-2>owner</a>'s <a id=message-ports:responsible-document href=webappapis.html#responsible-document>responsible document</a>.</p>

  <p class=note>If the port's <a href=#concept-port-owner id=message-ports:concept-port-owner-3>owner</a>'s <a id=message-ports:responsible-document-2 href=webappapis.html#responsible-document>responsible
  document</a> is <a id=message-ports:fully-active href=browsers.html#fully-active>fully active</a>, but the event listeners all have scripts whose <a href=webappapis.html#settings-object id=message-ports:settings-object-2>settings objects</a> specify <a href=webappapis.html#responsible-document id=message-ports:responsible-document-3>responsible documents</a> that are <em>not</em> <a id=message-ports:fully-active-2 href=browsers.html#fully-active>fully active</a>, then the
  messages will be lost.</p> 

  <p>Each <a id=message-ports:event-loop-2 href=webappapis.html#event-loop>event loop</a> has a <a id=message-ports:task-source-3 href=webappapis.html#task-source>task source</a> called the <dfn id=unshipped-port-message-queue>unshipped port
  message queue</dfn>. This is a virtual <a id=message-ports:task-source-4 href=webappapis.html#task-source>task source</a>: it must act as if it contained
  the <a href=webappapis.html#concept-task id=message-ports:concept-task-2>tasks</a> of each <a href=#port-message-queue id=message-ports:port-message-queue-4>port message queue</a> of each
  <code id=message-ports:messageport-4><a href=#messageport>MessagePort</a></code> whose <a href=#has-been-shipped id=message-ports:has-been-shipped>has been shipped</a> flag is false, whose <a href=#port-message-queue id=message-ports:port-message-queue-5>port
  message queue</a> is enabled, and whose <a href=#concept-port-owner id=message-ports:concept-port-owner-4>owner</a>'s
  <a id=message-ports:responsible-event-loop-2 href=webappapis.html#responsible-event-loop>responsible event loop</a> is that <a id=message-ports:event-loop-3 href=webappapis.html#event-loop>event loop</a>, in the order in which they
  were added to their respective <a id=message-ports:task-source-5 href=webappapis.html#task-source>task source</a>. When a <a href=webappapis.html#concept-task id=message-ports:concept-task-3>task</a> would be removed from the <a href=#unshipped-port-message-queue id=message-ports:unshipped-port-message-queue>unshipped port message
  queue</a>, it must instead be removed from its <a href=#port-message-queue id=message-ports:port-message-queue-6>port message queue</a>.</p>

  <p>When a <code id=message-ports:messageport-5><a href=#messageport>MessagePort</a></code>'s <a href=#has-been-shipped id=message-ports:has-been-shipped-2>has been shipped</a> flag is false, its <a href=#port-message-queue id=message-ports:port-message-queue-7>port
  message queue</a> must be ignored for the purposes of the <a id=message-ports:event-loop-4 href=webappapis.html#event-loop>event loop</a>. (The
  <a href=#unshipped-port-message-queue id=message-ports:unshipped-port-message-queue-2>unshipped port message queue</a> is used instead.)</p>

  <p class=note>The <a href=#has-been-shipped id=message-ports:has-been-shipped-3>has been shipped</a> flag is set to true when a port, its twin, or
  the object it was cloned from, is or has been transferred. When a <code id=message-ports:messageport-6><a href=#messageport>MessagePort</a></code>'s
  <a href=#has-been-shipped id=message-ports:has-been-shipped-4>has been shipped</a> flag is true, its <a href=#port-message-queue id=message-ports:port-message-queue-8>port message queue</a> acts as a
  first-class <a id=message-ports:task-source-6 href=webappapis.html#task-source>task source</a>, unaffected to any <a href=#unshipped-port-message-queue id=message-ports:unshipped-port-message-queue-3>unshipped port message
  queue</a>.</p>

  <p>When the user agent is to <dfn id=create-a-new-messageport-object>create a new <code>MessagePort</code> object</dfn> with a
  particular <a id=message-ports:environment-settings-object href=webappapis.html#environment-settings-object>environment settings object</a> as its <var>owner</var>, it must instantiate
  a new <code id=message-ports:messageport-7><a href=#messageport>MessagePort</a></code> object, and let its <a href=#concept-port-owner id=message-ports:concept-port-owner-5>owner</a>
  be <var>owner</var>.</p>

  <p>When the user agent is to <dfn id=entangle>entangle</dfn> two <code id=message-ports:messageport-8><a href=#messageport>MessagePort</a></code> objects, it must run
  the following steps:</p>

  <ol><li>
    <p>If one of the ports is already entangled, then disentangle it and the port that it was
    entangled with.</p>

    <p class=note>If those two previously entangled ports were the two ports of a
    <code id=message-ports:messagechannel><a href=#messagechannel>MessageChannel</a></code> object, then that <code id=message-ports:messagechannel-2><a href=#messagechannel>MessageChannel</a></code> object no longer
    represents an actual channel: the two ports in that object are no longer entangled.</p>
   <li>
    <p>Associate the two ports to be entangled, so that they form the two parts of a new channel.
    (There is no <code id=message-ports:messagechannel-3><a href=#messagechannel>MessageChannel</a></code> object that represents this channel.)</p>

    <p>Two ports <var>A</var> and <var>B</var> that have gone through this step
    are now said to be entangled; one is entangled to the other, and vice versa.</p>

    <p class=note>While this specification describes this process as instantaneous,
    implementations are more likely to implement it via message passing. As with all algorithms, the
    key is "merely" that the end result be indistinguishable, in a black-box sense, from the
    specification.</p>
   </ol>

  <hr>

  <p id=transferMessagePort><code id=message-ports:messageport-9><a href=#messageport>MessagePort</a></code> objects are <a id=message-ports:transferable-objects href=structured-data.html#transferable-objects>transferable
  objects</a>. Their <a id=message-ports:transfer-steps href=structured-data.html#transfer-steps>transfer steps</a>, given <var>value</var> and
  <var>dataHolder</var>, are:</p>

  <ol><li><p>Set <var>value</var>'s <a href=#has-been-shipped id=message-ports:has-been-shipped-5>has been shipped</a> flag to true.<li><p>Set <var>dataHolder</var>.[[PortMessageQueue]] to <var>value</var>'s <a href=#port-message-queue id=message-ports:port-message-queue-9>port message
   queue</a>.<li>
    <p>If <var>value</var> is entangled with another port <var>remotePort</var>, then:</p>

    <ol><li><p>Set <var>remotePort</var>'s <a href=#has-been-shipped id=message-ports:has-been-shipped-6>has been shipped</a> flag to true.<li><p>Set <var>dataHolder</var>.[[RemotePort]] to <var>remotePort</var>.</ol>
   <li><p>Otherwise, set <var>dataHolder</var>.[[RemotePort]] to null.</ol>

  <p>Their <a id=message-ports:transfer-receiving-steps href=structured-data.html#transfer-receiving-steps>transfer-receiving steps</a>, given <var>dataHolder</var> and <var>value</var>,
  are:</p>

  <ol><li><p>Set <var>value</var>'s <a href=#has-been-shipped id=message-ports:has-been-shipped-7>has been shipped</a> flag to true.<li><p>Set <var>value</var>'s <a href=#concept-port-owner id=message-ports:concept-port-owner-6>owner</a> to <var>value</var>'s <a id=message-ports:relevant-settings-object href=webappapis.html#relevant-settings-object>relevant settings
   object</a>.<li><p>Move all the <a href=webappapis.html#concept-task id=message-ports:concept-task-4>tasks</a> that are to fire <code id=message-ports:event-message><a href=indices.html#event-message>message</a></code> events in <var>dataHolder</var>.[[PortMessageQueue]] to the
   <a href=#port-message-queue id=message-ports:port-message-queue-10>port message queue</a> of <var>value</var>, if any, leaving
   <var>value</var>'s <a href=#port-message-queue id=message-ports:port-message-queue-11>port message queue</a> in its initial disabled state, and, if
   <var>value</var>'s <a href=#concept-port-owner id=message-ports:concept-port-owner-7>owner</a>'s <a id=message-ports:responsible-event-loop-3 href=webappapis.html#responsible-event-loop>responsible event
   loop</a> is a <a id=message-ports:window-event-loop-2 href=webappapis.html#window-event-loop>window event loop</a>, associating the moved <a href=webappapis.html#concept-task id=message-ports:concept-task-5>tasks</a> with <var>value</var>'s <a href=#concept-port-owner id=message-ports:concept-port-owner-8>owner</a>'s <a id=message-ports:responsible-document-4 href=webappapis.html#responsible-document>responsible document</a>.<li><p>If <var>dataHolder</var>.[[RemotePort]] is not null, then <a href=#entangle id=message-ports:entangle>entangle</a>
   <var>dataHolder</var>.[[RemotePort]] and <var>value</var>. (This will disentangle
   <var>dataHolder</var>.[[RemotePort]] from the original port that was transferred.)</ol>

  <hr>

  <p>The <dfn id=message-port-post-message-steps>message port post message steps</dfn>, given a <var>targetPort</var>, <var>message</var>
  and <var>options</var> are as follows:</p>

  <ol><li><p>Let <var>transfer</var> be <var>options</var>["<code>transfer</code>"].<li><p>If <var>transfer</var> <a href=https://infra.spec.whatwg.org/#list-contain id=message-ports:list-contains data-x-internal=list-contains>contains</a> this
   <code id=message-ports:messageport-10><a href=#messageport>MessagePort</a></code>, then throw a <a id=message-ports:datacloneerror-2 href=https://heycam.github.io/webidl/#datacloneerror data-x-internal=datacloneerror>"<code>DataCloneError</code>"</a>
   <code id=message-ports:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>doomed</var> be false.<li><p>If <var>targetPort</var> is not null and <var>transfer</var> <a href=https://infra.spec.whatwg.org/#list-contain id=message-ports:list-contains-2 data-x-internal=list-contains>contains</a> <var>targetPort</var>, then set <var>doomed</var> to true and
   optionally report to a developer console that the target port was posted to itself, causing the
   communication channel to be lost.<li><p>Let <var>serializeWithTransferResult</var> be
   <a id=message-ports:structuredserializewithtransfer href=structured-data.html#structuredserializewithtransfer>StructuredSerializeWithTransfer</a>(<var>message</var>, <var>transfer</var>). Rethrow
   any exceptions.<li><p>If <var>targetPort</var> is null, or if <var>doomed</var> is true, then return.<li>
    <p>Add a <a href=webappapis.html#concept-task id=message-ports:concept-task-6>task</a> that runs the following steps to the <a href=#port-message-queue id=message-ports:port-message-queue-12>port
    message queue</a> of <var>targetPort</var>:</p>

    <ol><li>
      <p>Let <var>finalTargetPort</var> be the <code id=message-ports:messageport-11><a href=#messageport>MessagePort</a></code> in whose <a href=#port-message-queue id=message-ports:port-message-queue-13>port message
      queue</a> the task now finds itself.</p>

      <p class=note>This can be different from <var>targetPort</var>, if <var>targetPort</var>
      itself was transferred and thus all its tasks moved along with it.</p>
     <li><p>Let <var>targetRealm</var> be <var>finalTargetPort</var>'s <a href=webappapis.html#concept-relevant-realm id=message-ports:concept-relevant-realm>relevant Realm</a>.<li>
      <p>Let <var>deserializeRecord</var> be
      <a id=message-ports:structureddeserializewithtransfer href=structured-data.html#structureddeserializewithtransfer>StructuredDeserializeWithTransfer</a>(<var>serializeWithTransferResult</var>,
      <var>targetRealm</var>).</p>

      <p>If this throws an exception, catch it, <a href=https://dom.spec.whatwg.org/#concept-event-fire id=message-ports:concept-event-fire data-x-internal=concept-event-fire>fire an
      event</a> named <code id=message-ports:event-messageerror><a href=indices.html#event-messageerror>messageerror</a></code> at
      <var>finalTargetPort</var>, using <code id=message-ports:messageevent><a href=comms.html#messageevent>MessageEvent</a></code>, and then return.
     <li><p>Let <var>messageClone</var> be <var>deserializeRecord</var>.[[Deserialized]].<li><p>Let <var>newPorts</var> be a new <a id=message-ports:frozen-array href=https://heycam.github.io/webidl/#dfn-frozen-array-type data-x-internal=frozen-array>frozen array</a> consisting of all
     <code id=message-ports:messageport-12><a href=#messageport>MessagePort</a></code> objects in <var>deserializeRecord</var>.[[TransferredValues]], if any,
     maintaining their relative order.<li><p><a href=https://dom.spec.whatwg.org/#concept-event-fire id=message-ports:concept-event-fire-2 data-x-internal=concept-event-fire>Fire an event</a> named <code id=message-ports:event-message-2><a href=indices.html#event-message>message</a></code> at <var>finalTargetPort</var>, using
     <code id=message-ports:messageevent-2><a href=comms.html#messageevent>MessageEvent</a></code>, with the <code id=message-ports:dom-messageevent-data><a href=comms.html#dom-messageevent-data>data</a></code> attribute
     initialized to <var>messageClone</var> and the <code id=message-ports:dom-messageevent-ports><a href=comms.html#dom-messageevent-ports>ports</a></code> attribute initialized to
     <var>newPorts</var>.</ol>
   </ol>

  <p>The <dfn id=dom-messageport-postmessage-options><code>postMessage(<var>message</var>,
  <var>options</var>)</code></dfn> method, when invoked on a <code id=message-ports:messageport-13><a href=#messageport>MessagePort</a></code> object must
  run the following steps:</p>

  <ol><li><p>Let <var>targetPort</var> be the port with which this <code id=message-ports:messageport-14><a href=#messageport>MessagePort</a></code> is
   entangled, if any; otherwise let it be null.<li><p>Run the <a href=#message-port-post-message-steps id=message-ports:message-port-post-message-steps>message port post message steps</a> providing <var>targetPort</var>,
   <var>message</var> and <var>options</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessagePort/postMessage title="The postMessage() method of the MessagePort interface sends a message from the port, and optionally, transfers ownership of objects to other browsing contexts.">MessagePort/postMessage</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div></aside><p>The <dfn id=dom-messageport-postmessage><code>postMessage(<var>message</var>,
  <var>transfer</var>)</code></dfn> method, when invoked on a <code id=message-ports:messageport-15><a href=#messageport>MessagePort</a></code> object
  must run the following steps:</p>

  <ol><li><p>Let <var>targetPort</var> be the port with which this <code id=message-ports:messageport-16><a href=#messageport>MessagePort</a></code> is
   entangled, if any; otherwise let it be null.<li><p>Let <var>options</var> be «[ "<code>transfer</code>" → <var>transfer</var>
   ]».<li><p>Run the <a href=#message-port-post-message-steps id=message-ports:message-port-post-message-steps-2>message port post message steps</a> providing <var>targetPort</var>,
   <var>message</var> and <var>options</var>.</ol>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessagePort/start title="The start() method of the MessagePort interface starts the sending of messages queued on the port. This method is only needed when using EventTarget.addEventListener; it is implied when using MessageChannel.onmessage.">MessagePort/start</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div></aside><p>The <dfn id=dom-messageport-start><code>start()</code></dfn> method, when invoked, must
  enable this <code id=message-ports:messageport-17><a href=#messageport>MessagePort</a></code> object's <a href=#port-message-queue id=message-ports:port-message-queue-14>port message queue</a>, if it is not
  already enabled.</p>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessagePort/close title="The close() method of the MessagePort interface disconnects the port, so it is no longer active. This stops the flow of messages to that port.">MessagePort/close</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div></aside><p>The <dfn id=dom-messageport-close><code>close()</code></dfn> method, when invoked, must
  run these steps:</p>

  <ol><li><p>Set this <code id=message-ports:messageport-18><a href=#messageport>MessagePort</a></code> object's <a id=message-ports:detached href=structured-data.html#detached>[[Detached]]</a> internal slot value
   to true.<li><p>If this <code id=message-ports:messageport-19><a href=#messageport>MessagePort</a></code> object is entangled, disentangle it.</ol>

  <hr>

  <p>The following are the <a id=message-ports:event-handlers href=webappapis.html#event-handlers>event handlers</a> (and their corresponding <a href=webappapis.html#event-handler-event-type id=message-ports:event-handler-event-type>event handler event types</a>) that must be supported,
  as <a id=message-ports:event-handler-idl-attributes href=webappapis.html#event-handler-idl-attributes>event handler IDL attributes</a>, by all objects implementing the
  <code id=message-ports:messageport-20><a href=#messageport>MessagePort</a></code> interface:</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessagePort/onmessage title="The onmessage event handler of the MessagePort interface is an EventListener, called whenever an MessageEvent of type message is fired on the port — that is, when the port receives a message.">MessagePort/onmessage</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5.1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>11+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/MessagePort/onmessageerror title="The onmessageerror event handler of the MessagePort interface is an EventListener, called whenever an MessageEvent of type messageerror is fired on the port—that is, when it receives a message that cannot be deserialized.">MessagePort/onmessageerror</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>57+</span></span><span class="safari unknown"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>60+</span></span><hr><span class="opera yes"><span>Opera</span><span>47+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>57+</span></span><span class="safari_ios unknown"><span>Safari iOS</span><span>?</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>60+</span></span><span class="webview_android yes"><span>WebView Android</span><span>60+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>8.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>44+</span></span></div></div></aside><table><thead><tr><th><a href=webappapis.html#event-handlers id=message-ports:event-handlers-2>Event handler</a> <th><a id=message-ports:event-handler-event-type-2 href=webappapis.html#event-handler-event-type>Event handler event type</a>
   <tbody><tr><td><dfn id=handler-messageport-onmessage><code>onmessage</code></dfn> <td> <code id=message-ports:event-message-3><a href=indices.html#event-message>message</a></code>
    <tr><td><dfn id=handler-messageport-onmessageerror><code>onmessageerror</code></dfn> <td> <code id=message-ports:event-messageerror-2><a href=indices.html#event-messageerror>messageerror</a></code>
  </table>

  <p>The first time a <code id=message-ports:messageport-21><a href=#messageport>MessagePort</a></code> object's <code id=message-ports:handler-messageport-onmessage-2><a href=#handler-messageport-onmessage>onmessage</a></code> IDL attribute is set, the port's <a href=#port-message-queue id=message-ports:port-message-queue-15>port
  message queue</a> must be enabled, as if the <code id=message-ports:dom-messageport-start-2><a href=#dom-messageport-start>start()</a></code>
  method had been called.</p>

  


  <h4 id=broadcasting-to-many-ports><span class=secno>9.5.4</span> Broadcasting to many ports<a href=#broadcasting-to-many-ports class=self-link></a></h4>

  <p><i>This section is non-normative.</i></p>

  <p>Broadcasting to many ports is in principle relatively simple: keep an array of
  <code id=broadcasting-to-many-ports:messageport><a href=#messageport>MessagePort</a></code> objects to send messages to, and iterate through the array to send a
  message. However, this has one rather unfortunate effect: it prevents the ports from being garbage
  collected, even if the other side has gone away. To avoid this problem, implement a simple
  protocol whereby the other side acknowledges it still exists. If it doesn't do so after a certain
  amount of time, assume it's gone, close the <code id=broadcasting-to-many-ports:messageport-2><a href=#messageport>MessagePort</a></code> object, and let it be garbage
  collected.</p>


  <h4 id=ports-and-garbage-collection><span class=secno>9.5.5</span> Ports and garbage collection<a href=#ports-and-garbage-collection class=self-link></a></h4>

  

  <p>When a <code id=ports-and-garbage-collection:messageport><a href=#messageport>MessagePort</a></code> object <var>o</var> is entangled, user agents must
  either act as if <var>o</var>'s entangled <code id=ports-and-garbage-collection:messageport-2><a href=#messageport>MessagePort</a></code> object has a strong
  reference to <var>o</var>, or as if the <a href=webappapis.html#concept-settings-object-global id=ports-and-garbage-collection:concept-settings-object-global>global
  object</a> specified by <var>o</var>'s <a href=#concept-port-owner id=ports-and-garbage-collection:concept-port-owner>owner</a> has a
  strong reference to <var>o</var>.</p>

  <div class=note>

   <p>Thus, a message port can be received, given an event listener, and then forgotten, and so long
   as that event listener could receive a message, the channel will be maintained.</p>

   <p>Of course, if this was to occur on both sides of the channel, then both ports could be garbage
   collected, since they would not be reachable from live code, despite having a strong reference to
   each other.</p>

  </div>

  <p>Furthermore, a <code id=ports-and-garbage-collection:messageport-3><a href=#messageport>MessagePort</a></code> object must not be garbage collected while there exists
  an event referenced by a <a href=webappapis.html#concept-task id=ports-and-garbage-collection:concept-task>task</a> in a <a id=ports-and-garbage-collection:task-queue href=webappapis.html#task-queue>task queue</a> that is to be dispatched on that <code id=ports-and-garbage-collection:messageport-4><a href=#messageport>MessagePort</a></code>
  object, or while the <code id=ports-and-garbage-collection:messageport-5><a href=#messageport>MessagePort</a></code> object's <a href=#port-message-queue id=ports-and-garbage-collection:port-message-queue>port message queue</a> is enabled
  and not empty.</p> 

  

  

  <p class=note>Authors are strongly encouraged to explicitly close <code id=ports-and-garbage-collection:messageport-6><a href=#messageport>MessagePort</a></code>
  objects to disentangle them, so that their resources can be recollected. Creating many
  <code id=ports-and-garbage-collection:messageport-7><a href=#messageport>MessagePort</a></code> objects and discarding them without closing them can lead to high
  transient memory usage since garbage collection is not necessarily performed promptly, especially
  for <code id=ports-and-garbage-collection:messageport-8><a href=#messageport>MessagePort</a></code>s where garbage collection can involve cross-process coordination.</p>



  <h3 id=broadcasting-to-other-browsing-contexts><span class=secno>9.6</span> <dfn>Broadcasting to other browsing contexts</dfn><a href=#broadcasting-to-other-browsing-contexts class=self-link></a></h3><div class=status><input onclick=toggleStatus(this) value=⋰ type=button><p class=support><strong>Support:</strong> broadcastchannel<span class="and_chr yes"><span>Chrome for Android</span> <span>80+</span></span><span class="chrome yes"><span>Chrome</span> <span>54+</span></span><span class="ios_saf no"><span>iOS Safari</span> <span>None</span></span><span class="firefox yes"><span>Firefox</span> <span>38+</span></span><span class="safari no"><span>Safari</span> <span>None</span></span><span class="samsung yes"><span>Samsung Internet</span> <span>7.2+</span></span><span class="and_uc yes"><span>UC Browser for Android</span> <span>12.12+</span></span><span class="edge yes"><span>Edge</span> <span>79+</span></span><span class="ie no"><span>IE</span> <span>None</span></span><span class="opera yes"><span>Opera</span> <span>41+</span></span><span class="op_mini no"><span>Opera Mini</span> <span>None</span></span><span class="android yes"><span>Android Browser</span> <span>80+</span></span><p class=caniuse>Source: <a href="https://caniuse.com/#feat=broadcastchannel">caniuse.com</a></div><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Broadcast_Channel_API title="The Broadcast Channel API allows basic communication between browsing contexts (that is, windows, tabs, frames, or iframes) and workers on the same origin.">Broadcast_Channel_API</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>38+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>54+</span></span><hr><span class="opera yes"><span>Opera</span><span>41+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android unknown"><span>Firefox Android</span><span>?</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>54+</span></span><span class="webview_android yes"><span>WebView Android</span><span>54+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>41+</span></span></div></div></aside>

  <p>Pages on a single <a id=broadcasting-to-other-browsing-contexts:concept-origin href=origin.html#concept-origin>origin</a> opened by the same user in the same user agent but in
  different unrelated <a href=browsers.html#browsing-context id=broadcasting-to-other-browsing-contexts:browsing-context>browsing contexts</a> sometimes need to
  send notifications to each other, for example "hey, the user logged in over here, check your
  credentials again".</p>

  <p>For elaborate cases, e.g. to manage locking of shared state, to manage synchronization of
  resources between a server and multiple local clients, to share a <code id=broadcasting-to-other-browsing-contexts:websocket><a href=web-sockets.html#websocket>WebSocket</a></code>
  connection with a remote host, and so forth, <a href=workers.html#sharedworker id=broadcasting-to-other-browsing-contexts:sharedworker>shared workers</a> are
  the most appropriate solution.</p>

  <p>For simple cases, though, where a shared worker would be an unreasonable overhead, authors can
  use the simple channel-based broadcast mechanism described in this section.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/BroadcastChannel title="The BroadcastChannel interface represents a named channel that any browsing context of a given origin can subscribe to. It allows communication between different documents (in different windows, tabs, frames or iframes) of the same origin. Messages are broadcasted via a message event fired at all BroadcastChannel objects listening to the channel.">BroadcastChannel</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>38+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>54+</span></span><hr><span class="opera yes"><span>Opera</span><span>41+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android unknown"><span>Firefox Android</span><span>?</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>54+</span></span><span class="webview_android yes"><span>WebView Android</span><span>54+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>41+</span></span></div></div></aside><pre><code class='idl'>[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn id='broadcastchannel'><c- g>BroadcastChannel</c-></dfn> : <a href='https://dom.spec.whatwg.org/#interface-eventtarget' data-x-internal='eventtarget' id='broadcasting-to-other-browsing-contexts:eventtarget'><c- n>EventTarget</c-></a> {
  <a href='#dom-broadcastchannel' id='broadcasting-to-other-browsing-contexts:dom-broadcastchannel'><c- b>constructor</c-></a>(<c- b>DOMString</c-> <c- g>name</c->);

  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>DOMString</c-> <a href='#dom-broadcastchannel-name' id='broadcasting-to-other-browsing-contexts:dom-broadcastchannel-name'><c- g>name</c-></a>;
  <c- b>void</c-> <a href='#dom-broadcastchannel-postmessage' id='broadcasting-to-other-browsing-contexts:dom-broadcastchannel-postmessage'><c- g>postMessage</c-></a>(<c- b>any</c-> <c- g>message</c->);
  <c- b>void</c-> <a href='#dom-broadcastchannel-close' id='broadcasting-to-other-browsing-contexts:dom-broadcastchannel-close'><c- g>close</c-></a>();
  <c- b>attribute</c-> <a href='webappapis.html#eventhandler' id='broadcasting-to-other-browsing-contexts:eventhandler'><c- n>EventHandler</c-></a> <a href='#handler-broadcastchannel-onmessage' id='broadcasting-to-other-browsing-contexts:handler-broadcastchannel-onmessage'><c- g>onmessage</c-></a>;
  <c- b>attribute</c-> <a href='webappapis.html#eventhandler' id='broadcasting-to-other-browsing-contexts:eventhandler-2'><c- n>EventHandler</c-></a> <a href='#handler-broadcastchannel-onmessageerror' id='broadcasting-to-other-browsing-contexts:handler-broadcastchannel-onmessageerror'><c- g>onmessageerror</c-></a>;
};</code></pre>

  <dl class=domintro><dt><var>broadcastChannel</var> = new <code id=dom-broadcastchannel-dev><a href=#dom-broadcastchannel>BroadcastChannel</a></code>(<var>name</var>)<dd>
    <p>Returns a new <code id=broadcasting-to-other-browsing-contexts:broadcastchannel><a href=#broadcastchannel>BroadcastChannel</a></code> object via which messages for the given channel
    name can be sent and received.</p>
   <dt><var>broadcastChannel</var> . <code id=dom-broadcastchannel-name-dev><a href=#dom-broadcastchannel-name>name</a></code><dd>
    <p>Returns the channel name (as passed to the constructor).</p>
   <dt><var>broadcastChannel</var> . <code id=dom-broadcastchannel-postmessage-dev><a href=#dom-broadcastchannel-postmessage>postMessage</a></code>(<var>message</var>)<dd>
    <p>Sends the given message to other <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-2><a href=#broadcastchannel>BroadcastChannel</a></code> objects set up for this channel. Messages can be structured objects, e.g. nested objects and arrays.</p>
   <dt><var>broadcastChannel</var> . <code id=dom-broadcastchannel-close-dev><a href=#dom-broadcastchannel-close>close</a></code>()<dd>
    <p>Closes the <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-3><a href=#broadcastchannel>BroadcastChannel</a></code> object, opening it up to garbage collection.</p>
   </dl>

  

  <p>A <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-4><a href=#broadcastchannel>BroadcastChannel</a></code> object has a <dfn id=channel-name>channel name</dfn>, a
  <dfn id=broadcastchannel-settings-object><code>BroadcastChannel</code> settings object</dfn>, and a <dfn id=concept-broadcastchannel-closed>closed flag</dfn>.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/BroadcastChannel/BroadcastChannel title="The BroadcastChannel() constructor creates a new BroadcastChannel and connects it to the underlying channel.">BroadcastChannel/BroadcastChannel</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>38+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>54+</span></span><hr><span class="opera yes"><span>Opera</span><span>41+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android unknown"><span>Firefox Android</span><span>?</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>54+</span></span><span class="webview_android yes"><span>WebView Android</span><span>54+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>41+</span></span></div></div></aside><p>The <dfn id=dom-broadcastchannel><code>BroadcastChannel()</code></dfn> constructor, when
  invoked, must create and return a <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-5><a href=#broadcastchannel>BroadcastChannel</a></code> object whose <a href=#channel-name id=broadcasting-to-other-browsing-contexts:channel-name>channel
  name</a> is the constructor's first argument, whose <a href=#broadcastchannel-settings-object id=broadcasting-to-other-browsing-contexts:broadcastchannel-settings-object><code>BroadcastChannel</code>
  settings object</a> is the <a id=broadcasting-to-other-browsing-contexts:incumbent-settings-object href=webappapis.html#incumbent-settings-object>incumbent settings object</a>, and whose <a href=#concept-broadcastchannel-closed id=broadcasting-to-other-browsing-contexts:concept-broadcastchannel-closed>closed flag</a> is false.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/BroadcastChannel/name title="The read-only BroadcastChannel.name property returns a DOMString, which uniquely identifies the given channel with its name. This name is passed to the BroadcastChannel() constructor at creation time and is therefore read-only.">BroadcastChannel/name</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>38+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>54+</span></span><hr><span class="opera yes"><span>Opera</span><span>41+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android unknown"><span>Firefox Android</span><span>?</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>54+</span></span><span class="webview_android yes"><span>WebView Android</span><span>54+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>41+</span></span></div></div></aside><p>The <dfn id=dom-broadcastchannel-name><code>name</code></dfn> attribute must return the
  <a href=#channel-name id=broadcasting-to-other-browsing-contexts:channel-name-2>channel name</a>.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/BroadcastChannel/postMessage title="The BroadcastChannel.postMessage() sends a message, which can be of any kind of Object, to each listener in any browsing context with the same origin. The message is transmitted as a message event targeted at each BroadcastChannel bound to the channel.">BroadcastChannel/postMessage</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>38+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>54+</span></span><hr><span class="opera yes"><span>Opera</span><span>41+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android unknown"><span>Firefox Android</span><span>?</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>54+</span></span><span class="webview_android yes"><span>WebView Android</span><span>54+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>41+</span></span></div></div></aside><p>The <dfn id=dom-broadcastchannel-postmessage><code>postMessage(<var>message</var>)</code></dfn> method,
  when invoked on a <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-6><a href=#broadcastchannel>BroadcastChannel</a></code> object, must run the following steps:</p>

  <ol><li><p>Let <var>source</var> be this <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-7><a href=#broadcastchannel>BroadcastChannel</a></code>.<li><p>Let <var>sourceSettings</var> be <var>source</var>'s <a href=#broadcastchannel-settings-object id=broadcasting-to-other-browsing-contexts:broadcastchannel-settings-object-2><code>BroadcastChannel</code>
   settings object</a>.<li><p>If <var>source</var>'s <a href=#concept-broadcastchannel-closed id=broadcasting-to-other-browsing-contexts:concept-broadcastchannel-closed-2>closed flag</a>
   is true, then throw an <a id=broadcasting-to-other-browsing-contexts:invalidstateerror href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=broadcasting-to-other-browsing-contexts:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>sourceChannel</var> be <var>source</var>'s <a href=#channel-name id=broadcasting-to-other-browsing-contexts:channel-name-3>channel name</a>.<li><p>Let <var>targetRealm</var> be a user-agent defined Realm.<li><p>Let <var>serialized</var> be <a id=broadcasting-to-other-browsing-contexts:structuredserialize href=structured-data.html#structuredserialize>StructuredSerialize</a>(<var>message</var>). Rethrow
   any exceptions.<li>
    <p>Let <var>destinations</var> be a list of <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-8><a href=#broadcastchannel>BroadcastChannel</a></code> objects that
    match the following criteria:</p>

    <ul><li>
      <p>Their <a href=#broadcastchannel-settings-object id=broadcasting-to-other-browsing-contexts:broadcastchannel-settings-object-3><code>BroadcastChannel</code> settings object</a> specifies either:</p>

      <ul><li><p>a <a href=webappapis.html#concept-settings-object-global id=broadcasting-to-other-browsing-contexts:concept-settings-object-global>global object</a> that is a
       <code id=broadcasting-to-other-browsing-contexts:window><a href=window-object.html#window>Window</a></code> object whose <a href=window-object.html#concept-document-window id=broadcasting-to-other-browsing-contexts:concept-document-window>associated
       <code>Document</code></a> is <a id=broadcasting-to-other-browsing-contexts:fully-active href=browsers.html#fully-active>fully active</a>, or<li><p>a <a href=webappapis.html#concept-settings-object-global id=broadcasting-to-other-browsing-contexts:concept-settings-object-global-2>global object</a> that is a
       <code id=broadcasting-to-other-browsing-contexts:workerglobalscope><a href=workers.html#workerglobalscope>WorkerGlobalScope</a></code> object whose <a href=workers.html#dom-workerglobalscope-closing id=broadcasting-to-other-browsing-contexts:dom-workerglobalscope-closing>closing</a> flag is false and whose
       <a id=broadcasting-to-other-browsing-contexts:worker href=workers.html#worker>worker</a> is not a <a id=broadcasting-to-other-browsing-contexts:suspendable-worker href=workers.html#suspendable-worker>suspendable worker</a>.</ul>
     <li><p>Their <a href=#broadcastchannel-settings-object id=broadcasting-to-other-browsing-contexts:broadcastchannel-settings-object-4><code>BroadcastChannel</code> settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=broadcasting-to-other-browsing-contexts:concept-settings-object-origin>origin</a> is <a id=broadcasting-to-other-browsing-contexts:same-origin href=origin.html#same-origin>same origin</a> with
     <var>sourceSettings</var>'s <a href=webappapis.html#concept-settings-object-origin id=broadcasting-to-other-browsing-contexts:concept-settings-object-origin-2>origin</a>.<li><p>Their <a href=#channel-name id=broadcasting-to-other-browsing-contexts:channel-name-4>channel name</a> is a <a id=broadcasting-to-other-browsing-contexts:case-sensitive href=infrastructure.html#case-sensitive>case-sensitive</a> match for
     <var>sourceChannel</var>.</ul>
   <li><p>Remove <var>source</var> from <var>destinations</var>.<li><p>Sort <var>destinations</var> such that all <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-9><a href=#broadcastchannel>BroadcastChannel</a></code> objects whose
   <a href=#broadcastchannel-settings-object id=broadcasting-to-other-browsing-contexts:broadcastchannel-settings-object-5><code>BroadcastChannel</code> settings
   objects</a> specify the same <a id=broadcasting-to-other-browsing-contexts:responsible-event-loop href=webappapis.html#responsible-event-loop>responsible event loop</a> are sorted in creation
   order, oldest first. (This does not define a complete ordering. Within this constraint, user
   agents may sort the list in any user-agent defined manner.)<li>
    <p>For each <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-10><a href=#broadcastchannel>BroadcastChannel</a></code> object <var>destination</var> in
    <var>destinations</var>, <a id=broadcasting-to-other-browsing-contexts:queue-a-task href=webappapis.html#queue-a-task>queue a task</a> on the <a id=broadcasting-to-other-browsing-contexts:dom-manipulation-task-source href=webappapis.html#dom-manipulation-task-source>DOM manipulation task
    source</a> of <var>destination</var>'s <a id=broadcasting-to-other-browsing-contexts:relevant-agent href=webappapis.html#relevant-agent>relevant agent</a>'s <a href=webappapis.html#concept-agent-event-loop id=broadcasting-to-other-browsing-contexts:concept-agent-event-loop>event loop</a> that runs the following steps. If that event
    loop is a <a id=broadcasting-to-other-browsing-contexts:window-event-loop href=webappapis.html#window-event-loop>window event loop</a>, then the <a href=webappapis.html#concept-task id=broadcasting-to-other-browsing-contexts:concept-task>task</a>'s
    <a href=webappapis.html#concept-task-document id=broadcasting-to-other-browsing-contexts:concept-task-document>document</a> must be set to <var>destination</var>'s
    <a href=#broadcastchannel-settings-object id=broadcasting-to-other-browsing-contexts:broadcastchannel-settings-object-6><code>BroadcastChannel</code> settings object</a>'s <a id=broadcasting-to-other-browsing-contexts:responsible-document href=webappapis.html#responsible-document>responsible document</a>.</p>

    <ol><li><p>If <var>destination</var>'s <a href=#concept-broadcastchannel-closed id=broadcasting-to-other-browsing-contexts:concept-broadcastchannel-closed-3>closed
     flag</a> is true, then return.<li><p>Let <var>targetRealm</var> be <var>destination</var>'s <a href=webappapis.html#concept-relevant-realm id=broadcasting-to-other-browsing-contexts:concept-relevant-realm>relevant Realm</a>.<li>
      <p>Let <var>data</var> be <a id=broadcasting-to-other-browsing-contexts:structureddeserialize href=structured-data.html#structureddeserialize>StructuredDeserialize</a>(<var>serialized</var>,
      <var>targetRealm</var>).</p>

      <p>If this throws an exception, catch it, <a href=https://dom.spec.whatwg.org/#concept-event-fire id=broadcasting-to-other-browsing-contexts:concept-event-fire data-x-internal=concept-event-fire>fire an
      event</a> named <code id=broadcasting-to-other-browsing-contexts:event-messageerror><a href=indices.html#event-messageerror>messageerror</a></code> at
      <var>destination</var>, using <code id=broadcasting-to-other-browsing-contexts:messageevent><a href=comms.html#messageevent>MessageEvent</a></code>, with the <code id=broadcasting-to-other-browsing-contexts:dom-messageevent-origin><a href=comms.html#dom-messageevent-origin>origin</a></code> attribute initialized to the <a href=origin.html#ascii-serialisation-of-an-origin id=broadcasting-to-other-browsing-contexts:ascii-serialisation-of-an-origin>serialization</a> of <var>sourceSettings</var>'s <a href=webappapis.html#concept-settings-object-origin id=broadcasting-to-other-browsing-contexts:concept-settings-object-origin-3>origin</a>, and then return.</p>
     <li><p><a href=https://dom.spec.whatwg.org/#concept-event-fire id=broadcasting-to-other-browsing-contexts:concept-event-fire-2 data-x-internal=concept-event-fire>Fire an event</a> named <code id=broadcasting-to-other-browsing-contexts:event-message><a href=indices.html#event-message>message</a></code> at <var>destination</var>, using
     <code id=broadcasting-to-other-browsing-contexts:messageevent-2><a href=comms.html#messageevent>MessageEvent</a></code>, with the <code id=broadcasting-to-other-browsing-contexts:dom-messageevent-data><a href=comms.html#dom-messageevent-data>data</a></code> attribute
     initialized to <var>data</var> and the <code id=broadcasting-to-other-browsing-contexts:dom-messageevent-origin-2><a href=comms.html#dom-messageevent-origin>origin</a></code>
     attribute initialized to the <a href=origin.html#ascii-serialisation-of-an-origin id=broadcasting-to-other-browsing-contexts:ascii-serialisation-of-an-origin-2>serialization</a> of
     <var>sourceSettings</var>'s <a href=webappapis.html#concept-settings-object-origin id=broadcasting-to-other-browsing-contexts:concept-settings-object-origin-4>origin</a>.</ol>
   </ol>

  <p>While a <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-11><a href=#broadcastchannel>BroadcastChannel</a></code> object whose <a href=#concept-broadcastchannel-closed id=broadcasting-to-other-browsing-contexts:concept-broadcastchannel-closed-4>closed flag</a> is false has an event listener
  registered for <code id=broadcasting-to-other-browsing-contexts:event-message-2><a href=indices.html#event-message>message</a></code> events, there must be a strong
  reference from <a href=webappapis.html#concept-settings-object-global id=broadcasting-to-other-browsing-contexts:concept-settings-object-global-3>global object</a> specified by
  the <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-12><a href=#broadcastchannel>BroadcastChannel</a></code> object's <a href=#broadcastchannel-settings-object id=broadcasting-to-other-browsing-contexts:broadcastchannel-settings-object-7><code>BroadcastChannel</code> settings
  object</a> to the <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-13><a href=#broadcastchannel>BroadcastChannel</a></code> object itself.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/BroadcastChannel/close title="The BroadcastChannel.close() terminates the connection to the underlying channel, allowing the object to be garbage collected. This is a necessary step to perform as there is no other way for a browser to know that this channel is not needed anymore.">BroadcastChannel/close</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>38+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>54+</span></span><hr><span class="opera yes"><span>Opera</span><span>41+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android unknown"><span>Firefox Android</span><span>?</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>54+</span></span><span class="webview_android yes"><span>WebView Android</span><span>54+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>41+</span></span></div></div></aside><p>The <dfn id=dom-broadcastchannel-close><code>close()</code></dfn> method must set the
  <a href=#concept-broadcastchannel-closed id=broadcasting-to-other-browsing-contexts:concept-broadcastchannel-closed-5>closed flag</a> of the
  <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-14><a href=#broadcastchannel>BroadcastChannel</a></code> object on which it was invoked to true.</p>

  <p class=note>Authors are strongly encouraged to explicitly close <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-15><a href=#broadcastchannel>BroadcastChannel</a></code>
  objects when they are no longer needed, so that they can be garbage collected. Creating many
  <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-16><a href=#broadcastchannel>BroadcastChannel</a></code> objects and discarding them while leaving them with an event
  listener and without closing them can lead to an apparent memory leak, since the objects will
  continue to live for as long as they have an event listener (or until their page or worker is
  closed).</p>

  <hr>

  <p>The following are the <a id=broadcasting-to-other-browsing-contexts:event-handlers href=webappapis.html#event-handlers>event handlers</a> (and their corresponding <a href=webappapis.html#event-handler-event-type id=broadcasting-to-other-browsing-contexts:event-handler-event-type>event handler event types</a>) that must be supported,
  as <a id=broadcasting-to-other-browsing-contexts:event-handler-idl-attributes href=webappapis.html#event-handler-idl-attributes>event handler IDL attributes</a>, by all objects implementing the
  <code id=broadcasting-to-other-browsing-contexts:broadcastchannel-17><a href=#broadcastchannel>BroadcastChannel</a></code> interface:</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/BroadcastChannel/onmessage title="The BroadcastChannel.onmessage event handler is a property that specifies the function to execute when a message event, of type MessageEvent, is received by this BroadcastChannel. Such an event is sent by the browser with a message broadcasted to the channel.">BroadcastChannel/onmessage</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>38+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>54+</span></span><hr><span class="opera yes"><span>Opera</span><span>41+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android unknown"><span>Firefox Android</span><span>?</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>54+</span></span><span class="webview_android yes"><span>WebView Android</span><span>54+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>41+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/BroadcastChannel/onmessageerror title="The onmessageerror event handler of the BroadcastChannel interface is an EventListener, called whenever an MessageEvent of type messageerror is fired on the BroadcastChannel instance — that is, when it receives a message that cannot be deserialized.">BroadcastChannel/onmessageerror</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>57+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>60+</span></span><hr><span class="opera yes"><span>Opera</span><span>47+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android unknown"><span>Firefox Android</span><span>?</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>60+</span></span><span class="webview_android yes"><span>WebView Android</span><span>60+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>8.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>44+</span></span></div></div></aside><table><thead><tr><th><a href=webappapis.html#event-handlers id=broadcasting-to-other-browsing-contexts:event-handlers-2>Event handler</a> <th><a id=broadcasting-to-other-browsing-contexts:event-handler-event-type-2 href=webappapis.html#event-handler-event-type>Event handler event type</a>
   <tbody><tr><td><dfn id=handler-broadcastchannel-onmessage><code>onmessage</code></dfn> <td> <code id=broadcasting-to-other-browsing-contexts:event-message-3><a href=indices.html#event-message>message</a></code>
    <tr><td><dfn id=handler-broadcastchannel-onmessageerror><code>onmessageerror</code></dfn> <td> <code id=broadcasting-to-other-browsing-contexts:event-messageerror-2><a href=indices.html#event-messageerror>messageerror</a></code>
  </table>

  

  <div class=example>

   <p>Suppose a page wants to know when the user logs out, even when the user does so from another
   tab at the same site:</p>

   <pre><code class='js'><c- a>var</c-> authChannel <c- o>=</c-> <c- k>new</c-> BroadcastChannel<c- p>(</c-><c- t>&apos;auth&apos;</c-><c- p>);</c->
authChannel<c- p>.</c->onmessage <c- o>=</c-> <c- a>function</c-> <c- p>(</c->event<c- p>)</c-> <c- p>{</c->
  <c- k>if</c-> <c- p>(</c->event<c- p>.</c->data <c- o>==</c-> <c- t>&apos;logout&apos;</c-><c- p>)</c->
    showLogout<c- p>();</c->
<c- p>}</c->

<c- a>function</c-> logoutRequested<c- p>()</c-> <c- p>{</c->
  <c- c1>// called when the user asks us to log them out</c->
  doLogout<c- p>();</c->
  showLogout<c- p>();</c->
  authChannel<c- p>.</c->postMessage<c- p>(</c-><c- t>&apos;logout&apos;</c-><c- p>);</c->
<c- p>}</c->

<c- a>function</c-> doLogout<c- p>()</c-> <c- p>{</c->
  <c- c1>// actually log the user out (e.g. clearing cookies)</c->
  <c- c1>// ...</c->
<c- p>}</c->

<c- a>function</c-> showLogout<c- p>()</c-> <c- p>{</c->
  <c- c1>// update the UI to indicate we&apos;re logged out</c->
  <c- c1>// ...</c->
<c- p>}</c-></code></pre>

  </div>





  <nav><a href=web-sockets.html>← 9.3 Web sockets</a> — <a href=./>Table of Contents</a> — <a href=workers.html>10 Web workers →</a></nav>