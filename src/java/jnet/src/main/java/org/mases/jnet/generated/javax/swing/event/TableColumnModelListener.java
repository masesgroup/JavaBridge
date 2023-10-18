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

package org.mases.jnet.generated.javax.swing.event;

public final class TableColumnModelListener extends org.mases.jcobridge.JCListener implements javax.swing.event.TableColumnModelListener {
    public TableColumnModelListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void columnAdded(javax.swing.event.TableColumnModelEvent arg0) {
        raiseEvent("columnAdded", arg0);
    }
    //@Override
    public void columnMarginChanged(javax.swing.event.ChangeEvent arg0) {
        raiseEvent("columnMarginChanged", arg0);
    }
    //@Override
    public void columnMoved(javax.swing.event.TableColumnModelEvent arg0) {
        raiseEvent("columnMoved", arg0);
    }
    //@Override
    public void columnRemoved(javax.swing.event.TableColumnModelEvent arg0) {
        raiseEvent("columnRemoved", arg0);
    }
    //@Override
    public void columnSelectionChanged(javax.swing.event.ListSelectionEvent arg0) {
        raiseEvent("columnSelectionChanged", arg0);
    }

}