using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000746 RID: 1862
	public class QualityItemInfoContent : ItemInfoContent
	{
		// Token: 0x0600A6EF RID: 42735 RVA: 0x0029F760 File Offset: 0x0029D960
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemInfoContent()
		{
			Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "QualityItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr);
			QualityItemInfoContent.NativeFieldInfoPtr_Star = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, "Star");
			QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, "QualityLabel");
			QualityItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, 100683807);
			QualityItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, 100683808);
		}

		// Token: 0x0600A6F0 RID: 42736 RVA: 0x0029F7E0 File Offset: 0x0029D9E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291867, RefRangeEnd = 291868, XrefRangeStart = 291853, XrefRangeEnd = 291867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x0029F830 File Offset: 0x0029DA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x000520B3 File Offset: 0x000502B3
		public QualityItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600A6F3 RID: 42739 RVA: 0x0029F86C File Offset: 0x0029DA6C
		// (set) Token: 0x0600A6F4 RID: 42740 RVA: 0x000520BC File Offset: 0x000502BC
		public unsafe Image Star
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_Star);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_Star), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600A6F5 RID: 42741 RVA: 0x0029F89C File Offset: 0x0029DA9C
		// (set) Token: 0x0600A6F6 RID: 42742 RVA: 0x000520DB File Offset: 0x000502DB
		public unsafe TextMeshProUGUI QualityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006FF2 RID: 28658
		private static readonly IntPtr NativeFieldInfoPtr_Star;

		// Token: 0x04006FF3 RID: 28659
		private static readonly IntPtr NativeFieldInfoPtr_QualityLabel;

		// Token: 0x04006FF4 RID: 28660
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006FF5 RID: 28661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
