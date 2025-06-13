using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000730 RID: 1840
	public class CategoryButton : MonoBehaviour
	{
		// Token: 0x0600A46D RID: 42093 RVA: 0x002978EC File Offset: 0x00295AEC
		// Note: this type is marked as 'beforefieldinit'.
		static CategoryButton()
		{
			Il2CppClassPointerStore<CategoryButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CategoryButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr);
			CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "<isSelected>k__BackingField");
			CategoryButton.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "Category");
			CategoryButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "button");
			CategoryButton.NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "shop");
			CategoryButton.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683509);
			CategoryButton.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683510);
			CategoryButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683511);
			CategoryButton.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683512);
			CategoryButton.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683513);
			CategoryButton.NativeMethodInfoPtr_Deselect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683514);
			CategoryButton.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683515);
			CategoryButton.NativeMethodInfoPtr_RefreshUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683516);
			CategoryButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683517);
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600A46E RID: 42094 RVA: 0x00297A20 File Offset: 0x00295C20
		// (set) Token: 0x0600A46F RID: 42095 RVA: 0x00297A5C File Offset: 0x00295C5C
		public unsafe bool isSelected
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x00297A9C File Offset: 0x00295C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288682, XrefRangeEnd = 288699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x00297AD0 File Offset: 0x00295CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288699, XrefRangeEnd = 288704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x00297B04 File Offset: 0x00295D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288704, XrefRangeEnd = 288708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x00297B38 File Offset: 0x00295D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288710, RefRangeEnd = 288712, XrefRangeStart = 288708, XrefRangeEnd = 288710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Deselect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A474 RID: 42100 RVA: 0x00297B6C File Offset: 0x00295D6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288715, RefRangeEnd = 288717, XrefRangeStart = 288712, XrefRangeEnd = 288715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A475 RID: 42101 RVA: 0x00297BA0 File Offset: 0x00295DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288717, XrefRangeEnd = 288719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_RefreshUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x00297BD4 File Offset: 0x00295DD4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CategoryButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x00050AC7 File Offset: 0x0004ECC7
		public CategoryButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600A478 RID: 42104 RVA: 0x00297C10 File Offset: 0x00295E10
		// (set) Token: 0x0600A479 RID: 42105 RVA: 0x00050AD0 File Offset: 0x0004ECD0
		public unsafe bool _isSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600A47A RID: 42106 RVA: 0x00297C38 File Offset: 0x00295E38
		// (set) Token: 0x0600A47B RID: 42107 RVA: 0x00050AEB File Offset: 0x0004ECEB
		public unsafe EShopCategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600A47C RID: 42108 RVA: 0x00297C60 File Offset: 0x00295E60
		// (set) Token: 0x0600A47D RID: 42109 RVA: 0x00050B06 File Offset: 0x0004ED06
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600A47E RID: 42110 RVA: 0x00297C90 File Offset: 0x00295E90
		// (set) Token: 0x0600A47F RID: 42111 RVA: 0x00050B25 File Offset: 0x0004ED25
		public unsafe ShopInterface shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E3E RID: 28222
		private static readonly IntPtr NativeFieldInfoPtr__isSelected_k__BackingField;

		// Token: 0x04006E3F RID: 28223
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04006E40 RID: 28224
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04006E41 RID: 28225
		private static readonly IntPtr NativeFieldInfoPtr_shop;

		// Token: 0x04006E42 RID: 28226
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0;

		// Token: 0x04006E43 RID: 28227
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04006E44 RID: 28228
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006E45 RID: 28229
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006E46 RID: 28230
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04006E47 RID: 28231
		private static readonly IntPtr NativeMethodInfoPtr_Deselect_Public_Void_0;

		// Token: 0x04006E48 RID: 28232
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_0;

		// Token: 0x04006E49 RID: 28233
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Private_Void_0;

		// Token: 0x04006E4A RID: 28234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
