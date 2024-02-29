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

package org.mases.jnet.generated.javax.print.event;

public final class PrintJobListener extends org.mases.jcobridge.JCListener implements javax.print.event.PrintJobListener {
    public PrintJobListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void printDataTransferCompleted(javax.print.event.PrintJobEvent arg0) {
        raiseEvent("printDataTransferCompleted", arg0);
    }
    //@Override
    public void printJobCanceled(javax.print.event.PrintJobEvent arg0) {
        raiseEvent("printJobCanceled", arg0);
    }
    //@Override
    public void printJobCompleted(javax.print.event.PrintJobEvent arg0) {
        raiseEvent("printJobCompleted", arg0);
    }
    //@Override
    public void printJobFailed(javax.print.event.PrintJobEvent arg0) {
        raiseEvent("printJobFailed", arg0);
    }
    //@Override
    public void printJobNoMoreEvents(javax.print.event.PrintJobEvent arg0) {
        raiseEvent("printJobNoMoreEvents", arg0);
    }
    //@Override
    public void printJobRequiresAttention(javax.print.event.PrintJobEvent arg0) {
        raiseEvent("printJobRequiresAttention", arg0);
    }

}