using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064B RID: 1611
	public class BodySearchScreen : Singleton<BodySearchScreen>
	{
		// Token: 0x06008CF9 RID: 36089 RVA: 0x00251120 File Offset: 0x0024F320
		// Note: this type is marked as 'beforefieldinit'.
		static BodySearchScreen()
		{
			Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BodySearchScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr);
			BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "MAX_SPEED_BOOST");
			BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			BodySearchScreen.NativeFieldInfoPtr_SlotRedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotRedColor");
			BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotHighlightRedColor");
			BodySearchScreen.NativeFieldInfoPtr_GapTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "GapTime");
			BodySearchScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "Canvas");
			BodySearchScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "Container");
			BodySearchScreen.NativeFieldInfoPtr_MinigameController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "MinigameController");
			BodySearchScreen.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotContainer");
			BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "ItemSlotPrefab");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicator");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicatorStart");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicatorEnd");
			BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "IndicatorAnimation");
			BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "TutorialAnimation");
			BodySearchScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "TutorialContainer");
			BodySearchScreen.NativeFieldInfoPtr_ResetAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "ResetAnimation");
			BodySearchScreen.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "slots");
			BodySearchScreen.NativeFieldInfoPtr_onSearchClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "onSearchClear");
			BodySearchScreen.NativeFieldInfoPtr_onSearchFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "onSearchFail");
			BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultSlotColor");
			BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultSlotHighlightColor");
			BodySearchScreen.NativeFieldInfoPtr_concealedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "concealedSlot");
			BodySearchScreen.NativeFieldInfoPtr_hoveredSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "hoveredSlot");
			BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultItemIconColors");
			BodySearchScreen.NativeFieldInfoPtr_speedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "speedBoost");
			BodySearchScreen.NativeFieldInfoPtr_searcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "searcher");
			BodySearchScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680913);
			BodySearchScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680914);
			BodySearchScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680915);
			BodySearchScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680916);
			BodySearchScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680917);
			BodySearchScreen.NativeMethodInfoPtr_SetupSlots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680918);
			BodySearchScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680919);
			BodySearchScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680920);
			BodySearchScreen.NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680921);
			BodySearchScreen.NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680922);
			BodySearchScreen.NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680923);
			BodySearchScreen.NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680924);
			BodySearchScreen.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680925);
			BodySearchScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680926);
			BodySearchScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680927);
			BodySearchScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680928);
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x06008CFA RID: 36090 RVA: 0x002514C0 File Offset: 0x0024F6C0
		// (set) Token: 0x06008CFB RID: 36091 RVA: 0x002514FC File Offset: 0x0024F6FC
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x06008CFC RID: 36092 RVA: 0x0025153C File Offset: 0x0024F73C
		// (set) Token: 0x06008CFD RID: 36093 RVA: 0x00251578 File Offset: 0x0024F778
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x002515B8 File Offset: 0x0024F7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258420, XrefRangeEnd = 258456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CFF RID: 36095 RVA: 0x002515F4 File Offset: 0x0024F7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258548, RefRangeEnd = 258549, XrefRangeStart = 258456, XrefRangeEnd = 258548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SetupSlots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D00 RID: 36096 RVA: 0x00251628 File Offset: 0x0024F828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258549, XrefRangeEnd = 258577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D01 RID: 36097 RVA: 0x0025165C File Offset: 0x0024F85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258656, RefRangeEnd = 258657, XrefRangeStart = 258577, XrefRangeEnd = 258656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC _searcher, float searchTime = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_searcher);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref searchTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D02 RID: 36098 RVA: 0x002516AC File Offset: 0x0024F8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258657, XrefRangeEnd = 258661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSlotConcealed(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008D03 RID: 36099 RVA: 0x002516FC File Offset: 0x0024F8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258661, XrefRangeEnd = 258665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ItemDetected(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D04 RID: 36100 RVA: 0x00251740 File Offset: 0x0024F940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258665, XrefRangeEnd = 258674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotHeld(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D05 RID: 36101 RVA: 0x00251784 File Offset: 0x0024F984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258674, XrefRangeEnd = 258679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotReleased(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D06 RID: 36102 RVA: 0x002517C8 File Offset: 0x0024F9C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258715, RefRangeEnd = 258717, XrefRangeStart = 258679, XrefRangeEnd = 258715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool clear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref clear;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D07 RID: 36103 RVA: 0x00251808 File Offset: 0x0024FA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258717, XrefRangeEnd = 258721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D08 RID: 36104 RVA: 0x0025183C File Offset: 0x0024FA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258721, XrefRangeEnd = 258724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D09 RID: 36105 RVA: 0x00251870 File Offset: 0x0024FA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258724, XrefRangeEnd = 258734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodySearchScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D0A RID: 36106 RVA: 0x0004326C File Offset: 0x0004146C
		public BodySearchScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x06008D0B RID: 36107 RVA: 0x002518AC File Offset: 0x0024FAAC
		// (set) Token: 0x06008D0C RID: 36108 RVA: 0x00043275 File Offset: 0x00041475
		public unsafe static float MAX_SPEED_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST, (void*)(&value));
			}
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x06008D0D RID: 36109 RVA: 0x002518C8 File Offset: 0x0024FAC8
		// (set) Token: 0x06008D0E RID: 36110 RVA: 0x00043283 File Offset: 0x00041483
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x06008D0F RID: 36111 RVA: 0x002518F0 File Offset: 0x0024FAF0
		// (set) Token: 0x06008D10 RID: 36112 RVA: 0x0004329E File Offset: 0x0004149E
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x06008D11 RID: 36113 RVA: 0x00251918 File Offset: 0x0024FB18
		// (set) Token: 0x06008D12 RID: 36114 RVA: 0x000432B9 File Offset: 0x000414B9
		public unsafe Color SlotRedColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotRedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotRedColor)) = value;
			}
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x06008D13 RID: 36115 RVA: 0x00251940 File Offset: 0x0024FB40
		// (set) Token: 0x06008D14 RID: 36116 RVA: 0x000432D4 File Offset: 0x000414D4
		public unsafe Color SlotHighlightRedColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor)) = value;
			}
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x06008D15 RID: 36117 RVA: 0x00251968 File Offset: 0x0024FB68
		// (set) Token: 0x06008D16 RID: 36118 RVA: 0x000432EF File Offset: 0x000414EF
		public unsafe float GapTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_GapTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_GapTime)) = value;
			}
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x06008D17 RID: 36119 RVA: 0x00251990 File Offset: 0x0024FB90
		// (set) Token: 0x06008D18 RID: 36120 RVA: 0x0004330A File Offset: 0x0004150A
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x06008D19 RID: 36121 RVA: 0x002519C0 File Offset: 0x0024FBC0
		// (set) Token: 0x06008D1A RID: 36122 RVA: 0x00043329 File Offset: 0x00041529
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x06008D1B RID: 36123 RVA: 0x002519F0 File Offset: 0x0024FBF0
		// (set) Token: 0x06008D1C RID: 36124 RVA: 0x00043348 File Offset: 0x00041548
		public unsafe RectTransform MinigameController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_MinigameController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_MinigameController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x06008D1D RID: 36125 RVA: 0x00251A20 File Offset: 0x0024FC20
		// (set) Token: 0x06008D1E RID: 36126 RVA: 0x00043367 File Offset: 0x00041567
		public unsafe RectTransform SlotContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x06008D1F RID: 36127 RVA: 0x00251A50 File Offset: 0x0024FC50
		// (set) Token: 0x06008D20 RID: 36128 RVA: 0x00043386 File Offset: 0x00041586
		public unsafe ItemSlotUI ItemSlotPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x06008D21 RID: 36129 RVA: 0x00251A80 File Offset: 0x0024FC80
		// (set) Token: 0x06008D22 RID: 36130 RVA: 0x000433A5 File Offset: 0x000415A5
		public unsafe RectTransform SearchIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x06008D23 RID: 36131 RVA: 0x00251AB0 File Offset: 0x0024FCB0
		// (set) Token: 0x06008D24 RID: 36132 RVA: 0x000433C4 File Offset: 0x000415C4
		public unsafe RectTransform SearchIndicatorStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x06008D25 RID: 36133 RVA: 0x00251AE0 File Offset: 0x0024FCE0
		// (set) Token: 0x06008D26 RID: 36134 RVA: 0x000433E3 File Offset: 0x000415E3
		public unsafe RectTransform SearchIndicatorEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x06008D27 RID: 36135 RVA: 0x00251B10 File Offset: 0x0024FD10
		// (set) Token: 0x06008D28 RID: 36136 RVA: 0x00043402 File Offset: 0x00041602
		public unsafe Animation IndicatorAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x06008D29 RID: 36137 RVA: 0x00251B40 File Offset: 0x0024FD40
		// (set) Token: 0x06008D2A RID: 36138 RVA: 0x00043421 File Offset: 0x00041621
		public unsafe Animation TutorialAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x06008D2B RID: 36139 RVA: 0x00251B70 File Offset: 0x0024FD70
		// (set) Token: 0x06008D2C RID: 36140 RVA: 0x00043440 File Offset: 0x00041640
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x06008D2D RID: 36141 RVA: 0x00251BA0 File Offset: 0x0024FDA0
		// (set) Token: 0x06008D2E RID: 36142 RVA: 0x0004345F File Offset: 0x0004165F
		public unsafe Animation ResetAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ResetAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ResetAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x06008D2F RID: 36143 RVA: 0x00251BD0 File Offset: 0x0024FDD0
		// (set) Token: 0x06008D30 RID: 36144 RVA: 0x0004347E File Offset: 0x0004167E
		public unsafe List<ItemSlotUI> slots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_slots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x06008D31 RID: 36145 RVA: 0x00251C00 File Offset: 0x0024FE00
		// (set) Token: 0x06008D32 RID: 36146 RVA: 0x0004349D File Offset: 0x0004169D
		public unsafe UnityEvent onSearchClear
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchClear);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchClear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x06008D33 RID: 36147 RVA: 0x00251C30 File Offset: 0x0024FE30
		// (set) Token: 0x06008D34 RID: 36148 RVA: 0x000434BC File Offset: 0x000416BC
		public unsafe UnityEvent onSearchFail
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchFail);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x00251C60 File Offset: 0x0024FE60
		// (set) Token: 0x06008D36 RID: 36150 RVA: 0x000434DB File Offset: 0x000416DB
		public unsafe Color defaultSlotColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor)) = value;
			}
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x06008D37 RID: 36151 RVA: 0x00251C88 File Offset: 0x0024FE88
		// (set) Token: 0x06008D38 RID: 36152 RVA: 0x000434F6 File Offset: 0x000416F6
		public unsafe Color defaultSlotHighlightColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor)) = value;
			}
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x06008D39 RID: 36153 RVA: 0x00251CB0 File Offset: 0x0024FEB0
		// (set) Token: 0x06008D3A RID: 36154 RVA: 0x00043511 File Offset: 0x00041711
		public unsafe ItemSlotUI concealedSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_concealedSlot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_concealedSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x06008D3B RID: 36155 RVA: 0x00251CE0 File Offset: 0x0024FEE0
		// (set) Token: 0x06008D3C RID: 36156 RVA: 0x00043530 File Offset: 0x00041730
		public unsafe ItemSlotUI hoveredSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_hoveredSlot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_hoveredSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x06008D3D RID: 36157 RVA: 0x00251D10 File Offset: 0x0024FF10
		// (set) Token: 0x06008D3E RID: 36158 RVA: 0x0004354F File Offset: 0x0004174F
		public unsafe Il2CppStructArray<Color> defaultItemIconColors
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x06008D3F RID: 36159 RVA: 0x00251D40 File Offset: 0x0024FF40
		// (set) Token: 0x06008D40 RID: 36160 RVA: 0x0004356E File Offset: 0x0004176E
		public unsafe float speedBoost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_speedBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_speedBoost)) = value;
			}
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x06008D41 RID: 36161 RVA: 0x00251D68 File Offset: 0x0024FF68
		// (set) Token: 0x06008D42 RID: 36162 RVA: 0x00043589 File Offset: 0x00041789
		public unsafe NPC searcher
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_searcher);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_searcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005FA9 RID: 24489
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SPEED_BOOST;

		// Token: 0x04005FAA RID: 24490
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005FAB RID: 24491
		private static readonly System.IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x04005FAC RID: 24492
		private static readonly System.IntPtr NativeFieldInfoPtr_SlotRedColor;

		// Token: 0x04005FAD RID: 24493
		private static readonly System.IntPtr NativeFieldInfoPtr_SlotHighlightRedColor;

		// Token: 0x04005FAE RID: 24494
		private static readonly System.IntPtr NativeFieldInfoPtr_GapTime;

		// Token: 0x04005FAF RID: 24495
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005FB0 RID: 24496
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005FB1 RID: 24497
		private static readonly System.IntPtr NativeFieldInfoPtr_MinigameController;

		// Token: 0x04005FB2 RID: 24498
		private static readonly System.IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x04005FB3 RID: 24499
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemSlotPrefab;

		// Token: 0x04005FB4 RID: 24500
		private static readonly System.IntPtr NativeFieldInfoPtr_SearchIndicator;

		// Token: 0x04005FB5 RID: 24501
		private static readonly System.IntPtr NativeFieldInfoPtr_SearchIndicatorStart;

		// Token: 0x04005FB6 RID: 24502
		private static readonly System.IntPtr NativeFieldInfoPtr_SearchIndicatorEnd;

		// Token: 0x04005FB7 RID: 24503
		private static readonly System.IntPtr NativeFieldInfoPtr_IndicatorAnimation;

		// Token: 0x04005FB8 RID: 24504
		private static readonly System.IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x04005FB9 RID: 24505
		private static readonly System.IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x04005FBA RID: 24506
		private static readonly System.IntPtr NativeFieldInfoPtr_ResetAnimation;

		// Token: 0x04005FBB RID: 24507
		private static readonly System.IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04005FBC RID: 24508
		private static readonly System.IntPtr NativeFieldInfoPtr_onSearchClear;

		// Token: 0x04005FBD RID: 24509
		private static readonly System.IntPtr NativeFieldInfoPtr_onSearchFail;

		// Token: 0x04005FBE RID: 24510
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultSlotColor;

		// Token: 0x04005FBF RID: 24511
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultSlotHighlightColor;

		// Token: 0x04005FC0 RID: 24512
		private static readonly System.IntPtr NativeFieldInfoPtr_concealedSlot;

		// Token: 0x04005FC1 RID: 24513
		private static readonly System.IntPtr NativeFieldInfoPtr_hoveredSlot;

		// Token: 0x04005FC2 RID: 24514
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultItemIconColors;

		// Token: 0x04005FC3 RID: 24515
		private static readonly System.IntPtr NativeFieldInfoPtr_speedBoost;

		// Token: 0x04005FC4 RID: 24516
		private static readonly System.IntPtr NativeFieldInfoPtr_searcher;

		// Token: 0x04005FC5 RID: 24517
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005FC6 RID: 24518
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005FC7 RID: 24519
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x04005FC8 RID: 24520
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005FC9 RID: 24521
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005FCA RID: 24522
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupSlots_Private_Void_0;

		// Token: 0x04005FCB RID: 24523
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005FCC RID: 24524
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0;

		// Token: 0x04005FCD RID: 24525
		private static readonly System.IntPtr NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0;

		// Token: 0x04005FCE RID: 24526
		private static readonly System.IntPtr NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0;

		// Token: 0x04005FCF RID: 24527
		private static readonly System.IntPtr NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0;

		// Token: 0x04005FD0 RID: 24528
		private static readonly System.IntPtr NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0;

		// Token: 0x04005FD1 RID: 24529
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04005FD2 RID: 24530
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04005FD3 RID: 24531
		private static readonly System.IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04005FD4 RID: 24532
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B61 RID: 2913
		[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBDB RID: 56283 RVA: 0x00347598 File Offset: 0x00345798
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr);
				BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, "slot");
				BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, 100680929);
				BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, 100680930);
				BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, 100680931);
			}

			// Token: 0x0600DBDC RID: 56284 RVA: 0x00347628 File Offset: 0x00345828
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBDD RID: 56285 RVA: 0x00347664 File Offset: 0x00345864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258328, XrefRangeEnd = 258337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBDE RID: 56286 RVA: 0x003476A8 File Offset: 0x003458A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258337, XrefRangeEnd = 258342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBDF RID: 56287 RVA: 0x0006AAC5 File Offset: 0x00068CC5
			public __c__DisplayClass35_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043CF RID: 17359
			// (get) Token: 0x0600DBE0 RID: 56288 RVA: 0x003476EC File Offset: 0x003458EC
			// (set) Token: 0x0600DBE1 RID: 56289 RVA: 0x0006AACE File Offset: 0x00068CCE
			public unsafe ItemSlotUI slot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr_slot);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D0 RID: 17360
			// (get) Token: 0x0600DBE2 RID: 56290 RVA: 0x0034771C File Offset: 0x0034591C
			// (set) Token: 0x0600DBE3 RID: 56291 RVA: 0x0006AAED File Offset: 0x00068CED
			public unsafe BodySearchScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093F1 RID: 37873
			private static readonly System.IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x040093F2 RID: 37874
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093F3 RID: 37875
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093F4 RID: 37876
			private static readonly System.IntPtr NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0;

			// Token: 0x040093F5 RID: 37877
			private static readonly System.IntPtr NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0;
		}

		// Token: 0x02000B62 RID: 2914
		[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBE4 RID: 56292 RVA: 0x0034774C File Offset: 0x0034594C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr);
				BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr_searchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, "searchTime");
				BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, 100680932);
				BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, 100680933);
				BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, 100680934);
			}

			// Token: 0x0600DBE5 RID: 56293 RVA: 0x003477DC File Offset: 0x003459DC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBE6 RID: 56294 RVA: 0x00347818 File Offset: 0x00345A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258415, XrefRangeEnd = 258420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DBE7 RID: 56295 RVA: 0x00347858 File Offset: 0x00345A58
			[CallerCount(0)]
			public unsafe bool _Open_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DBE8 RID: 56296 RVA: 0x0006AB0C File Offset: 0x00068D0C
			public __c__DisplayClass37_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D1 RID: 17361
			// (get) Token: 0x0600DBE9 RID: 56297 RVA: 0x00347894 File Offset: 0x00345A94
			// (set) Token: 0x0600DBEA RID: 56298 RVA: 0x0006AB15 File Offset: 0x00068D15
			public unsafe BodySearchScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D2 RID: 17362
			// (get) Token: 0x0600DBEB RID: 56299 RVA: 0x003478C4 File Offset: 0x00345AC4
			// (set) Token: 0x0600DBEC RID: 56300 RVA: 0x0006AB34 File Offset: 0x00068D34
			public unsafe float searchTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr_searchTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr_searchTime)) = value;
				}
			}

			// Token: 0x040093F6 RID: 37878
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093F7 RID: 37879
			private static readonly System.IntPtr NativeFieldInfoPtr_searchTime;

			// Token: 0x040093F8 RID: 37880
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093F9 RID: 37881
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040093FA RID: 37882
			private static readonly System.IntPtr NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0;

			// Token: 0x02000CC9 RID: 3273
			[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass37_0+<<Open>g__Search|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EA91 RID: 60049 RVA: 0x00371A7C File Offset: 0x0036FC7C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, "<<Open>g__Search|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<perGap>5__2");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<perBlock>5__3");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680935);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680936);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680937);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680938);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680939);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680940);
				}

				// Token: 0x0600EA92 RID: 60050 RVA: 0x00371B98 File Offset: 0x0036FD98
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA93 RID: 60051 RVA: 0x00371BE0 File Offset: 0x0036FDE0
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA94 RID: 60052 RVA: 0x00371C14 File Offset: 0x0036FE14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258342, XrefRangeEnd = 258410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004897 RID: 18583
				// (get) Token: 0x0600EA95 RID: 60053 RVA: 0x00371C50 File Offset: 0x0036FE50
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA96 RID: 60054 RVA: 0x00371C90 File Offset: 0x0036FE90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258410, XrefRangeEnd = 258415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004898 RID: 18584
				// (get) Token: 0x0600EA97 RID: 60055 RVA: 0x00371CC4 File Offset: 0x0036FEC4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA98 RID: 60056 RVA: 0x00072115 File Offset: 0x00070315
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004891 RID: 18577
				// (get) Token: 0x0600EA99 RID: 60057 RVA: 0x00371D04 File Offset: 0x0036FF04
				// (set) Token: 0x0600EA9A RID: 60058 RVA: 0x0007211E File Offset: 0x0007031E
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004892 RID: 18578
				// (get) Token: 0x0600EA9B RID: 60059 RVA: 0x00371D2C File Offset: 0x0036FF2C
				// (set) Token: 0x0600EA9C RID: 60060 RVA: 0x00072139 File Offset: 0x00070339
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004893 RID: 18579
				// (get) Token: 0x0600EA9D RID: 60061 RVA: 0x00371D5C File Offset: 0x0036FF5C
				// (set) Token: 0x0600EA9E RID: 60062 RVA: 0x00072158 File Offset: 0x00070358
				public unsafe BodySearchScreen.__c__DisplayClass37_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen.__c__DisplayClass37_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004894 RID: 18580
				// (get) Token: 0x0600EA9F RID: 60063 RVA: 0x00371D8C File Offset: 0x0036FF8C
				// (set) Token: 0x0600EAA0 RID: 60064 RVA: 0x00072177 File Offset: 0x00070377
				public unsafe float _perGap_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2)) = value;
					}
				}

				// Token: 0x17004895 RID: 18581
				// (get) Token: 0x0600EAA1 RID: 60065 RVA: 0x00371DB4 File Offset: 0x0036FFB4
				// (set) Token: 0x0600EAA2 RID: 60066 RVA: 0x00072192 File Offset: 0x00070392
				public unsafe float _perBlock_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3)) = value;
					}
				}

				// Token: 0x17004896 RID: 18582
				// (get) Token: 0x0600EAA3 RID: 60067 RVA: 0x00371DDC File Offset: 0x0036FFDC
				// (set) Token: 0x0600EAA4 RID: 60068 RVA: 0x000721AD File Offset: 0x000703AD
				public unsafe float _i_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009CEC RID: 40172
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009CED RID: 40173
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009CEE RID: 40174
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009CEF RID: 40175
				private static readonly System.IntPtr NativeFieldInfoPtr__perGap_5__2;

				// Token: 0x04009CF0 RID: 40176
				private static readonly System.IntPtr NativeFieldInfoPtr__perBlock_5__3;

				// Token: 0x04009CF1 RID: 40177
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009CF2 RID: 40178
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009CF3 RID: 40179
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CF4 RID: 40180
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009CF5 RID: 40181
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009CF6 RID: 40182
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CF7 RID: 40183
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
