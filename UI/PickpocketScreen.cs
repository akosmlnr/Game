using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000676 RID: 1654
	public class PickpocketScreen : Singleton<PickpocketScreen>
	{
		// Token: 0x0600925E RID: 37470 RVA: 0x002610B0 File Offset: 0x0025F2B0
		// Note: this type is marked as 'beforefieldinit'.
		static PickpocketScreen()
		{
			Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PickpocketScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr);
			PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "PICKPOCKET_XP");
			PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreaMaxWidth");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreaMinWidth");
			PickpocketScreen.NativeFieldInfoPtr_SlideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SlideTime");
			PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SlideTimeMaxMultiplier");
			PickpocketScreen.NativeFieldInfoPtr_ValueDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "ValueDivisor");
			PickpocketScreen.NativeFieldInfoPtr_Tolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Tolerance");
			PickpocketScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Canvas");
			PickpocketScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Container");
			PickpocketScreen.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Slots");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreas");
			PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "TutorialAnimation");
			PickpocketScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "TutorialContainer");
			PickpocketScreen.NativeFieldInfoPtr_SliderContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SliderContainer");
			PickpocketScreen.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Slider");
			PickpocketScreen.NativeFieldInfoPtr_InputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "InputPrompt");
			PickpocketScreen.NativeFieldInfoPtr_onFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onFail");
			PickpocketScreen.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onStop");
			PickpocketScreen.NativeFieldInfoPtr_onHitGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onHitGreen");
			PickpocketScreen.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "npc");
			PickpocketScreen.NativeFieldInfoPtr_isSliding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "isSliding");
			PickpocketScreen.NativeFieldInfoPtr_slideDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "slideDirection");
			PickpocketScreen.NativeFieldInfoPtr_sliderPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "sliderPosition");
			PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "slideTimeMultiplier");
			PickpocketScreen.NativeFieldInfoPtr_isFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "isFail");
			PickpocketScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681525);
			PickpocketScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681526);
			PickpocketScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681527);
			PickpocketScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681528);
			PickpocketScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681529);
			PickpocketScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681530);
			PickpocketScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681531);
			PickpocketScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681532);
			PickpocketScreen.NativeMethodInfoPtr_StopArrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681533);
			PickpocketScreen.NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681534);
			PickpocketScreen.NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681535);
			PickpocketScreen.NativeMethodInfoPtr_Fail_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681536);
			PickpocketScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681537);
			PickpocketScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681538);
			PickpocketScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681539);
			PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681540);
			PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681541);
			PickpocketScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681542);
			PickpocketScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681543);
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x0600925F RID: 37471 RVA: 0x00261478 File Offset: 0x0025F678
		// (set) Token: 0x06009260 RID: 37472 RVA: 0x002614B4 File Offset: 0x0025F6B4
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x06009261 RID: 37473 RVA: 0x002614F4 File Offset: 0x0025F6F4
		// (set) Token: 0x06009262 RID: 37474 RVA: 0x00261530 File Offset: 0x0025F730
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009263 RID: 37475 RVA: 0x00261570 File Offset: 0x0025F770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265103, XrefRangeEnd = 265120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickpocketScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x002615AC File Offset: 0x0025F7AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265226, RefRangeEnd = 265228, XrefRangeStart = 265120, XrefRangeEnd = 265226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC _npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009265 RID: 37477 RVA: 0x002615F0 File Offset: 0x0025F7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265228, XrefRangeEnd = 265230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x00261634 File Offset: 0x0025F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265230, XrefRangeEnd = 265258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x00261668 File Offset: 0x0025F868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265279, RefRangeEnd = 265280, XrefRangeStart = 265258, XrefRangeEnd = 265279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopArrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_StopArrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x0026169C File Offset: 0x0025F89C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265289, RefRangeEnd = 265290, XrefRangeStart = 265280, XrefRangeEnd = 265289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked(int index, bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locked;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x002616E8 File Offset: 0x0025F8E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 265297, RefRangeEnd = 265300, XrefRangeStart = 265290, XrefRangeEnd = 265297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI GetHoveredSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x00261728 File Offset: 0x0025F928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265300, XrefRangeEnd = 265307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Fail_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x0026175C File Offset: 0x0025F95C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265362, RefRangeEnd = 265363, XrefRangeStart = 265307, XrefRangeEnd = 265362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x00261790 File Offset: 0x0025F990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265363, XrefRangeEnd = 265367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x002617C4 File Offset: 0x0025F9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265367, XrefRangeEnd = 265370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x002617F8 File Offset: 0x0025F9F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265372, RefRangeEnd = 265374, XrefRangeStart = 265370, XrefRangeEnd = 265372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetGreenAreaNormalizedPosition(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x00261844 File Offset: 0x0025FA44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265376, RefRangeEnd = 265378, XrefRangeStart = 265374, XrefRangeEnd = 265376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetGreenAreaNormalizedWidth(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x00261890 File Offset: 0x0025FA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265378, XrefRangeEnd = 265381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PickpocketScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009271 RID: 37489 RVA: 0x002618CC File Offset: 0x0025FACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265381, XrefRangeEnd = 265386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x00046598 File Offset: 0x00044798
		public PickpocketScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x06009273 RID: 37491 RVA: 0x0026190C File Offset: 0x0025FB0C
		// (set) Token: 0x06009274 RID: 37492 RVA: 0x000465A1 File Offset: 0x000447A1
		public unsafe static int PICKPOCKET_XP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP, (void*)(&value));
			}
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x06009275 RID: 37493 RVA: 0x00261928 File Offset: 0x0025FB28
		// (set) Token: 0x06009276 RID: 37494 RVA: 0x000465AF File Offset: 0x000447AF
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x06009277 RID: 37495 RVA: 0x00261950 File Offset: 0x0025FB50
		// (set) Token: 0x06009278 RID: 37496 RVA: 0x000465CA File Offset: 0x000447CA
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x06009279 RID: 37497 RVA: 0x00261978 File Offset: 0x0025FB78
		// (set) Token: 0x0600927A RID: 37498 RVA: 0x000465E5 File Offset: 0x000447E5
		public unsafe float GreenAreaMaxWidth
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth)) = value;
			}
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x0600927B RID: 37499 RVA: 0x002619A0 File Offset: 0x0025FBA0
		// (set) Token: 0x0600927C RID: 37500 RVA: 0x00046600 File Offset: 0x00044800
		public unsafe float GreenAreaMinWidth
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth)) = value;
			}
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x0600927D RID: 37501 RVA: 0x002619C8 File Offset: 0x0025FBC8
		// (set) Token: 0x0600927E RID: 37502 RVA: 0x0004661B File Offset: 0x0004481B
		public unsafe float SlideTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTime)) = value;
			}
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x0600927F RID: 37503 RVA: 0x002619F0 File Offset: 0x0025FBF0
		// (set) Token: 0x06009280 RID: 37504 RVA: 0x00046636 File Offset: 0x00044836
		public unsafe float SlideTimeMaxMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier)) = value;
			}
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x06009281 RID: 37505 RVA: 0x00261A18 File Offset: 0x0025FC18
		// (set) Token: 0x06009282 RID: 37506 RVA: 0x00046651 File Offset: 0x00044851
		public unsafe float ValueDivisor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ValueDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ValueDivisor)) = value;
			}
		}

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x06009283 RID: 37507 RVA: 0x00261A40 File Offset: 0x0025FC40
		// (set) Token: 0x06009284 RID: 37508 RVA: 0x0004666C File Offset: 0x0004486C
		public unsafe float Tolerance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Tolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Tolerance)) = value;
			}
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x06009285 RID: 37509 RVA: 0x00261A68 File Offset: 0x0025FC68
		// (set) Token: 0x06009286 RID: 37510 RVA: 0x00046687 File Offset: 0x00044887
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x06009287 RID: 37511 RVA: 0x00261A98 File Offset: 0x0025FC98
		// (set) Token: 0x06009288 RID: 37512 RVA: 0x000466A6 File Offset: 0x000448A6
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x06009289 RID: 37513 RVA: 0x00261AC8 File Offset: 0x0025FCC8
		// (set) Token: 0x0600928A RID: 37514 RVA: 0x000466C5 File Offset: 0x000448C5
		public unsafe Il2CppReferenceArray<ItemSlotUI> Slots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x0600928B RID: 37515 RVA: 0x00261AF8 File Offset: 0x0025FCF8
		// (set) Token: 0x0600928C RID: 37516 RVA: 0x000466E4 File Offset: 0x000448E4
		public unsafe Il2CppReferenceArray<RectTransform> GreenAreas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x0600928D RID: 37517 RVA: 0x00261B28 File Offset: 0x0025FD28
		// (set) Token: 0x0600928E RID: 37518 RVA: 0x00046703 File Offset: 0x00044903
		public unsafe Animation TutorialAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x0600928F RID: 37519 RVA: 0x00261B58 File Offset: 0x0025FD58
		// (set) Token: 0x06009290 RID: 37520 RVA: 0x00046722 File Offset: 0x00044922
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x06009291 RID: 37521 RVA: 0x00261B88 File Offset: 0x0025FD88
		// (set) Token: 0x06009292 RID: 37522 RVA: 0x00046741 File Offset: 0x00044941
		public unsafe RectTransform SliderContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SliderContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SliderContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x06009293 RID: 37523 RVA: 0x00261BB8 File Offset: 0x0025FDB8
		// (set) Token: 0x06009294 RID: 37524 RVA: 0x00046760 File Offset: 0x00044960
		public unsafe Slider Slider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x06009295 RID: 37525 RVA: 0x00261BE8 File Offset: 0x0025FDE8
		// (set) Token: 0x06009296 RID: 37526 RVA: 0x0004677F File Offset: 0x0004497F
		public unsafe InputPrompt InputPrompt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_InputPrompt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_InputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x06009297 RID: 37527 RVA: 0x00261C18 File Offset: 0x0025FE18
		// (set) Token: 0x06009298 RID: 37528 RVA: 0x0004679E File Offset: 0x0004499E
		public unsafe UnityEvent onFail
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onFail);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x06009299 RID: 37529 RVA: 0x00261C48 File Offset: 0x0025FE48
		// (set) Token: 0x0600929A RID: 37530 RVA: 0x000467BD File Offset: 0x000449BD
		public unsafe UnityEvent onStop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onStop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x0600929B RID: 37531 RVA: 0x00261C78 File Offset: 0x0025FE78
		// (set) Token: 0x0600929C RID: 37532 RVA: 0x000467DC File Offset: 0x000449DC
		public unsafe UnityEvent onHitGreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onHitGreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onHitGreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x0600929D RID: 37533 RVA: 0x00261CA8 File Offset: 0x0025FEA8
		// (set) Token: 0x0600929E RID: 37534 RVA: 0x000467FB File Offset: 0x000449FB
		public unsafe NPC npc
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_npc);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x0600929F RID: 37535 RVA: 0x00261CD8 File Offset: 0x0025FED8
		// (set) Token: 0x060092A0 RID: 37536 RVA: 0x0004681A File Offset: 0x00044A1A
		public unsafe bool isSliding
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isSliding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isSliding)) = value;
			}
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x060092A1 RID: 37537 RVA: 0x00261D00 File Offset: 0x0025FF00
		// (set) Token: 0x060092A2 RID: 37538 RVA: 0x00046835 File Offset: 0x00044A35
		public unsafe int slideDirection
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideDirection)) = value;
			}
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x060092A3 RID: 37539 RVA: 0x00261D28 File Offset: 0x0025FF28
		// (set) Token: 0x060092A4 RID: 37540 RVA: 0x00046850 File Offset: 0x00044A50
		public unsafe float sliderPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_sliderPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_sliderPosition)) = value;
			}
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x060092A5 RID: 37541 RVA: 0x00261D50 File Offset: 0x0025FF50
		// (set) Token: 0x060092A6 RID: 37542 RVA: 0x0004686B File Offset: 0x00044A6B
		public unsafe float slideTimeMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier)) = value;
			}
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x060092A7 RID: 37543 RVA: 0x00261D78 File Offset: 0x0025FF78
		// (set) Token: 0x060092A8 RID: 37544 RVA: 0x00046886 File Offset: 0x00044A86
		public unsafe bool isFail
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isFail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isFail)) = value;
			}
		}

		// Token: 0x04006309 RID: 25353
		private static readonly System.IntPtr NativeFieldInfoPtr_PICKPOCKET_XP;

		// Token: 0x0400630A RID: 25354
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400630B RID: 25355
		private static readonly System.IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x0400630C RID: 25356
		private static readonly System.IntPtr NativeFieldInfoPtr_GreenAreaMaxWidth;

		// Token: 0x0400630D RID: 25357
		private static readonly System.IntPtr NativeFieldInfoPtr_GreenAreaMinWidth;

		// Token: 0x0400630E RID: 25358
		private static readonly System.IntPtr NativeFieldInfoPtr_SlideTime;

		// Token: 0x0400630F RID: 25359
		private static readonly System.IntPtr NativeFieldInfoPtr_SlideTimeMaxMultiplier;

		// Token: 0x04006310 RID: 25360
		private static readonly System.IntPtr NativeFieldInfoPtr_ValueDivisor;

		// Token: 0x04006311 RID: 25361
		private static readonly System.IntPtr NativeFieldInfoPtr_Tolerance;

		// Token: 0x04006312 RID: 25362
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006313 RID: 25363
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006314 RID: 25364
		private static readonly System.IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04006315 RID: 25365
		private static readonly System.IntPtr NativeFieldInfoPtr_GreenAreas;

		// Token: 0x04006316 RID: 25366
		private static readonly System.IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x04006317 RID: 25367
		private static readonly System.IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x04006318 RID: 25368
		private static readonly System.IntPtr NativeFieldInfoPtr_SliderContainer;

		// Token: 0x04006319 RID: 25369
		private static readonly System.IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x0400631A RID: 25370
		private static readonly System.IntPtr NativeFieldInfoPtr_InputPrompt;

		// Token: 0x0400631B RID: 25371
		private static readonly System.IntPtr NativeFieldInfoPtr_onFail;

		// Token: 0x0400631C RID: 25372
		private static readonly System.IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x0400631D RID: 25373
		private static readonly System.IntPtr NativeFieldInfoPtr_onHitGreen;

		// Token: 0x0400631E RID: 25374
		private static readonly System.IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400631F RID: 25375
		private static readonly System.IntPtr NativeFieldInfoPtr_isSliding;

		// Token: 0x04006320 RID: 25376
		private static readonly System.IntPtr NativeFieldInfoPtr_slideDirection;

		// Token: 0x04006321 RID: 25377
		private static readonly System.IntPtr NativeFieldInfoPtr_sliderPosition;

		// Token: 0x04006322 RID: 25378
		private static readonly System.IntPtr NativeFieldInfoPtr_slideTimeMultiplier;

		// Token: 0x04006323 RID: 25379
		private static readonly System.IntPtr NativeFieldInfoPtr_isFail;

		// Token: 0x04006324 RID: 25380
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006325 RID: 25381
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006326 RID: 25382
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x04006327 RID: 25383
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006328 RID: 25384
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006329 RID: 25385
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_0;

		// Token: 0x0400632A RID: 25386
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400632B RID: 25387
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400632C RID: 25388
		private static readonly System.IntPtr NativeMethodInfoPtr_StopArrow_Private_Void_0;

		// Token: 0x0400632D RID: 25389
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0;

		// Token: 0x0400632E RID: 25390
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0;

		// Token: 0x0400632F RID: 25391
		private static readonly System.IntPtr NativeMethodInfoPtr_Fail_Private_Void_0;

		// Token: 0x04006330 RID: 25392
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006331 RID: 25393
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04006332 RID: 25394
		private static readonly System.IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04006333 RID: 25395
		private static readonly System.IntPtr NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0;

		// Token: 0x04006334 RID: 25396
		private static readonly System.IntPtr NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0;

		// Token: 0x04006335 RID: 25397
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006336 RID: 25398
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B87 RID: 2951
		[ObfuscatedName("ScheduleOne.UI.PickpocketScreen+<<Fail>g__FailCoroutine|40_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DD6B RID: 56683 RVA: 0x0034BB34 File Offset: 0x00349D34
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique()
			{
				Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<<Fail>g__FailCoroutine|40_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>1__state");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>2__current");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>4__this");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681544);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681545);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681546);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681547);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681548);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681549);
			}

			// Token: 0x0600DD6C RID: 56684 RVA: 0x0034BC14 File Offset: 0x00349E14
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD6D RID: 56685 RVA: 0x0034BC5C File Offset: 0x00349E5C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD6E RID: 56686 RVA: 0x0034BC90 File Offset: 0x00349E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265093, XrefRangeEnd = 265098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004458 RID: 17496
			// (get) Token: 0x0600DD6F RID: 56687 RVA: 0x0034BCCC File Offset: 0x00349ECC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DD70 RID: 56688 RVA: 0x0034BD0C File Offset: 0x00349F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265098, XrefRangeEnd = 265103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004459 RID: 17497
			// (get) Token: 0x0600DD71 RID: 56689 RVA: 0x0034BD40 File Offset: 0x00349F40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DD72 RID: 56690 RVA: 0x0006B832 File Offset: 0x00069A32
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004455 RID: 17493
			// (get) Token: 0x0600DD73 RID: 56691 RVA: 0x0034BD80 File Offset: 0x00349F80
			// (set) Token: 0x0600DD74 RID: 56692 RVA: 0x0006B83B File Offset: 0x00069A3B
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004456 RID: 17494
			// (get) Token: 0x0600DD75 RID: 56693 RVA: 0x0034BDA8 File Offset: 0x00349FA8
			// (set) Token: 0x0600DD76 RID: 56694 RVA: 0x0006B856 File Offset: 0x00069A56
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004457 RID: 17495
			// (get) Token: 0x0600DD77 RID: 56695 RVA: 0x0034BDD8 File Offset: 0x00349FD8
			// (set) Token: 0x0600DD78 RID: 56696 RVA: 0x0006B875 File Offset: 0x00069A75
			public unsafe PickpocketScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PickpocketScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094E3 RID: 38115
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094E4 RID: 38116
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094E5 RID: 38117
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094E6 RID: 38118
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094E7 RID: 38119
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094E8 RID: 38120
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094E9 RID: 38121
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094EA RID: 38122
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094EB RID: 38123
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
