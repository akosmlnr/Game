using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C9 RID: 1737
	public class HomeScreen : PlayerSingleton<HomeScreen>
	{
		// Token: 0x06009A63 RID: 39523 RVA: 0x00279020 File Offset: 0x00277220
		// Note: this type is marked as 'beforefieldinit'.
		static HomeScreen()
		{
			Il2CppClassPointerStore<HomeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "HomeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr);
			HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			HomeScreen.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "canvas");
			HomeScreen.NativeFieldInfoPtr_timeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "timeText");
			HomeScreen.NativeFieldInfoPtr_appIconContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIconContainer");
			HomeScreen.NativeFieldInfoPtr_appIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIconPrefab");
			HomeScreen.NativeFieldInfoPtr_appIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIcons");
			HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "delayedSetOpenRoutine");
			HomeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682448);
			HomeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682449);
			HomeScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682450);
			HomeScreen.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682451);
			HomeScreen.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682452);
			HomeScreen.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682453);
			HomeScreen.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682454);
			HomeScreen.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682455);
			HomeScreen.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682456);
			HomeScreen.NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682457);
			HomeScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682458);
			HomeScreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682459);
			HomeScreen.NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682460);
			HomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682461);
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x06009A64 RID: 39524 RVA: 0x002791F4 File Offset: 0x002773F4
		// (set) Token: 0x06009A65 RID: 39525 RVA: 0x00279230 File Offset: 0x00277430
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x00279270 File Offset: 0x00277470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275933, XrefRangeEnd = 275939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x002792AC File Offset: 0x002774AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275939, XrefRangeEnd = 275982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref IsOwner;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x002792F8 File Offset: 0x002774F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275982, XrefRangeEnd = 276001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A69 RID: 39529 RVA: 0x00279334 File Offset: 0x00277534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276001, XrefRangeEnd = 276003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A6A RID: 39530 RVA: 0x00279368 File Offset: 0x00277568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276003, XrefRangeEnd = 276010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A6B RID: 39531 RVA: 0x0027939C File Offset: 0x0027759C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276010, XrefRangeEnd = 276015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref delay;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06009A6C RID: 39532 RVA: 0x002793F8 File Offset: 0x002775F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276018, RefRangeEnd = 276019, XrefRangeStart = 276015, XrefRangeEnd = 276018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref o;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A6D RID: 39533 RVA: 0x00279438 File Offset: 0x00277638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276019, XrefRangeEnd = 276022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x00279478 File Offset: 0x00277678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276022, XrefRangeEnd = 276048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x002794B4 File Offset: 0x002776B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276048, XrefRangeEnd = 276089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x002794F0 File Offset: 0x002776F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276126, RefRangeEnd = 276127, XrefRangeStart = 276089, XrefRangeEnd = 276126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button GenerateAppIcon<T>(App<T> prog) where T : PlayerSingleton<T>
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prog);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.MethodInfoStoreGeneric_GenerateAppIcon_Public_Button_App_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}

		// Token: 0x06009A71 RID: 39537 RVA: 0x00279540 File Offset: 0x00277740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276127, XrefRangeEnd = 276137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HomeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A72 RID: 39538 RVA: 0x0004AE39 File Offset: 0x00049039
		public HomeScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x06009A73 RID: 39539 RVA: 0x0027957C File Offset: 0x0027777C
		// (set) Token: 0x06009A74 RID: 39540 RVA: 0x0004AE42 File Offset: 0x00049042
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x06009A75 RID: 39541 RVA: 0x002795A4 File Offset: 0x002777A4
		// (set) Token: 0x06009A76 RID: 39542 RVA: 0x0004AE5D File Offset: 0x0004905D
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x06009A77 RID: 39543 RVA: 0x002795D4 File Offset: 0x002777D4
		// (set) Token: 0x06009A78 RID: 39544 RVA: 0x0004AE7C File Offset: 0x0004907C
		public unsafe Text timeText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_timeText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_timeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x06009A79 RID: 39545 RVA: 0x00279604 File Offset: 0x00277804
		// (set) Token: 0x06009A7A RID: 39546 RVA: 0x0004AE9B File Offset: 0x0004909B
		public unsafe RectTransform appIconContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x06009A7B RID: 39547 RVA: 0x00279634 File Offset: 0x00277834
		// (set) Token: 0x06009A7C RID: 39548 RVA: 0x0004AEBA File Offset: 0x000490BA
		public unsafe GameObject appIconPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x06009A7D RID: 39549 RVA: 0x00279664 File Offset: 0x00277864
		// (set) Token: 0x06009A7E RID: 39550 RVA: 0x0004AED9 File Offset: 0x000490D9
		public unsafe List<Button> appIcons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIcons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x06009A7F RID: 39551 RVA: 0x00279694 File Offset: 0x00277894
		// (set) Token: 0x06009A80 RID: 39552 RVA: 0x0004AEF8 File Offset: 0x000490F8
		public unsafe Coroutine delayedSetOpenRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006804 RID: 26628
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006805 RID: 26629
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006806 RID: 26630
		private static readonly System.IntPtr NativeFieldInfoPtr_timeText;

		// Token: 0x04006807 RID: 26631
		private static readonly System.IntPtr NativeFieldInfoPtr_appIconContainer;

		// Token: 0x04006808 RID: 26632
		private static readonly System.IntPtr NativeFieldInfoPtr_appIconPrefab;

		// Token: 0x04006809 RID: 26633
		private static readonly System.IntPtr NativeFieldInfoPtr_appIcons;

		// Token: 0x0400680A RID: 26634
		private static readonly System.IntPtr NativeFieldInfoPtr_delayedSetOpenRoutine;

		// Token: 0x0400680B RID: 26635
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x0400680C RID: 26636
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400680D RID: 26637
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400680E RID: 26638
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400680F RID: 26639
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006810 RID: 26640
		private static readonly System.IntPtr NativeMethodInfoPtr_PhoneOpened_Protected_Void_0;

		// Token: 0x04006811 RID: 26641
		private static readonly System.IntPtr NativeMethodInfoPtr_PhoneClosed_Protected_Void_0;

		// Token: 0x04006812 RID: 26642
		private static readonly System.IntPtr NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x04006813 RID: 26643
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006814 RID: 26644
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0;

		// Token: 0x04006815 RID: 26645
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006816 RID: 26646
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006817 RID: 26647
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0;

		// Token: 0x04006818 RID: 26648
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BBB RID: 3003
		[ObfuscatedName("ScheduleOne.UI.Phone.HomeScreen+<DelayedSetCanvasActive>d__15")]
		public sealed class _DelayedSetCanvasActive_d__15 : Il2CppSystem.Object
		{
			// Token: 0x0600DFE7 RID: 57319 RVA: 0x003530C0 File Offset: 0x003512C0
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetCanvasActive_d__15()
			{
				Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "<DelayedSetCanvasActive>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "<>1__state");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "<>2__current");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "delay");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "<>4__this");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "active");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682462);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682463);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682464);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682465);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682466);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682467);
			}

			// Token: 0x0600DFE8 RID: 57320 RVA: 0x003531C8 File Offset: 0x003513C8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetCanvasActive_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFE9 RID: 57321 RVA: 0x00353210 File Offset: 0x00351410
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFEA RID: 57322 RVA: 0x00353244 File Offset: 0x00351444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275923, XrefRangeEnd = 275928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004526 RID: 17702
			// (get) Token: 0x0600DFEB RID: 57323 RVA: 0x00353280 File Offset: 0x00351480
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DFEC RID: 57324 RVA: 0x003532C0 File Offset: 0x003514C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275928, XrefRangeEnd = 275933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004527 RID: 17703
			// (get) Token: 0x0600DFED RID: 57325 RVA: 0x003532F4 File Offset: 0x003514F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DFEE RID: 57326 RVA: 0x0006CB60 File Offset: 0x0006AD60
			public _DelayedSetCanvasActive_d__15(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004521 RID: 17697
			// (get) Token: 0x0600DFEF RID: 57327 RVA: 0x00353334 File Offset: 0x00351534
			// (set) Token: 0x0600DFF0 RID: 57328 RVA: 0x0006CB69 File Offset: 0x0006AD69
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004522 RID: 17698
			// (get) Token: 0x0600DFF1 RID: 57329 RVA: 0x0035335C File Offset: 0x0035155C
			// (set) Token: 0x0600DFF2 RID: 57330 RVA: 0x0006CB84 File Offset: 0x0006AD84
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004523 RID: 17699
			// (get) Token: 0x0600DFF3 RID: 57331 RVA: 0x0035338C File Offset: 0x0035158C
			// (set) Token: 0x0600DFF4 RID: 57332 RVA: 0x0006CBA3 File Offset: 0x0006ADA3
			public unsafe float delay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17004524 RID: 17700
			// (get) Token: 0x0600DFF5 RID: 57333 RVA: 0x003533B4 File Offset: 0x003515B4
			// (set) Token: 0x0600DFF6 RID: 57334 RVA: 0x0006CBBE File Offset: 0x0006ADBE
			public unsafe HomeScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HomeScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004525 RID: 17701
			// (get) Token: 0x0600DFF7 RID: 57335 RVA: 0x003533E4 File Offset: 0x003515E4
			// (set) Token: 0x0600DFF8 RID: 57336 RVA: 0x0006CBDD File Offset: 0x0006ADDD
			public unsafe bool active
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x04009655 RID: 38485
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009656 RID: 38486
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009657 RID: 38487
			private static readonly System.IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04009658 RID: 38488
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009659 RID: 38489
			private static readonly System.IntPtr NativeFieldInfoPtr_active;

			// Token: 0x0400965A RID: 38490
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400965B RID: 38491
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400965C RID: 38492
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400965D RID: 38493
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400965E RID: 38494
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400965F RID: 38495
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BBC RID: 3004
		private sealed class MethodInfoStoreGeneric_GenerateAppIcon_Public_Button_App_1_T_0<T>
		{
			// Token: 0x04009660 RID: 38496
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HomeScreen.NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0, Il2CppClassPointerStore<HomeScreen>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
