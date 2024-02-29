/*
 *  Copyright 2024 MASES s.r.l.
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 *  Refer to LICENSE for more information.
 */

/*
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*/

package org.mases.jnet.generated.org.xml.sax.helpers;

public final class XMLReaderAdapter extends org.mases.jcobridge.JCListener implements org.xml.sax.Parser, org.xml.sax.ContentHandler {
    public XMLReaderAdapter(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void characters(char[] arg0, int arg1, int arg2) {
        raiseEvent("characters", arg0, arg1, arg2);
    }
    //@Override
    public void endDocument() {
        raiseEvent("endDocument");
    }
    //@Override
    public void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) {
        raiseEvent("endElement", arg0, arg1, arg2);
    }
    //@Override
    public void endPrefixMapping(java.lang.String arg0) {
        raiseEvent("endPrefixMapping", arg0);
    }
    //@Override
    public void ignorableWhitespace(char[] arg0, int arg1, int arg2) {
        raiseEvent("ignorableWhitespace", arg0, arg1, arg2);
    }
    //@Override
    public void parse(java.lang.String arg0) {
        raiseEvent("parse", arg0);
    }
    //@Override
    public void parse(org.xml.sax.InputSource arg0) {
        raiseEvent("parse1", arg0);
    }
    //@Override
    public void processingInstruction(java.lang.String arg0, java.lang.String arg1) {
        raiseEvent("processingInstruction", arg0, arg1);
    }
    //@Override
    public void setDocumentHandler(org.xml.sax.DocumentHandler arg0) {
        raiseEvent("setDocumentHandler", arg0);
    }
    //@Override
    public void setDocumentLocator(org.xml.sax.Locator arg0) {
        raiseEvent("setDocumentLocator", arg0);
    }
    //@Override
    public void setDTDHandler(org.xml.sax.DTDHandler arg0) {
        raiseEvent("setDTDHandler", arg0);
    }
    //@Override
    public void setEntityResolver(org.xml.sax.EntityResolver arg0) {
        raiseEvent("setEntityResolver", arg0);
    }
    //@Override
    public void setErrorHandler(org.xml.sax.ErrorHandler arg0) {
        raiseEvent("setErrorHandler", arg0);
    }
    //@Override
    public void setLocale(java.util.Locale arg0) {
        raiseEvent("setLocale", arg0);
    }
    //@Override
    public void skippedEntity(java.lang.String arg0) {
        raiseEvent("skippedEntity", arg0);
    }
    //@Override
    public void startDocument() {
        raiseEvent("startDocument");
    }
    //@Override
    public void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) {
        raiseEvent("startElement", arg0, arg1, arg2, arg3);
    }
    //@Override
    public void startPrefixMapping(java.lang.String arg0, java.lang.String arg1) {
        raiseEvent("startPrefixMapping", arg0, arg1);
    }

}