using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000747 RID: 1863
	public class QualityItemUI : ItemUI
	{
		// Token: 0x0600A6F7 RID: 42743 RVA: 0x0029F8CC File Offset: 0x0029DACC
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemUI()
		{
			Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "QualityItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr);
			QualityItemUI.NativeFieldInfoPtr_QualityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, "QualityIcon");
			QualityItemUI.NativeFieldInfoPtr_qualityItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, "qualityItemInstance");
			QualityItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100683809);
			QualityItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100683810);
			QualityItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100683811);
		}

		// Token: 0x0600A6F8 RID: 42744 RVA: 0x0029F960 File Offset: 0x0029DB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291868, XrefRangeEnd = 291874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6F9 RID: 42745 RVA: 0x0029F9B0 File Offset: 0x0029DBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291874, XrefRangeEnd = 291880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6FA RID: 42746 RVA: 0x0029F9EC File Offset: 0x0029DBEC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6FB RID: 42747 RVA: 0x000520FA File Offset: 0x000502FA
		public QualityItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600A6FC RID: 42748 RVA: 0x0029FA28 File Offset: 0x0029DC28
		// (set) Token: 0x0600A6FD RID: 42749 RVA: 0x00052103 File Offset: 0x00050303
		public unsafe Image QualityIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_QualityIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_QualityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600A6FE RID: 42750 RVA: 0x0029FA58 File Offset: 0x0029DC58
		// (set) Token: 0x0600A6FF RID: 42751 RVA: 0x00052122 File Offset: 0x00050322
		public unsafe QualityItemInstance qualityItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_qualityItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_qualityItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006FF6 RID: 28662
		private static readonly IntPtr NativeFieldInfoPtr_QualityIcon;

		// Token: 0x04006FF7 RID: 28663
		private static readonly IntPtr NativeFieldInfoPtr_qualityItemInstance;

		// Token: 0x04006FF8 RID: 28664
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006FF9 RID: 28665
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006FFA RID: 28666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
