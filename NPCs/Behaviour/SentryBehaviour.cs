using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.Police;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000384 RID: 900
	public class SentryBehaviour : Behaviour
	{
		// Token: 0x06004503 RID: 17667 RVA: 0x00157DE8 File Offset: 0x00155FE8
		// Note: this type is marked as 'beforefieldinit'.
		static SentryBehaviour()
		{
			Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "SentryBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr);
			SentryBehaviour.NativeFieldInfoPtr_BODY_SEARCH_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "BODY_SEARCH_CHANCE");
			SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "FLASHLIGHT_MIN_TIME");
			SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "FLASHLIGHT_MAX_TIME");
			SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "FLASHLIGHT_ASSET_PATH");
			SentryBehaviour.NativeFieldInfoPtr_UseFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "UseFlashlight");
			SentryBehaviour.NativeFieldInfoPtr_flashlightEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "flashlightEquipped");
			SentryBehaviour.NativeFieldInfoPtr__AssignedLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "<AssignedLocation>k__BackingField");
			SentryBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "officer");
			SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted");
			SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted");
			SentryBehaviour.NativeMethodInfoPtr_get_AssignedLocation_Public_get_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671817);
			SentryBehaviour.NativeMethodInfoPtr_set_AssignedLocation_Private_set_Void_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671818);
			SentryBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671819);
			SentryBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671820);
			SentryBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671821);
			SentryBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671822);
			SentryBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671823);
			SentryBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671824);
			SentryBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671825);
			SentryBehaviour.NativeMethodInfoPtr_AssignLocation_Public_Void_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671826);
			SentryBehaviour.NativeMethodInfoPtr_UnassignLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671827);
			SentryBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671828);
			SentryBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671829);
			SentryBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671830);
			SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671831);
			SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671832);
			SentryBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671833);
			SentryBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671834);
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x00158048 File Offset: 0x00156248
		// (set) Token: 0x06004505 RID: 17669 RVA: 0x00158088 File Offset: 0x00156288
		public unsafe SentryLocation AssignedLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_get_AssignedLocation_Public_get_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118585, RefRangeEnd = 118586, XrefRangeStart = 118585, XrefRangeEnd = 118586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_set_AssignedLocation_Private_set_Void_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x001580CC File Offset: 0x001562CC
		public unsafe Transform standPoint
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 159191, RefRangeEnd = 159193, XrefRangeStart = 159184, XrefRangeEnd = 159191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x0015810C File Offset: 0x0015630C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159193, XrefRangeEnd = 159200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00158148 File Offset: 0x00156348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00158184 File Offset: 0x00156384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x001581C0 File Offset: 0x001563C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159200, XrefRangeEnd = 159206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x001581FC File Offset: 0x001563FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159206, XrefRangeEnd = 159212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00158238 File Offset: 0x00156438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00158274 File Offset: 0x00156474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159231, RefRangeEnd = 159232, XrefRangeStart = 159212, XrefRangeEnd = 159231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignLocation(SentryLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_AssignLocation_Public_Void_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x001582B8 File Offset: 0x001564B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159240, RefRangeEnd = 159241, XrefRangeStart = 159232, XrefRangeEnd = 159240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_UnassignLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x001582EC File Offset: 0x001564EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159241, XrefRangeEnd = 159276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00158328 File Offset: 0x00156528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159276, XrefRangeEnd = 159284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlashlightEquipped(bool equipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref equipped;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00158368 File Offset: 0x00156568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x001583A4 File Offset: 0x001565A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159284, XrefRangeEnd = 159285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x001583E0 File Offset: 0x001565E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x0015841C File Offset: 0x0015661C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00158458 File Offset: 0x00156658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159285, XrefRangeEnd = 159292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x000218F6 File Offset: 0x0001FAF6
		public SentryBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06004517 RID: 17687 RVA: 0x00158494 File Offset: 0x00156694
		// (set) Token: 0x06004518 RID: 17688 RVA: 0x000218FF File Offset: 0x0001FAFF
		public unsafe static float BODY_SEARCH_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_BODY_SEARCH_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_BODY_SEARCH_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06004519 RID: 17689 RVA: 0x001584B0 File Offset: 0x001566B0
		// (set) Token: 0x0600451A RID: 17690 RVA: 0x0002190D File Offset: 0x0001FB0D
		public unsafe static int FLASHLIGHT_MIN_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&value));
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x001584CC File Offset: 0x001566CC
		// (set) Token: 0x0600451C RID: 17692 RVA: 0x0002191B File Offset: 0x0001FB1B
		public unsafe int FLASHLIGHT_MAX_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME)) = value;
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x0600451D RID: 17693 RVA: 0x001584F4 File Offset: 0x001566F4
		// (set) Token: 0x0600451E RID: 17694 RVA: 0x00021936 File Offset: 0x0001FB36
		public unsafe static string FLASHLIGHT_ASSET_PATH
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x0600451F RID: 17695 RVA: 0x00158514 File Offset: 0x00156714
		// (set) Token: 0x06004520 RID: 17696 RVA: 0x00021948 File Offset: 0x0001FB48
		public unsafe bool UseFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_UseFlashlight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_UseFlashlight)) = value;
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06004521 RID: 17697 RVA: 0x0015853C File Offset: 0x0015673C
		// (set) Token: 0x06004522 RID: 17698 RVA: 0x00021963 File Offset: 0x0001FB63
		public unsafe bool flashlightEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_flashlightEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_flashlightEquipped)) = value;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06004523 RID: 17699 RVA: 0x00158564 File Offset: 0x00156764
		// (set) Token: 0x06004524 RID: 17700 RVA: 0x0002197E File Offset: 0x0001FB7E
		public unsafe SentryLocation _AssignedLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__AssignedLocation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__AssignedLocation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06004525 RID: 17701 RVA: 0x00158594 File Offset: 0x00156794
		// (set) Token: 0x06004526 RID: 17702 RVA: 0x0002199D File Offset: 0x0001FB9D
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06004527 RID: 17703 RVA: 0x001585C4 File Offset: 0x001567C4
		// (set) Token: 0x06004528 RID: 17704 RVA: 0x000219BC File Offset: 0x0001FBBC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06004529 RID: 17705 RVA: 0x001585EC File Offset: 0x001567EC
		// (set) Token: 0x0600452A RID: 17706 RVA: 0x000219D7 File Offset: 0x0001FBD7
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_CHANCE;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME;

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeFieldInfoPtr_UseFlashlight;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeFieldInfoPtr_flashlightEquipped;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeFieldInfoPtr__AssignedLocation_k__BackingField;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedLocation_Public_get_SentryLocation_0;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedLocation_Private_set_Void_SentryLocation_0;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0;

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002E42 RID: 11842
		private static readonly IntPtr NativeMethodInfoPtr_AssignLocation_Public_Void_SentryLocation_0;

		// Token: 0x04002E43 RID: 11843
		private static readonly IntPtr NativeMethodInfoPtr_UnassignLocation_Public_Void_0;

		// Token: 0x04002E44 RID: 11844
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002E45 RID: 11845
		private static readonly IntPtr NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0;

		// Token: 0x04002E46 RID: 11846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E47 RID: 11847
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002E48 RID: 11848
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002E49 RID: 11849
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002E4A RID: 11850
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
