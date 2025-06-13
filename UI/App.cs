using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000675 RID: 1653
	public class App<T> : PlayerSingleton<T> where T : PlayerSingleton<T>
	{
		// Token: 0x06009237 RID: 37431 RVA: 0x002608B0 File Offset: 0x0025EAB0
		// Note: this type is marked as 'beforefieldinit'.
		static App()
		{
			Il2CppClassPointerStore<App<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "App`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<App<T>>.NativeClassPtr);
			App<T>.NativeFieldInfoPtr_Apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "Apps");
			App<T>.NativeFieldInfoPtr_AppName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AppName");
			App<T>.NativeFieldInfoPtr_IconLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "IconLabel");
			App<T>.NativeFieldInfoPtr_AppIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AppIcon");
			App<T>.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "Orientation");
			App<T>.NativeFieldInfoPtr_AvailableInTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AvailableInTutorial");
			App<T>.NativeFieldInfoPtr_appContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "appContainer");
			App<T>.NativeFieldInfoPtr_notificationContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "notificationContainer");
			App<T>.NativeFieldInfoPtr_notificationText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "notificationText");
			App<T>.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "<isOpen>k__BackingField");
			App<T>.NativeFieldInfoPtr_appIconButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "appIconButton");
			App<T>.NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681509);
			App<T>.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681510);
			App<T>.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681511);
			App<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681512);
			App<T>.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681513);
			App<T>.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681514);
			App<T>.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681515);
			App<T>.NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681516);
			App<T>.NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681517);
			App<T>.NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681518);
			App<T>.NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681519);
			App<T>.NativeMethodInfoPtr_ShortcutClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681520);
			App<T>.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681521);
			App<T>.NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681522);
			App<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681523);
		}

		// Token: 0x06009238 RID: 37432 RVA: 0x00260B24 File Offset: 0x0025ED24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264868, XrefRangeEnd = 264881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static App<T> GetApp(int index)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<App<T>>(intPtr2) : null;
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x00260B64 File Offset: 0x0025ED64
		// (set) Token: 0x0600923A RID: 37434 RVA: 0x00260BA0 File Offset: 0x0025EDA0
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x00260BE0 File Offset: 0x0025EDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264881, XrefRangeEnd = 264889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref IsOwner;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x00260C2C File Offset: 0x0025EE2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 264927, RefRangeEnd = 264934, XrefRangeStart = 264889, XrefRangeEnd = 264927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x00260C68 File Offset: 0x0025EE68
		[CallerCount(0)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x00260C9C File Offset: 0x0025EE9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 264943, RefRangeEnd = 264949, XrefRangeStart = 264934, XrefRangeEnd = 264943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600923F RID: 37439 RVA: 0x00260CD8 File Offset: 0x0025EED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264968, RefRangeEnd = 264969, XrefRangeStart = 264949, XrefRangeEnd = 264968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHoveringButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x00260D14 File Offset: 0x0025EF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264969, XrefRangeEnd = 264998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateHomeScreenIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x00260D48 File Offset: 0x0025EF48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265001, RefRangeEnd = 265002, XrefRangeStart = 264998, XrefRangeEnd = 265001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotificationCount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x00260D88 File Offset: 0x0025EF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265002, XrefRangeEnd = 265006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x00260DC4 File Offset: 0x0025EFC4
		[CallerCount(0)]
		public unsafe void ShortcutClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_ShortcutClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x00260DF8 File Offset: 0x0025EFF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265013, RefRangeEnd = 265014, XrefRangeStart = 265006, XrefRangeEnd = 265013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009245 RID: 37445 RVA: 0x00260E48 File Offset: 0x0025F048
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 265077, RefRangeEnd = 265084, XrefRangeStart = 265014, XrefRangeEnd = 265077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009246 RID: 37446 RVA: 0x00260E94 File Offset: 0x0025F094
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 265085, RefRangeEnd = 265093, XrefRangeStart = 265084, XrefRangeEnd = 265085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe App() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<App<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009247 RID: 37447 RVA: 0x00046440 File Offset: 0x00044640
		public App(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x06009248 RID: 37448 RVA: 0x00260ED0 File Offset: 0x0025F0D0
		// (set) Token: 0x06009249 RID: 37449 RVA: 0x00046449 File Offset: 0x00044649
		public unsafe static List<App<T>> Apps
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(App<T>.NativeFieldInfoPtr_Apps, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<App<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(App<T>.NativeFieldInfoPtr_Apps, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x0600924A RID: 37450 RVA: 0x00260EF8 File Offset: 0x0025F0F8
		// (set) Token: 0x0600924B RID: 37451 RVA: 0x0004645B File Offset: 0x0004465B
		public unsafe string AppName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x0600924C RID: 37452 RVA: 0x00260F20 File Offset: 0x0025F120
		// (set) Token: 0x0600924D RID: 37453 RVA: 0x0004647A File Offset: 0x0004467A
		public unsafe string IconLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_IconLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_IconLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x0600924E RID: 37454 RVA: 0x00260F48 File Offset: 0x0025F148
		// (set) Token: 0x0600924F RID: 37455 RVA: 0x00046499 File Offset: 0x00044699
		public unsafe Sprite AppIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x06009250 RID: 37456 RVA: 0x00260F78 File Offset: 0x0025F178
		// (set) Token: 0x06009251 RID: 37457 RVA: 0x000464B8 File Offset: 0x000446B8
		public unsafe App<T>.EOrientation Orientation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_Orientation);
				return *intPtr;
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_Orientation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<App<T>.EOrientation>.NativeClassPtr, (System.UIntPtr)0));
			}
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x06009252 RID: 37458 RVA: 0x00260FA0 File Offset: 0x0025F1A0
		// (set) Token: 0x06009253 RID: 37459 RVA: 0x000464E6 File Offset: 0x000446E6
		public unsafe bool AvailableInTutorial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AvailableInTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AvailableInTutorial)) = value;
			}
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x06009254 RID: 37460 RVA: 0x00260FC8 File Offset: 0x0025F1C8
		// (set) Token: 0x06009255 RID: 37461 RVA: 0x00046501 File Offset: 0x00044701
		public unsafe RectTransform appContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x06009256 RID: 37462 RVA: 0x00260FF8 File Offset: 0x0025F1F8
		// (set) Token: 0x06009257 RID: 37463 RVA: 0x00046520 File Offset: 0x00044720
		public unsafe RectTransform notificationContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x06009258 RID: 37464 RVA: 0x00261028 File Offset: 0x0025F228
		// (set) Token: 0x06009259 RID: 37465 RVA: 0x0004653F File Offset: 0x0004473F
		public unsafe Text notificationText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x0600925A RID: 37466 RVA: 0x00261058 File Offset: 0x0025F258
		// (set) Token: 0x0600925B RID: 37467 RVA: 0x0004655E File Offset: 0x0004475E
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x0600925C RID: 37468 RVA: 0x00261080 File Offset: 0x0025F280
		// (set) Token: 0x0600925D RID: 37469 RVA: 0x00046579 File Offset: 0x00044779
		public unsafe Button appIconButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appIconButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appIconButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040062EF RID: 25327
		private static readonly System.IntPtr NativeFieldInfoPtr_Apps;

		// Token: 0x040062F0 RID: 25328
		private static readonly System.IntPtr NativeFieldInfoPtr_AppName;

		// Token: 0x040062F1 RID: 25329
		private static readonly System.IntPtr NativeFieldInfoPtr_IconLabel;

		// Token: 0x040062F2 RID: 25330
		private static readonly System.IntPtr NativeFieldInfoPtr_AppIcon;

		// Token: 0x040062F3 RID: 25331
		private static readonly System.IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x040062F4 RID: 25332
		private static readonly System.IntPtr NativeFieldInfoPtr_AvailableInTutorial;

		// Token: 0x040062F5 RID: 25333
		private static readonly System.IntPtr NativeFieldInfoPtr_appContainer;

		// Token: 0x040062F6 RID: 25334
		private static readonly System.IntPtr NativeFieldInfoPtr_notificationContainer;

		// Token: 0x040062F7 RID: 25335
		private static readonly System.IntPtr NativeFieldInfoPtr_notificationText;

		// Token: 0x040062F8 RID: 25336
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040062F9 RID: 25337
		private static readonly System.IntPtr NativeFieldInfoPtr_appIconButton;

		// Token: 0x040062FA RID: 25338
		private static readonly System.IntPtr NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0;

		// Token: 0x040062FB RID: 25339
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040062FC RID: 25340
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040062FD RID: 25341
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x040062FE RID: 25342
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040062FF RID: 25343
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04006300 RID: 25344
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006301 RID: 25345
		private static readonly System.IntPtr NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0;

		// Token: 0x04006302 RID: 25346
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0;

		// Token: 0x04006303 RID: 25347
		private static readonly System.IntPtr NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0;

		// Token: 0x04006304 RID: 25348
		private static readonly System.IntPtr NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0;

		// Token: 0x04006305 RID: 25349
		private static readonly System.IntPtr NativeMethodInfoPtr_ShortcutClicked_Private_Void_0;

		// Token: 0x04006306 RID: 25350
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006307 RID: 25351
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006308 RID: 25352
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000B86 RID: 2950
		[OriginalName("Assembly-CSharp.dll", "", "EOrientation")]
		public enum EOrientation
		{
			// Token: 0x040094E1 RID: 38113
			Horizontal,
			// Token: 0x040094E2 RID: 38114
			Vertical
		}
	}
}
