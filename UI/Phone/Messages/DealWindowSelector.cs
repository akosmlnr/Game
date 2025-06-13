using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006D4 RID: 1748
	public class DealWindowSelector : MonoBehaviour
	{
		// Token: 0x06009C3B RID: 39995 RVA: 0x0027E8A0 File Offset: 0x0027CAA0
		// Note: this type is marked as 'beforefieldinit'.
		static DealWindowSelector()
		{
			Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "DealWindowSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr);
			DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "TIME_ARM_ROTATION_0000");
			DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "TIME_ARM_ROTATION_2400");
			DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "WINDOW_CUTOFF_MINS");
			DealWindowSelector.NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "OnSelected");
			DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			DealWindowSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "Container");
			DealWindowSelector.NativeFieldInfoPtr_MorningButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "MorningButton");
			DealWindowSelector.NativeFieldInfoPtr_AfternoonButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "AfternoonButton");
			DealWindowSelector.NativeFieldInfoPtr_NightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "NightButton");
			DealWindowSelector.NativeFieldInfoPtr_LateNightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "LateNightButton");
			DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "CurrentTimeArm");
			DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "CurrentTimeLabel");
			DealWindowSelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "callback");
			DealWindowSelector.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "buttons");
			DealWindowSelector.NativeFieldInfoPtr_hintShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "hintShown");
			DealWindowSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682658);
			DealWindowSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682659);
			DealWindowSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682660);
			DealWindowSelector.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682661);
			DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682662);
			DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682663);
			DealWindowSelector.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682664);
			DealWindowSelector.NativeMethodInfoPtr_UpdateTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682665);
			DealWindowSelector.NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682666);
			DealWindowSelector.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682667);
			DealWindowSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682668);
			DealWindowSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682669);
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x06009C3C RID: 39996 RVA: 0x0027EAEC File Offset: 0x0027CCEC
		// (set) Token: 0x06009C3D RID: 39997 RVA: 0x0027EB28 File Offset: 0x0027CD28
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x0027EB68 File Offset: 0x0027CD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278482, XrefRangeEnd = 278519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x0027EB9C File Offset: 0x0027CD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278519, XrefRangeEnd = 278521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x0027EBE0 File Offset: 0x0027CDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278521, XrefRangeEnd = 278522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x0027EC20 File Offset: 0x0027CE20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 278567, RefRangeEnd = 278574, XrefRangeStart = 278522, XrefRangeEnd = 278567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open, MSGConversation conversation, Il2CppSystem.Action<EDealWindow> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x0027EC84 File Offset: 0x0027CE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278574, XrefRangeEnd = 278576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x0027ECB8 File Offset: 0x0027CEB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278587, RefRangeEnd = 278589, XrefRangeStart = 278576, XrefRangeEnd = 278587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_UpdateTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x0027ECEC File Offset: 0x0027CEEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278616, RefRangeEnd = 278618, XrefRangeStart = 278589, XrefRangeEnd = 278616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWindowValidity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C45 RID: 40005 RVA: 0x0027ED20 File Offset: 0x0027CF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278618, XrefRangeEnd = 278619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x0027ED54 File Offset: 0x0027CF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278619, XrefRangeEnd = 278623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonClicked(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref window;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x0027ED94 File Offset: 0x0027CF94
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealWindowSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x0004C01F File Offset: 0x0004A21F
		public DealWindowSelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x06009C49 RID: 40009 RVA: 0x0027EDD0 File Offset: 0x0027CFD0
		// (set) Token: 0x06009C4A RID: 40010 RVA: 0x0004C028 File Offset: 0x0004A228
		public unsafe static float TIME_ARM_ROTATION_0000
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000, (void*)(&value));
			}
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x06009C4B RID: 40011 RVA: 0x0027EDEC File Offset: 0x0027CFEC
		// (set) Token: 0x06009C4C RID: 40012 RVA: 0x0004C036 File Offset: 0x0004A236
		public unsafe static float TIME_ARM_ROTATION_2400
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400, (void*)(&value));
			}
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x06009C4D RID: 40013 RVA: 0x0027EE08 File Offset: 0x0027D008
		// (set) Token: 0x06009C4E RID: 40014 RVA: 0x0004C044 File Offset: 0x0004A244
		public unsafe static int WINDOW_CUTOFF_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS, (void*)(&value));
			}
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x06009C4F RID: 40015 RVA: 0x0027EE24 File Offset: 0x0027D024
		// (set) Token: 0x06009C50 RID: 40016 RVA: 0x0004C052 File Offset: 0x0004A252
		public unsafe UnityEvent<EDealWindow> OnSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_OnSelected);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EDealWindow>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_OnSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x06009C51 RID: 40017 RVA: 0x0027EE54 File Offset: 0x0027D054
		// (set) Token: 0x06009C52 RID: 40018 RVA: 0x0004C071 File Offset: 0x0004A271
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x06009C53 RID: 40019 RVA: 0x0027EE7C File Offset: 0x0027D07C
		// (set) Token: 0x06009C54 RID: 40020 RVA: 0x0004C08C File Offset: 0x0004A28C
		public unsafe GameObject Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x06009C55 RID: 40021 RVA: 0x0027EEAC File Offset: 0x0027D0AC
		// (set) Token: 0x06009C56 RID: 40022 RVA: 0x0004C0AB File Offset: 0x0004A2AB
		public unsafe WindowSelectorButton MorningButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_MorningButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_MorningButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x06009C57 RID: 40023 RVA: 0x0027EEDC File Offset: 0x0027D0DC
		// (set) Token: 0x06009C58 RID: 40024 RVA: 0x0004C0CA File Offset: 0x0004A2CA
		public unsafe WindowSelectorButton AfternoonButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_AfternoonButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_AfternoonButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x06009C59 RID: 40025 RVA: 0x0027EF0C File Offset: 0x0027D10C
		// (set) Token: 0x06009C5A RID: 40026 RVA: 0x0004C0E9 File Offset: 0x0004A2E9
		public unsafe WindowSelectorButton NightButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_NightButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_NightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x06009C5B RID: 40027 RVA: 0x0027EF3C File Offset: 0x0027D13C
		// (set) Token: 0x06009C5C RID: 40028 RVA: 0x0004C108 File Offset: 0x0004A308
		public unsafe WindowSelectorButton LateNightButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_LateNightButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_LateNightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x06009C5D RID: 40029 RVA: 0x0027EF6C File Offset: 0x0027D16C
		// (set) Token: 0x06009C5E RID: 40030 RVA: 0x0004C127 File Offset: 0x0004A327
		public unsafe RectTransform CurrentTimeArm
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x06009C5F RID: 40031 RVA: 0x0027EF9C File Offset: 0x0027D19C
		// (set) Token: 0x06009C60 RID: 40032 RVA: 0x0004C146 File Offset: 0x0004A346
		public unsafe Text CurrentTimeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x06009C61 RID: 40033 RVA: 0x0027EFCC File Offset: 0x0027D1CC
		// (set) Token: 0x06009C62 RID: 40034 RVA: 0x0004C165 File Offset: 0x0004A365
		public unsafe Il2CppSystem.Action<EDealWindow> callback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_callback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<EDealWindow>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x06009C63 RID: 40035 RVA: 0x0027EFFC File Offset: 0x0027D1FC
		// (set) Token: 0x06009C64 RID: 40036 RVA: 0x0004C184 File Offset: 0x0004A384
		public unsafe Il2CppReferenceArray<WindowSelectorButton> buttons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_buttons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WindowSelectorButton>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x06009C65 RID: 40037 RVA: 0x0027F02C File Offset: 0x0027D22C
		// (set) Token: 0x06009C66 RID: 40038 RVA: 0x0004C1A3 File Offset: 0x0004A3A3
		public unsafe bool hintShown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_hintShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_hintShown)) = value;
			}
		}

		// Token: 0x0400692F RID: 26927
		private static readonly System.IntPtr NativeFieldInfoPtr_TIME_ARM_ROTATION_0000;

		// Token: 0x04006930 RID: 26928
		private static readonly System.IntPtr NativeFieldInfoPtr_TIME_ARM_ROTATION_2400;

		// Token: 0x04006931 RID: 26929
		private static readonly System.IntPtr NativeFieldInfoPtr_WINDOW_CUTOFF_MINS;

		// Token: 0x04006932 RID: 26930
		private static readonly System.IntPtr NativeFieldInfoPtr_OnSelected;

		// Token: 0x04006933 RID: 26931
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006934 RID: 26932
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006935 RID: 26933
		private static readonly System.IntPtr NativeFieldInfoPtr_MorningButton;

		// Token: 0x04006936 RID: 26934
		private static readonly System.IntPtr NativeFieldInfoPtr_AfternoonButton;

		// Token: 0x04006937 RID: 26935
		private static readonly System.IntPtr NativeFieldInfoPtr_NightButton;

		// Token: 0x04006938 RID: 26936
		private static readonly System.IntPtr NativeFieldInfoPtr_LateNightButton;

		// Token: 0x04006939 RID: 26937
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTimeArm;

		// Token: 0x0400693A RID: 26938
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTimeLabel;

		// Token: 0x0400693B RID: 26939
		private static readonly System.IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400693C RID: 26940
		private static readonly System.IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400693D RID: 26941
		private static readonly System.IntPtr NativeFieldInfoPtr_hintShown;

		// Token: 0x0400693E RID: 26942
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400693F RID: 26943
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006940 RID: 26944
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006941 RID: 26945
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04006942 RID: 26946
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006943 RID: 26947
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0;

		// Token: 0x04006944 RID: 26948
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006945 RID: 26949
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTime_Private_Void_0;

		// Token: 0x04006946 RID: 26950
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0;

		// Token: 0x04006947 RID: 26951
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04006948 RID: 26952
		private static readonly System.IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0;

		// Token: 0x04006949 RID: 26953
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BCC RID: 3020
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealWindowSelector+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E090 RID: 57488 RVA: 0x00354E64 File Offset: 0x00353064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr);
				DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, "button");
				DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, 100682670);
				DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, 100682671);
			}

			// Token: 0x0600E091 RID: 57489 RVA: 0x00354EE0 File Offset: 0x003530E0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E092 RID: 57490 RVA: 0x00354F1C File Offset: 0x0035311C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278478, XrefRangeEnd = 278482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E093 RID: 57491 RVA: 0x0006D0C4 File Offset: 0x0006B2C4
			public __c__DisplayClass18_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004555 RID: 17749
			// (get) Token: 0x0600E094 RID: 57492 RVA: 0x00354F50 File Offset: 0x00353150
			// (set) Token: 0x0600E095 RID: 57493 RVA: 0x0006D0CD File Offset: 0x0006B2CD
			public unsafe WindowSelectorButton button
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr_button);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004556 RID: 17750
			// (get) Token: 0x0600E096 RID: 57494 RVA: 0x00354F80 File Offset: 0x00353180
			// (set) Token: 0x0600E097 RID: 57495 RVA: 0x0006D0EC File Offset: 0x0006B2EC
			public unsafe DealWindowSelector __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealWindowSelector>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096B2 RID: 38578
			private static readonly System.IntPtr NativeFieldInfoPtr_button;

			// Token: 0x040096B3 RID: 38579
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096B4 RID: 38580
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096B5 RID: 38581
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
