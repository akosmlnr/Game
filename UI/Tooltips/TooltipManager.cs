using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Tooltips
{
	// Token: 0x0200069E RID: 1694
	public class TooltipManager : Singleton<TooltipManager>
	{
		// Token: 0x06009640 RID: 38464 RVA: 0x0026C5C4 File Offset: 0x0026A7C4
		// Note: this type is marked as 'beforefieldinit'.
		static TooltipManager()
		{
			Il2CppClassPointerStore<TooltipManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Tooltips", "TooltipManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr);
			TooltipManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "Canvas");
			TooltipManager.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "anchor");
			TooltipManager.NativeFieldInfoPtr_tooltipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "tooltipLabel");
			TooltipManager.NativeFieldInfoPtr_canvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "canvases");
			TooltipManager.NativeFieldInfoPtr_sortedCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "sortedCanvases");
			TooltipManager.NativeFieldInfoPtr_raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "raycasters");
			TooltipManager.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "eventSystem");
			TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "tooltipShownThisFrame");
			TooltipManager.NativeFieldInfoPtr_pointerEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "pointerEventData");
			TooltipManager.NativeFieldInfoPtr_rayResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "rayResults");
			TooltipManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100682008);
			TooltipManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100682009);
			TooltipManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100682010);
			TooltipManager.NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100682011);
			TooltipManager.NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100682012);
			TooltipManager.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100682013);
			TooltipManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100682014);
		}

		// Token: 0x06009641 RID: 38465 RVA: 0x0026C748 File Offset: 0x0026A948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270031, XrefRangeEnd = 270114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x0026C784 File Offset: 0x0026A984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270114, XrefRangeEnd = 270115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x0026C7C0 File Offset: 0x0026A9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270115, XrefRangeEnd = 270117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x0026C7FC File Offset: 0x0026A9FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270192, RefRangeEnd = 270193, XrefRangeStart = 270117, XrefRangeEnd = 270192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCanvas(Canvas canvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x0026C840 File Offset: 0x0026AA40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270233, RefRangeEnd = 270234, XrefRangeStart = 270193, XrefRangeEnd = 270233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForTooltipHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x0026C874 File Offset: 0x0026AA74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270282, RefRangeEnd = 270283, XrefRangeStart = 270234, XrefRangeEnd = 270282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTooltip(string text, Vector2 position, bool worldspace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref worldspace;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009647 RID: 38471 RVA: 0x0026C8D4 File Offset: 0x0026AAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270283, XrefRangeEnd = 270312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TooltipManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x00048994 File Offset: 0x00046B94
		public TooltipManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x06009649 RID: 38473 RVA: 0x0026C910 File Offset: 0x0026AB10
		// (set) Token: 0x0600964A RID: 38474 RVA: 0x0004899D File Offset: 0x00046B9D
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0600964B RID: 38475 RVA: 0x0026C940 File Offset: 0x0026AB40
		// (set) Token: 0x0600964C RID: 38476 RVA: 0x000489BC File Offset: 0x00046BBC
		public unsafe RectTransform anchor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_anchor);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0600964D RID: 38477 RVA: 0x0026C970 File Offset: 0x0026AB70
		// (set) Token: 0x0600964E RID: 38478 RVA: 0x000489DB File Offset: 0x00046BDB
		public unsafe TextMeshProUGUI tooltipLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0600964F RID: 38479 RVA: 0x0026C9A0 File Offset: 0x0026ABA0
		// (set) Token: 0x06009650 RID: 38480 RVA: 0x000489FA File Offset: 0x00046BFA
		public unsafe List<Canvas> canvases
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_canvases);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Canvas>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_canvases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x06009651 RID: 38481 RVA: 0x0026C9D0 File Offset: 0x0026ABD0
		// (set) Token: 0x06009652 RID: 38482 RVA: 0x00048A19 File Offset: 0x00046C19
		public unsafe List<Canvas> sortedCanvases
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_sortedCanvases);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Canvas>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_sortedCanvases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x06009653 RID: 38483 RVA: 0x0026CA00 File Offset: 0x0026AC00
		// (set) Token: 0x06009654 RID: 38484 RVA: 0x00048A38 File Offset: 0x00046C38
		public unsafe List<GraphicRaycaster> raycasters
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_raycasters);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GraphicRaycaster>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_raycasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x06009655 RID: 38485 RVA: 0x0026CA30 File Offset: 0x0026AC30
		// (set) Token: 0x06009656 RID: 38486 RVA: 0x00048A57 File Offset: 0x00046C57
		public unsafe EventSystem eventSystem
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_eventSystem);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x06009657 RID: 38487 RVA: 0x0026CA60 File Offset: 0x0026AC60
		// (set) Token: 0x06009658 RID: 38488 RVA: 0x00048A76 File Offset: 0x00046C76
		public unsafe bool tooltipShownThisFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame)) = value;
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x06009659 RID: 38489 RVA: 0x0026CA88 File Offset: 0x0026AC88
		// (set) Token: 0x0600965A RID: 38490 RVA: 0x00048A91 File Offset: 0x00046C91
		public unsafe PointerEventData pointerEventData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_pointerEventData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_pointerEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x0600965B RID: 38491 RVA: 0x0026CAB8 File Offset: 0x0026ACB8
		// (set) Token: 0x0600965C RID: 38492 RVA: 0x00048AB0 File Offset: 0x00046CB0
		public unsafe List<RaycastResult> rayResults
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_rayResults);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_rayResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400656B RID: 25963
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400656C RID: 25964
		private static readonly System.IntPtr NativeFieldInfoPtr_anchor;

		// Token: 0x0400656D RID: 25965
		private static readonly System.IntPtr NativeFieldInfoPtr_tooltipLabel;

		// Token: 0x0400656E RID: 25966
		private static readonly System.IntPtr NativeFieldInfoPtr_canvases;

		// Token: 0x0400656F RID: 25967
		private static readonly System.IntPtr NativeFieldInfoPtr_sortedCanvases;

		// Token: 0x04006570 RID: 25968
		private static readonly System.IntPtr NativeFieldInfoPtr_raycasters;

		// Token: 0x04006571 RID: 25969
		private static readonly System.IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04006572 RID: 25970
		private static readonly System.IntPtr NativeFieldInfoPtr_tooltipShownThisFrame;

		// Token: 0x04006573 RID: 25971
		private static readonly System.IntPtr NativeFieldInfoPtr_pointerEventData;

		// Token: 0x04006574 RID: 25972
		private static readonly System.IntPtr NativeFieldInfoPtr_rayResults;

		// Token: 0x04006575 RID: 25973
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006576 RID: 25974
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006577 RID: 25975
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04006578 RID: 25976
		private static readonly System.IntPtr NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0;

		// Token: 0x04006579 RID: 25977
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0;

		// Token: 0x0400657A RID: 25978
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_0;

		// Token: 0x0400657B RID: 25979
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA7 RID: 2983
		[ObfuscatedName("ScheduleOne.UI.Tooltips.TooltipManager+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DF31 RID: 57137 RVA: 0x00351004 File Offset: 0x0034F204
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr);
				TooltipManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9");
				TooltipManager.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__10_0");
				TooltipManager.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__10_1");
				TooltipManager.__c.NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__10_2");
				TooltipManager.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__13_0");
				TooltipManager.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__13_1");
				TooltipManager.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__13_2");
				TooltipManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100682016);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__10_0_Internal_Boolean_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100682017);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__10_1_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100682018);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__10_2_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100682019);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__13_0_Internal_Boolean_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100682020);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__13_1_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100682021);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__13_2_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100682022);
			}

			// Token: 0x0600DF32 RID: 57138 RVA: 0x00351148 File Offset: 0x0034F348
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF33 RID: 57139 RVA: 0x00351184 File Offset: 0x0034F384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270013, XrefRangeEnd = 270021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__10_0(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__10_0_Internal_Boolean_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF34 RID: 57140 RVA: 0x003511D4 File Offset: 0x0034F3D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270021, XrefRangeEnd = 270023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Awake_b__10_1(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__10_1_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF35 RID: 57141 RVA: 0x00351224 File Offset: 0x0034F424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270023, XrefRangeEnd = 270026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Awake_b__10_2(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__10_2_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF36 RID: 57142 RVA: 0x00351274 File Offset: 0x0034F474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270026, XrefRangeEnd = 270031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCanvas_b__13_0(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__13_0_Internal_Boolean_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF37 RID: 57143 RVA: 0x003512C4 File Offset: 0x0034F4C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddCanvas_b__13_1(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__13_1_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF38 RID: 57144 RVA: 0x00351314 File Offset: 0x0034F514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddCanvas_b__13_2(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__13_2_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF39 RID: 57145 RVA: 0x0006C613 File Offset: 0x0006A813
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F1 RID: 17649
			// (get) Token: 0x0600DF3A RID: 57146 RVA: 0x00351364 File Offset: 0x0034F564
			// (set) Token: 0x0600DF3B RID: 57147 RVA: 0x0006C61C File Offset: 0x0006A81C
			public unsafe static TooltipManager.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TooltipManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F2 RID: 17650
			// (get) Token: 0x0600DF3C RID: 57148 RVA: 0x0035138C File Offset: 0x0034F58C
			// (set) Token: 0x0600DF3D RID: 57149 RVA: 0x0006C62E File Offset: 0x0006A82E
			public unsafe static Il2CppSystem.Func<Canvas, bool> __9__10_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Canvas, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F3 RID: 17651
			// (get) Token: 0x0600DF3E RID: 57150 RVA: 0x003513B4 File Offset: 0x0034F5B4
			// (set) Token: 0x0600DF3F RID: 57151 RVA: 0x0006C640 File Offset: 0x0006A840
			public unsafe static Il2CppSystem.Func<Canvas, int> __9__10_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F4 RID: 17652
			// (get) Token: 0x0600DF40 RID: 57152 RVA: 0x003513DC File Offset: 0x0034F5DC
			// (set) Token: 0x0600DF41 RID: 57153 RVA: 0x0006C652 File Offset: 0x0006A852
			public unsafe static Il2CppSystem.Func<Canvas, int> __9__10_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F5 RID: 17653
			// (get) Token: 0x0600DF42 RID: 57154 RVA: 0x00351404 File Offset: 0x0034F604
			// (set) Token: 0x0600DF43 RID: 57155 RVA: 0x0006C664 File Offset: 0x0006A864
			public unsafe static Il2CppSystem.Func<Canvas, bool> __9__13_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Canvas, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F6 RID: 17654
			// (get) Token: 0x0600DF44 RID: 57156 RVA: 0x0035142C File Offset: 0x0034F62C
			// (set) Token: 0x0600DF45 RID: 57157 RVA: 0x0006C676 File Offset: 0x0006A876
			public unsafe static Il2CppSystem.Func<Canvas, int> __9__13_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F7 RID: 17655
			// (get) Token: 0x0600DF46 RID: 57158 RVA: 0x00351454 File Offset: 0x0034F654
			// (set) Token: 0x0600DF47 RID: 57159 RVA: 0x0006C688 File Offset: 0x0006A888
			public unsafe static Il2CppSystem.Func<Canvas, int> __9__13_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095F3 RID: 38387
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040095F4 RID: 38388
			private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040095F5 RID: 38389
			private static readonly System.IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x040095F6 RID: 38390
			private static readonly System.IntPtr NativeFieldInfoPtr___9__10_2;

			// Token: 0x040095F7 RID: 38391
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040095F8 RID: 38392
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x040095F9 RID: 38393
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x040095FA RID: 38394
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095FB RID: 38395
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__10_0_Internal_Boolean_Canvas_0;

			// Token: 0x040095FC RID: 38396
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__10_1_Internal_Int32_Canvas_0;

			// Token: 0x040095FD RID: 38397
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__10_2_Internal_Int32_Canvas_0;

			// Token: 0x040095FE RID: 38398
			private static readonly System.IntPtr NativeMethodInfoPtr__AddCanvas_b__13_0_Internal_Boolean_Canvas_0;

			// Token: 0x040095FF RID: 38399
			private static readonly System.IntPtr NativeMethodInfoPtr__AddCanvas_b__13_1_Internal_Int32_Canvas_0;

			// Token: 0x04009600 RID: 38400
			private static readonly System.IntPtr NativeMethodInfoPtr__AddCanvas_b__13_2_Internal_Int32_Canvas_0;
		}
	}
}
