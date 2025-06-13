using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000690 RID: 1680
	public class MaskedObject : UIBehaviour
	{
		// Token: 0x06009505 RID: 38149 RVA: 0x00268E98 File Offset: 0x00267098
		// Note: this type is marked as 'beforefieldinit'.
		static MaskedObject()
		{
			Il2CppClassPointerStore<MaskedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "MaskedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr);
			MaskedObject.NativeFieldInfoPtr_canvasRendererToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "canvasRendererToClip");
			MaskedObject.NativeFieldInfoPtr_includeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "includeChildren");
			MaskedObject.NativeFieldInfoPtr_rootCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "rootCanvas");
			MaskedObject.NativeFieldInfoPtr_maskRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "maskRectTransform");
			MaskedObject.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "initialized");
			MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "canvasRenderersToClip");
			MaskedObject.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681887);
			MaskedObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681888);
			MaskedObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681889);
			MaskedObject.NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681890);
			MaskedObject.NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681891);
			MaskedObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681892);
		}

		// Token: 0x06009506 RID: 38150 RVA: 0x00268FB8 File Offset: 0x002671B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268809, XrefRangeEnd = 268811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009507 RID: 38151 RVA: 0x00268FF4 File Offset: 0x002671F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268811, XrefRangeEnd = 268815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009508 RID: 38152 RVA: 0x00269030 File Offset: 0x00267230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268815, XrefRangeEnd = 268833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009509 RID: 38153 RVA: 0x0026906C File Offset: 0x0026726C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268833, XrefRangeEnd = 268836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Canvas rootCanvas, RectTransform maskRectTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootCanvas);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(maskRectTransform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600950A RID: 38154 RVA: 0x002690C0 File Offset: 0x002672C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 268855, RefRangeEnd = 268859, XrefRangeStart = 268836, XrefRangeEnd = 268855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetClippingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600950B RID: 38155 RVA: 0x002690F4 File Offset: 0x002672F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268859, XrefRangeEnd = 268867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskedObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600950C RID: 38156 RVA: 0x00047DC6 File Offset: 0x00045FC6
		public MaskedObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0600950D RID: 38157 RVA: 0x00269130 File Offset: 0x00267330
		// (set) Token: 0x0600950E RID: 38158 RVA: 0x00047DCF File Offset: 0x00045FCF
		public unsafe CanvasRenderer canvasRendererToClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRendererToClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRendererToClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x0600950F RID: 38159 RVA: 0x00269160 File Offset: 0x00267360
		// (set) Token: 0x06009510 RID: 38160 RVA: 0x00047DEE File Offset: 0x00045FEE
		public unsafe bool includeChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_includeChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_includeChildren)) = value;
			}
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x06009511 RID: 38161 RVA: 0x00269188 File Offset: 0x00267388
		// (set) Token: 0x06009512 RID: 38162 RVA: 0x00047E09 File Offset: 0x00046009
		public unsafe Canvas rootCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_rootCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_rootCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x06009513 RID: 38163 RVA: 0x002691B8 File Offset: 0x002673B8
		// (set) Token: 0x06009514 RID: 38164 RVA: 0x00047E28 File Offset: 0x00046028
		public unsafe RectTransform maskRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_maskRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_maskRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x06009515 RID: 38165 RVA: 0x002691E8 File Offset: 0x002673E8
		// (set) Token: 0x06009516 RID: 38166 RVA: 0x00047E47 File Offset: 0x00046047
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x06009517 RID: 38167 RVA: 0x00269210 File Offset: 0x00267410
		// (set) Token: 0x06009518 RID: 38168 RVA: 0x00047E62 File Offset: 0x00046062
		public unsafe List<CanvasRenderer> canvasRenderersToClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064B0 RID: 25776
		private static readonly IntPtr NativeFieldInfoPtr_canvasRendererToClip;

		// Token: 0x040064B1 RID: 25777
		private static readonly IntPtr NativeFieldInfoPtr_includeChildren;

		// Token: 0x040064B2 RID: 25778
		private static readonly IntPtr NativeFieldInfoPtr_rootCanvas;

		// Token: 0x040064B3 RID: 25779
		private static readonly IntPtr NativeFieldInfoPtr_maskRectTransform;

		// Token: 0x040064B4 RID: 25780
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x040064B5 RID: 25781
		private static readonly IntPtr NativeFieldInfoPtr_canvasRenderersToClip;

		// Token: 0x040064B6 RID: 25782
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040064B7 RID: 25783
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040064B8 RID: 25784
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040064B9 RID: 25785
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0;

		// Token: 0x040064BA RID: 25786
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0;

		// Token: 0x040064BB RID: 25787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
