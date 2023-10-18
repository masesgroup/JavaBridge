/*
 *  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*/

package org.mases.jnet.generated.org.xml.sax.helpers;

public final class ParserAdapter extends org.mases.jcobridge.JCListener implements org.xml.sax.XMLReader, org.xml.sax.DocumentHandler {
    public ParserAdapter(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public boolean getFeature(java.lang.String arg0) {
        raiseEvent("getFeature", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public java.lang.Object getProperty(java.lang.String arg0) {
        raiseEvent("getProperty", arg0); Object retVal = getReturnData(); return (java.lang.Object)retVal;
    }
    //@Override
    public org.xml.sax.ContentHandler getContentHandler() {
        raiseEvent("getContentHandler"); Object retVal = getReturnData(); return (org.xml.sax.ContentHandler)retVal;
    }
    //@Override
    public org.xml.sax.DTDHandler getDTDHandler() {
        raiseEvent("getDTDHandler"); Object retVal = getReturnData(); return (org.xml.sax.DTDHandler)retVal;
    }
    //@Override
    public org.xml.sax.EntityResolver getEntityResolver() {
        raiseEvent("getEntityResolver"); Object retVal = getReturnData(); return (org.xml.sax.EntityResolver)retVal;
    }
    //@Override
    public org.xml.sax.ErrorHandler getErrorHandler() {
        raiseEvent("getErrorHandler"); Object retVal = getReturnData(); return (org.xml.sax.ErrorHandler)retVal;
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
    public void endElement(java.lang.String arg0) {
        raiseEvent("endElement", arg0);
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
    public void setContentHandler(org.xml.sax.ContentHandler arg0) {
        raiseEvent("setContentHandler", arg0);
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
    public void setFeature(java.lang.String arg0, boolean arg1) {
        raiseEvent("setFeature", arg0, arg1);
    }
    //@Override
    public void setProperty(java.lang.String arg0, java.lang.Object arg1) {
        raiseEvent("setProperty", arg0, arg1);
    }
    //@Override
    public void startDocument() {
        raiseEvent("startDocument");
    }
    //@Override
    public void startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1) {
        raiseEvent("startElement", arg0, arg1);
    }

}