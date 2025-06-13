using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000665 RID: 1637
	public class HUD : Singleton<HUD>
	{
		// Token: 0x06008FDB RID: 36827 RVA: 0x00259CB4 File Offset: 0x00257EB4
		// Note: this type is marked as 'beforefieldinit'.
		static HUD()
		{
			Il2CppClassPointerStore<HUD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HUD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUD>.NativeClassPtr);
			HUD.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "canvas");
			HUD.NativeFieldInfoPtr_canvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "canvasRect");
			HUD.NativeFieldInfoPtr_crosshair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "crosshair");
			HUD.NativeFieldInfoPtr_blackOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "blackOverlay");
			HUD.NativeFieldInfoPtr_radialIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "radialIndicator");
			HUD.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "raycaster");
			HUD.NativeFieldInfoPtr_topScreenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "topScreenText");
			HUD.NativeFieldInfoPtr_topScreenText_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "topScreenText_Background");
			HUD.NativeFieldInfoPtr_fpsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "fpsLabel");
			HUD.NativeFieldInfoPtr_cashSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "cashSlotContainer");
			HUD.NativeFieldInfoPtr_cashSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "cashSlotUI");
			HUD.NativeFieldInfoPtr_onlineBalanceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "onlineBalanceContainer");
			HUD.NativeFieldInfoPtr_onlineBalanceSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "onlineBalanceSlotUI");
			HUD.NativeFieldInfoPtr_managementSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "managementSlotContainer");
			HUD.NativeFieldInfoPtr_managementSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "managementSlotUI");
			HUD.NativeFieldInfoPtr_HotbarContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "HotbarContainer");
			HUD.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SlotContainer");
			HUD.NativeFieldInfoPtr_discardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "discardSlot");
			HUD.NativeFieldInfoPtr_discardSlotFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "discardSlotFill");
			HUD.NativeFieldInfoPtr_selectedItemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "selectedItemLabel");
			HUD.NativeFieldInfoPtr_QuestEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "QuestEntryContainer");
			HUD.NativeFieldInfoPtr_QuestEntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "QuestEntryTitle");
			HUD.NativeFieldInfoPtr_CrimeStatusUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CrimeStatusUI");
			HUD.NativeFieldInfoPtr_OnlineBalanceDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "OnlineBalanceDisplay");
			HUD.NativeFieldInfoPtr_SafeBalanceDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SafeBalanceDisplay");
			HUD.NativeFieldInfoPtr_CrosshairText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CrosshairText");
			HUD.NativeFieldInfoPtr_UnreadMessagesPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "UnreadMessagesPrompt");
			HUD.NativeFieldInfoPtr_SleepPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SleepPrompt");
			HUD.NativeFieldInfoPtr_CurfewPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CurfewPrompt");
			HUD.NativeFieldInfoPtr_RedGreenGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "RedGreenGradient");
			HUD.NativeFieldInfoPtr_SampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SampleSize");
			HUD.NativeFieldInfoPtr__previousFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "_previousFPS");
			HUD.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "eventSystem");
			HUD.NativeFieldInfoPtr_blackOverlayFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "blackOverlayFade");
			HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "radialIndicatorSetThisFrame");
			HUD.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681280);
			HUD.NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681281);
			HUD.NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681282);
			HUD.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681283);
			HUD.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681284);
			HUD.NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681285);
			HUD.NativeMethodInfoPtr_RefreshFPS_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681286);
			HUD.NativeMethodInfoPtr_GetAverageFPS_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681287);
			HUD.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681288);
			HUD.NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681289);
			HUD.NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681290);
			HUD.NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681291);
			HUD.NativeMethodInfoPtr_HideTopScreenText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681292);
			HUD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100681293);
		}

		// Token: 0x06008FDC RID: 36828 RVA: 0x0025A0B8 File Offset: 0x002582B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262086, XrefRangeEnd = 262099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x0025A0F4 File Offset: 0x002582F4
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 262102, RefRangeEnd = 262136, XrefRangeStart = 262099, XrefRangeEnd = 262102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrosshairVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x0025A134 File Offset: 0x00258334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262136, XrefRangeEnd = 262144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlackOverlayVisible(bool vis, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref fadeTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FDF RID: 36831 RVA: 0x0025A180 File Offset: 0x00258380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262144, XrefRangeEnd = 262145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FE0 RID: 36832 RVA: 0x0025A1BC File Offset: 0x002583BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262145, XrefRangeEnd = 262180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FE1 RID: 36833 RVA: 0x0025A1F0 File Offset: 0x002583F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262180, XrefRangeEnd = 262187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuestEntryTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x0025A224 File Offset: 0x00258424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262206, RefRangeEnd = 262207, XrefRangeStart = 262187, XrefRangeEnd = 262206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshFPS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_RefreshFPS_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FE3 RID: 36835 RVA: 0x0025A258 File Offset: 0x00258458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262207, XrefRangeEnd = 262212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageFPS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_GetAverageFPS_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008FE4 RID: 36836 RVA: 0x0025A294 File Offset: 0x00258494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262212, XrefRangeEnd = 262213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FE5 RID: 36837 RVA: 0x0025A2D0 File Offset: 0x002584D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262213, XrefRangeEnd = 262218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FadeBlackOverlay(bool visible, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref fadeTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x0025A32C File Offset: 0x0025852C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262221, RefRangeEnd = 262226, XrefRangeStart = 262218, XrefRangeEnd = 262221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowRadialIndicator(float fill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fill;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x0025A36C File Offset: 0x0025856C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 262231, RefRangeEnd = 262240, XrefRangeStart = 262226, XrefRangeEnd = 262231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTopScreenText(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x0025A3B0 File Offset: 0x002585B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 262243, RefRangeEnd = 262250, XrefRangeStart = 262240, XrefRangeEnd = 262243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideTopScreenText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_HideTopScreenText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0025A3E4 File Offset: 0x002585E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262250, XrefRangeEnd = 262260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HUD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUD>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x00044C65 File Offset: 0x00042E65
		public HUD(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x06008FEB RID: 36843 RVA: 0x0025A420 File Offset: 0x00258620
		// (set) Token: 0x06008FEC RID: 36844 RVA: 0x00044C6E File Offset: 0x00042E6E
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x06008FED RID: 36845 RVA: 0x0025A450 File Offset: 0x00258650
		// (set) Token: 0x06008FEE RID: 36846 RVA: 0x00044C8D File Offset: 0x00042E8D
		public unsafe RectTransform canvasRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvasRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvasRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x06008FEF RID: 36847 RVA: 0x0025A480 File Offset: 0x00258680
		// (set) Token: 0x06008FF0 RID: 36848 RVA: 0x00044CAC File Offset: 0x00042EAC
		public unsafe Image crosshair
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_crosshair);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_crosshair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x06008FF1 RID: 36849 RVA: 0x0025A4B0 File Offset: 0x002586B0
		// (set) Token: 0x06008FF2 RID: 36850 RVA: 0x00044CCB File Offset: 0x00042ECB
		public unsafe Image blackOverlay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x06008FF3 RID: 36851 RVA: 0x0025A4E0 File Offset: 0x002586E0
		// (set) Token: 0x06008FF4 RID: 36852 RVA: 0x00044CEA File Offset: 0x00042EEA
		public unsafe Image radialIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x06008FF5 RID: 36853 RVA: 0x0025A510 File Offset: 0x00258710
		// (set) Token: 0x06008FF6 RID: 36854 RVA: 0x00044D09 File Offset: 0x00042F09
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_raycaster);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x06008FF7 RID: 36855 RVA: 0x0025A540 File Offset: 0x00258740
		// (set) Token: 0x06008FF8 RID: 36856 RVA: 0x00044D28 File Offset: 0x00042F28
		public unsafe TextMeshProUGUI topScreenText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x0025A570 File Offset: 0x00258770
		// (set) Token: 0x06008FFA RID: 36858 RVA: 0x00044D47 File Offset: 0x00042F47
		public unsafe RectTransform topScreenText_Background
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText_Background);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x06008FFB RID: 36859 RVA: 0x0025A5A0 File Offset: 0x002587A0
		// (set) Token: 0x06008FFC RID: 36860 RVA: 0x00044D66 File Offset: 0x00042F66
		public unsafe Text fpsLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_fpsLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_fpsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x06008FFD RID: 36861 RVA: 0x0025A5D0 File Offset: 0x002587D0
		// (set) Token: 0x06008FFE RID: 36862 RVA: 0x00044D85 File Offset: 0x00042F85
		public unsafe RectTransform cashSlotContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x06008FFF RID: 36863 RVA: 0x0025A600 File Offset: 0x00258800
		// (set) Token: 0x06009000 RID: 36864 RVA: 0x00044DA4 File Offset: 0x00042FA4
		public unsafe RectTransform cashSlotUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x06009001 RID: 36865 RVA: 0x0025A630 File Offset: 0x00258830
		// (set) Token: 0x06009002 RID: 36866 RVA: 0x00044DC3 File Offset: 0x00042FC3
		public unsafe RectTransform onlineBalanceContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x06009003 RID: 36867 RVA: 0x0025A660 File Offset: 0x00258860
		// (set) Token: 0x06009004 RID: 36868 RVA: 0x00044DE2 File Offset: 0x00042FE2
		public unsafe RectTransform onlineBalanceSlotUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceSlotUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x06009005 RID: 36869 RVA: 0x0025A690 File Offset: 0x00258890
		// (set) Token: 0x06009006 RID: 36870 RVA: 0x00044E01 File Offset: 0x00043001
		public unsafe RectTransform managementSlotContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x06009007 RID: 36871 RVA: 0x0025A6C0 File Offset: 0x002588C0
		// (set) Token: 0x06009008 RID: 36872 RVA: 0x00044E20 File Offset: 0x00043020
		public unsafe ItemSlotUI managementSlotUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x06009009 RID: 36873 RVA: 0x0025A6F0 File Offset: 0x002588F0
		// (set) Token: 0x0600900A RID: 36874 RVA: 0x00044E3F File Offset: 0x0004303F
		public unsafe RectTransform HotbarContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_HotbarContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_HotbarContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x0600900B RID: 36875 RVA: 0x0025A720 File Offset: 0x00258920
		// (set) Token: 0x0600900C RID: 36876 RVA: 0x00044E5E File Offset: 0x0004305E
		public unsafe RectTransform SlotContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SlotContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x0600900D RID: 36877 RVA: 0x0025A750 File Offset: 0x00258950
		// (set) Token: 0x0600900E RID: 36878 RVA: 0x00044E7D File Offset: 0x0004307D
		public unsafe ItemSlotUI discardSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x0600900F RID: 36879 RVA: 0x0025A780 File Offset: 0x00258980
		// (set) Token: 0x06009010 RID: 36880 RVA: 0x00044E9C File Offset: 0x0004309C
		public unsafe Image discardSlotFill
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlotFill);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlotFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x06009011 RID: 36881 RVA: 0x0025A7B0 File Offset: 0x002589B0
		// (set) Token: 0x06009012 RID: 36882 RVA: 0x00044EBB File Offset: 0x000430BB
		public unsafe TextMeshProUGUI selectedItemLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_selectedItemLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_selectedItemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x06009013 RID: 36883 RVA: 0x0025A7E0 File Offset: 0x002589E0
		// (set) Token: 0x06009014 RID: 36884 RVA: 0x00044EDA File Offset: 0x000430DA
		public unsafe RectTransform QuestEntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x06009015 RID: 36885 RVA: 0x0025A810 File Offset: 0x00258A10
		// (set) Token: 0x06009016 RID: 36886 RVA: 0x00044EF9 File Offset: 0x000430F9
		public unsafe TextMeshProUGUI QuestEntryTitle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryTitle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x06009017 RID: 36887 RVA: 0x0025A840 File Offset: 0x00258A40
		// (set) Token: 0x06009018 RID: 36888 RVA: 0x00044F18 File Offset: 0x00043118
		public unsafe CrimeStatusUI CrimeStatusUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrimeStatusUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrimeStatusUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrimeStatusUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x06009019 RID: 36889 RVA: 0x0025A870 File Offset: 0x00258A70
		// (set) Token: 0x0600901A RID: 36890 RVA: 0x00044F37 File Offset: 0x00043137
		public unsafe BalanceDisplay OnlineBalanceDisplay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_OnlineBalanceDisplay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BalanceDisplay>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_OnlineBalanceDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x0600901B RID: 36891 RVA: 0x0025A8A0 File Offset: 0x00258AA0
		// (set) Token: 0x0600901C RID: 36892 RVA: 0x00044F56 File Offset: 0x00043156
		public unsafe BalanceDisplay SafeBalanceDisplay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SafeBalanceDisplay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BalanceDisplay>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SafeBalanceDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x0600901D RID: 36893 RVA: 0x0025A8D0 File Offset: 0x00258AD0
		// (set) Token: 0x0600901E RID: 36894 RVA: 0x00044F75 File Offset: 0x00043175
		public unsafe CrosshairText CrosshairText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrosshairText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrosshairText>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrosshairText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x0600901F RID: 36895 RVA: 0x0025A900 File Offset: 0x00258B00
		// (set) Token: 0x06009020 RID: 36896 RVA: 0x00044F94 File Offset: 0x00043194
		public unsafe RectTransform UnreadMessagesPrompt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_UnreadMessagesPrompt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_UnreadMessagesPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x06009021 RID: 36897 RVA: 0x0025A930 File Offset: 0x00258B30
		// (set) Token: 0x06009022 RID: 36898 RVA: 0x00044FB3 File Offset: 0x000431B3
		public unsafe TextMeshProUGUI SleepPrompt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SleepPrompt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SleepPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x06009023 RID: 36899 RVA: 0x0025A960 File Offset: 0x00258B60
		// (set) Token: 0x06009024 RID: 36900 RVA: 0x00044FD2 File Offset: 0x000431D2
		public unsafe TextMeshProUGUI CurfewPrompt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CurfewPrompt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CurfewPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x06009025 RID: 36901 RVA: 0x0025A990 File Offset: 0x00258B90
		// (set) Token: 0x06009026 RID: 36902 RVA: 0x00044FF1 File Offset: 0x000431F1
		public unsafe Gradient RedGreenGradient
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_RedGreenGradient);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_RedGreenGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x06009027 RID: 36903 RVA: 0x0025A9C0 File Offset: 0x00258BC0
		// (set) Token: 0x06009028 RID: 36904 RVA: 0x00045010 File Offset: 0x00043210
		public unsafe int SampleSize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SampleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SampleSize)) = value;
			}
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x06009029 RID: 36905 RVA: 0x0025A9E8 File Offset: 0x00258BE8
		// (set) Token: 0x0600902A RID: 36906 RVA: 0x0004502B File Offset: 0x0004322B
		public unsafe List<float> _previousFPS
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__previousFPS);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__previousFPS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x0600902B RID: 36907 RVA: 0x0025AA18 File Offset: 0x00258C18
		// (set) Token: 0x0600902C RID: 36908 RVA: 0x0004504A File Offset: 0x0004324A
		public unsafe EventSystem eventSystem
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_eventSystem);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x0600902D RID: 36909 RVA: 0x0025AA48 File Offset: 0x00258C48
		// (set) Token: 0x0600902E RID: 36910 RVA: 0x00045069 File Offset: 0x00043269
		public unsafe Coroutine blackOverlayFade
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlayFade);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlayFade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x0600902F RID: 36911 RVA: 0x0025AA78 File Offset: 0x00258C78
		// (set) Token: 0x06009030 RID: 36912 RVA: 0x00045088 File Offset: 0x00043288
		public unsafe bool radialIndicatorSetThisFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame)) = value;
			}
		}

		// Token: 0x0400617C RID: 24956
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x0400617D RID: 24957
		private static readonly System.IntPtr NativeFieldInfoPtr_canvasRect;

		// Token: 0x0400617E RID: 24958
		private static readonly System.IntPtr NativeFieldInfoPtr_crosshair;

		// Token: 0x0400617F RID: 24959
		private static readonly System.IntPtr NativeFieldInfoPtr_blackOverlay;

		// Token: 0x04006180 RID: 24960
		private static readonly System.IntPtr NativeFieldInfoPtr_radialIndicator;

		// Token: 0x04006181 RID: 24961
		private static readonly System.IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04006182 RID: 24962
		private static readonly System.IntPtr NativeFieldInfoPtr_topScreenText;

		// Token: 0x04006183 RID: 24963
		private static readonly System.IntPtr NativeFieldInfoPtr_topScreenText_Background;

		// Token: 0x04006184 RID: 24964
		private static readonly System.IntPtr NativeFieldInfoPtr_fpsLabel;

		// Token: 0x04006185 RID: 24965
		private static readonly System.IntPtr NativeFieldInfoPtr_cashSlotContainer;

		// Token: 0x04006186 RID: 24966
		private static readonly System.IntPtr NativeFieldInfoPtr_cashSlotUI;

		// Token: 0x04006187 RID: 24967
		private static readonly System.IntPtr NativeFieldInfoPtr_onlineBalanceContainer;

		// Token: 0x04006188 RID: 24968
		private static readonly System.IntPtr NativeFieldInfoPtr_onlineBalanceSlotUI;

		// Token: 0x04006189 RID: 24969
		private static readonly System.IntPtr NativeFieldInfoPtr_managementSlotContainer;

		// Token: 0x0400618A RID: 24970
		private static readonly System.IntPtr NativeFieldInfoPtr_managementSlotUI;

		// Token: 0x0400618B RID: 24971
		private static readonly System.IntPtr NativeFieldInfoPtr_HotbarContainer;

		// Token: 0x0400618C RID: 24972
		private static readonly System.IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x0400618D RID: 24973
		private static readonly System.IntPtr NativeFieldInfoPtr_discardSlot;

		// Token: 0x0400618E RID: 24974
		private static readonly System.IntPtr NativeFieldInfoPtr_discardSlotFill;

		// Token: 0x0400618F RID: 24975
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedItemLabel;

		// Token: 0x04006190 RID: 24976
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestEntryContainer;

		// Token: 0x04006191 RID: 24977
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestEntryTitle;

		// Token: 0x04006192 RID: 24978
		private static readonly System.IntPtr NativeFieldInfoPtr_CrimeStatusUI;

		// Token: 0x04006193 RID: 24979
		private static readonly System.IntPtr NativeFieldInfoPtr_OnlineBalanceDisplay;

		// Token: 0x04006194 RID: 24980
		private static readonly System.IntPtr NativeFieldInfoPtr_SafeBalanceDisplay;

		// Token: 0x04006195 RID: 24981
		private static readonly System.IntPtr NativeFieldInfoPtr_CrosshairText;

		// Token: 0x04006196 RID: 24982
		private static readonly System.IntPtr NativeFieldInfoPtr_UnreadMessagesPrompt;

		// Token: 0x04006197 RID: 24983
		private static readonly System.IntPtr NativeFieldInfoPtr_SleepPrompt;

		// Token: 0x04006198 RID: 24984
		private static readonly System.IntPtr NativeFieldInfoPtr_CurfewPrompt;

		// Token: 0x04006199 RID: 24985
		private static readonly System.IntPtr NativeFieldInfoPtr_RedGreenGradient;

		// Token: 0x0400619A RID: 24986
		private static readonly System.IntPtr NativeFieldInfoPtr_SampleSize;

		// Token: 0x0400619B RID: 24987
		private static readonly System.IntPtr NativeFieldInfoPtr__previousFPS;

		// Token: 0x0400619C RID: 24988
		private static readonly System.IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x0400619D RID: 24989
		private static readonly System.IntPtr NativeFieldInfoPtr_blackOverlayFade;

		// Token: 0x0400619E RID: 24990
		private static readonly System.IntPtr NativeFieldInfoPtr_radialIndicatorSetThisFrame;

		// Token: 0x0400619F RID: 24991
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040061A0 RID: 24992
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0;

		// Token: 0x040061A1 RID: 24993
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0;

		// Token: 0x040061A2 RID: 24994
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040061A3 RID: 24995
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040061A4 RID: 24996
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0;

		// Token: 0x040061A5 RID: 24997
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshFPS_Private_Void_0;

		// Token: 0x040061A6 RID: 24998
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageFPS_Private_Single_0;

		// Token: 0x040061A7 RID: 24999
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040061A8 RID: 25000
		private static readonly System.IntPtr NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0;

		// Token: 0x040061A9 RID: 25001
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0;

		// Token: 0x040061AA RID: 25002
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0;

		// Token: 0x040061AB RID: 25003
		private static readonly System.IntPtr NativeMethodInfoPtr_HideTopScreenText_Public_Void_0;

		// Token: 0x040061AC RID: 25004
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B77 RID: 2935
		[ObfuscatedName("ScheduleOne.UI.HUD+<FadeBlackOverlay>d__43")]
		public sealed class _FadeBlackOverlay_d__43 : Il2CppSystem.Object
		{
			// Token: 0x0600DCDA RID: 56538 RVA: 0x0034A264 File Offset: 0x00348464
			// Note: this type is marked as 'beforefieldinit'.
			static _FadeBlackOverlay_d__43()
			{
				Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUD>.NativeClassPtr, "<FadeBlackOverlay>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr);
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<>1__state");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<>2__current");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "visible");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<>4__this");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "fadeTime");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<startAlpha>5__2");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__endAlpha_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<endAlpha>5__3");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<i>5__4");
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100681294);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100681295);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100681296);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100681297);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100681298);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100681299);
			}

			// Token: 0x0600DCDB RID: 56539 RVA: 0x0034A3A8 File Offset: 0x003485A8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FadeBlackOverlay_d__43(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCDC RID: 56540 RVA: 0x0034A3F0 File Offset: 0x003485F0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCDD RID: 56541 RVA: 0x0034A424 File Offset: 0x00348624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262058, XrefRangeEnd = 262081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700442C RID: 17452
			// (get) Token: 0x0600DCDE RID: 56542 RVA: 0x0034A460 File Offset: 0x00348660
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DCDF RID: 56543 RVA: 0x0034A4A0 File Offset: 0x003486A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262081, XrefRangeEnd = 262086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700442D RID: 17453
			// (get) Token: 0x0600DCE0 RID: 56544 RVA: 0x0034A4D4 File Offset: 0x003486D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DCE1 RID: 56545 RVA: 0x0006B347 File Offset: 0x00069547
			public _FadeBlackOverlay_d__43(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004424 RID: 17444
			// (get) Token: 0x0600DCE2 RID: 56546 RVA: 0x0034A514 File Offset: 0x00348714
			// (set) Token: 0x0600DCE3 RID: 56547 RVA: 0x0006B350 File Offset: 0x00069550
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004425 RID: 17445
			// (get) Token: 0x0600DCE4 RID: 56548 RVA: 0x0034A53C File Offset: 0x0034873C
			// (set) Token: 0x0600DCE5 RID: 56549 RVA: 0x0006B36B File Offset: 0x0006956B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004426 RID: 17446
			// (get) Token: 0x0600DCE6 RID: 56550 RVA: 0x0034A56C File Offset: 0x0034876C
			// (set) Token: 0x0600DCE7 RID: 56551 RVA: 0x0006B38A File Offset: 0x0006958A
			public unsafe bool visible
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x17004427 RID: 17447
			// (get) Token: 0x0600DCE8 RID: 56552 RVA: 0x0034A594 File Offset: 0x00348794
			// (set) Token: 0x0600DCE9 RID: 56553 RVA: 0x0006B3A5 File Offset: 0x000695A5
			public unsafe HUD __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HUD>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004428 RID: 17448
			// (get) Token: 0x0600DCEA RID: 56554 RVA: 0x0034A5C4 File Offset: 0x003487C4
			// (set) Token: 0x0600DCEB RID: 56555 RVA: 0x0006B3C4 File Offset: 0x000695C4
			public unsafe float fadeTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x17004429 RID: 17449
			// (get) Token: 0x0600DCEC RID: 56556 RVA: 0x0034A5EC File Offset: 0x003487EC
			// (set) Token: 0x0600DCED RID: 56557 RVA: 0x0006B3DF File Offset: 0x000695DF
			public unsafe float _startAlpha_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__startAlpha_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__startAlpha_5__2)) = value;
				}
			}

			// Token: 0x1700442A RID: 17450
			// (get) Token: 0x0600DCEE RID: 56558 RVA: 0x0034A614 File Offset: 0x00348814
			// (set) Token: 0x0600DCEF RID: 56559 RVA: 0x0006B3FA File Offset: 0x000695FA
			public unsafe float _endAlpha_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__endAlpha_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__endAlpha_5__3)) = value;
				}
			}

			// Token: 0x1700442B RID: 17451
			// (get) Token: 0x0600DCF0 RID: 56560 RVA: 0x0034A63C File Offset: 0x0034883C
			// (set) Token: 0x0600DCF1 RID: 56561 RVA: 0x0006B415 File Offset: 0x00069615
			public unsafe float _i_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04009484 RID: 38020
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009485 RID: 38021
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009486 RID: 38022
			private static readonly System.IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x04009487 RID: 38023
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009488 RID: 38024
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x04009489 RID: 38025
			private static readonly System.IntPtr NativeFieldInfoPtr__startAlpha_5__2;

			// Token: 0x0400948A RID: 38026
			private static readonly System.IntPtr NativeFieldInfoPtr__endAlpha_5__3;

			// Token: 0x0400948B RID: 38027
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400948C RID: 38028
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400948D RID: 38029
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400948E RID: 38030
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400948F RID: 38031
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009490 RID: 38032
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009491 RID: 38033
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
