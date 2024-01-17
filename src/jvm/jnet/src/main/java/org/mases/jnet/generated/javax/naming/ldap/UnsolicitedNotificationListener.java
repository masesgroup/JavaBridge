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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*/

package org.mases.jnet.generated.javax.naming.ldap;

public final class UnsolicitedNotificationListener extends org.mases.jcobridge.JCListener implements javax.naming.ldap.UnsolicitedNotificationListener {
    public UnsolicitedNotificationListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void namingExceptionThrown(javax.naming.event.NamingExceptionEvent arg0) {
        raiseEvent("namingExceptionThrown", arg0);
    }
    //@Override
    public void notificationReceived(javax.naming.ldap.UnsolicitedNotificationEvent arg0) {
        raiseEvent("notificationReceived", arg0);
    }

}