using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006D8 RID: 1752
	public class MessageSenderInterface : MonoBehaviour
	{
		// Token: 0x06009CEE RID: 40174 RVA: 0x002805EC File Offset: 0x0027E7EC
		// Note: this type is marked as 'beforefieldinit'.
		static MessageSenderInterface()
		{
			Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageSenderInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr);
			MessageSenderInterface.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "Visibility");
			MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "DockedMenuYPos");
			MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ExpandedMenuYPos");
			MessageSenderInterface.NativeFieldInfoPtr_Menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "Menu");
			MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "SendablesContainer");
			MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "DockedUIElements");
			MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ExpandedUIElements");
			MessageSenderInterface.NativeFieldInfoPtr_ComposeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ComposeButton");
			MessageSenderInterface.NativeFieldInfoPtr_CancelButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "CancelButtons");
			MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "sendableBubbles");
			MessageSenderInterface.NativeFieldInfoPtr_sendableMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "sendableMap");
			MessageSenderInterface.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682703);
			MessageSenderInterface.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682704);
			MessageSenderInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682705);
			MessageSenderInterface.NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682706);
			MessageSenderInterface.NativeMethodInfoPtr_UpdateSendables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682707);
			MessageSenderInterface.NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682708);
			MessageSenderInterface.NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682709);
			MessageSenderInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682710);
			MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682711);
			MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682712);
		}

		// Token: 0x06009CEF RID: 40175 RVA: 0x002807C0 File Offset: 0x0027E9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279021, XrefRangeEnd = 279036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF0 RID: 40176 RVA: 0x002807F4 File Offset: 0x0027E9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279036, XrefRangeEnd = 279046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF1 RID: 40177 RVA: 0x00280828 File Offset: 0x0027EA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279046, XrefRangeEnd = 279048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF2 RID: 40178 RVA: 0x0028086C File Offset: 0x0027EA6C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 279065, RefRangeEnd = 279071, XrefRangeStart = 279048, XrefRangeEnd = 279065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibility(MessageSenderInterface.EVisibility visibility)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visibility;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF3 RID: 40179 RVA: 0x002808AC File Offset: 0x0027EAAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279092, RefRangeEnd = 279094, XrefRangeStart = 279071, XrefRangeEnd = 279092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSendables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_UpdateSendables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF4 RID: 40180 RVA: 0x002808E0 File Offset: 0x0027EAE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279132, RefRangeEnd = 279134, XrefRangeStart = 279094, XrefRangeEnd = 279132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSendable(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF5 RID: 40181 RVA: 0x00280924 File Offset: 0x0027EB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279134, XrefRangeEnd = 279136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendableSelected(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageSenderInterface.NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF6 RID: 40182 RVA: 0x00280974 File Offset: 0x0027EB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279136, XrefRangeEnd = 279151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageSenderInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF7 RID: 40183 RVA: 0x002809B0 File Offset: 0x0027EBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279151, XrefRangeEnd = 279152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__12_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF8 RID: 40184 RVA: 0x002809E4 File Offset: 0x0027EBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279152, XrefRangeEnd = 279153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__12_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CF9 RID: 40185 RVA: 0x0004C7AD File Offset: 0x0004A9AD
		public MessageSenderInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x06009CFA RID: 40186 RVA: 0x00280A18 File Offset: 0x0027EC18
		// (set) Token: 0x06009CFB RID: 40187 RVA: 0x0004C7B6 File Offset: 0x0004A9B6
		public unsafe MessageSenderInterface.EVisibility Visibility
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Visibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Visibility)) = value;
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x06009CFC RID: 40188 RVA: 0x00280A40 File Offset: 0x0027EC40
		// (set) Token: 0x06009CFD RID: 40189 RVA: 0x0004C7D1 File Offset: 0x0004A9D1
		public unsafe float DockedMenuYPos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos)) = value;
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x06009CFE RID: 40190 RVA: 0x00280A68 File Offset: 0x0027EC68
		// (set) Token: 0x06009CFF RID: 40191 RVA: 0x0004C7EC File Offset: 0x0004A9EC
		public unsafe float ExpandedMenuYPos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos)) = value;
			}
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x06009D00 RID: 40192 RVA: 0x00280A90 File Offset: 0x0027EC90
		// (set) Token: 0x06009D01 RID: 40193 RVA: 0x0004C807 File Offset: 0x0004AA07
		public unsafe RectTransform Menu
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Menu);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Menu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x06009D02 RID: 40194 RVA: 0x00280AC0 File Offset: 0x0027ECC0
		// (set) Token: 0x06009D03 RID: 40195 RVA: 0x0004C826 File Offset: 0x0004AA26
		public unsafe RectTransform SendablesContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x06009D04 RID: 40196 RVA: 0x00280AF0 File Offset: 0x0027ECF0
		// (set) Token: 0x06009D05 RID: 40197 RVA: 0x0004C845 File Offset: 0x0004AA45
		public unsafe Il2CppReferenceArray<RectTransform> DockedUIElements
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x06009D06 RID: 40198 RVA: 0x00280B20 File Offset: 0x0027ED20
		// (set) Token: 0x06009D07 RID: 40199 RVA: 0x0004C864 File Offset: 0x0004AA64
		public unsafe Il2CppReferenceArray<RectTransform> ExpandedUIElements
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x06009D08 RID: 40200 RVA: 0x00280B50 File Offset: 0x0027ED50
		// (set) Token: 0x06009D09 RID: 40201 RVA: 0x0004C883 File Offset: 0x0004AA83
		public unsafe Button ComposeButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ComposeButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ComposeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x06009D0A RID: 40202 RVA: 0x00280B80 File Offset: 0x0027ED80
		// (set) Token: 0x06009D0B RID: 40203 RVA: 0x0004C8A2 File Offset: 0x0004AAA2
		public unsafe Il2CppReferenceArray<Button> CancelButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_CancelButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_CancelButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x06009D0C RID: 40204 RVA: 0x00280BB0 File Offset: 0x0027EDB0
		// (set) Token: 0x06009D0D RID: 40205 RVA: 0x0004C8C1 File Offset: 0x0004AAC1
		public unsafe List<MessageBubble> sendableBubbles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageBubble>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x06009D0E RID: 40206 RVA: 0x00280BE0 File Offset: 0x0027EDE0
		// (set) Token: 0x06009D0F RID: 40207 RVA: 0x0004C8E0 File Offset: 0x0004AAE0
		public unsafe Dictionary<MessageBubble, SendableMessage> sendableMap
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableMap);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MessageBubble, SendableMessage>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006996 RID: 27030
		private static readonly System.IntPtr NativeFieldInfoPtr_Visibility;

		// Token: 0x04006997 RID: 27031
		private static readonly System.IntPtr NativeFieldInfoPtr_DockedMenuYPos;

		// Token: 0x04006998 RID: 27032
		private static readonly System.IntPtr NativeFieldInfoPtr_ExpandedMenuYPos;

		// Token: 0x04006999 RID: 27033
		private static readonly System.IntPtr NativeFieldInfoPtr_Menu;

		// Token: 0x0400699A RID: 27034
		private static readonly System.IntPtr NativeFieldInfoPtr_SendablesContainer;

		// Token: 0x0400699B RID: 27035
		private static readonly System.IntPtr NativeFieldInfoPtr_DockedUIElements;

		// Token: 0x0400699C RID: 27036
		private static readonly System.IntPtr NativeFieldInfoPtr_ExpandedUIElements;

		// Token: 0x0400699D RID: 27037
		private static readonly System.IntPtr NativeFieldInfoPtr_ComposeButton;

		// Token: 0x0400699E RID: 27038
		private static readonly System.IntPtr NativeFieldInfoPtr_CancelButtons;

		// Token: 0x0400699F RID: 27039
		private static readonly System.IntPtr NativeFieldInfoPtr_sendableBubbles;

		// Token: 0x040069A0 RID: 27040
		private static readonly System.IntPtr NativeFieldInfoPtr_sendableMap;

		// Token: 0x040069A1 RID: 27041
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040069A2 RID: 27042
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040069A3 RID: 27043
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040069A4 RID: 27044
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0;

		// Token: 0x040069A5 RID: 27045
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSendables_Public_Void_0;

		// Token: 0x040069A6 RID: 27046
		private static readonly System.IntPtr NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0;

		// Token: 0x040069A7 RID: 27047
		private static readonly System.IntPtr NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0;

		// Token: 0x040069A8 RID: 27048
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040069A9 RID: 27049
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__12_0_Private_Void_0;

		// Token: 0x040069AA RID: 27050
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__12_1_Private_Void_0;

		// Token: 0x02000BD1 RID: 3025
		[OriginalName("Assembly-CSharp.dll", "", "EVisibility")]
		public enum EVisibility
		{
			// Token: 0x040096C6 RID: 38598
			Hidden,
			// Token: 0x040096C7 RID: 38599
			Docked,
			// Token: 0x040096C8 RID: 38600
			Expanded
		}

		// Token: 0x02000BD2 RID: 3026
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessageSenderInterface+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E0AF RID: 57519 RVA: 0x00355354 File Offset: 0x00353554
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr);
				MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr_sendable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, "sendable");
				MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, 100682713);
				MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, 100682714);
			}

			// Token: 0x0600E0B0 RID: 57520 RVA: 0x003553D0 File Offset: 0x003535D0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0B1 RID: 57521 RVA: 0x0035540C File Offset: 0x0035360C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279020, XrefRangeEnd = 279021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddSendable_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0B2 RID: 57522 RVA: 0x0006D1BA File Offset: 0x0006B3BA
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455D RID: 17757
			// (get) Token: 0x0600E0B3 RID: 57523 RVA: 0x00355440 File Offset: 0x00353640
			// (set) Token: 0x0600E0B4 RID: 57524 RVA: 0x0006D1C3 File Offset: 0x0006B3C3
			public unsafe MessageSenderInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageSenderInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700455E RID: 17758
			// (get) Token: 0x0600E0B5 RID: 57525 RVA: 0x00355470 File Offset: 0x00353670
			// (set) Token: 0x0600E0B6 RID: 57526 RVA: 0x0006D1E2 File Offset: 0x0006B3E2
			public unsafe SendableMessage sendable
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr_sendable);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr_sendable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096C9 RID: 38601
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096CA RID: 38602
			private static readonly System.IntPtr NativeFieldInfoPtr_sendable;

			// Token: 0x040096CB RID: 38603
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096CC RID: 38604
			private static readonly System.IntPtr NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0;
		}
	}
}
