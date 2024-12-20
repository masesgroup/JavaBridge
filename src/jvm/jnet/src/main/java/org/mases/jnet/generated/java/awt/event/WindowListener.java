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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*/

package org.mases.jnet.generated.java.awt.event;

public final class WindowListener implements org.mases.jcobridge.IJCListener, java.awt.event.WindowListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public WindowListener(String key) throws org.mases.jcobridge.JCNativeException {
        super();
        _internalListener = new org.mases.jcobridge.JCListener(key);
    }

    public synchronized void release() {
       _internalListener.release();
    }
    
    public synchronized void raiseEvent(String eventName) {
       _internalListener.raiseEvent(eventName);
    }
    
    public synchronized void raiseEvent(String eventName, Object e) {
       _internalListener.raiseEvent(eventName, e);
    }
    
    public synchronized void raiseEvent(String eventName, Object e, Object... objects) {
       _internalListener.raiseEvent(eventName, e, objects);
    }
    
    public Object getEventData() {
       return _internalListener.getEventData();
    }
    
    public boolean hasExtraData() {
       return _internalListener.hasExtraData();
    }
    
    public int extraDataLength() {
       return _internalListener.extraDataLength();
    }
    
    public Object[] extraData() {
       return _internalListener.extraData();
    }
    
    public Object getReturnData() {
       return _internalListener.getReturnData();
    }
    
    public void setReturnData(Object retData) {
       _internalListener.setReturnData(retData);
    }

    //@Override
    public void windowActivated(java.awt.event.WindowEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("windowActivated", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void windowClosed(java.awt.event.WindowEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("windowClosed", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void windowClosing(java.awt.event.WindowEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("windowClosing", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void windowDeactivated(java.awt.event.WindowEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("windowDeactivated", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void windowDeiconified(java.awt.event.WindowEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("windowDeiconified", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void windowIconified(java.awt.event.WindowEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("windowIconified", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void windowOpened(java.awt.event.WindowEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("windowOpened", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }

}