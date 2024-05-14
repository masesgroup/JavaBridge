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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*/

package org.mases.jnet.generated.java.net.http;

public final class Listener extends org.mases.jcobridge.JCListener implements java.net.http.WebSocket.Listener {
    public Listener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public java.util.concurrent.CompletionStage onBinary(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1, boolean arg2) {
        raiseEvent("onBinary", arg0, arg1, arg2); Object retVal = getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onBinaryDefault(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1, boolean arg2) {
        return java.net.http.WebSocket.Listener.super.onBinary(arg0, arg1, arg2);
    }
    //@Override
    public java.util.concurrent.CompletionStage onClose(java.net.http.WebSocket arg0, int arg1, java.lang.String arg2) {
        raiseEvent("onClose", arg0, arg1, arg2); Object retVal = getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onCloseDefault(java.net.http.WebSocket arg0, int arg1, java.lang.String arg2) {
        return java.net.http.WebSocket.Listener.super.onClose(arg0, arg1, arg2);
    }
    //@Override
    public java.util.concurrent.CompletionStage onPing(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1) {
        raiseEvent("onPing", arg0, arg1); Object retVal = getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onPingDefault(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1) {
        return java.net.http.WebSocket.Listener.super.onPing(arg0, arg1);
    }
    //@Override
    public java.util.concurrent.CompletionStage onPong(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1) {
        raiseEvent("onPong", arg0, arg1); Object retVal = getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onPongDefault(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1) {
        return java.net.http.WebSocket.Listener.super.onPong(arg0, arg1);
    }
    //@Override
    public java.util.concurrent.CompletionStage onText(java.net.http.WebSocket arg0, java.lang.CharSequence arg1, boolean arg2) {
        raiseEvent("onText", arg0, arg1, arg2); Object retVal = getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onTextDefault(java.net.http.WebSocket arg0, java.lang.CharSequence arg1, boolean arg2) {
        return java.net.http.WebSocket.Listener.super.onText(arg0, arg1, arg2);
    }
    //@Override
    public void onError(java.net.http.WebSocket arg0, java.lang.Throwable arg1) {
        raiseEvent("onError", arg0, arg1);
    }
    //@Override
    public void onErrorDefault(java.net.http.WebSocket arg0, java.lang.Throwable arg1) {
        java.net.http.WebSocket.Listener.super.onError(arg0, arg1);
    }
    //@Override
    public void onOpen(java.net.http.WebSocket arg0) {
        raiseEvent("onOpen", arg0);
    }
    //@Override
    public void onOpenDefault(java.net.http.WebSocket arg0) {
        java.net.http.WebSocket.Listener.super.onOpen(arg0);
    }

}