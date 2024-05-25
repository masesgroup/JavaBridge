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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*/

package org.mases.jnet.generated.java.awt.event;

public final class WindowAdapter extends org.mases.jcobridge.JCListener implements java.awt.event.WindowListener, java.awt.event.WindowStateListener, java.awt.event.WindowFocusListener {
    public WindowAdapter(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void windowActivated(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowActivated", arg0);
    }
    //@Override
    public void windowClosed(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowClosed", arg0);
    }
    //@Override
    public void windowClosing(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowClosing", arg0);
    }
    //@Override
    public void windowDeactivated(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowDeactivated", arg0);
    }
    //@Override
    public void windowDeiconified(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowDeiconified", arg0);
    }
    //@Override
    public void windowGainedFocus(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowGainedFocus", arg0);
    }
    //@Override
    public void windowIconified(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowIconified", arg0);
    }
    //@Override
    public void windowLostFocus(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowLostFocus", arg0);
    }
    //@Override
    public void windowOpened(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowOpened", arg0);
    }
    //@Override
    public void windowStateChanged(java.awt.event.WindowEvent arg0) {
        raiseEvent("windowStateChanged", arg0);
    }

}