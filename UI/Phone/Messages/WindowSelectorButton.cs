using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006D9 RID: 1753
	public class WindowSelectorButton : MonoBehaviour
	{
		// Token: 0x06009D10 RID: 40208 RVA: 0x00280C10 File Offset: 0x0027EE10
		// Note: this type is marked as 'beforefieldinit'.
		static WindowSelectorButton()
		{
			Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "WindowSelectorButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr);
			WindowSelectorButton.NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "SELECTION_INDICATOR_SCALE");
			WindowSelectorButton.NativeFieldInfoPtr_INDICATOR_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "INDICATOR_LERP_TIME");
			WindowSelectorButton.NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "OnSelected");
			WindowSelectorButton.NativeFieldInfoPtr_WindowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "WindowType");
			WindowSelectorButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "Button");
			WindowSelectorButton.NativeFieldInfoPtr_InactiveOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "InactiveOverlay");
			WindowSelectorButton.NativeFieldInfoPtr_HoverIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "HoverIndicator");
			WindowSelectorButton.NativeFieldInfoPtr_hoverRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "hoverRoutine");
			WindowSelectorButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682715);
			WindowSelectorButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682716);
			WindowSelectorButton.NativeMethodInfoPtr_HoverStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682717);
			WindowSelectorButton.NativeMethodInfoPtr_HoverEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682718);
			WindowSelectorButton.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682719);
			WindowSelectorButton.NativeMethodInfoPtr_SetHoverIndicator_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682720);
			WindowSelectorButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682721);
		}

		// Token: 0x06009D11 RID: 40209 RVA: 0x00280D6C File Offset: 0x0027EF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279185, XrefRangeEnd = 279198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D12 RID: 40210 RVA: 0x00280DA0 File Offset: 0x0027EFA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279201, RefRangeEnd = 279202, XrefRangeStart = 279198, XrefRangeEnd = 279201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref interactable;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D13 RID: 40211 RVA: 0x00280DE0 File Offset: 0x0027EFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279202, XrefRangeEnd = 279203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_HoverStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D14 RID: 40212 RVA: 0x00280E14 File Offset: 0x0027F014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279203, XrefRangeEnd = 279204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_HoverEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D15 RID: 40213 RVA: 0x00280E48 File Offset: 0x0027F048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D16 RID: 40214 RVA: 0x00280E7C File Offset: 0x0027F07C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 279222, RefRangeEnd = 279229, XrefRangeStart = 279204, XrefRangeEnd = 279222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverIndicator(bool shown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref shown;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_SetHoverIndicator_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D17 RID: 40215 RVA: 0x00280EBC File Offset: 0x0027F0BC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowSelectorButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D18 RID: 40216 RVA: 0x0004C8FF File Offset: 0x0004AAFF
		public WindowSelectorButton(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x06009D19 RID: 40217 RVA: 0x00280EF8 File Offset: 0x0027F0F8
		// (set) Token: 0x06009D1A RID: 40218 RVA: 0x0004C908 File Offset: 0x0004AB08
		public unsafe static float SELECTION_INDICATOR_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WindowSelectorButton.NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WindowSelectorButton.NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE, (void*)(&value));
			}
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x06009D1B RID: 40219 RVA: 0x00280F14 File Offset: 0x0027F114
		// (set) Token: 0x06009D1C RID: 40220 RVA: 0x0004C916 File Offset: 0x0004AB16
		public unsafe static float INDICATOR_LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WindowSelectorButton.NativeFieldInfoPtr_INDICATOR_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WindowSelectorButton.NativeFieldInfoPtr_INDICATOR_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x06009D1D RID: 40221 RVA: 0x00280F30 File Offset: 0x0027F130
		// (set) Token: 0x06009D1E RID: 40222 RVA: 0x0004C924 File Offset: 0x0004AB24
		public unsafe UnityEvent OnSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_OnSelected);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_OnSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x06009D1F RID: 40223 RVA: 0x00280F60 File Offset: 0x0027F160
		// (set) Token: 0x06009D20 RID: 40224 RVA: 0x0004C943 File Offset: 0x0004AB43
		public unsafe EDealWindow WindowType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_WindowType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_WindowType)) = value;
			}
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x06009D21 RID: 40225 RVA: 0x00280F88 File Offset: 0x0027F188
		// (set) Token: 0x06009D22 RID: 40226 RVA: 0x0004C95E File Offset: 0x0004AB5E
		public unsafe Button Button
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_Button);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x06009D23 RID: 40227 RVA: 0x00280FB8 File Offset: 0x0027F1B8
		// (set) Token: 0x06009D24 RID: 40228 RVA: 0x0004C97D File Offset: 0x0004AB7D
		public unsafe GameObject InactiveOverlay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_InactiveOverlay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_InactiveOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x06009D25 RID: 40229 RVA: 0x00280FE8 File Offset: 0x0027F1E8
		// (set) Token: 0x06009D26 RID: 40230 RVA: 0x0004C99C File Offset: 0x0004AB9C
		public unsafe RectTransform HoverIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_HoverIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_HoverIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x06009D27 RID: 40231 RVA: 0x00281018 File Offset: 0x0027F218
		// (set) Token: 0x06009D28 RID: 40232 RVA: 0x0004C9BB File Offset: 0x0004ABBB
		public unsafe Coroutine hoverRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_hoverRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_hoverRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069AB RID: 27051
		private static readonly System.IntPtr NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE;

		// Token: 0x040069AC RID: 27052
		private static readonly System.IntPtr NativeFieldInfoPtr_INDICATOR_LERP_TIME;

		// Token: 0x040069AD RID: 27053
		private static readonly System.IntPtr NativeFieldInfoPtr_OnSelected;

		// Token: 0x040069AE RID: 27054
		private static readonly System.IntPtr NativeFieldInfoPtr_WindowType;

		// Token: 0x040069AF RID: 27055
		private static readonly System.IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040069B0 RID: 27056
		private static readonly System.IntPtr NativeFieldInfoPtr_InactiveOverlay;

		// Token: 0x040069B1 RID: 27057
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverIndicator;

		// Token: 0x040069B2 RID: 27058
		private static readonly System.IntPtr NativeFieldInfoPtr_hoverRoutine;

		// Token: 0x040069B3 RID: 27059
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040069B4 RID: 27060
		private static readonly System.IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040069B5 RID: 27061
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverStart_Public_Void_0;

		// Token: 0x040069B6 RID: 27062
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverEnd_Public_Void_0;

		// Token: 0x040069B7 RID: 27063
		private static readonly System.IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040069B8 RID: 27064
		private static readonly System.IntPtr NativeMethodInfoPtr_SetHoverIndicator_Public_Void_Boolean_0;

		// Token: 0x040069B9 RID: 27065
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BD3 RID: 3027
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.WindowSelectorButton+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E0B7 RID: 57527 RVA: 0x003554A0 File Offset: 0x003536A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr);
				WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr_shown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, "shown");
				WindowSelectorButton.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, 100682722);
				WindowSelectorButton.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, 100682723);
			}

			// Token: 0x0600E0B8 RID: 57528 RVA: 0x0035551C File Offset: 0x0035371C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0B9 RID: 57529 RVA: 0x00355558 File Offset: 0x00353758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279180, XrefRangeEnd = 279185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E0BA RID: 57530 RVA: 0x0006D201 File Offset: 0x0006B401
			public __c__DisplayClass13_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455F RID: 17759
			// (get) Token: 0x0600E0BB RID: 57531 RVA: 0x00355598 File Offset: 0x00353798
			// (set) Token: 0x0600E0BC RID: 57532 RVA: 0x0006D20A File Offset: 0x0006B40A
			public unsafe WindowSelectorButton __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004560 RID: 17760
			// (get) Token: 0x0600E0BD RID: 57533 RVA: 0x003555C8 File Offset: 0x003537C8
			// (set) Token: 0x0600E0BE RID: 57534 RVA: 0x0006D229 File Offset: 0x0006B429
			public unsafe bool shown
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr_shown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr_shown)) = value;
				}
			}

			// Token: 0x040096CD RID: 38605
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096CE RID: 38606
			private static readonly System.IntPtr NativeFieldInfoPtr_shown;

			// Token: 0x040096CF RID: 38607
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096D0 RID: 38608
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CDB RID: 3291
			[ObfuscatedName("ScheduleOne.UI.Phone.Messages.WindowSelectorButton+<>c__DisplayClass13_0+<<SetHoverIndicator>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EBEE RID: 60398 RVA: 0x00375904 File Offset: 0x00373B04
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, "<<SetHoverIndicator>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startScale>5__2");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__targetScale_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<targetScale>5__3");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682724);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682725);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682726);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682727);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682728);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682729);
				}

				// Token: 0x0600EBEF RID: 60399 RVA: 0x00375A20 File Offset: 0x00373C20
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBF0 RID: 60400 RVA: 0x00375A68 File Offset: 0x00373C68
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBF1 RID: 60401 RVA: 0x00375A9C File Offset: 0x00373C9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279153, XrefRangeEnd = 279175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004921 RID: 18721
				// (get) Token: 0x0600EBF2 RID: 60402 RVA: 0x00375AD8 File Offset: 0x00373CD8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBF3 RID: 60403 RVA: 0x00375B18 File Offset: 0x00373D18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279175, XrefRangeEnd = 279180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004922 RID: 18722
				// (get) Token: 0x0600EBF4 RID: 60404 RVA: 0x00375B4C File Offset: 0x00373D4C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBF5 RID: 60405 RVA: 0x00072D28 File Offset: 0x00070F28
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700491B RID: 18715
				// (get) Token: 0x0600EBF6 RID: 60406 RVA: 0x00375B8C File Offset: 0x00373D8C
				// (set) Token: 0x0600EBF7 RID: 60407 RVA: 0x00072D31 File Offset: 0x00070F31
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700491C RID: 18716
				// (get) Token: 0x0600EBF8 RID: 60408 RVA: 0x00375BB4 File Offset: 0x00373DB4
				// (set) Token: 0x0600EBF9 RID: 60409 RVA: 0x00072D4C File Offset: 0x00070F4C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700491D RID: 18717
				// (get) Token: 0x0600EBFA RID: 60410 RVA: 0x00375BE4 File Offset: 0x00373DE4
				// (set) Token: 0x0600EBFB RID: 60411 RVA: 0x00072D6B File Offset: 0x00070F6B
				public unsafe WindowSelectorButton.__c__DisplayClass13_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700491E RID: 18718
				// (get) Token: 0x0600EBFC RID: 60412 RVA: 0x00375C14 File Offset: 0x00373E14
				// (set) Token: 0x0600EBFD RID: 60413 RVA: 0x00072D8A File Offset: 0x00070F8A
				public unsafe float _startScale_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
					}
				}

				// Token: 0x1700491F RID: 18719
				// (get) Token: 0x0600EBFE RID: 60414 RVA: 0x00375C3C File Offset: 0x00373E3C
				// (set) Token: 0x0600EBFF RID: 60415 RVA: 0x00072DA5 File Offset: 0x00070FA5
				public unsafe float _targetScale_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__targetScale_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__targetScale_5__3)) = value;
					}
				}

				// Token: 0x17004920 RID: 18720
				// (get) Token: 0x0600EC00 RID: 60416 RVA: 0x00375C64 File Offset: 0x00373E64
				// (set) Token: 0x0600EC01 RID: 60417 RVA: 0x00072DC0 File Offset: 0x00070FC0
				public unsafe float _i_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009DBF RID: 40383
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009DC0 RID: 40384
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009DC1 RID: 40385
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009DC2 RID: 40386
				private static readonly System.IntPtr NativeFieldInfoPtr__startScale_5__2;

				// Token: 0x04009DC3 RID: 40387
				private static readonly System.IntPtr NativeFieldInfoPtr__targetScale_5__3;

				// Token: 0x04009DC4 RID: 40388
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009DC5 RID: 40389
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009DC6 RID: 40390
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DC7 RID: 40391
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009DC8 RID: 40392
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009DC9 RID: 40393
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DCA RID: 40394
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
