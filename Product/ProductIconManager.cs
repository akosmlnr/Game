using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005C9 RID: 1481
	public class ProductIconManager : Singleton<ProductIconManager>
	{
		// Token: 0x06008093 RID: 32915 RVA: 0x00228488 File Offset: 0x00226688
		// Note: this type is marked as 'beforefieldinit'.
		static ProductIconManager()
		{
			Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductIconManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr);
			ProductIconManager.NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "icons");
			ProductIconManager.NativeFieldInfoPtr_IconGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "IconGenerator");
			ProductIconManager.NativeFieldInfoPtr_IconContainerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "IconContainerPath");
			ProductIconManager.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "Products");
			ProductIconManager.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "Packaging");
			ProductIconManager.NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679474);
			ProductIconManager.NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679475);
			ProductIconManager.NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679476);
			ProductIconManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679477);
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x0022856C File Offset: 0x0022676C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243014, RefRangeEnd = 243016, XrefRangeStart = 242994, XrefRangeEnd = 243014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetIcon(string productID, string packagingID, bool ignoreError = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ignoreError;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x002285DC File Offset: 0x002267DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243049, RefRangeEnd = 243052, XrefRangeStart = 243016, XrefRangeEnd = 243049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GenerateIcons(string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x0022862C File Offset: 0x0022682C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243052, XrefRangeEnd = 243054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GenerateProductTexture(string productID, string packagingID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x00228690 File Offset: 0x00226890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243054, XrefRangeEnd = 243068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductIconManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x0003CD77 File Offset: 0x0003AF77
		public ProductIconManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x06008099 RID: 32921 RVA: 0x002286CC File Offset: 0x002268CC
		// (set) Token: 0x0600809A RID: 32922 RVA: 0x0003CD80 File Offset: 0x0003AF80
		public unsafe List<ProductIconManager.ProductIcon> icons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_icons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductIconManager.ProductIcon>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x0600809B RID: 32923 RVA: 0x002286FC File Offset: 0x002268FC
		// (set) Token: 0x0600809C RID: 32924 RVA: 0x0003CD9F File Offset: 0x0003AF9F
		public unsafe IconGenerator IconGenerator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconGenerator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconGenerator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x0600809D RID: 32925 RVA: 0x0022872C File Offset: 0x0022692C
		// (set) Token: 0x0600809E RID: 32926 RVA: 0x0003CDBE File Offset: 0x0003AFBE
		public unsafe string IconContainerPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconContainerPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconContainerPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x0600809F RID: 32927 RVA: 0x00228754 File Offset: 0x00226954
		// (set) Token: 0x060080A0 RID: 32928 RVA: 0x0003CDDD File Offset: 0x0003AFDD
		public unsafe Il2CppReferenceArray<ProductDefinition> Products
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Products);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x060080A1 RID: 32929 RVA: 0x00228784 File Offset: 0x00226984
		// (set) Token: 0x060080A2 RID: 32930 RVA: 0x0003CDFC File Offset: 0x0003AFFC
		public unsafe Il2CppReferenceArray<PackagingDefinition> Packaging
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Packaging);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PackagingDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005787 RID: 22407
		private static readonly System.IntPtr NativeFieldInfoPtr_icons;

		// Token: 0x04005788 RID: 22408
		private static readonly System.IntPtr NativeFieldInfoPtr_IconGenerator;

		// Token: 0x04005789 RID: 22409
		private static readonly System.IntPtr NativeFieldInfoPtr_IconContainerPath;

		// Token: 0x0400578A RID: 22410
		private static readonly System.IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x0400578B RID: 22411
		private static readonly System.IntPtr NativeFieldInfoPtr_Packaging;

		// Token: 0x0400578C RID: 22412
		private static readonly System.IntPtr NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0;

		// Token: 0x0400578D RID: 22413
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0;

		// Token: 0x0400578E RID: 22414
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0;

		// Token: 0x0400578F RID: 22415
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B16 RID: 2838
		[System.Serializable]
		public class ProductIcon : Il2CppSystem.Object
		{
			// Token: 0x0600D966 RID: 55654 RVA: 0x003405C0 File Offset: 0x0033E7C0
			// Note: this type is marked as 'beforefieldinit'.
			static ProductIcon()
			{
				Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "ProductIcon");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr);
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "ProductID");
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "PackagingID");
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "Icon");
				ProductIconManager.ProductIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, 100679478);
			}

			// Token: 0x0600D967 RID: 55655 RVA: 0x0034063C File Offset: 0x0033E83C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductIcon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.ProductIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D968 RID: 55656 RVA: 0x000697A8 File Offset: 0x000679A8
			public ProductIcon(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004316 RID: 17174
			// (get) Token: 0x0600D969 RID: 55657 RVA: 0x00340678 File Offset: 0x0033E878
			// (set) Token: 0x0600D96A RID: 55658 RVA: 0x000697B1 File Offset: 0x000679B1
			public unsafe string ProductID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004317 RID: 17175
			// (get) Token: 0x0600D96B RID: 55659 RVA: 0x003406A0 File Offset: 0x0033E8A0
			// (set) Token: 0x0600D96C RID: 55660 RVA: 0x000697D0 File Offset: 0x000679D0
			public unsafe string PackagingID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004318 RID: 17176
			// (get) Token: 0x0600D96D RID: 55661 RVA: 0x003406C8 File Offset: 0x0033E8C8
			// (set) Token: 0x0600D96E RID: 55662 RVA: 0x000697EF File Offset: 0x000679EF
			public unsafe Sprite Icon
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400926E RID: 37486
			private static readonly System.IntPtr NativeFieldInfoPtr_ProductID;

			// Token: 0x0400926F RID: 37487
			private static readonly System.IntPtr NativeFieldInfoPtr_PackagingID;

			// Token: 0x04009270 RID: 37488
			private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

			// Token: 0x04009271 RID: 37489
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B17 RID: 2839
		[ObfuscatedName("ScheduleOne.Product.ProductIconManager+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D96F RID: 55663 RVA: 0x003406F8 File Offset: 0x0033E8F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr);
				ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, "productID");
				ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_packagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, "packagingID");
				ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, 100679479);
				ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, 100679480);
			}

			// Token: 0x0600D970 RID: 55664 RVA: 0x00340774 File Offset: 0x0033E974
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D971 RID: 55665 RVA: 0x003407B0 File Offset: 0x0033E9B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242993, XrefRangeEnd = 242994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIcon_b__0(ProductIconManager.ProductIcon x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D972 RID: 55666 RVA: 0x0006980E File Offset: 0x00067A0E
			public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004319 RID: 17177
			// (get) Token: 0x0600D973 RID: 55667 RVA: 0x00340800 File Offset: 0x0033EA00
			// (set) Token: 0x0600D974 RID: 55668 RVA: 0x00069817 File Offset: 0x00067A17
			public unsafe string productID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_productID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_productID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700431A RID: 17178
			// (get) Token: 0x0600D975 RID: 55669 RVA: 0x00340828 File Offset: 0x0033EA28
			// (set) Token: 0x0600D976 RID: 55670 RVA: 0x00069836 File Offset: 0x00067A36
			public unsafe string packagingID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_packagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_packagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009272 RID: 37490
			private static readonly System.IntPtr NativeFieldInfoPtr_productID;

			// Token: 0x04009273 RID: 37491
			private static readonly System.IntPtr NativeFieldInfoPtr_packagingID;

			// Token: 0x04009274 RID: 37492
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009275 RID: 37493
			private static readonly System.IntPtr NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0;
		}

		// Token: 0x02000B18 RID: 2840
		[ObfuscatedName("ScheduleOne.Product.ProductIconManager+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D977 RID: 55671 RVA: 0x00340850 File Offset: 0x0033EA50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr);
				ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, "productID");
				ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, 100679481);
				ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, 100679482);
			}

			// Token: 0x0600D978 RID: 55672 RVA: 0x003408B8 File Offset: 0x0033EAB8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D979 RID: 55673 RVA: 0x003408F4 File Offset: 0x0033EAF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateIcons_b__0(ProductIconManager.ProductIcon x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D97A RID: 55674 RVA: 0x00069855 File Offset: 0x00067A55
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700431B RID: 17179
			// (get) Token: 0x0600D97B RID: 55675 RVA: 0x00340944 File Offset: 0x0033EB44
			// (set) Token: 0x0600D97C RID: 55676 RVA: 0x0006985E File Offset: 0x00067A5E
			public unsafe string productID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009276 RID: 37494
			private static readonly System.IntPtr NativeFieldInfoPtr_productID;

			// Token: 0x04009277 RID: 37495
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009278 RID: 37496
			private static readonly System.IntPtr NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0;
		}
	}
}
