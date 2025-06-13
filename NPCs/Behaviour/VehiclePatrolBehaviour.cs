using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.AI;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000387 RID: 903
	public class VehiclePatrolBehaviour : Behaviour
	{
		// Token: 0x0600454F RID: 17743 RVA: 0x00158D50 File Offset: 0x00156F50
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolBehaviour()
		{
			Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "VehiclePatrolBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr);
			VehiclePatrolBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_PROGRESSION_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "PROGRESSION_THRESHOLD");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_CurrentWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "CurrentWaypoint");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "Route");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_Vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "Vehicle");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "aggressiveDrivingEnabled");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "consecutivePathingFailures");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePatrolBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671851);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671852);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671853);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671854);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671855);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671856);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671857);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_SetRoute_Public_Void_VehiclePatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671858);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_StartPatrol_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671859);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671860);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671861);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671862);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671863);
			VehiclePatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671864);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671865);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671866);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671867);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671868);
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06004550 RID: 17744 RVA: 0x00158F9C File Offset: 0x0015719C
		public unsafe bool isDriving
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159340, XrefRangeEnd = 159347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06004551 RID: 17745 RVA: 0x00158FD8 File Offset: 0x001571D8
		public unsafe VehicleAgent Agent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
			}
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00159018 File Offset: 0x00157218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00159054 File Offset: 0x00157254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159347, XrefRangeEnd = 159349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00159090 File Offset: 0x00157290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159349, XrefRangeEnd = 159351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x001590CC File Offset: 0x001572CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159351, XrefRangeEnd = 159362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00159108 File Offset: 0x00157308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159362, XrefRangeEnd = 159373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00159144 File Offset: 0x00157344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118585, RefRangeEnd = 118586, XrefRangeStart = 118585, XrefRangeEnd = 118586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRoute(VehiclePatrolRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_SetRoute_Public_Void_VehiclePatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00159188 File Offset: 0x00157388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159397, RefRangeEnd = 159399, XrefRangeStart = 159373, XrefRangeEnd = 159397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_StartPatrol_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x001591BC File Offset: 0x001573BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159399, XrefRangeEnd = 159408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x001591F8 File Offset: 0x001573F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159416, RefRangeEnd = 159417, XrefRangeStart = 159408, XrefRangeEnd = 159416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DriveTo(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00159238 File Offset: 0x00157438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159417, XrefRangeEnd = 159420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NavigationCallback(VehicleAgent.ENavigationResult status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x00159278 File Offset: 0x00157478
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 159428, RefRangeEnd = 159431, XrefRangeStart = 159420, XrefRangeEnd = 159428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPosition;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x001592D0 File Offset: 0x001574D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159431, XrefRangeEnd = 159432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x0015930C File Offset: 0x0015750C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159432, XrefRangeEnd = 159433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x00159348 File Offset: 0x00157548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x00159384 File Offset: 0x00157584
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x001593C0 File Offset: 0x001575C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00021AD3 File Offset: 0x0001FCD3
		public VehiclePatrolBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x001593FC File Offset: 0x001575FC
		// (set) Token: 0x06004564 RID: 17764 RVA: 0x00021ADC File Offset: 0x0001FCDC
		public new unsafe static float MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePatrolBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePatrolBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06004565 RID: 17765 RVA: 0x00159418 File Offset: 0x00157618
		// (set) Token: 0x06004566 RID: 17766 RVA: 0x00021AEA File Offset: 0x0001FCEA
		public unsafe static float PROGRESSION_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePatrolBehaviour.NativeFieldInfoPtr_PROGRESSION_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePatrolBehaviour.NativeFieldInfoPtr_PROGRESSION_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06004567 RID: 17767 RVA: 0x00159434 File Offset: 0x00157634
		// (set) Token: 0x06004568 RID: 17768 RVA: 0x00021AF8 File Offset: 0x0001FCF8
		public unsafe int CurrentWaypoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_CurrentWaypoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_CurrentWaypoint)) = value;
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x0015945C File Offset: 0x0015765C
		// (set) Token: 0x0600456A RID: 17770 RVA: 0x00021B13 File Offset: 0x0001FD13
		public unsafe VehiclePatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x0600456B RID: 17771 RVA: 0x0015948C File Offset: 0x0015768C
		// (set) Token: 0x0600456C RID: 17772 RVA: 0x00021B32 File Offset: 0x0001FD32
		public unsafe LandVehicle Vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_Vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_Vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x0600456D RID: 17773 RVA: 0x001594BC File Offset: 0x001576BC
		// (set) Token: 0x0600456E RID: 17774 RVA: 0x00021B51 File Offset: 0x0001FD51
		public unsafe bool aggressiveDrivingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled)) = value;
			}
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600456F RID: 17775 RVA: 0x001594E4 File Offset: 0x001576E4
		// (set) Token: 0x06004570 RID: 17776 RVA: 0x00021B6C File Offset: 0x0001FD6C
		public new unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x0015950C File Offset: 0x0015770C
		// (set) Token: 0x06004572 RID: 17778 RVA: 0x00021B87 File Offset: 0x0001FD87
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06004573 RID: 17779 RVA: 0x00159534 File Offset: 0x00157734
		// (set) Token: 0x06004574 RID: 17780 RVA: 0x00021BA2 File Offset: 0x0001FDA2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002E63 RID: 11875
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeFieldInfoPtr_PROGRESSION_THRESHOLD;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeFieldInfoPtr_CurrentWaypoint;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeFieldInfoPtr_Vehicle;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeFieldInfoPtr_aggressiveDrivingEnabled;

		// Token: 0x04002E69 RID: 11881
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x04002E6A RID: 11882
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002E6B RID: 11883
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002E6C RID: 11884
		private static readonly IntPtr NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0;

		// Token: 0x04002E6D RID: 11885
		private static readonly IntPtr NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0;

		// Token: 0x04002E6E RID: 11886
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002E6F RID: 11887
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002E70 RID: 11888
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002E71 RID: 11889
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002E72 RID: 11890
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002E73 RID: 11891
		private static readonly IntPtr NativeMethodInfoPtr_SetRoute_Public_Void_VehiclePatrolRoute_0;

		// Token: 0x04002E74 RID: 11892
		private static readonly IntPtr NativeMethodInfoPtr_StartPatrol_Private_Void_0;

		// Token: 0x04002E75 RID: 11893
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002E76 RID: 11894
		private static readonly IntPtr NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0;

		// Token: 0x04002E77 RID: 11895
		private static readonly IntPtr NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0;

		// Token: 0x04002E78 RID: 11896
		private static readonly IntPtr NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0;

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
