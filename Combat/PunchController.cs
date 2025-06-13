using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020004B9 RID: 1209
	public class PunchController : MonoBehaviour
	{
		// Token: 0x06006765 RID: 26469 RVA: 0x001D43C4 File Offset: 0x001D25C4
		// Note: this type is marked as 'beforefieldinit'.
		static PunchController()
		{
			Il2CppClassPointerStore<PunchController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "PunchController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController>.NativeClassPtr);
			PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MAX_PUNCH_LOAD");
			PunchController.NativeFieldInfoPtr_MIN_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MIN_COOLDOWN");
			PunchController.NativeFieldInfoPtr_MAX_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MAX_COOLDOWN");
			PunchController.NativeFieldInfoPtr_PUNCH_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PUNCH_RANGE");
			PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PUNCH_DEBOUNCE");
			PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<PunchingEnabled>k__BackingField");
			PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<IsPunching>k__BackingField");
			PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "ViewmodelAvatarOffset");
			PunchController.NativeFieldInfoPtr_MinPunchDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinPunchDamage");
			PunchController.NativeFieldInfoPtr_MaxPunchDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxPunchDamage");
			PunchController.NativeFieldInfoPtr_MinPunchForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinPunchForce");
			PunchController.NativeFieldInfoPtr_MaxPunchForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxPunchForce");
			PunchController.NativeFieldInfoPtr_MinStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinStaminaCost");
			PunchController.NativeFieldInfoPtr_MaxStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxStaminaCost");
			PunchController.NativeFieldInfoPtr_PunchSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PunchSound");
			PunchController.NativeFieldInfoPtr_PunchAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PunchAnimator");
			PunchController.NativeFieldInfoPtr_punchLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "punchLoad");
			PunchController.NativeFieldInfoPtr_remainingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "remainingCooldown");
			PunchController.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "player");
			PunchController.NativeFieldInfoPtr_punchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "punchRoutine");
			PunchController.NativeFieldInfoPtr_itemEquippedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "itemEquippedLastFrame");
			PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "timeSincePunchingEnabled");
			PunchController.NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676465);
			PunchController.NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676466);
			PunchController.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676467);
			PunchController.NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676468);
			PunchController.NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676469);
			PunchController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676470);
			PunchController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676471);
			PunchController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676472);
			PunchController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676473);
			PunchController.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676474);
			PunchController.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676475);
			PunchController.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676476);
			PunchController.NativeMethodInfoPtr_StartLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676477);
			PunchController.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676478);
			PunchController.NativeMethodInfoPtr_Punch_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676479);
			PunchController.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676480);
			PunchController.NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676481);
			PunchController.NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676482);
			PunchController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676483);
			PunchController.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676484);
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x06006766 RID: 26470 RVA: 0x001D473C File Offset: 0x001D293C
		// (set) Token: 0x06006767 RID: 26471 RVA: 0x001D4778 File Offset: 0x001D2978
		public unsafe bool PunchingEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x001D47B8 File Offset: 0x001D29B8
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06006769 RID: 26473 RVA: 0x001D47F4 File Offset: 0x001D29F4
		// (set) Token: 0x0600676A RID: 26474 RVA: 0x001D4830 File Offset: 0x001D2A30
		public unsafe bool IsPunching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x001D4870 File Offset: 0x001D2A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210338, XrefRangeEnd = 210342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x001D48A4 File Offset: 0x001D2AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210342, XrefRangeEnd = 210354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x001D48D8 File Offset: 0x001D2AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210354, XrefRangeEnd = 210363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x001D490C File Offset: 0x001D2B0C
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x001D4940 File Offset: 0x001D2B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210363, XrefRangeEnd = 210365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x001D4974 File Offset: 0x001D2B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210373, RefRangeEnd = 210374, XrefRangeStart = 210365, XrefRangeEnd = 210373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x001D49A8 File Offset: 0x001D2BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210374, XrefRangeEnd = 210378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x001D49E4 File Offset: 0x001D2BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210378, XrefRangeEnd = 210409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_StartLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x001D4A18 File Offset: 0x001D2C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210409, XrefRangeEnd = 210443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x001D4A4C File Offset: 0x001D2C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210459, RefRangeEnd = 210460, XrefRangeStart = 210443, XrefRangeEnd = 210459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Punch(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref power;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Punch_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x001D4A8C File Offset: 0x001D2C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210460, XrefRangeEnd = 210529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteHit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref power;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x001D4ACC File Offset: 0x001D2CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210545, RefRangeEnd = 210547, XrefRangeStart = 210529, XrefRangeEnd = 210545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPunchingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x001D4B0C File Offset: 0x001D2D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210591, RefRangeEnd = 210592, XrefRangeStart = 210547, XrefRangeEnd = 210591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldBeEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x001D4B48 File Offset: 0x001D2D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210592, XrefRangeEnd = 210593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PunchController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x001D4B84 File Offset: 0x001D2D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210593, XrefRangeEnd = 210594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x00030AE0 File Offset: 0x0002ECE0
		public PunchController(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x0600677B RID: 26491 RVA: 0x001D4BB8 File Offset: 0x001D2DB8
		// (set) Token: 0x0600677C RID: 26492 RVA: 0x00030AE9 File Offset: 0x0002ECE9
		public unsafe static float MAX_PUNCH_LOAD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD, (void*)(&value));
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x0600677D RID: 26493 RVA: 0x001D4BD4 File Offset: 0x001D2DD4
		// (set) Token: 0x0600677E RID: 26494 RVA: 0x00030AF7 File Offset: 0x0002ECF7
		public unsafe static float MIN_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x0600677F RID: 26495 RVA: 0x001D4BF0 File Offset: 0x001D2DF0
		// (set) Token: 0x06006780 RID: 26496 RVA: 0x00030B05 File Offset: 0x0002ED05
		public unsafe static float MAX_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06006781 RID: 26497 RVA: 0x001D4C0C File Offset: 0x001D2E0C
		// (set) Token: 0x06006782 RID: 26498 RVA: 0x00030B13 File Offset: 0x0002ED13
		public unsafe static float PUNCH_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_PUNCH_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_PUNCH_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x06006783 RID: 26499 RVA: 0x001D4C28 File Offset: 0x001D2E28
		// (set) Token: 0x06006784 RID: 26500 RVA: 0x00030B21 File Offset: 0x0002ED21
		public unsafe static float PUNCH_DEBOUNCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE, (void*)(&value));
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x06006785 RID: 26501 RVA: 0x001D4C44 File Offset: 0x001D2E44
		// (set) Token: 0x06006786 RID: 26502 RVA: 0x00030B2F File Offset: 0x0002ED2F
		public unsafe bool _PunchingEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x001D4C6C File Offset: 0x001D2E6C
		// (set) Token: 0x06006788 RID: 26504 RVA: 0x00030B4A File Offset: 0x0002ED4A
		public unsafe bool _IsPunching_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06006789 RID: 26505 RVA: 0x001D4C94 File Offset: 0x001D2E94
		// (set) Token: 0x0600678A RID: 26506 RVA: 0x00030B65 File Offset: 0x0002ED65
		public unsafe Vector3 ViewmodelAvatarOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset)) = value;
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x001D4CBC File Offset: 0x001D2EBC
		// (set) Token: 0x0600678C RID: 26508 RVA: 0x00030B80 File Offset: 0x0002ED80
		public unsafe float MinPunchDamage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchDamage)) = value;
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x0600678D RID: 26509 RVA: 0x001D4CE4 File Offset: 0x001D2EE4
		// (set) Token: 0x0600678E RID: 26510 RVA: 0x00030B9B File Offset: 0x0002ED9B
		public unsafe float MaxPunchDamage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchDamage)) = value;
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x0600678F RID: 26511 RVA: 0x001D4D0C File Offset: 0x001D2F0C
		// (set) Token: 0x06006790 RID: 26512 RVA: 0x00030BB6 File Offset: 0x0002EDB6
		public unsafe float MinPunchForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchForce)) = value;
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x001D4D34 File Offset: 0x001D2F34
		// (set) Token: 0x06006792 RID: 26514 RVA: 0x00030BD1 File Offset: 0x0002EDD1
		public unsafe float MaxPunchForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchForce)) = value;
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x06006793 RID: 26515 RVA: 0x001D4D5C File Offset: 0x001D2F5C
		// (set) Token: 0x06006794 RID: 26516 RVA: 0x00030BEC File Offset: 0x0002EDEC
		public unsafe float MinStaminaCost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinStaminaCost)) = value;
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06006795 RID: 26517 RVA: 0x001D4D84 File Offset: 0x001D2F84
		// (set) Token: 0x06006796 RID: 26518 RVA: 0x00030C07 File Offset: 0x0002EE07
		public unsafe float MaxStaminaCost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxStaminaCost)) = value;
			}
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x06006797 RID: 26519 RVA: 0x001D4DAC File Offset: 0x001D2FAC
		// (set) Token: 0x06006798 RID: 26520 RVA: 0x00030C22 File Offset: 0x0002EE22
		public unsafe AudioSourceController PunchSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x06006799 RID: 26521 RVA: 0x001D4DDC File Offset: 0x001D2FDC
		// (set) Token: 0x0600679A RID: 26522 RVA: 0x00030C41 File Offset: 0x0002EE41
		public unsafe RuntimeAnimatorController PunchAnimator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchAnimator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x0600679B RID: 26523 RVA: 0x001D4E0C File Offset: 0x001D300C
		// (set) Token: 0x0600679C RID: 26524 RVA: 0x00030C60 File Offset: 0x0002EE60
		public unsafe float punchLoad
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchLoad)) = value;
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x0600679D RID: 26525 RVA: 0x001D4E34 File Offset: 0x001D3034
		// (set) Token: 0x0600679E RID: 26526 RVA: 0x00030C7B File Offset: 0x0002EE7B
		public unsafe float remainingCooldown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_remainingCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_remainingCooldown)) = value;
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x0600679F RID: 26527 RVA: 0x001D4E5C File Offset: 0x001D305C
		// (set) Token: 0x060067A0 RID: 26528 RVA: 0x00030C96 File Offset: 0x0002EE96
		public unsafe Player player
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_player);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x060067A1 RID: 26529 RVA: 0x001D4E8C File Offset: 0x001D308C
		// (set) Token: 0x060067A2 RID: 26530 RVA: 0x00030CB5 File Offset: 0x0002EEB5
		public unsafe Coroutine punchRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x060067A3 RID: 26531 RVA: 0x001D4EBC File Offset: 0x001D30BC
		// (set) Token: 0x060067A4 RID: 26532 RVA: 0x00030CD4 File Offset: 0x0002EED4
		public unsafe bool itemEquippedLastFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_itemEquippedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_itemEquippedLastFrame)) = value;
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x060067A5 RID: 26533 RVA: 0x001D4EE4 File Offset: 0x001D30E4
		// (set) Token: 0x060067A6 RID: 26534 RVA: 0x00030CEF File Offset: 0x0002EEEF
		public unsafe float timeSincePunchingEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled)) = value;
			}
		}

		// Token: 0x04004692 RID: 18066
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PUNCH_LOAD;

		// Token: 0x04004693 RID: 18067
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_COOLDOWN;

		// Token: 0x04004694 RID: 18068
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_COOLDOWN;

		// Token: 0x04004695 RID: 18069
		private static readonly System.IntPtr NativeFieldInfoPtr_PUNCH_RANGE;

		// Token: 0x04004696 RID: 18070
		private static readonly System.IntPtr NativeFieldInfoPtr_PUNCH_DEBOUNCE;

		// Token: 0x04004697 RID: 18071
		private static readonly System.IntPtr NativeFieldInfoPtr__PunchingEnabled_k__BackingField;

		// Token: 0x04004698 RID: 18072
		private static readonly System.IntPtr NativeFieldInfoPtr__IsPunching_k__BackingField;

		// Token: 0x04004699 RID: 18073
		private static readonly System.IntPtr NativeFieldInfoPtr_ViewmodelAvatarOffset;

		// Token: 0x0400469A RID: 18074
		private static readonly System.IntPtr NativeFieldInfoPtr_MinPunchDamage;

		// Token: 0x0400469B RID: 18075
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxPunchDamage;

		// Token: 0x0400469C RID: 18076
		private static readonly System.IntPtr NativeFieldInfoPtr_MinPunchForce;

		// Token: 0x0400469D RID: 18077
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxPunchForce;

		// Token: 0x0400469E RID: 18078
		private static readonly System.IntPtr NativeFieldInfoPtr_MinStaminaCost;

		// Token: 0x0400469F RID: 18079
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxStaminaCost;

		// Token: 0x040046A0 RID: 18080
		private static readonly System.IntPtr NativeFieldInfoPtr_PunchSound;

		// Token: 0x040046A1 RID: 18081
		private static readonly System.IntPtr NativeFieldInfoPtr_PunchAnimator;

		// Token: 0x040046A2 RID: 18082
		private static readonly System.IntPtr NativeFieldInfoPtr_punchLoad;

		// Token: 0x040046A3 RID: 18083
		private static readonly System.IntPtr NativeFieldInfoPtr_remainingCooldown;

		// Token: 0x040046A4 RID: 18084
		private static readonly System.IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040046A5 RID: 18085
		private static readonly System.IntPtr NativeFieldInfoPtr_punchRoutine;

		// Token: 0x040046A6 RID: 18086
		private static readonly System.IntPtr NativeFieldInfoPtr_itemEquippedLastFrame;

		// Token: 0x040046A7 RID: 18087
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSincePunchingEnabled;

		// Token: 0x040046A8 RID: 18088
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0;

		// Token: 0x040046A9 RID: 18089
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040046AA RID: 18090
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x040046AB RID: 18091
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0;

		// Token: 0x040046AC RID: 18092
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0;

		// Token: 0x040046AD RID: 18093
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040046AE RID: 18094
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040046AF RID: 18095
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040046B0 RID: 18096
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040046B1 RID: 18097
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCooldown_Private_Void_0;

		// Token: 0x040046B2 RID: 18098
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040046B3 RID: 18099
		private static readonly System.IntPtr NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0;

		// Token: 0x040046B4 RID: 18100
		private static readonly System.IntPtr NativeMethodInfoPtr_StartLoad_Private_Void_0;

		// Token: 0x040046B5 RID: 18101
		private static readonly System.IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x040046B6 RID: 18102
		private static readonly System.IntPtr NativeMethodInfoPtr_Punch_Private_Void_Single_0;

		// Token: 0x040046B7 RID: 18103
		private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0;

		// Token: 0x040046B8 RID: 18104
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0;

		// Token: 0x040046B9 RID: 18105
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0;

		// Token: 0x040046BA RID: 18106
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046BB RID: 18107
		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__31_0_Private_Void_0;

		// Token: 0x02000A7C RID: 2684
		[ObfuscatedName("ScheduleOne.Combat.PunchController+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D498 RID: 54424 RVA: 0x00333034 File Offset: 0x00331234
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr);
				PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "power");
				PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, 100676485);
				PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, 100676486);
			}

			// Token: 0x0600D499 RID: 54425 RVA: 0x003330B0 File Offset: 0x003312B0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D49A RID: 54426 RVA: 0x003330EC File Offset: 0x003312EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210333, XrefRangeEnd = 210338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D49B RID: 54427 RVA: 0x000671E5 File Offset: 0x000653E5
			public __c__DisplayClass39_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C2 RID: 16834
			// (get) Token: 0x0600D49C RID: 54428 RVA: 0x0033312C File Offset: 0x0033132C
			// (set) Token: 0x0600D49D RID: 54429 RVA: 0x000671EE File Offset: 0x000653EE
			public unsafe PunchController __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PunchController>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C3 RID: 16835
			// (get) Token: 0x0600D49E RID: 54430 RVA: 0x0033315C File Offset: 0x0033135C
			// (set) Token: 0x0600D49F RID: 54431 RVA: 0x0006720D File Offset: 0x0006540D
			public unsafe float power
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power)) = value;
				}
			}

			// Token: 0x04008F71 RID: 36721
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F72 RID: 36722
			private static readonly System.IntPtr NativeFieldInfoPtr_power;

			// Token: 0x04008F73 RID: 36723
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F74 RID: 36724
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CB2 RID: 3250
			[ObfuscatedName("ScheduleOne.Combat.PunchController+<>c__DisplayClass39_0+<<Punch>g__PunchRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E90E RID: 59662 RVA: 0x0036D298 File Offset: 0x0036B498
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "<<Punch>g__PunchRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676487);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676488);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676489);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676490);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676491);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676492);
				}

				// Token: 0x0600E90F RID: 59663 RVA: 0x0036D378 File Offset: 0x0036B578
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E910 RID: 59664 RVA: 0x0036D3C0 File Offset: 0x0036B5C0
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E911 RID: 59665 RVA: 0x0036D3F4 File Offset: 0x0036B5F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210312, XrefRangeEnd = 210328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004800 RID: 18432
				// (get) Token: 0x0600E912 RID: 59666 RVA: 0x0036D430 File Offset: 0x0036B630
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E913 RID: 59667 RVA: 0x0036D470 File Offset: 0x0036B670
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210328, XrefRangeEnd = 210333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004801 RID: 18433
				// (get) Token: 0x0600E914 RID: 59668 RVA: 0x0036D4A4 File Offset: 0x0036B6A4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E915 RID: 59669 RVA: 0x0007147A File Offset: 0x0006F67A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047FD RID: 18429
				// (get) Token: 0x0600E916 RID: 59670 RVA: 0x0036D4E4 File Offset: 0x0036B6E4
				// (set) Token: 0x0600E917 RID: 59671 RVA: 0x00071483 File Offset: 0x0006F683
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047FE RID: 18430
				// (get) Token: 0x0600E918 RID: 59672 RVA: 0x0036D50C File Offset: 0x0036B70C
				// (set) Token: 0x0600E919 RID: 59673 RVA: 0x0007149E File Offset: 0x0006F69E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047FF RID: 18431
				// (get) Token: 0x0600E91A RID: 59674 RVA: 0x0036D53C File Offset: 0x0036B73C
				// (set) Token: 0x0600E91B RID: 59675 RVA: 0x000714BD File Offset: 0x0006F6BD
				public unsafe PunchController.__c__DisplayClass39_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PunchController.__c__DisplayClass39_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009BFF RID: 39935
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C00 RID: 39936
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C01 RID: 39937
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C02 RID: 39938
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C03 RID: 39939
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C04 RID: 39940
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C05 RID: 39941
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C06 RID: 39942
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C07 RID: 39943
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
