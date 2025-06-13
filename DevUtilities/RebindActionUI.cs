using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000497 RID: 1175
	public class RebindActionUI : MonoBehaviour
	{
		// Token: 0x0600646A RID: 25706 RVA: 0x001CA1C0 File Offset: 0x001C83C0
		// Note: this type is marked as 'beforefieldinit'.
		static RebindActionUI()
		{
			Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "RebindActionUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr);
			RebindActionUI.NativeFieldInfoPtr_onRebind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "onRebind");
			RebindActionUI.NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_Action");
			RebindActionUI.NativeFieldInfoPtr_m_BindingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_BindingId");
			RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_DisplayStringOptions");
			RebindActionUI.NativeFieldInfoPtr_m_ActionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_ActionLabel");
			RebindActionUI.NativeFieldInfoPtr_m_BindingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_BindingText");
			RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindOverlay");
			RebindActionUI.NativeFieldInfoPtr_m_RebindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindText");
			RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_UpdateBindingUIEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindStartEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindStopEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindOperation");
			RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "s_RebindActionUIs");
			RebindActionUI.NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676117);
			RebindActionUI.NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676118);
			RebindActionUI.NativeMethodInfoPtr_get_bindingId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676119);
			RebindActionUI.NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676120);
			RebindActionUI.NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676121);
			RebindActionUI.NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676122);
			RebindActionUI.NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676123);
			RebindActionUI.NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676124);
			RebindActionUI.NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676125);
			RebindActionUI.NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676126);
			RebindActionUI.NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676127);
			RebindActionUI.NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676128);
			RebindActionUI.NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676129);
			RebindActionUI.NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676130);
			RebindActionUI.NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676131);
			RebindActionUI.NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676132);
			RebindActionUI.NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676133);
			RebindActionUI.NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676134);
			RebindActionUI.NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676135);
			RebindActionUI.NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676136);
			RebindActionUI.NativeMethodInfoPtr_ResetToDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676137);
			RebindActionUI.NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676138);
			RebindActionUI.NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676139);
			RebindActionUI.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676140);
			RebindActionUI.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676141);
			RebindActionUI.NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676142);
			RebindActionUI.NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676143);
			RebindActionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676144);
			RebindActionUI.NativeMethodInfoPtr__UpdateBindingDisplay_b__31_0_Private_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100676145);
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x0600646B RID: 25707 RVA: 0x001CA538 File Offset: 0x001C8738
		// (set) Token: 0x0600646C RID: 25708 RVA: 0x001CA578 File Offset: 0x001C8778
		public unsafe InputActionReference actionReference
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206633, XrefRangeEnd = 206636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x0600646D RID: 25709 RVA: 0x001CA5BC File Offset: 0x001C87BC
		// (set) Token: 0x0600646E RID: 25710 RVA: 0x001CA5F4 File Offset: 0x001C87F4
		public unsafe string bindingId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_bindingId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206636, XrefRangeEnd = 206638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x0600646F RID: 25711 RVA: 0x001CA638 File Offset: 0x001C8838
		// (set) Token: 0x06006470 RID: 25712 RVA: 0x001CA674 File Offset: 0x001C8874
		public unsafe InputBinding.DisplayStringOptions displayStringOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206638, XrefRangeEnd = 206639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x06006471 RID: 25713 RVA: 0x001CA6B4 File Offset: 0x001C88B4
		// (set) Token: 0x06006472 RID: 25714 RVA: 0x001CA6F4 File Offset: 0x001C88F4
		public unsafe TextMeshProUGUI actionLabel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206639, XrefRangeEnd = 206641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x06006473 RID: 25715 RVA: 0x001CA738 File Offset: 0x001C8938
		// (set) Token: 0x06006474 RID: 25716 RVA: 0x001CA778 File Offset: 0x001C8978
		public unsafe TextMeshProUGUI bindingText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206641, XrefRangeEnd = 206643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06006475 RID: 25717 RVA: 0x001CA7BC File Offset: 0x001C89BC
		// (set) Token: 0x06006476 RID: 25718 RVA: 0x001CA7FC File Offset: 0x001C89FC
		public unsafe TextMeshProUGUI rebindPrompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06006477 RID: 25719 RVA: 0x001CA840 File Offset: 0x001C8A40
		// (set) Token: 0x06006478 RID: 25720 RVA: 0x001CA880 File Offset: 0x001C8A80
		public unsafe GameObject rebindOverlay
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06006479 RID: 25721 RVA: 0x001CA8C4 File Offset: 0x001C8AC4
		public unsafe RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206643, XrefRangeEnd = 206650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.UpdateBindingUIEvent>(intPtr2) : null;
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x0600647A RID: 25722 RVA: 0x001CA904 File Offset: 0x001C8B04
		public unsafe RebindActionUI.InteractiveRebindEvent startRebindEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206650, XrefRangeEnd = 206657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x0600647B RID: 25723 RVA: 0x001CA944 File Offset: 0x001C8B44
		public unsafe RebindActionUI.InteractiveRebindEvent stopRebindEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206657, XrefRangeEnd = 206664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x0600647C RID: 25724 RVA: 0x001CA984 File Offset: 0x001C8B84
		public unsafe InputActionRebindingExtensions.RebindingOperation ongoingRebind
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48163, RefRangeEnd = 48164, XrefRangeStart = 48163, XrefRangeEnd = 48164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionRebindingExtensions.RebindingOperation>(intPtr2) : null;
			}
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x001CA9C4 File Offset: 0x001C8BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206664, XrefRangeEnd = 206686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveActionAndBinding(out InputAction action, out int bindingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &bindingIndex;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			action = ((intPtr2 == 0) ? null : new InputAction(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x001CAA30 File Offset: 0x001C8C30
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 206709, RefRangeEnd = 206719, XrefRangeStart = 206686, XrefRangeEnd = 206709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBindingDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x001CAA64 File Offset: 0x001C8C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206719, XrefRangeEnd = 206749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetToDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_ResetToDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x001CAA98 File Offset: 0x001C8C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206749, XrefRangeEnd = 206788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInteractiveRebind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x001CAACC File Offset: 0x001C8CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206853, RefRangeEnd = 206855, XrefRangeStart = 206788, XrefRangeEnd = 206853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformInteractiveRebind(InputAction action, int bindingIndex, bool allCompositeParts = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref bindingIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref allCompositeParts;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x001CAB2C File Offset: 0x001C8D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206855, XrefRangeEnd = 206884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x001CAB60 File Offset: 0x001C8D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206884, XrefRangeEnd = 206905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x001CAB94 File Offset: 0x001C8D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206905, XrefRangeEnd = 206932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActionChange(Il2CppSystem.Object obj, InputActionChange change)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x001CABD8 File Offset: 0x001C8DD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206940, RefRangeEnd = 206942, XrefRangeStart = 206932, XrefRangeEnd = 206940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActionLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x001CAC0C File Offset: 0x001C8E0C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindActionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x001CAC48 File Offset: 0x001C8E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206942, XrefRangeEnd = 206945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateBindingDisplay_b__31_0(InputBinding x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr__UpdateBindingDisplay_b__31_0_Private_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x0002F3F8 File Offset: 0x0002D5F8
		public RebindActionUI(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06006489 RID: 25737 RVA: 0x001CAC9C File Offset: 0x001C8E9C
		// (set) Token: 0x0600648A RID: 25738 RVA: 0x0002F401 File Offset: 0x0002D601
		public unsafe Il2CppSystem.Action onRebind
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_onRebind);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_onRebind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x0600648B RID: 25739 RVA: 0x001CACCC File Offset: 0x001C8ECC
		// (set) Token: 0x0600648C RID: 25740 RVA: 0x0002F420 File Offset: 0x0002D620
		public unsafe InputActionReference m_Action
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_Action);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x0600648D RID: 25741 RVA: 0x001CACFC File Offset: 0x001C8EFC
		// (set) Token: 0x0600648E RID: 25742 RVA: 0x0002F43F File Offset: 0x0002D63F
		public unsafe string m_BindingId
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x0600648F RID: 25743 RVA: 0x001CAD24 File Offset: 0x001C8F24
		// (set) Token: 0x06006490 RID: 25744 RVA: 0x0002F45E File Offset: 0x0002D65E
		public unsafe InputBinding.DisplayStringOptions m_DisplayStringOptions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions)) = value;
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06006491 RID: 25745 RVA: 0x001CAD4C File Offset: 0x001C8F4C
		// (set) Token: 0x06006492 RID: 25746 RVA: 0x0002F479 File Offset: 0x0002D679
		public unsafe TextMeshProUGUI m_ActionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_ActionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_ActionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x06006493 RID: 25747 RVA: 0x001CAD7C File Offset: 0x001C8F7C
		// (set) Token: 0x06006494 RID: 25748 RVA: 0x0002F498 File Offset: 0x0002D698
		public unsafe TextMeshProUGUI m_BindingText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x06006495 RID: 25749 RVA: 0x001CADAC File Offset: 0x001C8FAC
		// (set) Token: 0x06006496 RID: 25750 RVA: 0x0002F4B7 File Offset: 0x0002D6B7
		public unsafe GameObject m_RebindOverlay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x06006497 RID: 25751 RVA: 0x001CADDC File Offset: 0x001C8FDC
		// (set) Token: 0x06006498 RID: 25752 RVA: 0x0002F4D6 File Offset: 0x0002D6D6
		public unsafe TextMeshProUGUI m_RebindText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x06006499 RID: 25753 RVA: 0x001CAE0C File Offset: 0x001C900C
		// (set) Token: 0x0600649A RID: 25754 RVA: 0x0002F4F5 File Offset: 0x0002D6F5
		public unsafe RebindActionUI.UpdateBindingUIEvent m_UpdateBindingUIEvent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.UpdateBindingUIEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x0600649B RID: 25755 RVA: 0x001CAE3C File Offset: 0x001C903C
		// (set) Token: 0x0600649C RID: 25756 RVA: 0x0002F514 File Offset: 0x0002D714
		public unsafe RebindActionUI.InteractiveRebindEvent m_RebindStartEvent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x0600649D RID: 25757 RVA: 0x001CAE6C File Offset: 0x001C906C
		// (set) Token: 0x0600649E RID: 25758 RVA: 0x0002F533 File Offset: 0x0002D733
		public unsafe RebindActionUI.InteractiveRebindEvent m_RebindStopEvent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x0600649F RID: 25759 RVA: 0x001CAE9C File Offset: 0x001C909C
		// (set) Token: 0x060064A0 RID: 25760 RVA: 0x0002F552 File Offset: 0x0002D752
		public unsafe InputActionRebindingExtensions.RebindingOperation m_RebindOperation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOperation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionRebindingExtensions.RebindingOperation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x060064A1 RID: 25761 RVA: 0x001CAECC File Offset: 0x001C90CC
		// (set) Token: 0x060064A2 RID: 25762 RVA: 0x0002F571 File Offset: 0x0002D771
		public unsafe static List<RebindActionUI> s_RebindActionUIs
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RebindActionUI>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400447C RID: 17532
		private static readonly System.IntPtr NativeFieldInfoPtr_onRebind;

		// Token: 0x0400447D RID: 17533
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Action;

		// Token: 0x0400447E RID: 17534
		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingId;

		// Token: 0x0400447F RID: 17535
		private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayStringOptions;

		// Token: 0x04004480 RID: 17536
		private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionLabel;

		// Token: 0x04004481 RID: 17537
		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingText;

		// Token: 0x04004482 RID: 17538
		private static readonly System.IntPtr NativeFieldInfoPtr_m_RebindOverlay;

		// Token: 0x04004483 RID: 17539
		private static readonly System.IntPtr NativeFieldInfoPtr_m_RebindText;

		// Token: 0x04004484 RID: 17540
		private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateBindingUIEvent;

		// Token: 0x04004485 RID: 17541
		private static readonly System.IntPtr NativeFieldInfoPtr_m_RebindStartEvent;

		// Token: 0x04004486 RID: 17542
		private static readonly System.IntPtr NativeFieldInfoPtr_m_RebindStopEvent;

		// Token: 0x04004487 RID: 17543
		private static readonly System.IntPtr NativeFieldInfoPtr_m_RebindOperation;

		// Token: 0x04004488 RID: 17544
		private static readonly System.IntPtr NativeFieldInfoPtr_s_RebindActionUIs;

		// Token: 0x04004489 RID: 17545
		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0;

		// Token: 0x0400448A RID: 17546
		private static readonly System.IntPtr NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0;

		// Token: 0x0400448B RID: 17547
		private static readonly System.IntPtr NativeMethodInfoPtr_get_bindingId_Public_get_String_0;

		// Token: 0x0400448C RID: 17548
		private static readonly System.IntPtr NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0;

		// Token: 0x0400448D RID: 17549
		private static readonly System.IntPtr NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0;

		// Token: 0x0400448E RID: 17550
		private static readonly System.IntPtr NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0;

		// Token: 0x0400448F RID: 17551
		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0;

		// Token: 0x04004490 RID: 17552
		private static readonly System.IntPtr NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04004491 RID: 17553
		private static readonly System.IntPtr NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0;

		// Token: 0x04004492 RID: 17554
		private static readonly System.IntPtr NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04004493 RID: 17555
		private static readonly System.IntPtr NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0;

		// Token: 0x04004494 RID: 17556
		private static readonly System.IntPtr NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04004495 RID: 17557
		private static readonly System.IntPtr NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0;

		// Token: 0x04004496 RID: 17558
		private static readonly System.IntPtr NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0;

		// Token: 0x04004497 RID: 17559
		private static readonly System.IntPtr NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0;

		// Token: 0x04004498 RID: 17560
		private static readonly System.IntPtr NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0;

		// Token: 0x04004499 RID: 17561
		private static readonly System.IntPtr NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0;

		// Token: 0x0400449A RID: 17562
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0;

		// Token: 0x0400449B RID: 17563
		private static readonly System.IntPtr NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0;

		// Token: 0x0400449C RID: 17564
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0;

		// Token: 0x0400449D RID: 17565
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetToDefault_Public_Void_0;

		// Token: 0x0400449E RID: 17566
		private static readonly System.IntPtr NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0;

		// Token: 0x0400449F RID: 17567
		private static readonly System.IntPtr NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0;

		// Token: 0x040044A0 RID: 17568
		private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

		// Token: 0x040044A1 RID: 17569
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

		// Token: 0x040044A2 RID: 17570
		private static readonly System.IntPtr NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0;

		// Token: 0x040044A3 RID: 17571
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0;

		// Token: 0x040044A4 RID: 17572
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040044A5 RID: 17573
		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateBindingDisplay_b__31_0_Private_Boolean_InputBinding_0;

		// Token: 0x02000A6D RID: 2669
		[System.Serializable]
		public class UpdateBindingUIEvent : UnityEvent<RebindActionUI, string, string, string>
		{
			// Token: 0x0600D433 RID: 54323 RVA: 0x00066E52 File Offset: 0x00065052
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateBindingUIEvent()
			{
				Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "UpdateBindingUIEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr);
				RebindActionUI.UpdateBindingUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr, 100676146);
			}

			// Token: 0x0600D434 RID: 54324 RVA: 0x00331FE0 File Offset: 0x003301E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206593, XrefRangeEnd = 206596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateBindingUIEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.UpdateBindingUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D435 RID: 54325 RVA: 0x00066E86 File Offset: 0x00065086
			public UpdateBindingUIEvent(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008F3E RID: 36670
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A6E RID: 2670
		[System.Serializable]
		public class InteractiveRebindEvent : UnityEvent<RebindActionUI, InputActionRebindingExtensions.RebindingOperation>
		{
			// Token: 0x0600D436 RID: 54326 RVA: 0x00066E8F File Offset: 0x0006508F
			// Note: this type is marked as 'beforefieldinit'.
			static InteractiveRebindEvent()
			{
				Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "InteractiveRebindEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr);
				RebindActionUI.InteractiveRebindEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr, 100676147);
			}

			// Token: 0x0600D437 RID: 54327 RVA: 0x0033201C File Offset: 0x0033021C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206596, XrefRangeEnd = 206599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InteractiveRebindEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.InteractiveRebindEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D438 RID: 54328 RVA: 0x00066EC3 File Offset: 0x000650C3
			public InteractiveRebindEvent(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008F3F RID: 36671
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A6F RID: 2671
		[ObfuscatedName("ScheduleOne.DevUtilities.RebindActionUI+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D439 RID: 54329 RVA: 0x00332058 File Offset: 0x00330258
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr);
				RebindActionUI.__c__DisplayClass30_0.NativeFieldInfoPtr_bindingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr, "bindingId");
				RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr, 100676148);
				RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr, 100676149);
			}

			// Token: 0x0600D43A RID: 54330 RVA: 0x003320C0 File Offset: 0x003302C0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D43B RID: 54331 RVA: 0x003320FC File Offset: 0x003302FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206599, XrefRangeEnd = 206601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveActionAndBinding_b__0(InputBinding x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D43C RID: 54332 RVA: 0x00066ECC File Offset: 0x000650CC
			public __c__DisplayClass30_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AC RID: 16812
			// (get) Token: 0x0600D43D RID: 54333 RVA: 0x00332150 File Offset: 0x00330350
			// (set) Token: 0x0600D43E RID: 54334 RVA: 0x00066ED5 File Offset: 0x000650D5
			public unsafe Il2CppSystem.Guid bindingId
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass30_0.NativeFieldInfoPtr_bindingId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass30_0.NativeFieldInfoPtr_bindingId)) = value;
				}
			}

			// Token: 0x04008F40 RID: 36672
			private static readonly System.IntPtr NativeFieldInfoPtr_bindingId;

			// Token: 0x04008F41 RID: 36673
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F42 RID: 36674
			private static readonly System.IntPtr NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0;
		}

		// Token: 0x02000A70 RID: 2672
		[ObfuscatedName("ScheduleOne.DevUtilities.RebindActionUI+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D43F RID: 54335 RVA: 0x00332178 File Offset: 0x00330378
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr);
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_allCompositeParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "allCompositeParts");
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "bindingIndex");
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "action");
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100676150);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100676151);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100676152);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100676153);
			}

			// Token: 0x0600D440 RID: 54336 RVA: 0x00332244 File Offset: 0x00330444
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D441 RID: 54337 RVA: 0x00332280 File Offset: 0x00330480
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 206606, RefRangeEnd = 206608, XrefRangeStart = 206601, XrefRangeEnd = 206606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D442 RID: 54338 RVA: 0x003322B4 File Offset: 0x003304B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206608, XrefRangeEnd = 206619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PerformInteractiveRebind_b__1(InputActionRebindingExtensions.RebindingOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D443 RID: 54339 RVA: 0x003322F8 File Offset: 0x003304F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206619, XrefRangeEnd = 206633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PerformInteractiveRebind_b__2(InputActionRebindingExtensions.RebindingOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D444 RID: 54340 RVA: 0x00066EF0 File Offset: 0x000650F0
			public __c__DisplayClass34_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AD RID: 16813
			// (get) Token: 0x0600D445 RID: 54341 RVA: 0x0033233C File Offset: 0x0033053C
			// (set) Token: 0x0600D446 RID: 54342 RVA: 0x00066EF9 File Offset: 0x000650F9
			public unsafe RebindActionUI __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041AE RID: 16814
			// (get) Token: 0x0600D447 RID: 54343 RVA: 0x0033236C File Offset: 0x0033056C
			// (set) Token: 0x0600D448 RID: 54344 RVA: 0x00066F18 File Offset: 0x00065118
			public unsafe bool allCompositeParts
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_allCompositeParts);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_allCompositeParts)) = value;
				}
			}

			// Token: 0x170041AF RID: 16815
			// (get) Token: 0x0600D449 RID: 54345 RVA: 0x00332394 File Offset: 0x00330594
			// (set) Token: 0x0600D44A RID: 54346 RVA: 0x00066F33 File Offset: 0x00065133
			public unsafe int bindingIndex
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingIndex)) = value;
				}
			}

			// Token: 0x170041B0 RID: 16816
			// (get) Token: 0x0600D44B RID: 54347 RVA: 0x003323BC File Offset: 0x003305BC
			// (set) Token: 0x0600D44C RID: 54348 RVA: 0x00066F4E File Offset: 0x0006514E
			public unsafe InputAction action
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_action);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F43 RID: 36675
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F44 RID: 36676
			private static readonly System.IntPtr NativeFieldInfoPtr_allCompositeParts;

			// Token: 0x04008F45 RID: 36677
			private static readonly System.IntPtr NativeFieldInfoPtr_bindingIndex;

			// Token: 0x04008F46 RID: 36678
			private static readonly System.IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04008F47 RID: 36679
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F48 RID: 36680
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04008F49 RID: 36681
			private static readonly System.IntPtr NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0;

			// Token: 0x04008F4A RID: 36682
			private static readonly System.IntPtr NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0;
		}
	}
}
