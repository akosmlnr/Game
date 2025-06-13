using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000370 RID: 880
	public class PotActionBehaviour : Behaviour
	{
		// Token: 0x060041A6 RID: 16806 RVA: 0x0014B7C8 File Offset: 0x001499C8
		// Note: this type is marked as 'beforefieldinit'.
		static PotActionBehaviour()
		{
			Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PotActionBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr);
			PotActionBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<Initialized>k__BackingField");
			PotActionBehaviour.NativeFieldInfoPtr__AssignedPot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<AssignedPot>k__BackingField");
			PotActionBehaviour.NativeFieldInfoPtr__CurrentActionType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<CurrentActionType>k__BackingField");
			PotActionBehaviour.NativeFieldInfoPtr__CurrentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<CurrentState>k__BackingField");
			PotActionBehaviour.NativeFieldInfoPtr_AdditiveNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "AdditiveNumber");
			PotActionBehaviour.NativeFieldInfoPtr_WateringCanEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "WateringCanEquippable");
			PotActionBehaviour.NativeFieldInfoPtr_TrimmersEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "TrimmersEquippable");
			PotActionBehaviour.NativeFieldInfoPtr_botanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "botanist");
			PotActionBehaviour.NativeFieldInfoPtr_walkToSuppliesRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "walkToSuppliesRoutine");
			PotActionBehaviour.NativeFieldInfoPtr_grabRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "grabRoutine");
			PotActionBehaviour.NativeFieldInfoPtr_walkToPotRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "walkToPotRoutine");
			PotActionBehaviour.NativeFieldInfoPtr_performActionRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "performActionRoutine");
			PotActionBehaviour.NativeFieldInfoPtr_currentActionAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "currentActionAnimation");
			PotActionBehaviour.NativeFieldInfoPtr_currentActionEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "currentActionEquippable");
			PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PotActionBehaviourAssembly-CSharp.dll_Excuted");
			PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PotActionBehaviourAssembly-CSharp.dll_Excuted");
			PotActionBehaviour.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671249);
			PotActionBehaviour.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671250);
			PotActionBehaviour.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671251);
			PotActionBehaviour.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671252);
			PotActionBehaviour.NativeMethodInfoPtr_get_CurrentActionType_Public_get_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671253);
			PotActionBehaviour.NativeMethodInfoPtr_set_CurrentActionType_Protected_set_Void_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671254);
			PotActionBehaviour.NativeMethodInfoPtr_get_CurrentState_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671255);
			PotActionBehaviour.NativeMethodInfoPtr_set_CurrentState_Protected_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671256);
			PotActionBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671257);
			PotActionBehaviour.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Pot_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671258);
			PotActionBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671259);
			PotActionBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671260);
			PotActionBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671261);
			PotActionBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671262);
			PotActionBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671263);
			PotActionBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671264);
			PotActionBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671265);
			PotActionBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671266);
			PotActionBehaviour.NativeMethodInfoPtr_WalkToSupplies_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671267);
			PotActionBehaviour.NativeMethodInfoPtr_GrabItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671268);
			PotActionBehaviour.NativeMethodInfoPtr_WalkToPot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671269);
			PotActionBehaviour.NativeMethodInfoPtr_PerformAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671270);
			PotActionBehaviour.NativeMethodInfoPtr_CompleteAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671271);
			PotActionBehaviour.NativeMethodInfoPtr_StopPerformAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671272);
			PotActionBehaviour.NativeMethodInfoPtr_GetActionAnimation_Private_String_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671273);
			PotActionBehaviour.NativeMethodInfoPtr_GetActionEquippable_Private_AvatarEquippable_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671274);
			PotActionBehaviour.NativeMethodInfoPtr_GetWaitTime_Public_Single_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671275);
			PotActionBehaviour.NativeMethodInfoPtr_CanGetToSupplies_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671276);
			PotActionBehaviour.NativeMethodInfoPtr_IsAtSupplies_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671277);
			PotActionBehaviour.NativeMethodInfoPtr_GetSuppliesAsTransitEntity_Private_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671278);
			PotActionBehaviour.NativeMethodInfoPtr_CanGetToPot_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671279);
			PotActionBehaviour.NativeMethodInfoPtr_GetPotAccessPoint_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671280);
			PotActionBehaviour.NativeMethodInfoPtr_IsAtPot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671281);
			PotActionBehaviour.NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_EActionType_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671282);
			PotActionBehaviour.NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671283);
			PotActionBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671284);
			PotActionBehaviour.NativeMethodInfoPtr_DoesTaskTypeRequireSupplies_Public_Boolean_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671285);
			PotActionBehaviour.NativeMethodInfoPtr_DoesBotanistHaveMaterialsForTask_Public_Boolean_Botanist_Pot_EActionType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671286);
			PotActionBehaviour.NativeMethodInfoPtr_GetSoilInSupplies_Private_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671287);
			PotActionBehaviour.NativeMethodInfoPtr_GetSeedInSupplies_Private_ItemInstance_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671288);
			PotActionBehaviour.NativeMethodInfoPtr_GetAdditiveInSupplies_Private_ItemInstance_Pot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671289);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotBeWatered_Public_Boolean_Pot_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671290);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveSoilPour_Public_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671291);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveSeedSown_Public_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671292);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveAdditiveApplied_Public_Boolean_Pot_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671293);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotBeHarvested_Public_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671294);
			PotActionBehaviour.NativeMethodInfoPtr_DoesPotHaveValidDestination_Public_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671295);
			PotActionBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671296);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671297);
			PotActionBehaviour.NativeMethodInfoPtr__WalkToSupplies_b__38_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671298);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671299);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671300);
			PotActionBehaviour.NativeMethodInfoPtr__WalkToPot_b__40_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671301);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671302);
			PotActionBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671303);
			PotActionBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671304);
			PotActionBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671305);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671306);
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x0014BDC0 File Offset: 0x00149FC0
		// (set) Token: 0x060041A8 RID: 16808 RVA: 0x0014BDFC File Offset: 0x00149FFC
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x0014BE3C File Offset: 0x0014A03C
		// (set) Token: 0x060041AA RID: 16810 RVA: 0x0014BE7C File Offset: 0x0014A07C
		public unsafe Pot AssignedPot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118585, RefRangeEnd = 118586, XrefRangeStart = 118585, XrefRangeEnd = 118586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060041AB RID: 16811 RVA: 0x0014BEC0 File Offset: 0x0014A0C0
		// (set) Token: 0x060041AC RID: 16812 RVA: 0x0014BEFC File Offset: 0x0014A0FC
		public unsafe PotActionBehaviour.EActionType CurrentActionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_get_CurrentActionType_Public_get_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_set_CurrentActionType_Protected_set_Void_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x0014BF3C File Offset: 0x0014A13C
		// (set) Token: 0x060041AE RID: 16814 RVA: 0x0014BF78 File Offset: 0x0014A178
		public unsafe PotActionBehaviour.EState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_get_CurrentState_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_set_CurrentState_Protected_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x0014BFB8 File Offset: 0x0014A1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154183, XrefRangeEnd = 154190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x0014BFF4 File Offset: 0x0014A1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154190, XrefRangeEnd = 154204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Pot pot, PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref actionType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Pot_EActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x0014C050 File Offset: 0x0014A250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154204, XrefRangeEnd = 154206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x0014C08C File Offset: 0x0014A28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154206, XrefRangeEnd = 154208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x0014C0C8 File Offset: 0x0014A2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154208, XrefRangeEnd = 154210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x0014C104 File Offset: 0x0014A304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x0014C140 File Offset: 0x0014A340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154210, XrefRangeEnd = 154212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x0014C17C File Offset: 0x0014A37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154212, XrefRangeEnd = 154275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x0014C1B8 File Offset: 0x0014A3B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154311, RefRangeEnd = 154313, XrefRangeStart = 154275, XrefRangeEnd = 154311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x0014C1EC File Offset: 0x0014A3EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154320, RefRangeEnd = 154322, XrefRangeStart = 154313, XrefRangeEnd = 154320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x0014C220 File Offset: 0x0014A420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154354, RefRangeEnd = 154355, XrefRangeStart = 154322, XrefRangeEnd = 154354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkToSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_WalkToSupplies_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x0014C254 File Offset: 0x0014A454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154355, XrefRangeEnd = 154376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GrabItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x0014C288 File Offset: 0x0014A488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154376, XrefRangeEnd = 154405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkToPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_WalkToPot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x0014C2BC File Offset: 0x0014A4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154405, XrefRangeEnd = 154426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_PerformAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x0014C2F0 File Offset: 0x0014A4F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154532, RefRangeEnd = 154533, XrefRangeStart = 154426, XrefRangeEnd = 154532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CompleteAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x0014C324 File Offset: 0x0014A524
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 154561, RefRangeEnd = 154564, XrefRangeStart = 154533, XrefRangeEnd = 154561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_StopPerformAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x0014C358 File Offset: 0x0014A558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154564, XrefRangeEnd = 154569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActionAnimation(PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref actionType;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetActionAnimation_Private_String_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x0014C39C File Offset: 0x0014A59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154569, XrefRangeEnd = 154578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippable GetActionEquippable(PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref actionType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetActionEquippable_Private_AvatarEquippable_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x0014C3E8 File Offset: 0x0014A5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154578, XrefRangeEnd = 154588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetWaitTime(PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref actionType;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetWaitTime_Public_Single_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x0014C434 File Offset: 0x0014A634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 154597, RefRangeEnd = 154600, XrefRangeStart = 154588, XrefRangeEnd = 154597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetToSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanGetToSupplies_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x0014C470 File Offset: 0x0014A670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154600, XrefRangeEnd = 154606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_IsAtSupplies_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x0014C4AC File Offset: 0x0014A6AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154625, RefRangeEnd = 154627, XrefRangeStart = 154606, XrefRangeEnd = 154625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITransitEntity GetSuppliesAsTransitEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetSuppliesAsTransitEntity_Private_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x0014C4EC File Offset: 0x0014A6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154627, XrefRangeEnd = 154632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetToPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanGetToPot_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x0014C528 File Offset: 0x0014A728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154647, RefRangeEnd = 154649, XrefRangeStart = 154632, XrefRangeEnd = 154647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetPotAccessPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetPotAccessPoint_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x0014C568 File Offset: 0x0014A768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154649, XrefRangeEnd = 154666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_IsAtPot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x0014C5A4 File Offset: 0x0014A7A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 154697, RefRangeEnd = 154703, XrefRangeStart = 154666, XrefRangeEnd = 154697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetRequiredItemIDs(PotActionBehaviour.EActionType actionType, Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref actionType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pot);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_EActionType_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x0014C604 File Offset: 0x0014A804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154703, XrefRangeEnd = 154704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetRequiredItemIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x0014C644 File Offset: 0x0014A844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154713, RefRangeEnd = 154715, XrefRangeStart = 154704, XrefRangeEnd = 154713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreActionConditionsMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x0014C680 File Offset: 0x0014A880
		[CallerCount(0)]
		public unsafe bool DoesTaskTypeRequireSupplies(PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref actionType;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_DoesTaskTypeRequireSupplies_Public_Boolean_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x0014C6CC File Offset: 0x0014A8CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 154729, RefRangeEnd = 154734, XrefRangeStart = 154715, XrefRangeEnd = 154729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesBotanistHaveMaterialsForTask(Botanist botanist, Pot pot, PotActionBehaviour.EActionType actionType, int additiveNumber = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(botanist);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref actionType;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref additiveNumber;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_DoesBotanistHaveMaterialsForTask_Public_Boolean_Botanist_Pot_EActionType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x0014C748 File Offset: 0x0014A948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154734, XrefRangeEnd = 154743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetSoilInSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetSoilInSupplies_Private_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x0014C788 File Offset: 0x0014A988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154743, XrefRangeEnd = 154753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetSeedInSupplies(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetSeedInSupplies_Private_ItemInstance_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x0014C7D8 File Offset: 0x0014A9D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154765, RefRangeEnd = 154766, XrefRangeStart = 154753, XrefRangeEnd = 154765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetAdditiveInSupplies(Pot pot, int additiveNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref additiveNumber;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetAdditiveInSupplies_Private_ItemInstance_Pot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x0014C838 File Offset: 0x0014AA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154775, RefRangeEnd = 154776, XrefRangeStart = 154766, XrefRangeEnd = 154775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotBeWatered(Pot pot, float threshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref threshold;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotBeWatered_Public_Boolean_Pot_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x0014C894 File Offset: 0x0014AA94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154780, RefRangeEnd = 154781, XrefRangeStart = 154776, XrefRangeEnd = 154780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotHaveSoilPour(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveSoilPour_Public_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x0014C8E4 File Offset: 0x0014AAE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154789, RefRangeEnd = 154790, XrefRangeStart = 154781, XrefRangeEnd = 154789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotHaveSeedSown(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveSeedSown_Public_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x0014C934 File Offset: 0x0014AB34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154810, RefRangeEnd = 154811, XrefRangeStart = 154790, XrefRangeEnd = 154810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotHaveAdditiveApplied(Pot pot, out int additiveNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &additiveNumber;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveAdditiveApplied_Public_Boolean_Pot_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x0014C990 File Offset: 0x0014AB90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154820, RefRangeEnd = 154821, XrefRangeStart = 154811, XrefRangeEnd = 154820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotBeHarvested(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotBeHarvested_Public_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x0014C9E0 File Offset: 0x0014ABE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154821, XrefRangeEnd = 154836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesPotHaveValidDestination(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_DoesPotHaveValidDestination_Public_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x0014CA30 File Offset: 0x0014AC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154836, XrefRangeEnd = 154840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotActionBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x0014CA6C File Offset: 0x0014AC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154840, XrefRangeEnd = 154845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x0014CAAC File Offset: 0x0014ACAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalkToSupplies_b__38_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr__WalkToSupplies_b__38_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x0014CAE8 File Offset: 0x0014ACE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154845, XrefRangeEnd = 154850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x0014CB28 File Offset: 0x0014AD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154850, XrefRangeEnd = 154855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x0014CB68 File Offset: 0x0014AD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalkToPot_b__40_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr__WalkToPot_b__40_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x0014CBA4 File Offset: 0x0014ADA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154855, XrefRangeEnd = 154860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x0014CBE4 File Offset: 0x0014ADE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154860, XrefRangeEnd = 154861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x0014CC20 File Offset: 0x0014AE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154861, XrefRangeEnd = 154862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x0014CC5C File Offset: 0x0014AE5C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x0014CC98 File Offset: 0x0014AE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154862, XrefRangeEnd = 154869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00020628 File Offset: 0x0001E828
		public PotActionBehaviour(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x0014CCD4 File Offset: 0x0014AED4
		// (set) Token: 0x060041E3 RID: 16867 RVA: 0x00020631 File Offset: 0x0001E831
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060041E4 RID: 16868 RVA: 0x0014CCFC File Offset: 0x0014AEFC
		// (set) Token: 0x060041E5 RID: 16869 RVA: 0x0002064C File Offset: 0x0001E84C
		public unsafe Pot _AssignedPot_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__AssignedPot_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__AssignedPot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x0014CD2C File Offset: 0x0014AF2C
		// (set) Token: 0x060041E7 RID: 16871 RVA: 0x0002066B File Offset: 0x0001E86B
		public unsafe PotActionBehaviour.EActionType _CurrentActionType_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__CurrentActionType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__CurrentActionType_k__BackingField)) = value;
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060041E8 RID: 16872 RVA: 0x0014CD54 File Offset: 0x0014AF54
		// (set) Token: 0x060041E9 RID: 16873 RVA: 0x00020686 File Offset: 0x0001E886
		public unsafe PotActionBehaviour.EState _CurrentState_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__CurrentState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__CurrentState_k__BackingField)) = value;
			}
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060041EA RID: 16874 RVA: 0x0014CD7C File Offset: 0x0014AF7C
		// (set) Token: 0x060041EB RID: 16875 RVA: 0x000206A1 File Offset: 0x0001E8A1
		public unsafe int AdditiveNumber
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_AdditiveNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_AdditiveNumber)) = value;
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x0014CDA4 File Offset: 0x0014AFA4
		// (set) Token: 0x060041ED RID: 16877 RVA: 0x000206BC File Offset: 0x0001E8BC
		public unsafe AvatarEquippable WateringCanEquippable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_WateringCanEquippable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_WateringCanEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060041EE RID: 16878 RVA: 0x0014CDD4 File Offset: 0x0014AFD4
		// (set) Token: 0x060041EF RID: 16879 RVA: 0x000206DB File Offset: 0x0001E8DB
		public unsafe AvatarEquippable TrimmersEquippable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_TrimmersEquippable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_TrimmersEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x0014CE04 File Offset: 0x0014B004
		// (set) Token: 0x060041F1 RID: 16881 RVA: 0x000206FA File Offset: 0x0001E8FA
		public unsafe Botanist botanist
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_botanist);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_botanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x0014CE34 File Offset: 0x0014B034
		// (set) Token: 0x060041F3 RID: 16883 RVA: 0x00020719 File Offset: 0x0001E919
		public unsafe Coroutine walkToSuppliesRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_walkToSuppliesRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_walkToSuppliesRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060041F4 RID: 16884 RVA: 0x0014CE64 File Offset: 0x0014B064
		// (set) Token: 0x060041F5 RID: 16885 RVA: 0x00020738 File Offset: 0x0001E938
		public unsafe Coroutine grabRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_grabRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_grabRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x0014CE94 File Offset: 0x0014B094
		// (set) Token: 0x060041F7 RID: 16887 RVA: 0x00020757 File Offset: 0x0001E957
		public unsafe Coroutine walkToPotRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_walkToPotRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_walkToPotRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060041F8 RID: 16888 RVA: 0x0014CEC4 File Offset: 0x0014B0C4
		// (set) Token: 0x060041F9 RID: 16889 RVA: 0x00020776 File Offset: 0x0001E976
		public unsafe Coroutine performActionRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_performActionRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_performActionRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x0014CEF4 File Offset: 0x0014B0F4
		// (set) Token: 0x060041FB RID: 16891 RVA: 0x00020795 File Offset: 0x0001E995
		public unsafe string currentActionAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_currentActionAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_currentActionAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060041FC RID: 16892 RVA: 0x0014CF1C File Offset: 0x0014B11C
		// (set) Token: 0x060041FD RID: 16893 RVA: 0x000207B4 File Offset: 0x0001E9B4
		public unsafe AvatarEquippable currentActionEquippable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_currentActionEquippable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_currentActionEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x0014CF4C File Offset: 0x0014B14C
		// (set) Token: 0x060041FF RID: 16895 RVA: 0x000207D3 File Offset: 0x0001E9D3
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x0014CF74 File Offset: 0x0014B174
		// (set) Token: 0x06004201 RID: 16897 RVA: 0x000207EE File Offset: 0x0001E9EE
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002BAA RID: 11178
		private static readonly System.IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04002BAB RID: 11179
		private static readonly System.IntPtr NativeFieldInfoPtr__AssignedPot_k__BackingField;

		// Token: 0x04002BAC RID: 11180
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentActionType_k__BackingField;

		// Token: 0x04002BAD RID: 11181
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentState_k__BackingField;

		// Token: 0x04002BAE RID: 11182
		private static readonly System.IntPtr NativeFieldInfoPtr_AdditiveNumber;

		// Token: 0x04002BAF RID: 11183
		private static readonly System.IntPtr NativeFieldInfoPtr_WateringCanEquippable;

		// Token: 0x04002BB0 RID: 11184
		private static readonly System.IntPtr NativeFieldInfoPtr_TrimmersEquippable;

		// Token: 0x04002BB1 RID: 11185
		private static readonly System.IntPtr NativeFieldInfoPtr_botanist;

		// Token: 0x04002BB2 RID: 11186
		private static readonly System.IntPtr NativeFieldInfoPtr_walkToSuppliesRoutine;

		// Token: 0x04002BB3 RID: 11187
		private static readonly System.IntPtr NativeFieldInfoPtr_grabRoutine;

		// Token: 0x04002BB4 RID: 11188
		private static readonly System.IntPtr NativeFieldInfoPtr_walkToPotRoutine;

		// Token: 0x04002BB5 RID: 11189
		private static readonly System.IntPtr NativeFieldInfoPtr_performActionRoutine;

		// Token: 0x04002BB6 RID: 11190
		private static readonly System.IntPtr NativeFieldInfoPtr_currentActionAnimation;

		// Token: 0x04002BB7 RID: 11191
		private static readonly System.IntPtr NativeFieldInfoPtr_currentActionEquippable;

		// Token: 0x04002BB8 RID: 11192
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002BB9 RID: 11193
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002BBA RID: 11194
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04002BBB RID: 11195
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0;

		// Token: 0x04002BBC RID: 11196
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0;

		// Token: 0x04002BBD RID: 11197
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0;

		// Token: 0x04002BBE RID: 11198
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentActionType_Public_get_EActionType_0;

		// Token: 0x04002BBF RID: 11199
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentActionType_Protected_set_Void_EActionType_0;

		// Token: 0x04002BC0 RID: 11200
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentState_Public_get_EState_0;

		// Token: 0x04002BC1 RID: 11201
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentState_Protected_set_Void_EState_0;

		// Token: 0x04002BC2 RID: 11202
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002BC3 RID: 11203
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Pot_EActionType_0;

		// Token: 0x04002BC4 RID: 11204
		private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002BC5 RID: 11205
		private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002BC6 RID: 11206
		private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002BC7 RID: 11207
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002BC8 RID: 11208
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002BC9 RID: 11209
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002BCA RID: 11210
		private static readonly System.IntPtr NativeMethodInfoPtr_StartAction_Private_Void_0;

		// Token: 0x04002BCB RID: 11211
		private static readonly System.IntPtr NativeMethodInfoPtr_StopAllActions_Private_Void_0;

		// Token: 0x04002BCC RID: 11212
		private static readonly System.IntPtr NativeMethodInfoPtr_WalkToSupplies_Public_Void_0;

		// Token: 0x04002BCD RID: 11213
		private static readonly System.IntPtr NativeMethodInfoPtr_GrabItem_Public_Void_0;

		// Token: 0x04002BCE RID: 11214
		private static readonly System.IntPtr NativeMethodInfoPtr_WalkToPot_Public_Void_0;

		// Token: 0x04002BCF RID: 11215
		private static readonly System.IntPtr NativeMethodInfoPtr_PerformAction_Public_Void_0;

		// Token: 0x04002BD0 RID: 11216
		private static readonly System.IntPtr NativeMethodInfoPtr_CompleteAction_Private_Void_0;

		// Token: 0x04002BD1 RID: 11217
		private static readonly System.IntPtr NativeMethodInfoPtr_StopPerformAction_Private_Void_0;

		// Token: 0x04002BD2 RID: 11218
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActionAnimation_Private_String_EActionType_0;

		// Token: 0x04002BD3 RID: 11219
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActionEquippable_Private_AvatarEquippable_EActionType_0;

		// Token: 0x04002BD4 RID: 11220
		private static readonly System.IntPtr NativeMethodInfoPtr_GetWaitTime_Public_Single_EActionType_0;

		// Token: 0x04002BD5 RID: 11221
		private static readonly System.IntPtr NativeMethodInfoPtr_CanGetToSupplies_Public_Boolean_0;

		// Token: 0x04002BD6 RID: 11222
		private static readonly System.IntPtr NativeMethodInfoPtr_IsAtSupplies_Private_Boolean_0;

		// Token: 0x04002BD7 RID: 11223
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSuppliesAsTransitEntity_Private_ITransitEntity_0;

		// Token: 0x04002BD8 RID: 11224
		private static readonly System.IntPtr NativeMethodInfoPtr_CanGetToPot_Public_Boolean_0;

		// Token: 0x04002BD9 RID: 11225
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPotAccessPoint_Private_Transform_0;

		// Token: 0x04002BDA RID: 11226
		private static readonly System.IntPtr NativeMethodInfoPtr_IsAtPot_Private_Boolean_0;

		// Token: 0x04002BDB RID: 11227
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_EActionType_Pot_0;

		// Token: 0x04002BDC RID: 11228
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_0;

		// Token: 0x04002BDD RID: 11229
		private static readonly System.IntPtr NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_0;

		// Token: 0x04002BDE RID: 11230
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesTaskTypeRequireSupplies_Public_Boolean_EActionType_0;

		// Token: 0x04002BDF RID: 11231
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesBotanistHaveMaterialsForTask_Public_Boolean_Botanist_Pot_EActionType_Int32_0;

		// Token: 0x04002BE0 RID: 11232
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSoilInSupplies_Private_ItemInstance_0;

		// Token: 0x04002BE1 RID: 11233
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSeedInSupplies_Private_ItemInstance_Pot_0;

		// Token: 0x04002BE2 RID: 11234
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdditiveInSupplies_Private_ItemInstance_Pot_Int32_0;

		// Token: 0x04002BE3 RID: 11235
		private static readonly System.IntPtr NativeMethodInfoPtr_CanPotBeWatered_Public_Boolean_Pot_Single_0;

		// Token: 0x04002BE4 RID: 11236
		private static readonly System.IntPtr NativeMethodInfoPtr_CanPotHaveSoilPour_Public_Boolean_Pot_0;

		// Token: 0x04002BE5 RID: 11237
		private static readonly System.IntPtr NativeMethodInfoPtr_CanPotHaveSeedSown_Public_Boolean_Pot_0;

		// Token: 0x04002BE6 RID: 11238
		private static readonly System.IntPtr NativeMethodInfoPtr_CanPotHaveAdditiveApplied_Public_Boolean_Pot_byref_Int32_0;

		// Token: 0x04002BE7 RID: 11239
		private static readonly System.IntPtr NativeMethodInfoPtr_CanPotBeHarvested_Public_Boolean_Pot_0;

		// Token: 0x04002BE8 RID: 11240
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesPotHaveValidDestination_Public_Boolean_Pot_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BEA RID: 11242
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002BEB RID: 11243
		private static readonly System.IntPtr NativeMethodInfoPtr__WalkToSupplies_b__38_1_Private_Boolean_0;

		// Token: 0x04002BEC RID: 11244
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04002BED RID: 11245
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2;

		// Token: 0x04002BEE RID: 11246
		private static readonly System.IntPtr NativeMethodInfoPtr__WalkToPot_b__40_1_Private_Boolean_0;

		// Token: 0x04002BEF RID: 11247
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3;

		// Token: 0x04002BF0 RID: 11248
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002BF1 RID: 11249
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002BF2 RID: 11250
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002BF3 RID: 11251
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x0200099B RID: 2459
		[OriginalName("Assembly-CSharp.dll", "", "EActionType")]
		public enum EActionType
		{
			// Token: 0x04008B04 RID: 35588
			None,
			// Token: 0x04008B05 RID: 35589
			PourSoil,
			// Token: 0x04008B06 RID: 35590
			SowSeed,
			// Token: 0x04008B07 RID: 35591
			Water,
			// Token: 0x04008B08 RID: 35592
			ApplyAdditive,
			// Token: 0x04008B09 RID: 35593
			Harvest
		}

		// Token: 0x0200099C RID: 2460
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04008B0B RID: 35595
			Idle,
			// Token: 0x04008B0C RID: 35596
			WalkingToSupplies,
			// Token: 0x04008B0D RID: 35597
			GrabbingSupplies,
			// Token: 0x04008B0E RID: 35598
			WalkingToPot,
			// Token: 0x04008B0F RID: 35599
			PerformingAction,
			// Token: 0x04008B10 RID: 35600
			WalkingToDestination
		}

		// Token: 0x0200099D RID: 2461
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<<GrabItem>g__Routine|39_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD5A RID: 52570 RVA: 0x0031E4E0 File Offset: 0x0031C6E0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<<GrabItem>g__Routine|39_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671307);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671308);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671309);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671310);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671311);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671312);
			}

			// Token: 0x0600CD5B RID: 52571 RVA: 0x0031E5C0 File Offset: 0x0031C7C0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD5C RID: 52572 RVA: 0x0031E608 File Offset: 0x0031C808
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD5D RID: 52573 RVA: 0x0031E63C File Offset: 0x0031C83C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154054, XrefRangeEnd = 154084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003FB9 RID: 16313
			// (get) Token: 0x0600CD5E RID: 52574 RVA: 0x0031E678 File Offset: 0x0031C878
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD5F RID: 52575 RVA: 0x0031E6B8 File Offset: 0x0031C8B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154084, XrefRangeEnd = 154089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003FBA RID: 16314
			// (get) Token: 0x0600CD60 RID: 52576 RVA: 0x0031E6EC File Offset: 0x0031C8EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD61 RID: 52577 RVA: 0x00063939 File Offset: 0x00061B39
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FB6 RID: 16310
			// (get) Token: 0x0600CD62 RID: 52578 RVA: 0x0031E72C File Offset: 0x0031C92C
			// (set) Token: 0x0600CD63 RID: 52579 RVA: 0x00063942 File Offset: 0x00061B42
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FB7 RID: 16311
			// (get) Token: 0x0600CD64 RID: 52580 RVA: 0x0031E754 File Offset: 0x0031C954
			// (set) Token: 0x0600CD65 RID: 52581 RVA: 0x0006395D File Offset: 0x00061B5D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB8 RID: 16312
			// (get) Token: 0x0600CD66 RID: 52582 RVA: 0x0031E784 File Offset: 0x0031C984
			// (set) Token: 0x0600CD67 RID: 52583 RVA: 0x0006397C File Offset: 0x00061B7C
			public unsafe PotActionBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B11 RID: 35601
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B12 RID: 35602
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B13 RID: 35603
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B14 RID: 35604
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B15 RID: 35605
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B16 RID: 35606
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B17 RID: 35607
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B18 RID: 35608
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B19 RID: 35609
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200099E RID: 2462
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<<PerformAction>g__Routine|41_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CD68 RID: 52584 RVA: 0x0031E7B4 File Offset: 0x0031C9B4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique()
			{
				Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<<PerformAction>g__Routine|41_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__waitTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<waitTime>5__2");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671313);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671314);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671315);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671316);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671317);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671318);
			}

			// Token: 0x0600CD69 RID: 52585 RVA: 0x0031E8BC File Offset: 0x0031CABC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD6A RID: 52586 RVA: 0x0031E904 File Offset: 0x0031CB04
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD6B RID: 52587 RVA: 0x0031E938 File Offset: 0x0031CB38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154089, XrefRangeEnd = 154158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003FC0 RID: 16320
			// (get) Token: 0x0600CD6C RID: 52588 RVA: 0x0031E974 File Offset: 0x0031CB74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD6D RID: 52589 RVA: 0x0031E9B4 File Offset: 0x0031CBB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154158, XrefRangeEnd = 154163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003FC1 RID: 16321
			// (get) Token: 0x0600CD6E RID: 52590 RVA: 0x0031E9E8 File Offset: 0x0031CBE8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD6F RID: 52591 RVA: 0x0006399B File Offset: 0x00061B9B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FBB RID: 16315
			// (get) Token: 0x0600CD70 RID: 52592 RVA: 0x0031EA28 File Offset: 0x0031CC28
			// (set) Token: 0x0600CD71 RID: 52593 RVA: 0x000639A4 File Offset: 0x00061BA4
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FBC RID: 16316
			// (get) Token: 0x0600CD72 RID: 52594 RVA: 0x0031EA50 File Offset: 0x0031CC50
			// (set) Token: 0x0600CD73 RID: 52595 RVA: 0x000639BF File Offset: 0x00061BBF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBD RID: 16317
			// (get) Token: 0x0600CD74 RID: 52596 RVA: 0x0031EA80 File Offset: 0x0031CC80
			// (set) Token: 0x0600CD75 RID: 52597 RVA: 0x000639DE File Offset: 0x00061BDE
			public unsafe PotActionBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBE RID: 16318
			// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x0031EAB0 File Offset: 0x0031CCB0
			// (set) Token: 0x0600CD77 RID: 52599 RVA: 0x000639FD File Offset: 0x00061BFD
			public unsafe float _waitTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__waitTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__waitTime_5__2)) = value;
				}
			}

			// Token: 0x17003FBF RID: 16319
			// (get) Token: 0x0600CD78 RID: 52600 RVA: 0x0031EAD8 File Offset: 0x0031CCD8
			// (set) Token: 0x0600CD79 RID: 52601 RVA: 0x00063A18 File Offset: 0x00061C18
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008B1A RID: 35610
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B1B RID: 35611
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B1C RID: 35612
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B1D RID: 35613
			private static readonly System.IntPtr NativeFieldInfoPtr__waitTime_5__2;

			// Token: 0x04008B1E RID: 35614
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008B1F RID: 35615
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B20 RID: 35616
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B21 RID: 35617
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B22 RID: 35618
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B23 RID: 35619
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B24 RID: 35620
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200099F RID: 2463
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<<WalkToPot>g__Routine|40_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600CD7A RID: 52602 RVA: 0x0031EB00 File Offset: 0x0031CD00
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<<WalkToPot>g__Routine|40_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671319);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671320);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671321);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671322);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671323);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671324);
			}

			// Token: 0x0600CD7B RID: 52603 RVA: 0x0031EBE0 File Offset: 0x0031CDE0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD7C RID: 52604 RVA: 0x0031EC28 File Offset: 0x0031CE28
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD7D RID: 52605 RVA: 0x0031EC5C File Offset: 0x0031CE5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154163, XrefRangeEnd = 154168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003FC5 RID: 16325
			// (get) Token: 0x0600CD7E RID: 52606 RVA: 0x0031EC98 File Offset: 0x0031CE98
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD7F RID: 52607 RVA: 0x0031ECD8 File Offset: 0x0031CED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154168, XrefRangeEnd = 154173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003FC6 RID: 16326
			// (get) Token: 0x0600CD80 RID: 52608 RVA: 0x0031ED0C File Offset: 0x0031CF0C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD81 RID: 52609 RVA: 0x00063A33 File Offset: 0x00061C33
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC2 RID: 16322
			// (get) Token: 0x0600CD82 RID: 52610 RVA: 0x0031ED4C File Offset: 0x0031CF4C
			// (set) Token: 0x0600CD83 RID: 52611 RVA: 0x00063A3C File Offset: 0x00061C3C
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FC3 RID: 16323
			// (get) Token: 0x0600CD84 RID: 52612 RVA: 0x0031ED74 File Offset: 0x0031CF74
			// (set) Token: 0x0600CD85 RID: 52613 RVA: 0x00063A57 File Offset: 0x00061C57
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC4 RID: 16324
			// (get) Token: 0x0600CD86 RID: 52614 RVA: 0x0031EDA4 File Offset: 0x0031CFA4
			// (set) Token: 0x0600CD87 RID: 52615 RVA: 0x00063A76 File Offset: 0x00061C76
			public unsafe PotActionBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B25 RID: 35621
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B26 RID: 35622
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B27 RID: 35623
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B28 RID: 35624
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B29 RID: 35625
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B2A RID: 35626
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B2B RID: 35627
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B2C RID: 35628
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B2D RID: 35629
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009A0 RID: 2464
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<<WalkToSupplies>g__Routine|38_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2 : Il2CppSystem.Object
		{
			// Token: 0x0600CD88 RID: 52616 RVA: 0x0031EDD4 File Offset: 0x0031CFD4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2()
			{
				Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<<WalkToSupplies>g__Routine|38_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, "<>1__state");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, "<>2__current");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, "<>4__this");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671325);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671326);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671327);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671328);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671329);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671330);
			}

			// Token: 0x0600CD89 RID: 52617 RVA: 0x0031EEB4 File Offset: 0x0031D0B4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD8A RID: 52618 RVA: 0x0031EEFC File Offset: 0x0031D0FC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD8B RID: 52619 RVA: 0x0031EF30 File Offset: 0x0031D130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154173, XrefRangeEnd = 154178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003FCA RID: 16330
			// (get) Token: 0x0600CD8C RID: 52620 RVA: 0x0031EF6C File Offset: 0x0031D16C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD8D RID: 52621 RVA: 0x0031EFAC File Offset: 0x0031D1AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154178, XrefRangeEnd = 154183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003FCB RID: 16331
			// (get) Token: 0x0600CD8E RID: 52622 RVA: 0x0031EFE0 File Offset: 0x0031D1E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD8F RID: 52623 RVA: 0x00063A95 File Offset: 0x00061C95
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC7 RID: 16327
			// (get) Token: 0x0600CD90 RID: 52624 RVA: 0x0031F020 File Offset: 0x0031D220
			// (set) Token: 0x0600CD91 RID: 52625 RVA: 0x00063A9E File Offset: 0x00061C9E
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FC8 RID: 16328
			// (get) Token: 0x0600CD92 RID: 52626 RVA: 0x0031F048 File Offset: 0x0031D248
			// (set) Token: 0x0600CD93 RID: 52627 RVA: 0x00063AB9 File Offset: 0x00061CB9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC9 RID: 16329
			// (get) Token: 0x0600CD94 RID: 52628 RVA: 0x0031F078 File Offset: 0x0031D278
			// (set) Token: 0x0600CD95 RID: 52629 RVA: 0x00063AD8 File Offset: 0x00061CD8
			public unsafe PotActionBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B2E RID: 35630
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B2F RID: 35631
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B30 RID: 35632
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B31 RID: 35633
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B32 RID: 35634
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B33 RID: 35635
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B34 RID: 35636
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B35 RID: 35637
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B36 RID: 35638
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009A1 RID: 2465
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CD96 RID: 52630 RVA: 0x0031F0A8 File Offset: 0x0031D2A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr);
				PotActionBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr, "<>9");
				PotActionBehaviour.__c.NativeFieldInfoPtr___9__53_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr, "<>9__53_0");
				PotActionBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr, 100671332);
				PotActionBehaviour.__c.NativeMethodInfoPtr__GetRequiredItemIDs_b__53_0_Internal_String_SeedDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr, 100671333);
			}

			// Token: 0x0600CD97 RID: 52631 RVA: 0x0031F124 File Offset: 0x0031D324
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD98 RID: 52632 RVA: 0x0031F160 File Offset: 0x0031D360
			[CallerCount(0)]
			public unsafe string _GetRequiredItemIDs_b__53_0(SeedDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.__c.NativeMethodInfoPtr__GetRequiredItemIDs_b__53_0_Internal_String_SeedDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600CD99 RID: 52633 RVA: 0x00063AF7 File Offset: 0x00061CF7
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FCC RID: 16332
			// (get) Token: 0x0600CD9A RID: 52634 RVA: 0x0031F1A8 File Offset: 0x0031D3A8
			// (set) Token: 0x0600CD9B RID: 52635 RVA: 0x00063B00 File Offset: 0x00061D00
			public unsafe static PotActionBehaviour.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PotActionBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PotActionBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCD RID: 16333
			// (get) Token: 0x0600CD9C RID: 52636 RVA: 0x0031F1D0 File Offset: 0x0031D3D0
			// (set) Token: 0x0600CD9D RID: 52637 RVA: 0x00063B12 File Offset: 0x00061D12
			public unsafe static Il2CppSystem.Converter<SeedDefinition, string> __9__53_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PotActionBehaviour.__c.NativeFieldInfoPtr___9__53_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Converter<SeedDefinition, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PotActionBehaviour.__c.NativeFieldInfoPtr___9__53_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B37 RID: 35639
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B38 RID: 35640
			private static readonly System.IntPtr NativeFieldInfoPtr___9__53_0;

			// Token: 0x04008B39 RID: 35641
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B3A RID: 35642
			private static readonly System.IntPtr NativeMethodInfoPtr__GetRequiredItemIDs_b__53_0_Internal_String_SeedDefinition_0;
		}
	}
}
