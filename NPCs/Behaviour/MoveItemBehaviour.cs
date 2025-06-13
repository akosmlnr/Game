using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200036D RID: 877
	public class MoveItemBehaviour : Behaviour
	{
		// Token: 0x0600410E RID: 16654 RVA: 0x001491FC File Offset: 0x001473FC
		// Note: this type is marked as 'beforefieldinit'.
		static MoveItemBehaviour()
		{
			Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "MoveItemBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr);
			MoveItemBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<Initialized>k__BackingField");
			MoveItemBehaviour.NativeFieldInfoPtr_assignedRoute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "assignedRoute");
			MoveItemBehaviour.NativeFieldInfoPtr_itemToRetrieveTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "itemToRetrieveTemplate");
			MoveItemBehaviour.NativeFieldInfoPtr_grabbedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "grabbedAmount");
			MoveItemBehaviour.NativeFieldInfoPtr_maxMoveAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "maxMoveAmount");
			MoveItemBehaviour.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "currentState");
			MoveItemBehaviour.NativeFieldInfoPtr_walkToSourceRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "walkToSourceRoutine");
			MoveItemBehaviour.NativeFieldInfoPtr_grabRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "grabRoutine");
			MoveItemBehaviour.NativeFieldInfoPtr_walkToDestinationRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "walkToDestinationRoutine");
			MoveItemBehaviour.NativeFieldInfoPtr_placingRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "placingRoutine");
			MoveItemBehaviour.NativeFieldInfoPtr_skipPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "skipPickup");
			MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted");
			MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted");
			MoveItemBehaviour.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671119);
			MoveItemBehaviour.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671120);
			MoveItemBehaviour.NativeMethodInfoPtr_Initialize_Public_Void_TransitRoute_ItemInstance_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671121);
			MoveItemBehaviour.NativeMethodInfoPtr_Resume_Public_Void_TransitRoute_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671122);
			MoveItemBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671123);
			MoveItemBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671124);
			MoveItemBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671125);
			MoveItemBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671126);
			MoveItemBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671127);
			MoveItemBehaviour.NativeMethodInfoPtr_StartTransit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671128);
			MoveItemBehaviour.NativeMethodInfoPtr_IsNpcInventoryItemValid_Private_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671129);
			MoveItemBehaviour.NativeMethodInfoPtr_EndTransit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671130);
			MoveItemBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671131);
			MoveItemBehaviour.NativeMethodInfoPtr_WalkToSource_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671132);
			MoveItemBehaviour.NativeMethodInfoPtr_GrabItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671133);
			MoveItemBehaviour.NativeMethodInfoPtr_TakeItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671134);
			MoveItemBehaviour.NativeMethodInfoPtr_WalkToDestination_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671135);
			MoveItemBehaviour.NativeMethodInfoPtr_PlaceItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671136);
			MoveItemBehaviour.NativeMethodInfoPtr_GetAmountToGrab_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671137);
			MoveItemBehaviour.NativeMethodInfoPtr_StopCurrentActivity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671138);
			MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671139);
			MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_ItemInstance_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671140);
			MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671141);
			MoveItemBehaviour.NativeMethodInfoPtr_IsDestinationValid_Public_Boolean_TransitRoute_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671142);
			MoveItemBehaviour.NativeMethodInfoPtr_CanGetToSource_Public_Boolean_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671143);
			MoveItemBehaviour.NativeMethodInfoPtr_GetSourceAccessPoint_Private_Transform_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671144);
			MoveItemBehaviour.NativeMethodInfoPtr_IsAtSource_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671145);
			MoveItemBehaviour.NativeMethodInfoPtr_CanGetToDestination_Public_Boolean_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671146);
			MoveItemBehaviour.NativeMethodInfoPtr_GetDestinationAccessPoint_Private_Transform_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671147);
			MoveItemBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671148);
			MoveItemBehaviour.NativeMethodInfoPtr_GetSaveData_Public_MoveItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671149);
			MoveItemBehaviour.NativeMethodInfoPtr_Load_Public_Void_MoveItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671150);
			MoveItemBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671151);
			MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671152);
			MoveItemBehaviour.NativeMethodInfoPtr__WalkToSource_b__26_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671153);
			MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671154);
			MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671155);
			MoveItemBehaviour.NativeMethodInfoPtr__WalkToDestination_b__29_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671156);
			MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671157);
			MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671158);
			MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671159);
			MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671160);
			MoveItemBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100671161);
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600410F RID: 16655 RVA: 0x0014968C File Offset: 0x0014788C
		// (set) Token: 0x06004110 RID: 16656 RVA: 0x001496C8 File Offset: 0x001478C8
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00149708 File Offset: 0x00147908
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 153177, RefRangeEnd = 153182, XrefRangeStart = 153141, XrefRangeEnd = 153177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1, bool _skipPickup = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemToRetrieveTemplate);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _maxMoveAmount;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _skipPickup;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Initialize_Public_Void_TransitRoute_ItemInstance_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x00149778 File Offset: 0x00147978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153182, XrefRangeEnd = 153184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemToRetrieveTemplate);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _maxMoveAmount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Resume_Public_Void_TransitRoute_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x001497DC File Offset: 0x001479DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153184, XrefRangeEnd = 153186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x00149818 File Offset: 0x00147A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153186, XrefRangeEnd = 153188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x00149854 File Offset: 0x00147A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153188, XrefRangeEnd = 153190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x00149890 File Offset: 0x00147A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153190, XrefRangeEnd = 153203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x001498CC File Offset: 0x00147ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x00149908 File Offset: 0x00147B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153230, RefRangeEnd = 153232, XrefRangeStart = 153203, XrefRangeEnd = 153230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTransit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_StartTransit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x0014993C File Offset: 0x00147B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153232, XrefRangeEnd = 153236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNpcInventoryItemValid(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsNpcInventoryItemValid_Private_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x0014998C File Offset: 0x00147B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153236, XrefRangeEnd = 153248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndTransit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_EndTransit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x001499C0 File Offset: 0x00147BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153248, XrefRangeEnd = 153293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x001499FC File Offset: 0x00147BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153293, XrefRangeEnd = 153321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkToSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_WalkToSource_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00149A30 File Offset: 0x00147C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153321, XrefRangeEnd = 153335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GrabItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00149A64 File Offset: 0x00147C64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153357, RefRangeEnd = 153358, XrefRangeStart = 153335, XrefRangeEnd = 153357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_TakeItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00149A98 File Offset: 0x00147C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153358, XrefRangeEnd = 153382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkToDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_WalkToDestination_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x00149ACC File Offset: 0x00147CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153382, XrefRangeEnd = 153396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_PlaceItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x00149B00 File Offset: 0x00147D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153396, XrefRangeEnd = 153402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAmountToGrab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GetAmountToGrab_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00149B3C File Offset: 0x00147D3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153406, RefRangeEnd = 153409, XrefRangeStart = 153402, XrefRangeEnd = 153406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCurrentActivity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_StopCurrentActivity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x00149B70 File Offset: 0x00147D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153409, XrefRangeEnd = 153440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTransitRouteValid(TransitRoute route, string itemID, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(itemID);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x00149BEC File Offset: 0x00147DEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153465, RefRangeEnd = 153467, XrefRangeStart = 153440, XrefRangeEnd = 153465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTransitRouteValid(TransitRoute route, ItemInstance templateItem, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(templateItem);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_ItemInstance_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00149C68 File Offset: 0x00147E68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 153482, RefRangeEnd = 153489, XrefRangeStart = 153467, XrefRangeEnd = 153482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTransitRouteValid(TransitRoute route, string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(itemID);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x00149CC8 File Offset: 0x00147EC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 153516, RefRangeEnd = 153520, XrefRangeStart = 153489, XrefRangeEnd = 153516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDestinationValid(TransitRoute route, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsDestinationValid_Public_Boolean_TransitRoute_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x00149D28 File Offset: 0x00147F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153520, XrefRangeEnd = 153530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetToSource(TransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_CanGetToSource_Public_Boolean_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x00149D78 File Offset: 0x00147F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153530, XrefRangeEnd = 153536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetSourceAccessPoint(TransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GetSourceAccessPoint_Private_Transform_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x00149DC8 File Offset: 0x00147FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153536, XrefRangeEnd = 153542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsAtSource_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x00149E04 File Offset: 0x00148004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153542, XrefRangeEnd = 153547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetToDestination(TransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_CanGetToDestination_Public_Boolean_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00149E54 File Offset: 0x00148054
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 153558, RefRangeEnd = 153562, XrefRangeStart = 153547, XrefRangeEnd = 153558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetDestinationAccessPoint(TransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GetDestinationAccessPoint_Private_Transform_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00149EA4 File Offset: 0x001480A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153590, RefRangeEnd = 153591, XrefRangeStart = 153562, XrefRangeEnd = 153590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00149EE0 File Offset: 0x001480E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 153610, RefRangeEnd = 153614, XrefRangeStart = 153591, XrefRangeEnd = 153610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveItemData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GetSaveData_Public_MoveItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemData>(intPtr2) : null;
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00149F20 File Offset: 0x00148120
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 153642, RefRangeEnd = 153650, XrefRangeStart = 153614, XrefRangeEnd = 153642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(MoveItemData moveItemData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(moveItemData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Load_Public_Void_MoveItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00149F64 File Offset: 0x00148164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153650, XrefRangeEnd = 153651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveItemBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00149FA0 File Offset: 0x001481A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153651, XrefRangeEnd = 153656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00149FE0 File Offset: 0x001481E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153656, XrefRangeEnd = 153658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalkToSource_b__26_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr__WalkToSource_b__26_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x0014A01C File Offset: 0x0014821C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153658, XrefRangeEnd = 153663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x0014A05C File Offset: 0x0014825C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153663, XrefRangeEnd = 153668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x0014A09C File Offset: 0x0014829C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalkToDestination_b__29_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr__WalkToDestination_b__29_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x0014A0D8 File Offset: 0x001482D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153668, XrefRangeEnd = 153673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x0014A118 File Offset: 0x00148318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153673, XrefRangeEnd = 153674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x0014A154 File Offset: 0x00148354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153674, XrefRangeEnd = 153675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x0014A190 File Offset: 0x00148390
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x0014A1CC File Offset: 0x001483CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x00020346 File Offset: 0x0001E546
		public MoveItemBehaviour(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x0014A208 File Offset: 0x00148408
		// (set) Token: 0x0600413C RID: 16700 RVA: 0x0002034F File Offset: 0x0001E54F
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x0014A230 File Offset: 0x00148430
		// (set) Token: 0x0600413E RID: 16702 RVA: 0x0002036A File Offset: 0x0001E56A
		public unsafe TransitRoute assignedRoute
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_assignedRoute);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_assignedRoute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x0014A260 File Offset: 0x00148460
		// (set) Token: 0x06004140 RID: 16704 RVA: 0x00020389 File Offset: 0x0001E589
		public unsafe ItemInstance itemToRetrieveTemplate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_itemToRetrieveTemplate);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_itemToRetrieveTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x0014A290 File Offset: 0x00148490
		// (set) Token: 0x06004142 RID: 16706 RVA: 0x000203A8 File Offset: 0x0001E5A8
		public unsafe int grabbedAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_grabbedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_grabbedAmount)) = value;
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x0014A2B8 File Offset: 0x001484B8
		// (set) Token: 0x06004144 RID: 16708 RVA: 0x000203C3 File Offset: 0x0001E5C3
		public unsafe int maxMoveAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_maxMoveAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_maxMoveAmount)) = value;
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x0014A2E0 File Offset: 0x001484E0
		// (set) Token: 0x06004146 RID: 16710 RVA: 0x000203DE File Offset: 0x0001E5DE
		public unsafe MoveItemBehaviour.EState currentState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x0014A308 File Offset: 0x00148508
		// (set) Token: 0x06004148 RID: 16712 RVA: 0x000203F9 File Offset: 0x0001E5F9
		public unsafe Coroutine walkToSourceRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_walkToSourceRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_walkToSourceRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x0014A338 File Offset: 0x00148538
		// (set) Token: 0x0600414A RID: 16714 RVA: 0x00020418 File Offset: 0x0001E618
		public unsafe Coroutine grabRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_grabRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_grabRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x0600414B RID: 16715 RVA: 0x0014A368 File Offset: 0x00148568
		// (set) Token: 0x0600414C RID: 16716 RVA: 0x00020437 File Offset: 0x0001E637
		public unsafe Coroutine walkToDestinationRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_walkToDestinationRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_walkToDestinationRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x0014A398 File Offset: 0x00148598
		// (set) Token: 0x0600414E RID: 16718 RVA: 0x00020456 File Offset: 0x0001E656
		public unsafe Coroutine placingRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_placingRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_placingRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x0014A3C8 File Offset: 0x001485C8
		// (set) Token: 0x06004150 RID: 16720 RVA: 0x00020475 File Offset: 0x0001E675
		public unsafe bool skipPickup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_skipPickup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_skipPickup)) = value;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x0014A3F0 File Offset: 0x001485F0
		// (set) Token: 0x06004152 RID: 16722 RVA: 0x00020490 File Offset: 0x0001E690
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x0014A418 File Offset: 0x00148618
		// (set) Token: 0x06004154 RID: 16724 RVA: 0x000204AB File Offset: 0x0001E6AB
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002B32 RID: 11058
		private static readonly System.IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04002B33 RID: 11059
		private static readonly System.IntPtr NativeFieldInfoPtr_assignedRoute;

		// Token: 0x04002B34 RID: 11060
		private static readonly System.IntPtr NativeFieldInfoPtr_itemToRetrieveTemplate;

		// Token: 0x04002B35 RID: 11061
		private static readonly System.IntPtr NativeFieldInfoPtr_grabbedAmount;

		// Token: 0x04002B36 RID: 11062
		private static readonly System.IntPtr NativeFieldInfoPtr_maxMoveAmount;

		// Token: 0x04002B37 RID: 11063
		private static readonly System.IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x04002B38 RID: 11064
		private static readonly System.IntPtr NativeFieldInfoPtr_walkToSourceRoutine;

		// Token: 0x04002B39 RID: 11065
		private static readonly System.IntPtr NativeFieldInfoPtr_grabRoutine;

		// Token: 0x04002B3A RID: 11066
		private static readonly System.IntPtr NativeFieldInfoPtr_walkToDestinationRoutine;

		// Token: 0x04002B3B RID: 11067
		private static readonly System.IntPtr NativeFieldInfoPtr_placingRoutine;

		// Token: 0x04002B3C RID: 11068
		private static readonly System.IntPtr NativeFieldInfoPtr_skipPickup;

		// Token: 0x04002B3D RID: 11069
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002B3E RID: 11070
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002B3F RID: 11071
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04002B40 RID: 11072
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0;

		// Token: 0x04002B41 RID: 11073
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_TransitRoute_ItemInstance_Int32_Boolean_0;

		// Token: 0x04002B42 RID: 11074
		private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Public_Void_TransitRoute_ItemInstance_Int32_0;

		// Token: 0x04002B43 RID: 11075
		private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002B44 RID: 11076
		private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002B45 RID: 11077
		private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002B46 RID: 11078
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002B47 RID: 11079
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002B48 RID: 11080
		private static readonly System.IntPtr NativeMethodInfoPtr_StartTransit_Private_Void_0;

		// Token: 0x04002B49 RID: 11081
		private static readonly System.IntPtr NativeMethodInfoPtr_IsNpcInventoryItemValid_Private_Boolean_ItemInstance_0;

		// Token: 0x04002B4A RID: 11082
		private static readonly System.IntPtr NativeMethodInfoPtr_EndTransit_Private_Void_0;

		// Token: 0x04002B4B RID: 11083
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002B4C RID: 11084
		private static readonly System.IntPtr NativeMethodInfoPtr_WalkToSource_Public_Void_0;

		// Token: 0x04002B4D RID: 11085
		private static readonly System.IntPtr NativeMethodInfoPtr_GrabItem_Public_Void_0;

		// Token: 0x04002B4E RID: 11086
		private static readonly System.IntPtr NativeMethodInfoPtr_TakeItem_Private_Void_0;

		// Token: 0x04002B4F RID: 11087
		private static readonly System.IntPtr NativeMethodInfoPtr_WalkToDestination_Public_Void_0;

		// Token: 0x04002B50 RID: 11088
		private static readonly System.IntPtr NativeMethodInfoPtr_PlaceItem_Public_Void_0;

		// Token: 0x04002B51 RID: 11089
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAmountToGrab_Private_Int32_0;

		// Token: 0x04002B52 RID: 11090
		private static readonly System.IntPtr NativeMethodInfoPtr_StopCurrentActivity_Private_Void_0;

		// Token: 0x04002B53 RID: 11091
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_byref_String_0;

		// Token: 0x04002B54 RID: 11092
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_ItemInstance_byref_String_0;

		// Token: 0x04002B55 RID: 11093
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_0;

		// Token: 0x04002B56 RID: 11094
		private static readonly System.IntPtr NativeMethodInfoPtr_IsDestinationValid_Public_Boolean_TransitRoute_ItemInstance_0;

		// Token: 0x04002B57 RID: 11095
		private static readonly System.IntPtr NativeMethodInfoPtr_CanGetToSource_Public_Boolean_TransitRoute_0;

		// Token: 0x04002B58 RID: 11096
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSourceAccessPoint_Private_Transform_TransitRoute_0;

		// Token: 0x04002B59 RID: 11097
		private static readonly System.IntPtr NativeMethodInfoPtr_IsAtSource_Private_Boolean_0;

		// Token: 0x04002B5A RID: 11098
		private static readonly System.IntPtr NativeMethodInfoPtr_CanGetToDestination_Public_Boolean_TransitRoute_0;

		// Token: 0x04002B5B RID: 11099
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDestinationAccessPoint_Private_Transform_TransitRoute_0;

		// Token: 0x04002B5C RID: 11100
		private static readonly System.IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002B5D RID: 11101
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_MoveItemData_0;

		// Token: 0x04002B5E RID: 11102
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_MoveItemData_0;

		// Token: 0x04002B5F RID: 11103
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B60 RID: 11104
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002B61 RID: 11105
		private static readonly System.IntPtr NativeMethodInfoPtr__WalkToSource_b__26_1_Private_Boolean_0;

		// Token: 0x04002B62 RID: 11106
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04002B63 RID: 11107
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2;

		// Token: 0x04002B64 RID: 11108
		private static readonly System.IntPtr NativeMethodInfoPtr__WalkToDestination_b__29_1_Private_Boolean_0;

		// Token: 0x04002B65 RID: 11109
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3;

		// Token: 0x04002B66 RID: 11110
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002B67 RID: 11111
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002B68 RID: 11112
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002B69 RID: 11113
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000994 RID: 2452
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04008AC6 RID: 35526
			Idle,
			// Token: 0x04008AC7 RID: 35527
			WalkingToSource,
			// Token: 0x04008AC8 RID: 35528
			Grabbing,
			// Token: 0x04008AC9 RID: 35529
			WalkingToDestination,
			// Token: 0x04008ACA RID: 35530
			Placing
		}

		// Token: 0x02000995 RID: 2453
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.MoveItemBehaviour+<<GrabItem>g__Routine|27_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD02 RID: 52482 RVA: 0x0031D370 File Offset: 0x0031B570
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0()
			{
				Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<<GrabItem>g__Routine|27_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, "<>1__state");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, "<>2__current");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, "<>4__this");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100671162);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100671163);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100671164);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100671165);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100671166);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100671167);
			}

			// Token: 0x0600CD03 RID: 52483 RVA: 0x0031D450 File Offset: 0x0031B650
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD04 RID: 52484 RVA: 0x0031D498 File Offset: 0x0031B698
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD05 RID: 52485 RVA: 0x0031D4CC File Offset: 0x0031B6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153050, XrefRangeEnd = 153064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003F99 RID: 16281
			// (get) Token: 0x0600CD06 RID: 52486 RVA: 0x0031D508 File Offset: 0x0031B708
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD07 RID: 52487 RVA: 0x0031D548 File Offset: 0x0031B748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153064, XrefRangeEnd = 153069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003F9A RID: 16282
			// (get) Token: 0x0600CD08 RID: 52488 RVA: 0x0031D57C File Offset: 0x0031B77C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD09 RID: 52489 RVA: 0x000636B7 File Offset: 0x000618B7
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F96 RID: 16278
			// (get) Token: 0x0600CD0A RID: 52490 RVA: 0x0031D5BC File Offset: 0x0031B7BC
			// (set) Token: 0x0600CD0B RID: 52491 RVA: 0x000636C0 File Offset: 0x000618C0
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F97 RID: 16279
			// (get) Token: 0x0600CD0C RID: 52492 RVA: 0x0031D5E4 File Offset: 0x0031B7E4
			// (set) Token: 0x0600CD0D RID: 52493 RVA: 0x000636DB File Offset: 0x000618DB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F98 RID: 16280
			// (get) Token: 0x0600CD0E RID: 52494 RVA: 0x0031D614 File Offset: 0x0031B814
			// (set) Token: 0x0600CD0F RID: 52495 RVA: 0x000636FA File Offset: 0x000618FA
			public unsafe MoveItemBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ACB RID: 35531
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008ACC RID: 35532
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008ACD RID: 35533
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008ACE RID: 35534
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008ACF RID: 35535
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AD0 RID: 35536
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008AD1 RID: 35537
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008AD2 RID: 35538
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AD3 RID: 35539
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000996 RID: 2454
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.MoveItemBehaviour+<<PlaceItem>g__Routine|30_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600CD10 RID: 52496 RVA: 0x0031D644 File Offset: 0x0031B844
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1()
			{
				Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<<PlaceItem>g__Routine|30_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, "<>1__state");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, "<>2__current");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, "<>4__this");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100671168);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100671169);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100671170);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100671171);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100671172);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100671173);
			}

			// Token: 0x0600CD11 RID: 52497 RVA: 0x0031D724 File Offset: 0x0031B924
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD12 RID: 52498 RVA: 0x0031D76C File Offset: 0x0031B96C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD13 RID: 52499 RVA: 0x0031D7A0 File Offset: 0x0031B9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153069, XrefRangeEnd = 153116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003F9E RID: 16286
			// (get) Token: 0x0600CD14 RID: 52500 RVA: 0x0031D7DC File Offset: 0x0031B9DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD15 RID: 52501 RVA: 0x0031D81C File Offset: 0x0031BA1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153116, XrefRangeEnd = 153121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003F9F RID: 16287
			// (get) Token: 0x0600CD16 RID: 52502 RVA: 0x0031D850 File Offset: 0x0031BA50
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD17 RID: 52503 RVA: 0x00063719 File Offset: 0x00061919
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F9B RID: 16283
			// (get) Token: 0x0600CD18 RID: 52504 RVA: 0x0031D890 File Offset: 0x0031BA90
			// (set) Token: 0x0600CD19 RID: 52505 RVA: 0x00063722 File Offset: 0x00061922
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F9C RID: 16284
			// (get) Token: 0x0600CD1A RID: 52506 RVA: 0x0031D8B8 File Offset: 0x0031BAB8
			// (set) Token: 0x0600CD1B RID: 52507 RVA: 0x0006373D File Offset: 0x0006193D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F9D RID: 16285
			// (get) Token: 0x0600CD1C RID: 52508 RVA: 0x0031D8E8 File Offset: 0x0031BAE8
			// (set) Token: 0x0600CD1D RID: 52509 RVA: 0x0006375C File Offset: 0x0006195C
			public unsafe MoveItemBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AD4 RID: 35540
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008AD5 RID: 35541
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008AD6 RID: 35542
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AD7 RID: 35543
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AD8 RID: 35544
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AD9 RID: 35545
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008ADA RID: 35546
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008ADB RID: 35547
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008ADC RID: 35548
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000997 RID: 2455
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.MoveItemBehaviour+<<WalkToDestination>g__Routine|29_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2 : Il2CppSystem.Object
		{
			// Token: 0x0600CD1E RID: 52510 RVA: 0x0031D918 File Offset: 0x0031BB18
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2()
			{
				Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<<WalkToDestination>g__Routine|29_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, "<>1__state");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, "<>2__current");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, "<>4__this");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100671174);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100671175);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100671176);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100671177);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100671178);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100671179);
			}

			// Token: 0x0600CD1F RID: 52511 RVA: 0x0031D9F8 File Offset: 0x0031BBF8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD20 RID: 52512 RVA: 0x0031DA40 File Offset: 0x0031BC40
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD21 RID: 52513 RVA: 0x0031DA74 File Offset: 0x0031BC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153121, XrefRangeEnd = 153126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003FA3 RID: 16291
			// (get) Token: 0x0600CD22 RID: 52514 RVA: 0x0031DAB0 File Offset: 0x0031BCB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD23 RID: 52515 RVA: 0x0031DAF0 File Offset: 0x0031BCF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153126, XrefRangeEnd = 153131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003FA4 RID: 16292
			// (get) Token: 0x0600CD24 RID: 52516 RVA: 0x0031DB24 File Offset: 0x0031BD24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD25 RID: 52517 RVA: 0x0006377B File Offset: 0x0006197B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FA0 RID: 16288
			// (get) Token: 0x0600CD26 RID: 52518 RVA: 0x0031DB64 File Offset: 0x0031BD64
			// (set) Token: 0x0600CD27 RID: 52519 RVA: 0x00063784 File Offset: 0x00061984
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FA1 RID: 16289
			// (get) Token: 0x0600CD28 RID: 52520 RVA: 0x0031DB8C File Offset: 0x0031BD8C
			// (set) Token: 0x0600CD29 RID: 52521 RVA: 0x0006379F File Offset: 0x0006199F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA2 RID: 16290
			// (get) Token: 0x0600CD2A RID: 52522 RVA: 0x0031DBBC File Offset: 0x0031BDBC
			// (set) Token: 0x0600CD2B RID: 52523 RVA: 0x000637BE File Offset: 0x000619BE
			public unsafe MoveItemBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ADD RID: 35549
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008ADE RID: 35550
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008ADF RID: 35551
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AE0 RID: 35552
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AE1 RID: 35553
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AE2 RID: 35554
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008AE3 RID: 35555
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008AE4 RID: 35556
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AE5 RID: 35557
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000998 RID: 2456
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.MoveItemBehaviour+<<WalkToSource>g__Routine|26_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3 : Il2CppSystem.Object
		{
			// Token: 0x0600CD2C RID: 52524 RVA: 0x0031DBEC File Offset: 0x0031BDEC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3()
			{
				Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<<WalkToSource>g__Routine|26_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, "<>1__state");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, "<>2__current");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, "<>4__this");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100671180);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100671181);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100671182);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100671183);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100671184);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100671185);
			}

			// Token: 0x0600CD2D RID: 52525 RVA: 0x0031DCCC File Offset: 0x0031BECC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD2E RID: 52526 RVA: 0x0031DD14 File Offset: 0x0031BF14
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CD2F RID: 52527 RVA: 0x0031DD48 File Offset: 0x0031BF48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153131, XrefRangeEnd = 153136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003FA8 RID: 16296
			// (get) Token: 0x0600CD30 RID: 52528 RVA: 0x0031DD84 File Offset: 0x0031BF84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD31 RID: 52529 RVA: 0x0031DDC4 File Offset: 0x0031BFC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153136, XrefRangeEnd = 153141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003FA9 RID: 16297
			// (get) Token: 0x0600CD32 RID: 52530 RVA: 0x0031DDF8 File Offset: 0x0031BFF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CD33 RID: 52531 RVA: 0x000637DD File Offset: 0x000619DD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FA5 RID: 16293
			// (get) Token: 0x0600CD34 RID: 52532 RVA: 0x0031DE38 File Offset: 0x0031C038
			// (set) Token: 0x0600CD35 RID: 52533 RVA: 0x000637E6 File Offset: 0x000619E6
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FA6 RID: 16294
			// (get) Token: 0x0600CD36 RID: 52534 RVA: 0x0031DE60 File Offset: 0x0031C060
			// (set) Token: 0x0600CD37 RID: 52535 RVA: 0x00063801 File Offset: 0x00061A01
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA7 RID: 16295
			// (get) Token: 0x0600CD38 RID: 52536 RVA: 0x0031DE90 File Offset: 0x0031C090
			// (set) Token: 0x0600CD39 RID: 52537 RVA: 0x00063820 File Offset: 0x00061A20
			public unsafe MoveItemBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AE6 RID: 35558
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008AE7 RID: 35559
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008AE8 RID: 35560
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AE9 RID: 35561
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AEA RID: 35562
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AEB RID: 35563
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008AEC RID: 35564
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008AED RID: 35565
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AEE RID: 35566
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
