using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Polling;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Polling
{
	// Token: 0x020006BF RID: 1727
	public class PollPanel : MonoBehaviour
	{
		// Token: 0x060098C3 RID: 39107 RVA: 0x00274440 File Offset: 0x00272640
		// Note: this type is marked as 'beforefieldinit'.
		static PollPanel()
		{
			Il2CppClassPointerStore<PollPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Polling", "PollPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel>.NativeClassPtr);
			PollPanel.NativeFieldInfoPtr_BUTTON_PRESS_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "BUTTON_PRESS_TIME");
			PollPanel.NativeFieldInfoPtr_ResponseSubmittedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ResponseSubmittedMessage");
			PollPanel.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ButtonPrefab");
			PollPanel.NativeFieldInfoPtr_TextColor_Green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "TextColor_Green");
			PollPanel.NativeFieldInfoPtr_TextColor_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "TextColor_Red");
			PollPanel.NativeFieldInfoPtr_PollManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "PollManager");
			PollPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "Container");
			PollPanel.NativeFieldInfoPtr_ActivePill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ActivePill");
			PollPanel.NativeFieldInfoPtr_ClosedPill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ClosedPill");
			PollPanel.NativeFieldInfoPtr_QuestionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "QuestionLabel");
			PollPanel.NativeFieldInfoPtr_ButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ButtonContainer");
			PollPanel.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "InstructionLabel");
			PollPanel.NativeFieldInfoPtr_ConfirmationMessageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ConfirmationMessageLabel");
			PollPanel.NativeFieldInfoPtr_SubmissionStartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "SubmissionStartSound");
			PollPanel.NativeFieldInfoPtr_SubmissionSuccessSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "SubmissionSuccessSound");
			PollPanel.NativeFieldInfoPtr_SubmissionFailSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "SubmissionFailSound");
			PollPanel.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "buttons");
			PollPanel.NativeFieldInfoPtr_buttonFills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "buttonFills");
			PollPanel.NativeFieldInfoPtr_heldButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "heldButton");
			PollPanel.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "selectedButton");
			PollPanel.NativeFieldInfoPtr_lastHeldButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "lastHeldButton");
			PollPanel.NativeFieldInfoPtr_buttonPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "buttonPressTime");
			PollPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682274);
			PollPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682275);
			PollPanel.NativeMethodInfoPtr_DisplayActivePoll_Public_Void_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682276);
			PollPanel.NativeMethodInfoPtr_DisplayConfirmedPoll_Public_Void_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682277);
			PollPanel.NativeMethodInfoPtr_DisplaySubmittedAnswer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682278);
			PollPanel.NativeMethodInfoPtr_Rebuild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682279);
			PollPanel.NativeMethodInfoPtr_CreateButtons_Private_List_1_Button_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682280);
			PollPanel.NativeMethodInfoPtr_ButtonPressed_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682281);
			PollPanel.NativeMethodInfoPtr_FinalizeButtonPress_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682282);
			PollPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100682283);
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x002746F0 File Offset: 0x002728F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273749, XrefRangeEnd = 273781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x00274724 File Offset: 0x00272924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273781, XrefRangeEnd = 273802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x00274758 File Offset: 0x00272958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273802, XrefRangeEnd = 273848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayActivePoll(PollData poll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(poll);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_DisplayActivePoll_Public_Void_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x0027479C File Offset: 0x0027299C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273848, XrefRangeEnd = 273910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayConfirmedPoll(PollData poll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(poll);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_DisplayConfirmedPoll_Public_Void_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x002747E0 File Offset: 0x002729E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273954, RefRangeEnd = 273955, XrefRangeStart = 273910, XrefRangeEnd = 273954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplaySubmittedAnswer(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref buttonIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_DisplaySubmittedAnswer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098C9 RID: 39113 RVA: 0x00274820 File Offset: 0x00272A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273986, RefRangeEnd = 273988, XrefRangeStart = 273955, XrefRangeEnd = 273986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rebuild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_Rebuild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098CA RID: 39114 RVA: 0x00274854 File Offset: 0x00272A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274043, RefRangeEnd = 274045, XrefRangeStart = 273988, XrefRangeEnd = 274043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Button> CreateButtons(PollData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_CreateButtons_Private_List_1_Button_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
		}

		// Token: 0x060098CB RID: 39115 RVA: 0x002748A4 File Offset: 0x00272AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274045, XrefRangeEnd = 274062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonPressed(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref buttonIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_ButtonPressed_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098CC RID: 39116 RVA: 0x002748E4 File Offset: 0x00272AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274100, RefRangeEnd = 274101, XrefRangeStart = 274062, XrefRangeEnd = 274100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeButtonPress(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref buttonIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_FinalizeButtonPress_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098CD RID: 39117 RVA: 0x00274924 File Offset: 0x00272B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274101, XrefRangeEnd = 274116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x00049E03 File Offset: 0x00048003
		public PollPanel(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x060098CF RID: 39119 RVA: 0x00274960 File Offset: 0x00272B60
		// (set) Token: 0x060098D0 RID: 39120 RVA: 0x00049E0C File Offset: 0x0004800C
		public unsafe static float BUTTON_PRESS_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PollPanel.NativeFieldInfoPtr_BUTTON_PRESS_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PollPanel.NativeFieldInfoPtr_BUTTON_PRESS_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x060098D1 RID: 39121 RVA: 0x0027497C File Offset: 0x00272B7C
		// (set) Token: 0x060098D2 RID: 39122 RVA: 0x00049E1A File Offset: 0x0004801A
		public unsafe static string ResponseSubmittedMessage
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(PollPanel.NativeFieldInfoPtr_ResponseSubmittedMessage, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PollPanel.NativeFieldInfoPtr_ResponseSubmittedMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x060098D3 RID: 39123 RVA: 0x0027499C File Offset: 0x00272B9C
		// (set) Token: 0x060098D4 RID: 39124 RVA: 0x00049E2C File Offset: 0x0004802C
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ButtonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x060098D5 RID: 39125 RVA: 0x002749CC File Offset: 0x00272BCC
		// (set) Token: 0x060098D6 RID: 39126 RVA: 0x00049E4B File Offset: 0x0004804B
		public unsafe Color TextColor_Green
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_TextColor_Green);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_TextColor_Green)) = value;
			}
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x060098D7 RID: 39127 RVA: 0x002749F4 File Offset: 0x00272BF4
		// (set) Token: 0x060098D8 RID: 39128 RVA: 0x00049E66 File Offset: 0x00048066
		public unsafe Color TextColor_Red
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_TextColor_Red);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_TextColor_Red)) = value;
			}
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x060098D9 RID: 39129 RVA: 0x00274A1C File Offset: 0x00272C1C
		// (set) Token: 0x060098DA RID: 39130 RVA: 0x00049E81 File Offset: 0x00048081
		public unsafe PollManager PollManager
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_PollManager);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollManager>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_PollManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x060098DB RID: 39131 RVA: 0x00274A4C File Offset: 0x00272C4C
		// (set) Token: 0x060098DC RID: 39132 RVA: 0x00049EA0 File Offset: 0x000480A0
		public unsafe GameObject Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x060098DD RID: 39133 RVA: 0x00274A7C File Offset: 0x00272C7C
		// (set) Token: 0x060098DE RID: 39134 RVA: 0x00049EBF File Offset: 0x000480BF
		public unsafe GameObject ActivePill
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ActivePill);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ActivePill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x060098DF RID: 39135 RVA: 0x00274AAC File Offset: 0x00272CAC
		// (set) Token: 0x060098E0 RID: 39136 RVA: 0x00049EDE File Offset: 0x000480DE
		public unsafe GameObject ClosedPill
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ClosedPill);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ClosedPill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x060098E1 RID: 39137 RVA: 0x00274ADC File Offset: 0x00272CDC
		// (set) Token: 0x060098E2 RID: 39138 RVA: 0x00049EFD File Offset: 0x000480FD
		public unsafe TextMeshProUGUI QuestionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_QuestionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_QuestionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x060098E3 RID: 39139 RVA: 0x00274B0C File Offset: 0x00272D0C
		// (set) Token: 0x060098E4 RID: 39140 RVA: 0x00049F1C File Offset: 0x0004811C
		public unsafe RectTransform ButtonContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ButtonContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x060098E5 RID: 39141 RVA: 0x00274B3C File Offset: 0x00272D3C
		// (set) Token: 0x060098E6 RID: 39142 RVA: 0x00049F3B File Offset: 0x0004813B
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_InstructionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x060098E7 RID: 39143 RVA: 0x00274B6C File Offset: 0x00272D6C
		// (set) Token: 0x060098E8 RID: 39144 RVA: 0x00049F5A File Offset: 0x0004815A
		public unsafe TextMeshProUGUI ConfirmationMessageLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ConfirmationMessageLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ConfirmationMessageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x060098E9 RID: 39145 RVA: 0x00274B9C File Offset: 0x00272D9C
		// (set) Token: 0x060098EA RID: 39146 RVA: 0x00049F79 File Offset: 0x00048179
		public unsafe AudioSourceController SubmissionStartSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionStartSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionStartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x060098EB RID: 39147 RVA: 0x00274BCC File Offset: 0x00272DCC
		// (set) Token: 0x060098EC RID: 39148 RVA: 0x00049F98 File Offset: 0x00048198
		public unsafe AudioSourceController SubmissionSuccessSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionSuccessSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionSuccessSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x060098ED RID: 39149 RVA: 0x00274BFC File Offset: 0x00272DFC
		// (set) Token: 0x060098EE RID: 39150 RVA: 0x00049FB7 File Offset: 0x000481B7
		public unsafe AudioSourceController SubmissionFailSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionFailSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionFailSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x060098EF RID: 39151 RVA: 0x00274C2C File Offset: 0x00272E2C
		// (set) Token: 0x060098F0 RID: 39152 RVA: 0x00049FD6 File Offset: 0x000481D6
		public unsafe List<Button> buttons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x060098F1 RID: 39153 RVA: 0x00274C5C File Offset: 0x00272E5C
		// (set) Token: 0x060098F2 RID: 39154 RVA: 0x00049FF5 File Offset: 0x000481F5
		public unsafe List<Image> buttonFills
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttonFills);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Image>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttonFills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x060098F3 RID: 39155 RVA: 0x00274C8C File Offset: 0x00272E8C
		// (set) Token: 0x060098F4 RID: 39156 RVA: 0x0004A014 File Offset: 0x00048214
		public unsafe int heldButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_heldButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_heldButton)) = value;
			}
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x060098F5 RID: 39157 RVA: 0x00274CB4 File Offset: 0x00272EB4
		// (set) Token: 0x060098F6 RID: 39158 RVA: 0x0004A02F File Offset: 0x0004822F
		public unsafe int selectedButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_selectedButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_selectedButton)) = value;
			}
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x060098F7 RID: 39159 RVA: 0x00274CDC File Offset: 0x00272EDC
		// (set) Token: 0x060098F8 RID: 39160 RVA: 0x0004A04A File Offset: 0x0004824A
		public unsafe int lastHeldButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_lastHeldButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_lastHeldButton)) = value;
			}
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x060098F9 RID: 39161 RVA: 0x00274D04 File Offset: 0x00272F04
		// (set) Token: 0x060098FA RID: 39162 RVA: 0x0004A065 File Offset: 0x00048265
		public unsafe float buttonPressTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttonPressTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttonPressTime)) = value;
			}
		}

		// Token: 0x04006703 RID: 26371
		private static readonly System.IntPtr NativeFieldInfoPtr_BUTTON_PRESS_TIME;

		// Token: 0x04006704 RID: 26372
		private static readonly System.IntPtr NativeFieldInfoPtr_ResponseSubmittedMessage;

		// Token: 0x04006705 RID: 26373
		private static readonly System.IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x04006706 RID: 26374
		private static readonly System.IntPtr NativeFieldInfoPtr_TextColor_Green;

		// Token: 0x04006707 RID: 26375
		private static readonly System.IntPtr NativeFieldInfoPtr_TextColor_Red;

		// Token: 0x04006708 RID: 26376
		private static readonly System.IntPtr NativeFieldInfoPtr_PollManager;

		// Token: 0x04006709 RID: 26377
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400670A RID: 26378
		private static readonly System.IntPtr NativeFieldInfoPtr_ActivePill;

		// Token: 0x0400670B RID: 26379
		private static readonly System.IntPtr NativeFieldInfoPtr_ClosedPill;

		// Token: 0x0400670C RID: 26380
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestionLabel;

		// Token: 0x0400670D RID: 26381
		private static readonly System.IntPtr NativeFieldInfoPtr_ButtonContainer;

		// Token: 0x0400670E RID: 26382
		private static readonly System.IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x0400670F RID: 26383
		private static readonly System.IntPtr NativeFieldInfoPtr_ConfirmationMessageLabel;

		// Token: 0x04006710 RID: 26384
		private static readonly System.IntPtr NativeFieldInfoPtr_SubmissionStartSound;

		// Token: 0x04006711 RID: 26385
		private static readonly System.IntPtr NativeFieldInfoPtr_SubmissionSuccessSound;

		// Token: 0x04006712 RID: 26386
		private static readonly System.IntPtr NativeFieldInfoPtr_SubmissionFailSound;

		// Token: 0x04006713 RID: 26387
		private static readonly System.IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x04006714 RID: 26388
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonFills;

		// Token: 0x04006715 RID: 26389
		private static readonly System.IntPtr NativeFieldInfoPtr_heldButton;

		// Token: 0x04006716 RID: 26390
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x04006717 RID: 26391
		private static readonly System.IntPtr NativeFieldInfoPtr_lastHeldButton;

		// Token: 0x04006718 RID: 26392
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonPressTime;

		// Token: 0x04006719 RID: 26393
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400671A RID: 26394
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400671B RID: 26395
		private static readonly System.IntPtr NativeMethodInfoPtr_DisplayActivePoll_Public_Void_PollData_0;

		// Token: 0x0400671C RID: 26396
		private static readonly System.IntPtr NativeMethodInfoPtr_DisplayConfirmedPoll_Public_Void_PollData_0;

		// Token: 0x0400671D RID: 26397
		private static readonly System.IntPtr NativeMethodInfoPtr_DisplaySubmittedAnswer_Private_Void_Int32_0;

		// Token: 0x0400671E RID: 26398
		private static readonly System.IntPtr NativeMethodInfoPtr_Rebuild_Private_Void_0;

		// Token: 0x0400671F RID: 26399
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateButtons_Private_List_1_Button_PollData_0;

		// Token: 0x04006720 RID: 26400
		private static readonly System.IntPtr NativeMethodInfoPtr_ButtonPressed_Private_Void_Int32_0;

		// Token: 0x04006721 RID: 26401
		private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeButtonPress_Private_Void_Int32_0;

		// Token: 0x04006722 RID: 26402
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAE RID: 2990
		[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF74 RID: 57204 RVA: 0x00351D04 File Offset: 0x0034FF04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr);
				PollPanel.__c__DisplayClass27_0.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr, "layout");
				PollPanel.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr, 100682284);
				PollPanel.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr, 100682285);
			}

			// Token: 0x0600DF75 RID: 57205 RVA: 0x00351D6C File Offset: 0x0034FF6C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF76 RID: 57206 RVA: 0x00351DA8 File Offset: 0x0034FFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273698, XrefRangeEnd = 273703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DF77 RID: 57207 RVA: 0x0006C7AA File Offset: 0x0006A9AA
			public __c__DisplayClass27_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004502 RID: 17666
			// (get) Token: 0x0600DF78 RID: 57208 RVA: 0x00351DE8 File Offset: 0x0034FFE8
			// (set) Token: 0x0600DF79 RID: 57209 RVA: 0x0006C7B3 File Offset: 0x0006A9B3
			public unsafe VerticalLayoutGroup layout
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.NativeFieldInfoPtr_layout);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.NativeFieldInfoPtr_layout), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009619 RID: 38425
			private static readonly System.IntPtr NativeFieldInfoPtr_layout;

			// Token: 0x0400961A RID: 38426
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400961B RID: 38427
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CD5 RID: 3285
			[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass27_0+<<Rebuild>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EB88 RID: 60296 RVA: 0x003745F0 File Offset: 0x003727F0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr, "<<Rebuild>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682286);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682287);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682288);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682289);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682290);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682291);
				}

				// Token: 0x0600EB89 RID: 60297 RVA: 0x003746D0 File Offset: 0x003728D0
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB8A RID: 60298 RVA: 0x00374718 File Offset: 0x00372918
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB8B RID: 60299 RVA: 0x0037474C File Offset: 0x0037294C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273682, XrefRangeEnd = 273693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048F7 RID: 18679
				// (get) Token: 0x0600EB8C RID: 60300 RVA: 0x00374788 File Offset: 0x00372988
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB8D RID: 60301 RVA: 0x003747C8 File Offset: 0x003729C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273693, XrefRangeEnd = 273698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048F8 RID: 18680
				// (get) Token: 0x0600EB8E RID: 60302 RVA: 0x003747FC File Offset: 0x003729FC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB8F RID: 60303 RVA: 0x000729E5 File Offset: 0x00070BE5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048F4 RID: 18676
				// (get) Token: 0x0600EB90 RID: 60304 RVA: 0x0037483C File Offset: 0x00372A3C
				// (set) Token: 0x0600EB91 RID: 60305 RVA: 0x000729EE File Offset: 0x00070BEE
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048F5 RID: 18677
				// (get) Token: 0x0600EB92 RID: 60306 RVA: 0x00374864 File Offset: 0x00372A64
				// (set) Token: 0x0600EB93 RID: 60307 RVA: 0x00072A09 File Offset: 0x00070C09
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048F6 RID: 18678
				// (get) Token: 0x0600EB94 RID: 60308 RVA: 0x00374894 File Offset: 0x00372A94
				// (set) Token: 0x0600EB95 RID: 60309 RVA: 0x00072A28 File Offset: 0x00070C28
				public unsafe PollPanel.__c__DisplayClass27_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollPanel.__c__DisplayClass27_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009D80 RID: 40320
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D81 RID: 40321
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D82 RID: 40322
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D83 RID: 40323
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D84 RID: 40324
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D85 RID: 40325
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D86 RID: 40326
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D87 RID: 40327
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D88 RID: 40328
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BAF RID: 2991
		[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF7A RID: 57210 RVA: 0x00351E18 File Offset: 0x00350018
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr);
				PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_buttonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr, "buttonIndex");
				PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr, 100682292);
				PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__CreateButtons_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr, 100682293);
			}

			// Token: 0x0600DF7B RID: 57211 RVA: 0x00351E94 File Offset: 0x00350094
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF7C RID: 57212 RVA: 0x00351ED0 File Offset: 0x003500D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273703, XrefRangeEnd = 273720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateButtons_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__CreateButtons_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF7D RID: 57213 RVA: 0x0006C7D2 File Offset: 0x0006A9D2
			public __c__DisplayClass28_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004503 RID: 17667
			// (get) Token: 0x0600DF7E RID: 57214 RVA: 0x00351F14 File Offset: 0x00350114
			// (set) Token: 0x0600DF7F RID: 57215 RVA: 0x0006C7DB File Offset: 0x0006A9DB
			public unsafe int buttonIndex
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_buttonIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_buttonIndex)) = value;
				}
			}

			// Token: 0x17004504 RID: 17668
			// (get) Token: 0x0600DF80 RID: 57216 RVA: 0x00351F3C File Offset: 0x0035013C
			// (set) Token: 0x0600DF81 RID: 57217 RVA: 0x0006C7F6 File Offset: 0x0006A9F6
			public unsafe PollPanel __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollPanel>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400961C RID: 38428
			private static readonly System.IntPtr NativeFieldInfoPtr_buttonIndex;

			// Token: 0x0400961D RID: 38429
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400961E RID: 38430
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400961F RID: 38431
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateButtons_b__0_Internal_Void_BaseEventData_0;
		}

		// Token: 0x02000BB0 RID: 2992
		[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF82 RID: 57218 RVA: 0x00351F6C File Offset: 0x0035016C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr);
				PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr_buttonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, "buttonIndex");
				PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, 100682294);
				PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, 100682295);
				PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr__FinalizeButtonPress_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, 100682296);
			}

			// Token: 0x0600DF83 RID: 57219 RVA: 0x00351FFC File Offset: 0x003501FC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF84 RID: 57220 RVA: 0x00352038 File Offset: 0x00350238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273744, XrefRangeEnd = 273749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DF85 RID: 57221 RVA: 0x00352078 File Offset: 0x00350278
			[CallerCount(0)]
			public unsafe bool _FinalizeButtonPress_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr__FinalizeButtonPress_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF86 RID: 57222 RVA: 0x0006C815 File Offset: 0x0006AA15
			public __c__DisplayClass30_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004505 RID: 17669
			// (get) Token: 0x0600DF87 RID: 57223 RVA: 0x003520B4 File Offset: 0x003502B4
			// (set) Token: 0x0600DF88 RID: 57224 RVA: 0x0006C81E File Offset: 0x0006AA1E
			public unsafe PollPanel __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollPanel>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004506 RID: 17670
			// (get) Token: 0x0600DF89 RID: 57225 RVA: 0x003520E4 File Offset: 0x003502E4
			// (set) Token: 0x0600DF8A RID: 57226 RVA: 0x0006C83D File Offset: 0x0006AA3D
			public unsafe int buttonIndex
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr_buttonIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr_buttonIndex)) = value;
				}
			}

			// Token: 0x04009620 RID: 38432
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009621 RID: 38433
			private static readonly System.IntPtr NativeFieldInfoPtr_buttonIndex;

			// Token: 0x04009622 RID: 38434
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009623 RID: 38435
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009624 RID: 38436
			private static readonly System.IntPtr NativeMethodInfoPtr__FinalizeButtonPress_b__1_Internal_Boolean_0;

			// Token: 0x02000CD6 RID: 3286
			[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass30_0+<<FinalizeButtonPress>g__Submit|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EB96 RID: 60310 RVA: 0x003748C4 File Offset: 0x00372AC4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, "<<FinalizeButtonPress>g__Submit|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682297);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682298);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682299);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682300);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682301);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682302);
				}

				// Token: 0x0600EB97 RID: 60311 RVA: 0x003749A4 File Offset: 0x00372BA4
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB98 RID: 60312 RVA: 0x003749EC File Offset: 0x00372BEC
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB99 RID: 60313 RVA: 0x00374A20 File Offset: 0x00372C20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273720, XrefRangeEnd = 273739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048FC RID: 18684
				// (get) Token: 0x0600EB9A RID: 60314 RVA: 0x00374A5C File Offset: 0x00372C5C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB9B RID: 60315 RVA: 0x00374A9C File Offset: 0x00372C9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273739, XrefRangeEnd = 273744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048FD RID: 18685
				// (get) Token: 0x0600EB9C RID: 60316 RVA: 0x00374AD0 File Offset: 0x00372CD0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB9D RID: 60317 RVA: 0x00072A47 File Offset: 0x00070C47
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048F9 RID: 18681
				// (get) Token: 0x0600EB9E RID: 60318 RVA: 0x00374B10 File Offset: 0x00372D10
				// (set) Token: 0x0600EB9F RID: 60319 RVA: 0x00072A50 File Offset: 0x00070C50
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048FA RID: 18682
				// (get) Token: 0x0600EBA0 RID: 60320 RVA: 0x00374B38 File Offset: 0x00372D38
				// (set) Token: 0x0600EBA1 RID: 60321 RVA: 0x00072A6B File Offset: 0x00070C6B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048FB RID: 18683
				// (get) Token: 0x0600EBA2 RID: 60322 RVA: 0x00374B68 File Offset: 0x00372D68
				// (set) Token: 0x0600EBA3 RID: 60323 RVA: 0x00072A8A File Offset: 0x00070C8A
				public unsafe PollPanel.__c__DisplayClass30_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollPanel.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009D89 RID: 40329
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D8A RID: 40330
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D8B RID: 40331
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D8C RID: 40332
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D8D RID: 40333
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D8E RID: 40334
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D8F RID: 40335
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D90 RID: 40336
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D91 RID: 40337
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
