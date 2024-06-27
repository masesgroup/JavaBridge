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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*/

package org.mases.jnet.generated.javax.swing.event;

public final class InternalFrameAdapter extends org.mases.jcobridge.JCListener implements javax.swing.event.InternalFrameListener {
    public InternalFrameAdapter(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void internalFrameActivated(javax.swing.event.InternalFrameEvent arg0) {
        raiseEvent("internalFrameActivated", arg0);
    }
    //@Override
    public void internalFrameClosed(javax.swing.event.InternalFrameEvent arg0) {
        raiseEvent("internalFrameClosed", arg0);
    }
    //@Override
    public void internalFrameClosing(javax.swing.event.InternalFrameEvent arg0) {
        raiseEvent("internalFrameClosing", arg0);
    }
    //@Override
    public void internalFrameDeactivated(javax.swing.event.InternalFrameEvent arg0) {
        raiseEvent("internalFrameDeactivated", arg0);
    }
    //@Override
    public void internalFrameDeiconified(javax.swing.event.InternalFrameEvent arg0) {
        raiseEvent("internalFrameDeiconified", arg0);
    }
    //@Override
    public void internalFrameIconified(javax.swing.event.InternalFrameEvent arg0) {
        raiseEvent("internalFrameIconified", arg0);
    }
    //@Override
    public void internalFrameOpened(javax.swing.event.InternalFrameEvent arg0) {
        raiseEvent("internalFrameOpened", arg0);
    }

}