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

package org.mases.jnet.generated.java.util.function;

public final class IntUnaryOperator extends org.mases.jcobridge.JCListener implements java.util.function.IntUnaryOperator {
    public IntUnaryOperator(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public int applyAsInt(int arg0) {
        raiseEvent("applyAsInt", arg0); Object retVal = getReturnData(); return (int)retVal;
    }
    //@Override
    public java.util.function.IntUnaryOperator andThen(java.util.function.IntUnaryOperator arg0) {
        raiseEvent("andThen", arg0); Object retVal = getReturnData(); return (java.util.function.IntUnaryOperator)retVal;
    }
    //@Override
    public java.util.function.IntUnaryOperator compose(java.util.function.IntUnaryOperator arg0) {
        raiseEvent("compose", arg0); Object retVal = getReturnData(); return (java.util.function.IntUnaryOperator)retVal;
    }

}