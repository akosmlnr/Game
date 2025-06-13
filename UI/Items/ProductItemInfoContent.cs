using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000745 RID: 1861
	public class ProductItemInfoContent : QualityItemInfoContent
	{
		// Token: 0x0600A6E8 RID: 42728 RVA: 0x0029F5D4 File Offset: 0x0029D7D4
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemInfoContent()
		{
			Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ProductItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr);
			ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, "PropertyLabels");
			ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100683804);
			ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100683805);
			ProductItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100683806);
		}

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x0029F654 File Offset: 0x0029D854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291805, XrefRangeEnd = 291815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x0029F6A4 File Offset: 0x0029D8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291815, XrefRangeEnd = 291845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x0029F6F4 File Offset: 0x0029D8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291845, XrefRangeEnd = 291853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6EC RID: 42732 RVA: 0x0005208B File Offset: 0x0005028B
		public ProductItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600A6ED RID: 42733 RVA: 0x0029F730 File Offset: 0x0029D930
		// (set) Token: 0x0600A6EE RID: 42734 RVA: 0x00052094 File Offset: 0x00050294
		public unsafe List<TextMeshProUGUI> PropertyLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006FEE RID: 28654
		private static readonly IntPtr NativeFieldInfoPtr_PropertyLabels;

		// Token: 0x04006FEF RID: 28655
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006FF0 RID: 28656
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0;

		// Token: 0x04006FF1 RID: 28657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
