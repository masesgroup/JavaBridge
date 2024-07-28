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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*/

package org.mases.jnet.generated.javax.swing;

public final class Action extends org.mases.jcobridge.JCListener implements javax.swing.Action {
    public Action(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public boolean isEnabled() {
        raiseEvent("isEnabled"); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public java.lang.Object getValue(java.lang.String arg0) {
        raiseEvent("getValue", arg0); Object retVal = getReturnData(); return (java.lang.Object)retVal;
    }
    //@Override
    public void actionPerformed(java.awt.event.ActionEvent arg0) {
        raiseEvent("actionPerformed", arg0);
    }
    //@Override
    public void addPropertyChangeListener(java.beans.PropertyChangeListener arg0) {
        raiseEvent("addPropertyChangeListener", arg0);
    }
    //@Override
    public void putValue(java.lang.String arg0, java.lang.Object arg1) {
        raiseEvent("putValue", arg0, arg1);
    }
    //@Override
    public void removePropertyChangeListener(java.beans.PropertyChangeListener arg0) {
        raiseEvent("removePropertyChangeListener", arg0);
    }
    //@Override
    public void setEnabled(boolean arg0) {
        raiseEvent("setEnabled", arg0);
    }
    //@Override
    public boolean accept(java.lang.Object arg0) {
        raiseEvent("accept", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean acceptDefault(java.lang.Object arg0) {
        return javax.swing.Action.super.accept(arg0);
    }

}