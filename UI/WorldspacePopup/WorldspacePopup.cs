using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x0200069A RID: 1690
	public class WorldspacePopup : MonoBehaviour
	{
		// Token: 0x060095E5 RID: 38373 RVA: 0x0026B60C File Offset: 0x0026980C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopup()
		{
			Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr);
			WorldspacePopup.NativeFieldInfoPtr_ActivePopups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "ActivePopups");
			WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "CurrentFillLevel");
			WorldspacePopup.NativeFieldInfoPtr_UIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "UIPrefab");
			WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "DisplayOnHUD");
			WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "ScaleWithDistance");
			WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "WorldspaceOffset");
			WorldspacePopup.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "Range");
			WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "SizeMultiplier");
			WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "WorldspaceUI");
			WorldspacePopup.NativeFieldInfoPtr_HUDUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUI");
			WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUIIcon");
			WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUICanvasGroup");
			WorldspacePopup.NativeFieldInfoPtr_UIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "UIs");
			WorldspacePopup.NativeFieldInfoPtr_popupCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "popupCoroutine");
			WorldspacePopup.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681976);
			WorldspacePopup.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681977);
			WorldspacePopup.NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681978);
			WorldspacePopup.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681979);
			WorldspacePopup.NativeMethodInfoPtr_Popup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681980);
			WorldspacePopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681981);
			WorldspacePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681983);
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x0026B7E0 File Offset: 0x002699E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269554, XrefRangeEnd = 269567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095E7 RID: 38375 RVA: 0x0026B814 File Offset: 0x00269A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269567, XrefRangeEnd = 269575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095E8 RID: 38376 RVA: 0x0026B848 File Offset: 0x00269A48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269601, RefRangeEnd = 269604, XrefRangeStart = 269575, XrefRangeEnd = 269601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI CreateUI(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
		}

		// Token: 0x060095E9 RID: 38377 RVA: 0x0026B898 File Offset: 0x00269A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269604, XrefRangeEnd = 269619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x0026B8CC File Offset: 0x00269ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269627, RefRangeEnd = 269628, XrefRangeStart = 269619, XrefRangeEnd = 269627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Popup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_Popup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x0026B900 File Offset: 0x00269B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269628, XrefRangeEnd = 269636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x0026B93C File Offset: 0x00269B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269636, XrefRangeEnd = 269641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x0004860C File Offset: 0x0004680C
		public WorldspacePopup(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x060095EE RID: 38382 RVA: 0x0026B97C File Offset: 0x00269B7C
		// (set) Token: 0x060095EF RID: 38383 RVA: 0x00048615 File Offset: 0x00046815
		public unsafe static List<WorldspacePopup> ActivePopups
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopup.NativeFieldInfoPtr_ActivePopups, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopup>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopup.NativeFieldInfoPtr_ActivePopups, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x060095F0 RID: 38384 RVA: 0x0026B9A4 File Offset: 0x00269BA4
		// (set) Token: 0x060095F1 RID: 38385 RVA: 0x00048627 File Offset: 0x00046827
		public unsafe float CurrentFillLevel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel)) = value;
			}
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x060095F2 RID: 38386 RVA: 0x0026B9CC File Offset: 0x00269BCC
		// (set) Token: 0x060095F3 RID: 38387 RVA: 0x00048642 File Offset: 0x00046842
		public unsafe WorldspacePopupUI UIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x060095F4 RID: 38388 RVA: 0x0026B9FC File Offset: 0x00269BFC
		// (set) Token: 0x060095F5 RID: 38389 RVA: 0x00048661 File Offset: 0x00046861
		public unsafe bool DisplayOnHUD
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD)) = value;
			}
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x060095F6 RID: 38390 RVA: 0x0026BA24 File Offset: 0x00269C24
		// (set) Token: 0x060095F7 RID: 38391 RVA: 0x0004867C File Offset: 0x0004687C
		public unsafe bool ScaleWithDistance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance)) = value;
			}
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x060095F8 RID: 38392 RVA: 0x0026BA4C File Offset: 0x00269C4C
		// (set) Token: 0x060095F9 RID: 38393 RVA: 0x00048697 File Offset: 0x00046897
		public unsafe Vector3 WorldspaceOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset)) = value;
			}
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x060095FA RID: 38394 RVA: 0x0026BA74 File Offset: 0x00269C74
		// (set) Token: 0x060095FB RID: 38395 RVA: 0x000486B2 File Offset: 0x000468B2
		public unsafe float Range
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x060095FC RID: 38396 RVA: 0x0026BA9C File Offset: 0x00269C9C
		// (set) Token: 0x060095FD RID: 38397 RVA: 0x000486CD File Offset: 0x000468CD
		public unsafe float SizeMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier)) = value;
			}
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x060095FE RID: 38398 RVA: 0x0026BAC4 File Offset: 0x00269CC4
		// (set) Token: 0x060095FF RID: 38399 RVA: 0x000486E8 File Offset: 0x000468E8
		public unsafe WorldspacePopupUI WorldspaceUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x06009600 RID: 38400 RVA: 0x0026BAF4 File Offset: 0x00269CF4
		// (set) Token: 0x06009601 RID: 38401 RVA: 0x00048707 File Offset: 0x00046907
		public unsafe RectTransform HUDUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x06009602 RID: 38402 RVA: 0x0026BB24 File Offset: 0x00269D24
		// (set) Token: 0x06009603 RID: 38403 RVA: 0x00048726 File Offset: 0x00046926
		public unsafe WorldspacePopupUI HUDUIIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x06009604 RID: 38404 RVA: 0x0026BB54 File Offset: 0x00269D54
		// (set) Token: 0x06009605 RID: 38405 RVA: 0x00048745 File Offset: 0x00046945
		public unsafe CanvasGroup HUDUICanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x06009606 RID: 38406 RVA: 0x0026BB84 File Offset: 0x00269D84
		// (set) Token: 0x06009607 RID: 38407 RVA: 0x00048764 File Offset: 0x00046964
		public unsafe List<WorldspacePopupUI> UIs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopupUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x06009608 RID: 38408 RVA: 0x0026BBB4 File Offset: 0x00269DB4
		// (set) Token: 0x06009609 RID: 38409 RVA: 0x00048783 File Offset: 0x00046983
		public unsafe Coroutine popupCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_popupCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_popupCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006536 RID: 25910
		private static readonly System.IntPtr NativeFieldInfoPtr_ActivePopups;

		// Token: 0x04006537 RID: 25911
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFillLevel;

		// Token: 0x04006538 RID: 25912
		private static readonly System.IntPtr NativeFieldInfoPtr_UIPrefab;

		// Token: 0x04006539 RID: 25913
		private static readonly System.IntPtr NativeFieldInfoPtr_DisplayOnHUD;

		// Token: 0x0400653A RID: 25914
		private static readonly System.IntPtr NativeFieldInfoPtr_ScaleWithDistance;

		// Token: 0x0400653B RID: 25915
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceOffset;

		// Token: 0x0400653C RID: 25916
		private static readonly System.IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x0400653D RID: 25917
		private static readonly System.IntPtr NativeFieldInfoPtr_SizeMultiplier;

		// Token: 0x0400653E RID: 25918
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceUI;

		// Token: 0x0400653F RID: 25919
		private static readonly System.IntPtr NativeFieldInfoPtr_HUDUI;

		// Token: 0x04006540 RID: 25920
		private static readonly System.IntPtr NativeFieldInfoPtr_HUDUIIcon;

		// Token: 0x04006541 RID: 25921
		private static readonly System.IntPtr NativeFieldInfoPtr_HUDUICanvasGroup;

		// Token: 0x04006542 RID: 25922
		private static readonly System.IntPtr NativeFieldInfoPtr_UIs;

		// Token: 0x04006543 RID: 25923
		private static readonly System.IntPtr NativeFieldInfoPtr_popupCoroutine;

		// Token: 0x04006544 RID: 25924
		private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04006545 RID: 25925
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04006546 RID: 25926
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0;

		// Token: 0x04006547 RID: 25927
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006548 RID: 25928
		private static readonly System.IntPtr NativeMethodInfoPtr_Popup_Public_Void_0;

		// Token: 0x04006549 RID: 25929
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400654A RID: 25930
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BA5 RID: 2981
		[ObfuscatedName("ScheduleOne.UI.WorldspacePopup.WorldspacePopup+<<Popup>g__PopupCoroutine|18_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DF17 RID: 57111 RVA: 0x00350B6C File Offset: 0x0034ED6C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique()
			{
				Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "<<Popup>g__PopupCoroutine|18_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681984);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681985);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681986);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681987);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681988);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681989);
			}

			// Token: 0x0600DF18 RID: 57112 RVA: 0x00350C74 File Offset: 0x0034EE74
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF19 RID: 57113 RVA: 0x00350CBC File Offset: 0x0034EEBC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF1A RID: 57114 RVA: 0x00350CF0 File Offset: 0x0034EEF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269541, XrefRangeEnd = 269545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170044ED RID: 17645
			// (get) Token: 0x0600DF1B RID: 57115 RVA: 0x00350D2C File Offset: 0x0034EF2C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DF1C RID: 57116 RVA: 0x00350D6C File Offset: 0x0034EF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269545, XrefRangeEnd = 269550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170044EE RID: 17646
			// (get) Token: 0x0600DF1D RID: 57117 RVA: 0x00350DA0 File Offset: 0x0034EFA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DF1E RID: 57118 RVA: 0x0006C534 File Offset: 0x0006A734
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E8 RID: 17640
			// (get) Token: 0x0600DF1F RID: 57119 RVA: 0x00350DE0 File Offset: 0x0034EFE0
			// (set) Token: 0x0600DF20 RID: 57120 RVA: 0x0006C53D File Offset: 0x0006A73D
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044E9 RID: 17641
			// (get) Token: 0x0600DF21 RID: 57121 RVA: 0x00350E08 File Offset: 0x0034F008
			// (set) Token: 0x0600DF22 RID: 57122 RVA: 0x0006C558 File Offset: 0x0006A758
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EA RID: 17642
			// (get) Token: 0x0600DF23 RID: 57123 RVA: 0x00350E38 File Offset: 0x0034F038
			// (set) Token: 0x0600DF24 RID: 57124 RVA: 0x0006C577 File Offset: 0x0006A777
			public unsafe WorldspacePopup __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EB RID: 17643
			// (get) Token: 0x0600DF25 RID: 57125 RVA: 0x00350E68 File Offset: 0x0034F068
			// (set) Token: 0x0600DF26 RID: 57126 RVA: 0x0006C596 File Offset: 0x0006A796
			public unsafe float _lerpTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x170044EC RID: 17644
			// (get) Token: 0x0600DF27 RID: 57127 RVA: 0x00350E90 File Offset: 0x0034F090
			// (set) Token: 0x0600DF28 RID: 57128 RVA: 0x0006C5B1 File Offset: 0x0006A7B1
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040095E4 RID: 38372
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095E5 RID: 38373
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095E6 RID: 38374
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095E7 RID: 38375
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x040095E8 RID: 38376
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040095E9 RID: 38377
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095EA RID: 38378
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095EB RID: 38379
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095EC RID: 38380
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095ED RID: 38381
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095EE RID: 38382
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA6 RID: 2982
		[ObfuscatedName("ScheduleOne.UI.WorldspacePopup.WorldspacePopup+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF29 RID: 57129 RVA: 0x00350EB8 File Offset: 0x0034F0B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr);
				WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, "newUI");
				WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, 100681990);
				WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, 100681991);
			}

			// Token: 0x0600DF2A RID: 57130 RVA: 0x00350F34 File Offset: 0x0034F134
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF2B RID: 57131 RVA: 0x00350F70 File Offset: 0x0034F170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269550, XrefRangeEnd = 269554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF2C RID: 57132 RVA: 0x0006C5CC File Offset: 0x0006A7CC
			public __c__DisplayClass16_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044EF RID: 17647
			// (get) Token: 0x0600DF2D RID: 57133 RVA: 0x00350FA4 File Offset: 0x0034F1A4
			// (set) Token: 0x0600DF2E RID: 57134 RVA: 0x0006C5D5 File Offset: 0x0006A7D5
			public unsafe WorldspacePopup __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F0 RID: 17648
			// (get) Token: 0x0600DF2F RID: 57135 RVA: 0x00350FD4 File Offset: 0x0034F1D4
			// (set) Token: 0x0600DF30 RID: 57136 RVA: 0x0006C5F4 File Offset: 0x0006A7F4
			public unsafe WorldspacePopupUI newUI
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095EF RID: 38383
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095F0 RID: 38384
			private static readonly System.IntPtr NativeFieldInfoPtr_newUI;

			// Token: 0x040095F1 RID: 38385
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095F2 RID: 38386
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0;
		}
	}
}
