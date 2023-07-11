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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*/

package org.mases.jnet.generated.java.awt.dnd;

public final class DropTargetListener extends org.mases.jcobridge.JCListener implements java.awt.dnd.DropTargetListener {
    public DropTargetListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void dragEnter(java.awt.dnd.DropTargetDragEvent arg0) {
        raiseEvent("dragEnter", arg0);
    }
    //@Override
    public void dragExit(java.awt.dnd.DropTargetEvent arg0) {
        raiseEvent("dragExit", arg0);
    }
    //@Override
    public void dragOver(java.awt.dnd.DropTargetDragEvent arg0) {
        raiseEvent("dragOver", arg0);
    }
    //@Override
    public void drop(java.awt.dnd.DropTargetDropEvent arg0) {
        raiseEvent("drop", arg0);
    }
    //@Override
    public void dropActionChanged(java.awt.dnd.DropTargetDragEvent arg0) {
        raiseEvent("dropActionChanged", arg0);
    }

}