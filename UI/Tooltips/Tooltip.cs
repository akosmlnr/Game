using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Tooltips
{
	// Token: 0x0200069D RID: 1693
	public class Tooltip : MonoBehaviour
	{
		// Token: 0x0600962F RID: 38447 RVA: 0x0026C2C4 File Offset: 0x0026A4C4
		// Note: this type is marked as 'beforefieldinit'.
		static Tooltip()
		{
			Il2CppClassPointerStore<Tooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Tooltips", "Tooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tooltip>.NativeClassPtr);
			Tooltip.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "text");
			Tooltip.NativeFieldInfoPtr_labelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "labelOffset");
			Tooltip.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "rect");
			Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "<isWorldspace>k__BackingField");
			Tooltip.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "canvas");
			Tooltip.NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100682003);
			Tooltip.NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100682004);
			Tooltip.NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100682005);
			Tooltip.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100682006);
			Tooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100682007);
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x06009630 RID: 38448 RVA: 0x0026C3BC File Offset: 0x0026A5BC
		public unsafe Vector3 labelPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 269987, RefRangeEnd = 269988, XrefRangeStart = 269984, XrefRangeEnd = 269987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x06009631 RID: 38449 RVA: 0x0026C3F8 File Offset: 0x0026A5F8
		// (set) Token: 0x06009632 RID: 38450 RVA: 0x0026C434 File Offset: 0x0026A634
		public unsafe bool isWorldspace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x0026C474 File Offset: 0x0026A674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269988, XrefRangeEnd = 270013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tooltip.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009634 RID: 38452 RVA: 0x0026C4B0 File Offset: 0x0026A6B0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tooltip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tooltip>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009635 RID: 38453 RVA: 0x000488F8 File Offset: 0x00046AF8
		public Tooltip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x06009636 RID: 38454 RVA: 0x0026C4EC File Offset: 0x0026A6EC
		// (set) Token: 0x06009637 RID: 38455 RVA: 0x00048901 File Offset: 0x00046B01
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x06009638 RID: 38456 RVA: 0x0026C514 File Offset: 0x0026A714
		// (set) Token: 0x06009639 RID: 38457 RVA: 0x00048920 File Offset: 0x00046B20
		public unsafe Vector2 labelOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_labelOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_labelOffset)) = value;
			}
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0600963A RID: 38458 RVA: 0x0026C53C File Offset: 0x0026A73C
		// (set) Token: 0x0600963B RID: 38459 RVA: 0x0004893B File Offset: 0x00046B3B
		public unsafe RectTransform rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x0600963C RID: 38460 RVA: 0x0026C56C File Offset: 0x0026A76C
		// (set) Token: 0x0600963D RID: 38461 RVA: 0x0004895A File Offset: 0x00046B5A
		public unsafe bool _isWorldspace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0600963E RID: 38462 RVA: 0x0026C594 File Offset: 0x0026A794
		// (set) Token: 0x0600963F RID: 38463 RVA: 0x00048975 File Offset: 0x00046B75
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006561 RID: 25953
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04006562 RID: 25954
		private static readonly IntPtr NativeFieldInfoPtr_labelOffset;

		// Token: 0x04006563 RID: 25955
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x04006564 RID: 25956
		private static readonly IntPtr NativeFieldInfoPtr__isWorldspace_k__BackingField;

		// Token: 0x04006565 RID: 25957
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006566 RID: 25958
		private static readonly IntPtr NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0;

		// Token: 0x04006567 RID: 25959
		private static readonly IntPtr NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0;

		// Token: 0x04006568 RID: 25960
		private static readonly IntPtr NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0;

		// Token: 0x04006569 RID: 25961
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400656A RID: 25962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
