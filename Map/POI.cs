using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007B1 RID: 1969
	public class POI : MonoBehaviour
	{
		// Token: 0x0600BA1B RID: 47643 RVA: 0x002E647C File Offset: 0x002E467C
		// Note: this type is marked as 'beforefieldinit'.
		static POI()
		{
			Il2CppClassPointerStore<POI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "POI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI>.NativeClassPtr);
			POI.NativeFieldInfoPtr__UISetup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<UISetup>k__BackingField");
			POI.NativeFieldInfoPtr_MainTextVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "MainTextVisibility");
			POI.NativeFieldInfoPtr_DefaultMainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "DefaultMainText");
			POI.NativeFieldInfoPtr_AutoUpdatePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "AutoUpdatePosition");
			POI.NativeFieldInfoPtr_Rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "Rotate");
			POI.NativeFieldInfoPtr__MainText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<MainText>k__BackingField");
			POI.NativeFieldInfoPtr_UIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "UIPrefab");
			POI.NativeFieldInfoPtr__UI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<UI>k__BackingField");
			POI.NativeFieldInfoPtr__IconContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<IconContainer>k__BackingField");
			POI.NativeFieldInfoPtr_mainLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "mainLabel");
			POI.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "button");
			POI.NativeFieldInfoPtr_eventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "eventTrigger");
			POI.NativeFieldInfoPtr_mainTextSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "mainTextSet");
			POI.NativeFieldInfoPtr_onUICreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "onUICreated");
			POI.NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686328);
			POI.NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686329);
			POI.NativeMethodInfoPtr_get_MainText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686330);
			POI.NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686331);
			POI.NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686332);
			POI.NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686333);
			POI.NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686334);
			POI.NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686335);
			POI.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686336);
			POI.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686337);
			POI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686338);
			POI.NativeMethodInfoPtr_SetMainText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686339);
			POI.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686340);
			POI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686341);
			POI.NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686342);
			POI.NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686343);
			POI.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686344);
			POI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686345);
			POI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686346);
			POI.NativeMethodInfoPtr__InitializeUI_b__32_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686347);
			POI.NativeMethodInfoPtr__InitializeUI_b__32_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686348);
			POI.NativeMethodInfoPtr__InitializeUI_b__32_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100686349);
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0600BA1C RID: 47644 RVA: 0x002E677C File Offset: 0x002E497C
		// (set) Token: 0x0600BA1D RID: 47645 RVA: 0x002E67B8 File Offset: 0x002E49B8
		public unsafe bool UISetup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0600BA1E RID: 47646 RVA: 0x002E67F8 File Offset: 0x002E49F8
		// (set) Token: 0x0600BA1F RID: 47647 RVA: 0x002E6830 File Offset: 0x002E4A30
		public unsafe string MainText
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_MainText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0600BA20 RID: 47648 RVA: 0x002E6874 File Offset: 0x002E4A74
		// (set) Token: 0x0600BA21 RID: 47649 RVA: 0x002E68B4 File Offset: 0x002E4AB4
		public unsafe RectTransform UI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0600BA22 RID: 47650 RVA: 0x002E68F8 File Offset: 0x002E4AF8
		// (set) Token: 0x0600BA23 RID: 47651 RVA: 0x002E6938 File Offset: 0x002E4B38
		public unsafe RectTransform IconContainer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600BA24 RID: 47652 RVA: 0x002E697C File Offset: 0x002E4B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317107, XrefRangeEnd = 317132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA25 RID: 47653 RVA: 0x002E69B0 File Offset: 0x002E4BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317132, XrefRangeEnd = 317141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA26 RID: 47654 RVA: 0x002E69E4 File Offset: 0x002E4BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317141, XrefRangeEnd = 317148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA27 RID: 47655 RVA: 0x002E6A18 File Offset: 0x002E4C18
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 317153, RefRangeEnd = 317167, XrefRangeStart = 317148, XrefRangeEnd = 317153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMainText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_SetMainText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA28 RID: 47656 RVA: 0x002E6A5C File Offset: 0x002E4C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317167, XrefRangeEnd = 317192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA29 RID: 47657 RVA: 0x002E6A98 File Offset: 0x002E4C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317279, RefRangeEnd = 317280, XrefRangeStart = 317192, XrefRangeEnd = 317279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA2A RID: 47658 RVA: 0x002E6AD4 File Offset: 0x002E4CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317280, XrefRangeEnd = 317281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA2B RID: 47659 RVA: 0x002E6B10 File Offset: 0x002E4D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317281, XrefRangeEnd = 317282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA2C RID: 47660 RVA: 0x002E6B4C File Offset: 0x002E4D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317282, XrefRangeEnd = 317289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA2D RID: 47661 RVA: 0x002E6B88 File Offset: 0x002E4D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe POI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA2E RID: 47662 RVA: 0x002E6BC4 File Offset: 0x002E4DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317289, XrefRangeEnd = 317294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600BA2F RID: 47663 RVA: 0x002E6C04 File Offset: 0x002E4E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317294, RefRangeEnd = 317296, XrefRangeStart = 317294, XrefRangeEnd = 317294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__32_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__32_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA30 RID: 47664 RVA: 0x002E6C48 File Offset: 0x002E4E48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 40160, RefRangeEnd = 40167, XrefRangeStart = 40160, XrefRangeEnd = 40167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__32_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__32_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA31 RID: 47665 RVA: 0x002E6C8C File Offset: 0x002E4E8C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 87251, RefRangeEnd = 87270, XrefRangeStart = 87251, XrefRangeEnd = 87270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__32_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__32_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA32 RID: 47666 RVA: 0x0005AFC1 File Offset: 0x000591C1
		public POI(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0600BA33 RID: 47667 RVA: 0x002E6CC0 File Offset: 0x002E4EC0
		// (set) Token: 0x0600BA34 RID: 47668 RVA: 0x0005AFCA File Offset: 0x000591CA
		public unsafe bool _UISetup_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UISetup_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UISetup_k__BackingField)) = value;
			}
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0600BA35 RID: 47669 RVA: 0x002E6CE8 File Offset: 0x002E4EE8
		// (set) Token: 0x0600BA36 RID: 47670 RVA: 0x0005AFE5 File Offset: 0x000591E5
		public unsafe POI.TextShowMode MainTextVisibility
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_MainTextVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_MainTextVisibility)) = value;
			}
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0600BA37 RID: 47671 RVA: 0x002E6D10 File Offset: 0x002E4F10
		// (set) Token: 0x0600BA38 RID: 47672 RVA: 0x0005B000 File Offset: 0x00059200
		public unsafe string DefaultMainText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_DefaultMainText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_DefaultMainText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0600BA39 RID: 47673 RVA: 0x002E6D38 File Offset: 0x002E4F38
		// (set) Token: 0x0600BA3A RID: 47674 RVA: 0x0005B01F File Offset: 0x0005921F
		public unsafe bool AutoUpdatePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_AutoUpdatePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_AutoUpdatePosition)) = value;
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0600BA3B RID: 47675 RVA: 0x002E6D60 File Offset: 0x002E4F60
		// (set) Token: 0x0600BA3C RID: 47676 RVA: 0x0005B03A File Offset: 0x0005923A
		public unsafe bool Rotate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_Rotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_Rotate)) = value;
			}
		}

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0600BA3D RID: 47677 RVA: 0x002E6D88 File Offset: 0x002E4F88
		// (set) Token: 0x0600BA3E RID: 47678 RVA: 0x0005B055 File Offset: 0x00059255
		public unsafe string _MainText_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__MainText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__MainText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0600BA3F RID: 47679 RVA: 0x002E6DB0 File Offset: 0x002E4FB0
		// (set) Token: 0x0600BA40 RID: 47680 RVA: 0x0005B074 File Offset: 0x00059274
		public unsafe GameObject UIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_UIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_UIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0600BA41 RID: 47681 RVA: 0x002E6DE0 File Offset: 0x002E4FE0
		// (set) Token: 0x0600BA42 RID: 47682 RVA: 0x0005B093 File Offset: 0x00059293
		public unsafe RectTransform _UI_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UI_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0600BA43 RID: 47683 RVA: 0x002E6E10 File Offset: 0x002E5010
		// (set) Token: 0x0600BA44 RID: 47684 RVA: 0x0005B0B2 File Offset: 0x000592B2
		public unsafe RectTransform _IconContainer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__IconContainer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__IconContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0600BA45 RID: 47685 RVA: 0x002E6E40 File Offset: 0x002E5040
		// (set) Token: 0x0600BA46 RID: 47686 RVA: 0x0005B0D1 File Offset: 0x000592D1
		public unsafe Text mainLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0600BA47 RID: 47687 RVA: 0x002E6E70 File Offset: 0x002E5070
		// (set) Token: 0x0600BA48 RID: 47688 RVA: 0x0005B0F0 File Offset: 0x000592F0
		public unsafe Button button
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_button);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0600BA49 RID: 47689 RVA: 0x002E6EA0 File Offset: 0x002E50A0
		// (set) Token: 0x0600BA4A RID: 47690 RVA: 0x0005B10F File Offset: 0x0005930F
		public unsafe EventTrigger eventTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_eventTrigger);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_eventTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0600BA4B RID: 47691 RVA: 0x002E6ED0 File Offset: 0x002E50D0
		// (set) Token: 0x0600BA4C RID: 47692 RVA: 0x0005B12E File Offset: 0x0005932E
		public unsafe bool mainTextSet
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainTextSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainTextSet)) = value;
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0600BA4D RID: 47693 RVA: 0x002E6EF8 File Offset: 0x002E50F8
		// (set) Token: 0x0600BA4E RID: 47694 RVA: 0x0005B149 File Offset: 0x00059349
		public unsafe UnityEvent onUICreated
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_onUICreated);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_onUICreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D84 RID: 32132
		private static readonly System.IntPtr NativeFieldInfoPtr__UISetup_k__BackingField;

		// Token: 0x04007D85 RID: 32133
		private static readonly System.IntPtr NativeFieldInfoPtr_MainTextVisibility;

		// Token: 0x04007D86 RID: 32134
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultMainText;

		// Token: 0x04007D87 RID: 32135
		private static readonly System.IntPtr NativeFieldInfoPtr_AutoUpdatePosition;

		// Token: 0x04007D88 RID: 32136
		private static readonly System.IntPtr NativeFieldInfoPtr_Rotate;

		// Token: 0x04007D89 RID: 32137
		private static readonly System.IntPtr NativeFieldInfoPtr__MainText_k__BackingField;

		// Token: 0x04007D8A RID: 32138
		private static readonly System.IntPtr NativeFieldInfoPtr_UIPrefab;

		// Token: 0x04007D8B RID: 32139
		private static readonly System.IntPtr NativeFieldInfoPtr__UI_k__BackingField;

		// Token: 0x04007D8C RID: 32140
		private static readonly System.IntPtr NativeFieldInfoPtr__IconContainer_k__BackingField;

		// Token: 0x04007D8D RID: 32141
		private static readonly System.IntPtr NativeFieldInfoPtr_mainLabel;

		// Token: 0x04007D8E RID: 32142
		private static readonly System.IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04007D8F RID: 32143
		private static readonly System.IntPtr NativeFieldInfoPtr_eventTrigger;

		// Token: 0x04007D90 RID: 32144
		private static readonly System.IntPtr NativeFieldInfoPtr_mainTextSet;

		// Token: 0x04007D91 RID: 32145
		private static readonly System.IntPtr NativeFieldInfoPtr_onUICreated;

		// Token: 0x04007D92 RID: 32146
		private static readonly System.IntPtr NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0;

		// Token: 0x04007D93 RID: 32147
		private static readonly System.IntPtr NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0;

		// Token: 0x04007D94 RID: 32148
		private static readonly System.IntPtr NativeMethodInfoPtr_get_MainText_Public_get_String_0;

		// Token: 0x04007D95 RID: 32149
		private static readonly System.IntPtr NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0;

		// Token: 0x04007D96 RID: 32150
		private static readonly System.IntPtr NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0;

		// Token: 0x04007D97 RID: 32151
		private static readonly System.IntPtr NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0;

		// Token: 0x04007D98 RID: 32152
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0;

		// Token: 0x04007D99 RID: 32153
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0;

		// Token: 0x04007D9A RID: 32154
		private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04007D9B RID: 32155
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04007D9C RID: 32156
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007D9D RID: 32157
		private static readonly System.IntPtr NativeMethodInfoPtr_SetMainText_Public_Void_String_0;

		// Token: 0x04007D9E RID: 32158
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0;

		// Token: 0x04007D9F RID: 32159
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0;

		// Token: 0x04007DA0 RID: 32160
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0;

		// Token: 0x04007DA1 RID: 32161
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0;

		// Token: 0x04007DA2 RID: 32162
		private static readonly System.IntPtr NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0;

		// Token: 0x04007DA3 RID: 32163
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007DA4 RID: 32164
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007DA5 RID: 32165
		private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__32_0_Private_Void_BaseEventData_0;

		// Token: 0x04007DA6 RID: 32166
		private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__32_1_Private_Void_BaseEventData_0;

		// Token: 0x04007DA7 RID: 32167
		private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__32_2_Private_Void_0;

		// Token: 0x02000C5E RID: 3166
		[OriginalName("Assembly-CSharp.dll", "", "TextShowMode")]
		public enum TextShowMode
		{
			// Token: 0x040099DD RID: 39389
			Off,
			// Token: 0x040099DE RID: 39390
			Always,
			// Token: 0x040099DF RID: 39391
			OnHover
		}

		// Token: 0x02000C5F RID: 3167
		[ObfuscatedName("ScheduleOne.Map.POI+<<OnEnable>g__Wait|27_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E5B9 RID: 58809 RVA: 0x0036371C File Offset: 0x0036191C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique()
			{
				Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<POI>.NativeClassPtr, "<<OnEnable>g__Wait|27_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>1__state");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>2__current");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>4__this");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100686350);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100686351);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100686352);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100686353);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100686354);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100686355);
			}

			// Token: 0x0600E5BA RID: 58810 RVA: 0x003637FC File Offset: 0x003619FC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E5BB RID: 58811 RVA: 0x00363844 File Offset: 0x00361A44
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E5BC RID: 58812 RVA: 0x00363878 File Offset: 0x00361A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317070, XrefRangeEnd = 317094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170046E1 RID: 18145
			// (get) Token: 0x0600E5BD RID: 58813 RVA: 0x003638B4 File Offset: 0x00361AB4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E5BE RID: 58814 RVA: 0x003638F4 File Offset: 0x00361AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317094, XrefRangeEnd = 317099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170046E2 RID: 18146
			// (get) Token: 0x0600E5BF RID: 58815 RVA: 0x00363928 File Offset: 0x00361B28
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E5C0 RID: 58816 RVA: 0x0006FB27 File Offset: 0x0006DD27
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046DE RID: 18142
			// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x00363968 File Offset: 0x00361B68
			// (set) Token: 0x0600E5C2 RID: 58818 RVA: 0x0006FB30 File Offset: 0x0006DD30
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046DF RID: 18143
			// (get) Token: 0x0600E5C3 RID: 58819 RVA: 0x00363990 File Offset: 0x00361B90
			// (set) Token: 0x0600E5C4 RID: 58820 RVA: 0x0006FB4B File Offset: 0x0006DD4B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046E0 RID: 18144
			// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x003639C0 File Offset: 0x00361BC0
			// (set) Token: 0x0600E5C6 RID: 58822 RVA: 0x0006FB6A File Offset: 0x0006DD6A
			public unsafe POI __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099E0 RID: 39392
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040099E1 RID: 39393
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040099E2 RID: 39394
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099E3 RID: 39395
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040099E4 RID: 39396
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099E5 RID: 39397
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040099E6 RID: 39398
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040099E7 RID: 39399
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099E8 RID: 39400
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C60 RID: 3168
		[ObfuscatedName("ScheduleOne.Map.POI+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E5C7 RID: 58823 RVA: 0x003639F0 File Offset: 0x00361BF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<POI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<POI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI.__c>.NativeClassPtr);
				POI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, "<>9");
				POI.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, "<>9__27_1");
				POI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, 100686357);
				POI.__c.NativeMethodInfoPtr__OnEnable_b__27_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, 100686358);
			}

			// Token: 0x0600E5C8 RID: 58824 RVA: 0x00363A6C File Offset: 0x00361C6C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E5C9 RID: 58825 RVA: 0x00363AA8 File Offset: 0x00361CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317099, XrefRangeEnd = 317107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnEnable_b__27_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(POI.__c.NativeMethodInfoPtr__OnEnable_b__27_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E5CA RID: 58826 RVA: 0x0006FB89 File Offset: 0x0006DD89
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046E3 RID: 18147
			// (get) Token: 0x0600E5CB RID: 58827 RVA: 0x00363AE4 File Offset: 0x00361CE4
			// (set) Token: 0x0600E5CC RID: 58828 RVA: 0x0006FB92 File Offset: 0x0006DD92
			public unsafe static POI.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(POI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(POI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046E4 RID: 18148
			// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x00363B0C File Offset: 0x00361D0C
			// (set) Token: 0x0600E5CE RID: 58830 RVA: 0x0006FBA4 File Offset: 0x0006DDA4
			public unsafe static Il2CppSystem.Func<bool> __9__27_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(POI.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(POI.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099E9 RID: 39401
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040099EA RID: 39402
			private static readonly System.IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x040099EB RID: 39403
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099EC RID: 39404
			private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__27_1_Internal_Boolean_0;
		}
	}
}
