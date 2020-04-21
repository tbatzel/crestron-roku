using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_ROKU_IP
{
    public class UserModuleClass_ROKU_IP : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput KEY_BACK;
        Crestron.Logos.SplusObjects.DigitalInput KEY_HOME;
        Crestron.Logos.SplusObjects.DigitalInput KEY_UP;
        Crestron.Logos.SplusObjects.DigitalInput KEY_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput KEY_LEFT;
        Crestron.Logos.SplusObjects.DigitalInput KEY_RIGHT;
        Crestron.Logos.SplusObjects.DigitalInput KEY_INSTANTREPLAY;
        Crestron.Logos.SplusObjects.DigitalInput KEY_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput KEY_INFO;
        Crestron.Logos.SplusObjects.DigitalInput KEY_REV;
        Crestron.Logos.SplusObjects.DigitalInput KEY_PLAY;
        Crestron.Logos.SplusObjects.DigitalInput KEY_FWD;
        Crestron.Logos.SplusObjects.StringInput LAUNCH_APPID;
        StringParameter ADDRESS;
        SplusTcpClient TCP_ROKU_CLIENT;
        CrestronString G_HOST;
        CrestronString G_ACTION;
        private void CONNECT (  SplusExecutionContext __context__ ) 
            { 
            short STATUS_ERR = 0;
            short STATUS_DISCNT = 0;
            
            
            __context__.SourceCodeLine = 33;
            STATUS_ERR = (short) ( Functions.SocketConnectClient( TCP_ROKU_CLIENT , G_HOST , (ushort)( 8060 ) , (ushort)( 0 ) ) ) ; 
            __context__.SourceCodeLine = 34;
            if ( Functions.TestForTrue  ( ( 0)  ) ) 
                {
                __context__.SourceCodeLine = 34;
                Trace( "Connection Status = {0:d}", (short)STATUS_ERR) ; 
                }
            
            __context__.SourceCodeLine = 36;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUS_ERR < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 38;
                Trace( "Error: SocketConnectClient: Host(server name)") ; 
                __context__.SourceCodeLine = 39;
                if ( Functions.TestForTrue  ( ( 0)  ) ) 
                    {
                    __context__.SourceCodeLine = 39;
                    Trace( "Error: Attempting disconnect") ; 
                    }
                
                __context__.SourceCodeLine = 40;
                STATUS_DISCNT = (short) ( Functions.SocketDisconnectClient( TCP_ROKU_CLIENT ) ) ; 
                __context__.SourceCodeLine = 41;
                if ( Functions.TestForTrue  ( ( 0)  ) ) 
                    {
                    __context__.SourceCodeLine = 41;
                    Trace( "Disconnect Status = {0:d}", (short)STATUS_DISCNT) ; 
                    }
                
                __context__.SourceCodeLine = 42;
                G_ACTION  .UpdateValue ( ""  ) ; 
                } 
            
            
            }
            
        object KEY_BACK_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 54;
                G_ACTION  .UpdateValue ( "POST " + "/keypress/Back"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object KEY_HOME_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 58;
            G_ACTION  .UpdateValue ( "POST " + "/keypress/Home"  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object KEY_UP_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 62;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/Up"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_DOWN_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 66;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/Down"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_LEFT_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 70;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/Left"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_RIGHT_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 74;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/Right"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_INSTANTREPLAY_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 78;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/InstantReplay"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_SELECT_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 82;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/Select"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_INFO_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 86;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/Info"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_REV_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 90;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/Rev"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_PLAY_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 94;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/Play"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_FWD_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 98;
        G_ACTION  .UpdateValue ( "POST " + "/keypress/Fwd"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_BACK_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 103;
        CONNECT (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LAUNCH_APPID_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 108;
        G_ACTION  .UpdateValue ( "POST " + "/launch/" + LAUNCH_APPID  ) ; 
        __context__.SourceCodeLine = 109;
        CONNECT (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TCP_ROKU_CLIENT_OnSocketConnect_14 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short STATUS_ERR = 0;
        
        CrestronString SCMD;
        SCMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
        
        
        __context__.SourceCodeLine = 119;
        SCMD  .UpdateValue ( G_ACTION + " HTTP/1.1" + "\r\n" + "Host: " + G_HOST + "\r\n\r\n"  ) ; 
        __context__.SourceCodeLine = 120;
        if ( Functions.TestForTrue  ( ( 0)  ) ) 
            {
            __context__.SourceCodeLine = 120;
            Trace( "POST Command = {0}", SCMD ) ; 
            }
        
        __context__.SourceCodeLine = 122;
        STATUS_ERR = (short) ( Functions.SocketSend( TCP_ROKU_CLIENT , SCMD ) ) ; 
        __context__.SourceCodeLine = 123;
        if ( Functions.TestForTrue  ( ( 0)  ) ) 
            {
            __context__.SourceCodeLine = 123;
            Trace( "Send Status = {0:d}", (short)STATUS_ERR) ; 
            }
        
        __context__.SourceCodeLine = 125;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUS_ERR < 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 127;
            Trace( "Error: SocketConnect: Host+URL") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object TCP_ROKU_CLIENT_OnSocketReceive_15 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        CrestronString STEMP_STRING;
        STEMP_STRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2000, this );
        
        short STATUS_DISCNT = 0;
        
        
        __context__.SourceCodeLine = 138;
        if ( Functions.TestForTrue  ( ( 0)  ) ) 
            {
            __context__.SourceCodeLine = 138;
            Trace( "Received Len: {0:d}", (ushort)Functions.Length( TCP_ROKU_CLIENT.SocketRxBuf )) ; 
            }
        
        __context__.SourceCodeLine = 139;
        if ( Functions.TestForTrue  ( ( 0)  ) ) 
            {
            __context__.SourceCodeLine = 139;
            Trace( "Received: {0}", TCP_ROKU_CLIENT .  SocketRxBuf ) ; 
            }
        
        __context__.SourceCodeLine = 141;
        Functions.ClearBuffer ( TCP_ROKU_CLIENT .  SocketRxBuf ) ; 
        __context__.SourceCodeLine = 142;
        STATUS_DISCNT = (short) ( Functions.SocketDisconnectClient( TCP_ROKU_CLIENT ) ) ; 
        __context__.SourceCodeLine = 143;
        if ( Functions.TestForTrue  ( ( 0)  ) ) 
            {
            __context__.SourceCodeLine = 143;
            Trace( "Disconnect Status = {0:d}", (short)STATUS_DISCNT) ; 
            }
        
        __context__.SourceCodeLine = 144;
        G_ACTION  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 152;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 153;
        G_HOST  .UpdateValue ( ADDRESS  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    G_HOST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    G_ACTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    TCP_ROKU_CLIENT  = new SplusTcpClient ( 2000, this );
    
    KEY_BACK = new Crestron.Logos.SplusObjects.DigitalInput( KEY_BACK__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_BACK__DigitalInput__, KEY_BACK );
    
    KEY_HOME = new Crestron.Logos.SplusObjects.DigitalInput( KEY_HOME__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_HOME__DigitalInput__, KEY_HOME );
    
    KEY_UP = new Crestron.Logos.SplusObjects.DigitalInput( KEY_UP__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_UP__DigitalInput__, KEY_UP );
    
    KEY_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( KEY_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_DOWN__DigitalInput__, KEY_DOWN );
    
    KEY_LEFT = new Crestron.Logos.SplusObjects.DigitalInput( KEY_LEFT__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_LEFT__DigitalInput__, KEY_LEFT );
    
    KEY_RIGHT = new Crestron.Logos.SplusObjects.DigitalInput( KEY_RIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_RIGHT__DigitalInput__, KEY_RIGHT );
    
    KEY_INSTANTREPLAY = new Crestron.Logos.SplusObjects.DigitalInput( KEY_INSTANTREPLAY__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_INSTANTREPLAY__DigitalInput__, KEY_INSTANTREPLAY );
    
    KEY_SELECT = new Crestron.Logos.SplusObjects.DigitalInput( KEY_SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_SELECT__DigitalInput__, KEY_SELECT );
    
    KEY_INFO = new Crestron.Logos.SplusObjects.DigitalInput( KEY_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_INFO__DigitalInput__, KEY_INFO );
    
    KEY_REV = new Crestron.Logos.SplusObjects.DigitalInput( KEY_REV__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_REV__DigitalInput__, KEY_REV );
    
    KEY_PLAY = new Crestron.Logos.SplusObjects.DigitalInput( KEY_PLAY__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_PLAY__DigitalInput__, KEY_PLAY );
    
    KEY_FWD = new Crestron.Logos.SplusObjects.DigitalInput( KEY_FWD__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_FWD__DigitalInput__, KEY_FWD );
    
    LAUNCH_APPID = new Crestron.Logos.SplusObjects.StringInput( LAUNCH_APPID__AnalogSerialInput__, 12, this );
    m_StringInputList.Add( LAUNCH_APPID__AnalogSerialInput__, LAUNCH_APPID );
    
    ADDRESS = new StringParameter( ADDRESS__Parameter__, this );
    m_ParameterList.Add( ADDRESS__Parameter__, ADDRESS );
    
    
    KEY_BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_0, false ) );
    KEY_HOME.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_HOME_OnPush_1, false ) );
    KEY_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_UP_OnPush_2, false ) );
    KEY_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_DOWN_OnPush_3, false ) );
    KEY_LEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_LEFT_OnPush_4, false ) );
    KEY_RIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_RIGHT_OnPush_5, false ) );
    KEY_INSTANTREPLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_INSTANTREPLAY_OnPush_6, false ) );
    KEY_SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_SELECT_OnPush_7, false ) );
    KEY_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_INFO_OnPush_8, false ) );
    KEY_REV.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_REV_OnPush_9, false ) );
    KEY_PLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_PLAY_OnPush_10, false ) );
    KEY_FWD.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_FWD_OnPush_11, false ) );
    KEY_BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_HOME.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_LEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_RIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_INSTANTREPLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_REV.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_PLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    KEY_FWD.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_12, false ) );
    LAUNCH_APPID.OnSerialChange.Add( new InputChangeHandlerWrapper( LAUNCH_APPID_OnChange_13, false ) );
    TCP_ROKU_CLIENT.OnSocketConnect.Add( new SocketHandlerWrapper( TCP_ROKU_CLIENT_OnSocketConnect_14, false ) );
    TCP_ROKU_CLIENT.OnSocketReceive.Add( new SocketHandlerWrapper( TCP_ROKU_CLIENT_OnSocketReceive_15, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ROKU_IP ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint KEY_BACK__DigitalInput__ = 0;
const uint KEY_HOME__DigitalInput__ = 1;
const uint KEY_UP__DigitalInput__ = 2;
const uint KEY_DOWN__DigitalInput__ = 3;
const uint KEY_LEFT__DigitalInput__ = 4;
const uint KEY_RIGHT__DigitalInput__ = 5;
const uint KEY_INSTANTREPLAY__DigitalInput__ = 6;
const uint KEY_SELECT__DigitalInput__ = 7;
const uint KEY_INFO__DigitalInput__ = 8;
const uint KEY_REV__DigitalInput__ = 9;
const uint KEY_PLAY__DigitalInput__ = 10;
const uint KEY_FWD__DigitalInput__ = 11;
const uint LAUNCH_APPID__AnalogSerialInput__ = 0;
const uint ADDRESS__Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
