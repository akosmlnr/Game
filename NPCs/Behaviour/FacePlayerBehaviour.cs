using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000377 RID: 887
	public class FacePlayerBehaviour : Behaviour
	{
		// Token: 0x060042EB RID: 17131 RVA: 0x00150734 File Offset: 0x0014E934
		// Note: this type is marked as 'beforefieldinit'.
		static FacePlayerBehaviour()
		{
			Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FacePlayerBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr);
			FacePlayerBehaviour.NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, "<Player>k__BackingField");
			FacePlayerBehaviour.NativeFieldInfoPtr__Countdown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, "<Countdown>k__BackingField");
			FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FacePlayerBehaviourAssembly-CSharp.dll_Excuted");
			FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FacePlayerBehaviourAssembly-CSharp.dll_Excuted");
			FacePlayerBehaviour.NativeMethodInfoPtr_get_Player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671513);
			FacePlayerBehaviour.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671514);
			FacePlayerBehaviour.NativeMethodInfoPtr_get_Countdown_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671515);
			FacePlayerBehaviour.NativeMethodInfoPtr_set_Countdown_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671516);
			FacePlayerBehaviour.NativeMethodInfoPtr_SetTarget_Public_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671517);
			FacePlayerBehaviour.NativeMethodInfoPtr_SetTargetLocal_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671518);
			FacePlayerBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671519);
			FacePlayerBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671520);
			FacePlayerBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671521);
			FacePlayerBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671522);
			FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671523);
			FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671524);
			FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671525);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTarget_244313061_Private_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671526);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_244313061_Public_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671527);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTarget_244313061_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671528);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671529);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetLocal_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671530);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671531);
			FacePlayerBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671532);
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x00150944 File Offset: 0x0014EB44
		// (set) Token: 0x060042ED RID: 17133 RVA: 0x00150984 File Offset: 0x0014EB84
		public unsafe Player Player
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_get_Player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x001509C8 File Offset: 0x0014EBC8
		// (set) Token: 0x060042EF RID: 17135 RVA: 0x00150A04 File Offset: 0x0014EC04
		public unsafe float Countdown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_get_Countdown_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_set_Countdown_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00150A44 File Offset: 0x0014EC44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156278, RefRangeEnd = 156281, XrefRangeStart = 156255, XrefRangeEnd = 156278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(NetworkObject player, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_SetTarget_Public_Void_NetworkObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00150A94 File Offset: 0x0014EC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156310, RefRangeEnd = 156311, XrefRangeStart = 156281, XrefRangeEnd = 156310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetLocal(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_SetTargetLocal_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x00150AD8 File Offset: 0x0014ECD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156311, XrefRangeEnd = 156315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00150B14 File Offset: 0x0014ED14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156315, XrefRangeEnd = 156325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00150B50 File Offset: 0x0014ED50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00150B8C File Offset: 0x0014ED8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FacePlayerBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00150BC8 File Offset: 0x0014EDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156325, XrefRangeEnd = 156340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x00150C04 File Offset: 0x0014EE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156340, XrefRangeEnd = 156341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00150C40 File Offset: 0x0014EE40
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x00150C7C File Offset: 0x0014EE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156341, XrefRangeEnd = 156352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTarget_244313061_Private_Void_NetworkObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x00150CCC File Offset: 0x0014EECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156370, RefRangeEnd = 156372, XrefRangeStart = 156352, XrefRangeEnd = 156370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_244313061_Public_Void_NetworkObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x00150D1C File Offset: 0x0014EF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156372, XrefRangeEnd = 156377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetTarget_244313061(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTarget_244313061_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00150D80 File Offset: 0x0014EF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156377, XrefRangeEnd = 156387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTargetLocal_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00150DC4 File Offset: 0x0014EFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156387, XrefRangeEnd = 156397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTargetLocal_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetLocal_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00150E08 File Offset: 0x0014F008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156397, XrefRangeEnd = 156408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTargetLocal_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00150E58 File Offset: 0x0014F058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00020C34 File Offset: 0x0001EE34
		public FacePlayerBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06004301 RID: 17153 RVA: 0x00150E94 File Offset: 0x0014F094
		// (set) Token: 0x06004302 RID: 17154 RVA: 0x00020C3D File Offset: 0x0001EE3D
		public unsafe Player _Player_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr__Player_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06004303 RID: 17155 RVA: 0x00150EC4 File Offset: 0x0014F0C4
		// (set) Token: 0x06004304 RID: 17156 RVA: 0x00020C5C File Offset: 0x0001EE5C
		public unsafe float _Countdown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr__Countdown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr__Countdown_k__BackingField)) = value;
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x00150EEC File Offset: 0x0014F0EC
		// (set) Token: 0x06004306 RID: 17158 RVA: 0x00020C77 File Offset: 0x0001EE77
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x00150F14 File Offset: 0x0014F114
		// (set) Token: 0x06004308 RID: 17160 RVA: 0x00020C92 File Offset: 0x0001EE92
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002CAA RID: 11434
		private static readonly IntPtr NativeFieldInfoPtr__Player_k__BackingField;

		// Token: 0x04002CAB RID: 11435
		private static readonly IntPtr NativeFieldInfoPtr__Countdown_k__BackingField;

		// Token: 0x04002CAC RID: 11436
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002CAD RID: 11437
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002CAE RID: 11438
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_Player_0;

		// Token: 0x04002CAF RID: 11439
		private static readonly IntPtr NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0;

		// Token: 0x04002CB0 RID: 11440
		private static readonly IntPtr NativeMethodInfoPtr_get_Countdown_Public_get_Single_0;

		// Token: 0x04002CB1 RID: 11441
		private static readonly IntPtr NativeMethodInfoPtr_set_Countdown_Private_set_Void_Single_0;

		// Token: 0x04002CB2 RID: 11442
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_NetworkObject_Single_0;

		// Token: 0x04002CB3 RID: 11443
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetLocal_Private_Void_NetworkObject_0;

		// Token: 0x04002CB4 RID: 11444
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002CB5 RID: 11445
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002CB6 RID: 11446
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002CB7 RID: 11447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CB8 RID: 11448
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002CB9 RID: 11449
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002CBA RID: 11450
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002CBB RID: 11451
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetTarget_244313061_Private_Void_NetworkObject_Single_0;

		// Token: 0x04002CBC RID: 11452
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTarget_244313061_Public_Void_NetworkObject_Single_0;

		// Token: 0x04002CBD RID: 11453
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetTarget_244313061_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002CBE RID: 11454
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002CBF RID: 11455
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTargetLocal_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002CC0 RID: 11456
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002CC1 RID: 11457
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
