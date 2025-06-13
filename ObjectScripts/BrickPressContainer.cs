using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000766 RID: 1894
	public class BrickPressContainer : MonoBehaviour
	{
		// Token: 0x0600AD90 RID: 44432 RVA: 0x002B7464 File Offset: 0x002B5664
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressContainer()
		{
			Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BrickPressContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr);
			BrickPressContainer.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Visuals");
			BrickPressContainer.NativeFieldInfoPtr_ContentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "ContentsContainer");
			BrickPressContainer.NativeFieldInfoPtr_Contents_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Contents_Min");
			BrickPressContainer.NativeFieldInfoPtr_Contents_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Contents_Max");
			BrickPressContainer.NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, 100684711);
			BrickPressContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, 100684712);
		}

		// Token: 0x0600AD91 RID: 44433 RVA: 0x002B750C File Offset: 0x002B570C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301070, RefRangeEnd = 301071, XrefRangeStart = 301060, XrefRangeEnd = 301070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContents(ProductItemInstance product, float fillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillLevel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressContainer.NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AD92 RID: 44434 RVA: 0x002B755C File Offset: 0x002B575C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AD93 RID: 44435 RVA: 0x00055266 File Offset: 0x00053466
		public BrickPressContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600AD94 RID: 44436 RVA: 0x002B7598 File Offset: 0x002B5798
		// (set) Token: 0x0600AD95 RID: 44437 RVA: 0x0005526F File Offset: 0x0005346F
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600AD96 RID: 44438 RVA: 0x002B75C8 File Offset: 0x002B57C8
		// (set) Token: 0x0600AD97 RID: 44439 RVA: 0x0005528E File Offset: 0x0005348E
		public unsafe Transform ContentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_ContentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_ContentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600AD98 RID: 44440 RVA: 0x002B75F8 File Offset: 0x002B57F8
		// (set) Token: 0x0600AD99 RID: 44441 RVA: 0x000552AD File Offset: 0x000534AD
		public unsafe Transform Contents_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600AD9A RID: 44442 RVA: 0x002B7628 File Offset: 0x002B5828
		// (set) Token: 0x0600AD9B RID: 44443 RVA: 0x000552CC File Offset: 0x000534CC
		public unsafe Transform Contents_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400749F RID: 29855
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040074A0 RID: 29856
		private static readonly IntPtr NativeFieldInfoPtr_ContentsContainer;

		// Token: 0x040074A1 RID: 29857
		private static readonly IntPtr NativeFieldInfoPtr_Contents_Min;

		// Token: 0x040074A2 RID: 29858
		private static readonly IntPtr NativeFieldInfoPtr_Contents_Max;

		// Token: 0x040074A3 RID: 29859
		private static readonly IntPtr NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0;

		// Token: 0x040074A4 RID: 29860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
