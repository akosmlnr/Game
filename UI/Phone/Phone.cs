using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006CA RID: 1738
	public class Phone : PlayerSingleton<Phone>
	{
		// Token: 0x06009A81 RID: 39553 RVA: 0x002796C4 File Offset: 0x002778C4
		// Note: this type is marked as 'beforefieldinit'.
		static Phone()
		{
			Il2CppClassPointerStore<Phone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "Phone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone>.NativeClassPtr);
			Phone.NativeFieldInfoPtr_ActiveApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "ActiveApp");
			Phone.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<IsOpen>k__BackingField");
			Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<isHorizontal>k__BackingField");
			Phone.NativeFieldInfoPtr__isOpenable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<isOpenable>k__BackingField");
			Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<FlashlightOn>k__BackingField");
			Phone.NativeFieldInfoPtr_testData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "testData");
			Phone.NativeFieldInfoPtr_testCalller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "testCalller");
			Phone.NativeFieldInfoPtr_phoneModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "phoneModel");
			Phone.NativeFieldInfoPtr_orientation_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "orientation_Vertical");
			Phone.NativeFieldInfoPtr_orientation_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "orientation_Horizontal");
			Phone.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "raycaster");
			Phone.NativeFieldInfoPtr_PhoneFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "PhoneFlashlight");
			Phone.NativeFieldInfoPtr_FlashlightToggleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "FlashlightToggleSound");
			Phone.NativeFieldInfoPtr_rotationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "rotationTime");
			Phone.NativeFieldInfoPtr_LookOffsetMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "LookOffsetMax");
			Phone.NativeFieldInfoPtr_LookOffsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "LookOffsetMin");
			Phone.NativeFieldInfoPtr_OpenVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "OpenVerticalOffset");
			Phone.NativeFieldInfoPtr_onPhoneOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "onPhoneOpened");
			Phone.NativeFieldInfoPtr_onPhoneClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "onPhoneClosed");
			Phone.NativeFieldInfoPtr_closeApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "closeApps");
			Phone.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "eventSystem");
			Phone.NativeFieldInfoPtr_flashlightVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "flashlightVisibility");
			Phone.NativeFieldInfoPtr_rotationCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "rotationCoroutine");
			Phone.NativeFieldInfoPtr_lookOffsetCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "lookOffsetCoroutine");
			Phone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682468);
			Phone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682469);
			Phone.NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682470);
			Phone.NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682471);
			Phone.NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682472);
			Phone.NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682473);
			Phone.NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682474);
			Phone.NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682475);
			Phone.NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682476);
			Phone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682477);
			Phone.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682478);
			Phone.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682479);
			Phone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682480);
			Phone.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682481);
			Phone.NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682482);
			Phone.NativeMethodInfoPtr_SetOpenable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682483);
			Phone.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682484);
			Phone.NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682485);
			Phone.NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682486);
			Phone.NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682487);
			Phone.NativeMethodInfoPtr_RequestCloseApp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682488);
			Phone.NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682489);
			Phone.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682490);
			Phone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682491);
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x06009A82 RID: 39554 RVA: 0x00279AB4 File Offset: 0x00277CB4
		// (set) Token: 0x06009A83 RID: 39555 RVA: 0x00279AF0 File Offset: 0x00277CF0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x06009A84 RID: 39556 RVA: 0x00279B30 File Offset: 0x00277D30
		// (set) Token: 0x06009A85 RID: 39557 RVA: 0x00279B6C File Offset: 0x00277D6C
		public unsafe bool isHorizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x06009A86 RID: 39558 RVA: 0x00279BAC File Offset: 0x00277DAC
		// (set) Token: 0x06009A87 RID: 39559 RVA: 0x00279BE8 File Offset: 0x00277DE8
		public unsafe bool isOpenable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x06009A88 RID: 39560 RVA: 0x00279C28 File Offset: 0x00277E28
		// (set) Token: 0x06009A89 RID: 39561 RVA: 0x00279C64 File Offset: 0x00277E64
		public unsafe bool FlashlightOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x06009A8A RID: 39562 RVA: 0x00279CA4 File Offset: 0x00277EA4
		public unsafe float ScaledLookOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276199, XrefRangeEnd = 276204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06009A8B RID: 39563 RVA: 0x00279CE0 File Offset: 0x00277EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276204, XrefRangeEnd = 276212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A8C RID: 39564 RVA: 0x00279D1C File Offset: 0x00277F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276212, XrefRangeEnd = 276220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref IsOwner;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x00279D68 File Offset: 0x00277F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276220, XrefRangeEnd = 276233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A8E RID: 39566 RVA: 0x00279DA4 File Offset: 0x00277FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276233, XrefRangeEnd = 276261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A8F RID: 39567 RVA: 0x00279DE0 File Offset: 0x00277FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276261, XrefRangeEnd = 276268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A90 RID: 39568 RVA: 0x00279E1C File Offset: 0x0027801C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276268, XrefRangeEnd = 276277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleFlashlight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A91 RID: 39569 RVA: 0x00279E50 File Offset: 0x00278050
		[CallerCount(0)]
		public unsafe void SetOpenable(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref o;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetOpenable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x00279E90 File Offset: 0x00278090
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276296, RefRangeEnd = 276299, XrefRangeStart = 276277, XrefRangeEnd = 276296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref o;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A93 RID: 39571 RVA: 0x00279ED0 File Offset: 0x002780D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276307, RefRangeEnd = 276309, XrefRangeStart = 276299, XrefRangeEnd = 276307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsHorizontal(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref h;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A94 RID: 39572 RVA: 0x00279F10 File Offset: 0x00278110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276309, XrefRangeEnd = 276314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetIsHorizontal_Process(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref h;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06009A95 RID: 39573 RVA: 0x00279F5C File Offset: 0x0027815C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276327, RefRangeEnd = 276330, XrefRangeStart = 276314, XrefRangeEnd = 276327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLookOffsetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref multiplier;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A96 RID: 39574 RVA: 0x00279F9C File Offset: 0x0027819C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276336, RefRangeEnd = 276337, XrefRangeStart = 276330, XrefRangeEnd = 276336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestCloseApp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_RequestCloseApp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A97 RID: 39575 RVA: 0x00279FD0 File Offset: 0x002781D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276337, XrefRangeEnd = 276342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetLookOffset_Process(float lookOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref lookOffset;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06009A98 RID: 39576 RVA: 0x0027A01C File Offset: 0x0027821C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276342, XrefRangeEnd = 276359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MouseRaycast(out RaycastResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			result = ((intPtr2 == 0) ? null : new RaycastResult(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x0027A07C File Offset: 0x0027827C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276359, XrefRangeEnd = 276362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Phone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x0004AF17 File Offset: 0x00049117
		public Phone(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x06009A9B RID: 39579 RVA: 0x0027A0B8 File Offset: 0x002782B8
		// (set) Token: 0x06009A9C RID: 39580 RVA: 0x0004AF20 File Offset: 0x00049120
		public unsafe static GameObject ActiveApp
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Phone.NativeFieldInfoPtr_ActiveApp, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Phone.NativeFieldInfoPtr_ActiveApp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x06009A9D RID: 39581 RVA: 0x0027A0E0 File Offset: 0x002782E0
		// (set) Token: 0x06009A9E RID: 39582 RVA: 0x0004AF32 File Offset: 0x00049132
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x06009A9F RID: 39583 RVA: 0x0027A108 File Offset: 0x00278308
		// (set) Token: 0x06009AA0 RID: 39584 RVA: 0x0004AF4D File Offset: 0x0004914D
		public unsafe bool _isHorizontal_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x06009AA1 RID: 39585 RVA: 0x0027A130 File Offset: 0x00278330
		// (set) Token: 0x06009AA2 RID: 39586 RVA: 0x0004AF68 File Offset: 0x00049168
		public unsafe bool _isOpenable_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isOpenable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isOpenable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x06009AA3 RID: 39587 RVA: 0x0027A158 File Offset: 0x00278358
		// (set) Token: 0x06009AA4 RID: 39588 RVA: 0x0004AF83 File Offset: 0x00049183
		public unsafe bool _FlashlightOn_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x06009AA5 RID: 39589 RVA: 0x0027A180 File Offset: 0x00278380
		// (set) Token: 0x06009AA6 RID: 39590 RVA: 0x0004AF9E File Offset: 0x0004919E
		public unsafe PhoneCallData testData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x06009AA7 RID: 39591 RVA: 0x0027A1B0 File Offset: 0x002783B0
		// (set) Token: 0x06009AA8 RID: 39592 RVA: 0x0004AFBD File Offset: 0x000491BD
		public unsafe CallerID testCalller
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testCalller);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testCalller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x06009AA9 RID: 39593 RVA: 0x0027A1E0 File Offset: 0x002783E0
		// (set) Token: 0x06009AAA RID: 39594 RVA: 0x0004AFDC File Offset: 0x000491DC
		public unsafe GameObject phoneModel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_phoneModel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_phoneModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x06009AAB RID: 39595 RVA: 0x0027A210 File Offset: 0x00278410
		// (set) Token: 0x06009AAC RID: 39596 RVA: 0x0004AFFB File Offset: 0x000491FB
		public unsafe Transform orientation_Vertical
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Vertical);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Vertical), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x06009AAD RID: 39597 RVA: 0x0027A240 File Offset: 0x00278440
		// (set) Token: 0x06009AAE RID: 39598 RVA: 0x0004B01A File Offset: 0x0004921A
		public unsafe Transform orientation_Horizontal
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Horizontal);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Horizontal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x06009AAF RID: 39599 RVA: 0x0027A270 File Offset: 0x00278470
		// (set) Token: 0x06009AB0 RID: 39600 RVA: 0x0004B039 File Offset: 0x00049239
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_raycaster);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x06009AB1 RID: 39601 RVA: 0x0027A2A0 File Offset: 0x002784A0
		// (set) Token: 0x06009AB2 RID: 39602 RVA: 0x0004B058 File Offset: 0x00049258
		public unsafe GameObject PhoneFlashlight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_PhoneFlashlight);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_PhoneFlashlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x06009AB3 RID: 39603 RVA: 0x0027A2D0 File Offset: 0x002784D0
		// (set) Token: 0x06009AB4 RID: 39604 RVA: 0x0004B077 File Offset: 0x00049277
		public unsafe AudioSourceController FlashlightToggleSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_FlashlightToggleSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_FlashlightToggleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x06009AB5 RID: 39605 RVA: 0x0027A300 File Offset: 0x00278500
		// (set) Token: 0x06009AB6 RID: 39606 RVA: 0x0004B096 File Offset: 0x00049296
		public unsafe float rotationTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationTime)) = value;
			}
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x06009AB7 RID: 39607 RVA: 0x0027A328 File Offset: 0x00278528
		// (set) Token: 0x06009AB8 RID: 39608 RVA: 0x0004B0B1 File Offset: 0x000492B1
		public unsafe float LookOffsetMax
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMax)) = value;
			}
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x06009AB9 RID: 39609 RVA: 0x0027A350 File Offset: 0x00278550
		// (set) Token: 0x06009ABA RID: 39610 RVA: 0x0004B0CC File Offset: 0x000492CC
		public unsafe float LookOffsetMin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMin)) = value;
			}
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x06009ABB RID: 39611 RVA: 0x0027A378 File Offset: 0x00278578
		// (set) Token: 0x06009ABC RID: 39612 RVA: 0x0004B0E7 File Offset: 0x000492E7
		public unsafe float OpenVerticalOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_OpenVerticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_OpenVerticalOffset)) = value;
			}
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x06009ABD RID: 39613 RVA: 0x0027A3A0 File Offset: 0x002785A0
		// (set) Token: 0x06009ABE RID: 39614 RVA: 0x0004B102 File Offset: 0x00049302
		public unsafe Il2CppSystem.Action onPhoneOpened
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneOpened);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x06009ABF RID: 39615 RVA: 0x0027A3D0 File Offset: 0x002785D0
		// (set) Token: 0x06009AC0 RID: 39616 RVA: 0x0004B121 File Offset: 0x00049321
		public unsafe Il2CppSystem.Action onPhoneClosed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneClosed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x06009AC1 RID: 39617 RVA: 0x0027A400 File Offset: 0x00278600
		// (set) Token: 0x06009AC2 RID: 39618 RVA: 0x0004B140 File Offset: 0x00049340
		public unsafe Il2CppSystem.Action closeApps
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_closeApps);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_closeApps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x06009AC3 RID: 39619 RVA: 0x0027A430 File Offset: 0x00278630
		// (set) Token: 0x06009AC4 RID: 39620 RVA: 0x0004B15F File Offset: 0x0004935F
		public unsafe EventSystem eventSystem
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_eventSystem);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x06009AC5 RID: 39621 RVA: 0x0027A460 File Offset: 0x00278660
		// (set) Token: 0x06009AC6 RID: 39622 RVA: 0x0004B17E File Offset: 0x0004937E
		public unsafe VisibilityAttribute flashlightVisibility
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_flashlightVisibility);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_flashlightVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x06009AC7 RID: 39623 RVA: 0x0027A490 File Offset: 0x00278690
		// (set) Token: 0x06009AC8 RID: 39624 RVA: 0x0004B19D File Offset: 0x0004939D
		public unsafe Coroutine rotationCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x06009AC9 RID: 39625 RVA: 0x0027A4C0 File Offset: 0x002786C0
		// (set) Token: 0x06009ACA RID: 39626 RVA: 0x0004B1BC File Offset: 0x000493BC
		public unsafe Coroutine lookOffsetCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_lookOffsetCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_lookOffsetCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006819 RID: 26649
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveApp;

		// Token: 0x0400681A RID: 26650
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400681B RID: 26651
		private static readonly System.IntPtr NativeFieldInfoPtr__isHorizontal_k__BackingField;

		// Token: 0x0400681C RID: 26652
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpenable_k__BackingField;

		// Token: 0x0400681D RID: 26653
		private static readonly System.IntPtr NativeFieldInfoPtr__FlashlightOn_k__BackingField;

		// Token: 0x0400681E RID: 26654
		private static readonly System.IntPtr NativeFieldInfoPtr_testData;

		// Token: 0x0400681F RID: 26655
		private static readonly System.IntPtr NativeFieldInfoPtr_testCalller;

		// Token: 0x04006820 RID: 26656
		private static readonly System.IntPtr NativeFieldInfoPtr_phoneModel;

		// Token: 0x04006821 RID: 26657
		private static readonly System.IntPtr NativeFieldInfoPtr_orientation_Vertical;

		// Token: 0x04006822 RID: 26658
		private static readonly System.IntPtr NativeFieldInfoPtr_orientation_Horizontal;

		// Token: 0x04006823 RID: 26659
		private static readonly System.IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04006824 RID: 26660
		private static readonly System.IntPtr NativeFieldInfoPtr_PhoneFlashlight;

		// Token: 0x04006825 RID: 26661
		private static readonly System.IntPtr NativeFieldInfoPtr_FlashlightToggleSound;

		// Token: 0x04006826 RID: 26662
		private static readonly System.IntPtr NativeFieldInfoPtr_rotationTime;

		// Token: 0x04006827 RID: 26663
		private static readonly System.IntPtr NativeFieldInfoPtr_LookOffsetMax;

		// Token: 0x04006828 RID: 26664
		private static readonly System.IntPtr NativeFieldInfoPtr_LookOffsetMin;

		// Token: 0x04006829 RID: 26665
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenVerticalOffset;

		// Token: 0x0400682A RID: 26666
		private static readonly System.IntPtr NativeFieldInfoPtr_onPhoneOpened;

		// Token: 0x0400682B RID: 26667
		private static readonly System.IntPtr NativeFieldInfoPtr_onPhoneClosed;

		// Token: 0x0400682C RID: 26668
		private static readonly System.IntPtr NativeFieldInfoPtr_closeApps;

		// Token: 0x0400682D RID: 26669
		private static readonly System.IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x0400682E RID: 26670
		private static readonly System.IntPtr NativeFieldInfoPtr_flashlightVisibility;

		// Token: 0x0400682F RID: 26671
		private static readonly System.IntPtr NativeFieldInfoPtr_rotationCoroutine;

		// Token: 0x04006830 RID: 26672
		private static readonly System.IntPtr NativeFieldInfoPtr_lookOffsetCoroutine;

		// Token: 0x04006831 RID: 26673
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006832 RID: 26674
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006833 RID: 26675
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0;

		// Token: 0x04006834 RID: 26676
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0;

		// Token: 0x04006835 RID: 26677
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0;

		// Token: 0x04006836 RID: 26678
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0;

		// Token: 0x04006837 RID: 26679
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0;

		// Token: 0x04006838 RID: 26680
		private static readonly System.IntPtr NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0;

		// Token: 0x04006839 RID: 26681
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0;

		// Token: 0x0400683A RID: 26682
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400683B RID: 26683
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400683C RID: 26684
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400683D RID: 26685
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400683E RID: 26686
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400683F RID: 26687
		private static readonly System.IntPtr NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0;

		// Token: 0x04006840 RID: 26688
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOpenable_Public_Void_Boolean_0;

		// Token: 0x04006841 RID: 26689
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006842 RID: 26690
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0;

		// Token: 0x04006843 RID: 26691
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0;

		// Token: 0x04006844 RID: 26692
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0;

		// Token: 0x04006845 RID: 26693
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestCloseApp_Public_Void_0;

		// Token: 0x04006846 RID: 26694
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0;

		// Token: 0x04006847 RID: 26695
		private static readonly System.IntPtr NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0;

		// Token: 0x04006848 RID: 26696
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BBD RID: 3005
		[ObfuscatedName("ScheduleOne.UI.Phone.Phone+<SetIsHorizontal_Process>d__46")]
		public sealed class _SetIsHorizontal_Process_d__46 : Il2CppSystem.Object
		{
			// Token: 0x0600DFFA RID: 57338 RVA: 0x00353460 File Offset: 0x00351660
			// Note: this type is marked as 'beforefieldinit'.
			static _SetIsHorizontal_Process_d__46()
			{
				Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<SetIsHorizontal_Process>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr);
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<>1__state");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<>2__current");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<>4__this");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "h");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__adjustedRotationTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<adjustedRotationTime>5__2");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__startRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<startRotation>5__3");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__endRotation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<endRotation>5__4");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<i>5__5");
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682492);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682493);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682494);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682495);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682496);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682497);
			}

			// Token: 0x0600DFFB RID: 57339 RVA: 0x003535A4 File Offset: 0x003517A4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetIsHorizontal_Process_d__46(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFFC RID: 57340 RVA: 0x003535EC File Offset: 0x003517EC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFFD RID: 57341 RVA: 0x00353620 File Offset: 0x00351820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276137, XrefRangeEnd = 276165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004530 RID: 17712
			// (get) Token: 0x0600DFFE RID: 57342 RVA: 0x0035365C File Offset: 0x0035185C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DFFF RID: 57343 RVA: 0x0035369C File Offset: 0x0035189C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276165, XrefRangeEnd = 276170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004531 RID: 17713
			// (get) Token: 0x0600E000 RID: 57344 RVA: 0x003536D0 File Offset: 0x003518D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E001 RID: 57345 RVA: 0x0006CBF8 File Offset: 0x0006ADF8
			public _SetIsHorizontal_Process_d__46(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004528 RID: 17704
			// (get) Token: 0x0600E002 RID: 57346 RVA: 0x00353710 File Offset: 0x00351910
			// (set) Token: 0x0600E003 RID: 57347 RVA: 0x0006CC01 File Offset: 0x0006AE01
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004529 RID: 17705
			// (get) Token: 0x0600E004 RID: 57348 RVA: 0x00353738 File Offset: 0x00351938
			// (set) Token: 0x0600E005 RID: 57349 RVA: 0x0006CC1C File Offset: 0x0006AE1C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452A RID: 17706
			// (get) Token: 0x0600E006 RID: 57350 RVA: 0x00353768 File Offset: 0x00351968
			// (set) Token: 0x0600E007 RID: 57351 RVA: 0x0006CC3B File Offset: 0x0006AE3B
			public unsafe Phone __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Phone>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452B RID: 17707
			// (get) Token: 0x0600E008 RID: 57352 RVA: 0x00353798 File Offset: 0x00351998
			// (set) Token: 0x0600E009 RID: 57353 RVA: 0x0006CC5A File Offset: 0x0006AE5A
			public unsafe bool h
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr_h);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr_h)) = value;
				}
			}

			// Token: 0x1700452C RID: 17708
			// (get) Token: 0x0600E00A RID: 57354 RVA: 0x003537C0 File Offset: 0x003519C0
			// (set) Token: 0x0600E00B RID: 57355 RVA: 0x0006CC75 File Offset: 0x0006AE75
			public unsafe float _adjustedRotationTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__adjustedRotationTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__adjustedRotationTime_5__2)) = value;
				}
			}

			// Token: 0x1700452D RID: 17709
			// (get) Token: 0x0600E00C RID: 57356 RVA: 0x003537E8 File Offset: 0x003519E8
			// (set) Token: 0x0600E00D RID: 57357 RVA: 0x0006CC90 File Offset: 0x0006AE90
			public unsafe Quaternion _startRotation_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__startRotation_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__startRotation_5__3)) = value;
				}
			}

			// Token: 0x1700452E RID: 17710
			// (get) Token: 0x0600E00E RID: 57358 RVA: 0x00353810 File Offset: 0x00351A10
			// (set) Token: 0x0600E00F RID: 57359 RVA: 0x0006CCAB File Offset: 0x0006AEAB
			public unsafe Quaternion _endRotation_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__endRotation_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__endRotation_5__4)) = value;
				}
			}

			// Token: 0x1700452F RID: 17711
			// (get) Token: 0x0600E010 RID: 57360 RVA: 0x00353838 File Offset: 0x00351A38
			// (set) Token: 0x0600E011 RID: 57361 RVA: 0x0006CCC6 File Offset: 0x0006AEC6
			public unsafe float _i_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04009661 RID: 38497
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009662 RID: 38498
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009663 RID: 38499
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009664 RID: 38500
			private static readonly System.IntPtr NativeFieldInfoPtr_h;

			// Token: 0x04009665 RID: 38501
			private static readonly System.IntPtr NativeFieldInfoPtr__adjustedRotationTime_5__2;

			// Token: 0x04009666 RID: 38502
			private static readonly System.IntPtr NativeFieldInfoPtr__startRotation_5__3;

			// Token: 0x04009667 RID: 38503
			private static readonly System.IntPtr NativeFieldInfoPtr__endRotation_5__4;

			// Token: 0x04009668 RID: 38504
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04009669 RID: 38505
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400966A RID: 38506
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400966B RID: 38507
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400966C RID: 38508
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400966D RID: 38509
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400966E RID: 38510
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BBE RID: 3006
		[ObfuscatedName("ScheduleOne.UI.Phone.Phone+<SetLookOffset_Process>d__50")]
		public sealed class _SetLookOffset_Process_d__50 : Il2CppSystem.Object
		{
			// Token: 0x0600E012 RID: 57362 RVA: 0x00353860 File Offset: 0x00351A60
			// Note: this type is marked as 'beforefieldinit'.
			static _SetLookOffset_Process_d__50()
			{
				Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<SetLookOffset_Process>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr);
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<>1__state");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<>2__current");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<>4__this");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr_lookOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "lookOffset");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__startOffset_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<startOffset>5__2");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__endOffset_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<endOffset>5__3");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__moveTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<moveTime>5__4");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<i>5__5");
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682498);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682499);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682500);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682501);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682502);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682503);
			}

			// Token: 0x0600E013 RID: 57363 RVA: 0x003539A4 File Offset: 0x00351BA4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetLookOffset_Process_d__50(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E014 RID: 57364 RVA: 0x003539EC File Offset: 0x00351BEC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E015 RID: 57365 RVA: 0x00353A20 File Offset: 0x00351C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276170, XrefRangeEnd = 276194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700453A RID: 17722
			// (get) Token: 0x0600E016 RID: 57366 RVA: 0x00353A5C File Offset: 0x00351C5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E017 RID: 57367 RVA: 0x00353A9C File Offset: 0x00351C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276194, XrefRangeEnd = 276199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700453B RID: 17723
			// (get) Token: 0x0600E018 RID: 57368 RVA: 0x00353AD0 File Offset: 0x00351CD0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E019 RID: 57369 RVA: 0x0006CCE1 File Offset: 0x0006AEE1
			public _SetLookOffset_Process_d__50(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004532 RID: 17714
			// (get) Token: 0x0600E01A RID: 57370 RVA: 0x00353B10 File Offset: 0x00351D10
			// (set) Token: 0x0600E01B RID: 57371 RVA: 0x0006CCEA File Offset: 0x0006AEEA
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004533 RID: 17715
			// (get) Token: 0x0600E01C RID: 57372 RVA: 0x00353B38 File Offset: 0x00351D38
			// (set) Token: 0x0600E01D RID: 57373 RVA: 0x0006CD05 File Offset: 0x0006AF05
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004534 RID: 17716
			// (get) Token: 0x0600E01E RID: 57374 RVA: 0x00353B68 File Offset: 0x00351D68
			// (set) Token: 0x0600E01F RID: 57375 RVA: 0x0006CD24 File Offset: 0x0006AF24
			public unsafe Phone __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Phone>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004535 RID: 17717
			// (get) Token: 0x0600E020 RID: 57376 RVA: 0x00353B98 File Offset: 0x00351D98
			// (set) Token: 0x0600E021 RID: 57377 RVA: 0x0006CD43 File Offset: 0x0006AF43
			public unsafe float lookOffset
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr_lookOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr_lookOffset)) = value;
				}
			}

			// Token: 0x17004536 RID: 17718
			// (get) Token: 0x0600E022 RID: 57378 RVA: 0x00353BC0 File Offset: 0x00351DC0
			// (set) Token: 0x0600E023 RID: 57379 RVA: 0x0006CD5E File Offset: 0x0006AF5E
			public unsafe float _startOffset_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__startOffset_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__startOffset_5__2)) = value;
				}
			}

			// Token: 0x17004537 RID: 17719
			// (get) Token: 0x0600E024 RID: 57380 RVA: 0x00353BE8 File Offset: 0x00351DE8
			// (set) Token: 0x0600E025 RID: 57381 RVA: 0x0006CD79 File Offset: 0x0006AF79
			public unsafe float _endOffset_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__endOffset_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__endOffset_5__3)) = value;
				}
			}

			// Token: 0x17004538 RID: 17720
			// (get) Token: 0x0600E026 RID: 57382 RVA: 0x00353C10 File Offset: 0x00351E10
			// (set) Token: 0x0600E027 RID: 57383 RVA: 0x0006CD94 File Offset: 0x0006AF94
			public unsafe float _moveTime_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__moveTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__moveTime_5__4)) = value;
				}
			}

			// Token: 0x17004539 RID: 17721
			// (get) Token: 0x0600E028 RID: 57384 RVA: 0x00353C38 File Offset: 0x00351E38
			// (set) Token: 0x0600E029 RID: 57385 RVA: 0x0006CDAF File Offset: 0x0006AFAF
			public unsafe float _i_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x0400966F RID: 38511
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009670 RID: 38512
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009671 RID: 38513
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009672 RID: 38514
			private static readonly System.IntPtr NativeFieldInfoPtr_lookOffset;

			// Token: 0x04009673 RID: 38515
			private static readonly System.IntPtr NativeFieldInfoPtr__startOffset_5__2;

			// Token: 0x04009674 RID: 38516
			private static readonly System.IntPtr NativeFieldInfoPtr__endOffset_5__3;

			// Token: 0x04009675 RID: 38517
			private static readonly System.IntPtr NativeFieldInfoPtr__moveTime_5__4;

			// Token: 0x04009676 RID: 38518
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04009677 RID: 38519
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009678 RID: 38520
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009679 RID: 38521
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400967A RID: 38522
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400967B RID: 38523
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400967C RID: 38524
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
