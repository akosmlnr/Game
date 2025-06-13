using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005D6 RID: 1494
	public class ProductEntry : MonoBehaviour
	{
		// Token: 0x06008245 RID: 33349 RVA: 0x0022FBDC File Offset: 0x0022DDDC
		// Note: this type is marked as 'beforefieldinit'.
		static ProductEntry()
		{
			Il2CppClassPointerStore<ProductEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr);
			ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "<Definition>k__BackingField");
			ProductEntry.NativeFieldInfoPtr_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "SelectedColor");
			ProductEntry.NativeFieldInfoPtr_DeselectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "DeselectedColor");
			ProductEntry.NativeFieldInfoPtr_FavouritedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouritedColor");
			ProductEntry.NativeFieldInfoPtr_UnfavouritedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "UnfavouritedColor");
			ProductEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Button");
			ProductEntry.NativeFieldInfoPtr_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Frame");
			ProductEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Icon");
			ProductEntry.NativeFieldInfoPtr_Tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Tick");
			ProductEntry.NativeFieldInfoPtr_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Cross");
			ProductEntry.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Trigger");
			ProductEntry.NativeFieldInfoPtr_FavouriteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouriteButton");
			ProductEntry.NativeFieldInfoPtr_FavouriteIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouriteIcon");
			ProductEntry.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "onHovered");
			ProductEntry.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "destroyed");
			ProductEntry.NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679761);
			ProductEntry.NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679762);
			ProductEntry.NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679763);
			ProductEntry.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679764);
			ProductEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679765);
			ProductEntry.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679766);
			ProductEntry.NativeMethodInfoPtr_FavouriteClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679767);
			ProductEntry.NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679768);
			ProductEntry.NativeMethodInfoPtr_UpdateListed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679769);
			ProductEntry.NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679770);
			ProductEntry.NativeMethodInfoPtr_UpdateFavourited_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679771);
			ProductEntry.NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679772);
			ProductEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679773);
			ProductEntry.NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679774);
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x06008246 RID: 33350 RVA: 0x0022FE50 File Offset: 0x0022E050
		// (set) Token: 0x06008247 RID: 33351 RVA: 0x0022FE90 File Offset: 0x0022E090
		public unsafe ProductDefinition Definition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008248 RID: 33352 RVA: 0x0022FED4 File Offset: 0x0022E0D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247842, RefRangeEnd = 247844, XrefRangeStart = 247718, XrefRangeEnd = 247842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008249 RID: 33353 RVA: 0x0022FF18 File Offset: 0x0022E118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247852, RefRangeEnd = 247853, XrefRangeStart = 247844, XrefRangeEnd = 247852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600824A RID: 33354 RVA: 0x0022FF4C File Offset: 0x0022E14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247853, XrefRangeEnd = 247939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x0022FF80 File Offset: 0x0022E180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247939, XrefRangeEnd = 247946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x0022FFB4 File Offset: 0x0022E1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247946, XrefRangeEnd = 247962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FavouriteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_FavouriteClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x0022FFE8 File Offset: 0x0022E1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247962, XrefRangeEnd = 247967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductListedOrDelisted(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600824E RID: 33358 RVA: 0x0023002C File Offset: 0x0022E22C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 247986, RefRangeEnd = 247992, XrefRangeStart = 247967, XrefRangeEnd = 247986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateListed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600824F RID: 33359 RVA: 0x00230060 File Offset: 0x0022E260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247992, XrefRangeEnd = 247997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductFavouritedOrUnFavourited(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x002300A4 File Offset: 0x0022E2A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248012, RefRangeEnd = 248014, XrefRangeStart = 247997, XrefRangeEnd = 248012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFavourited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateFavourited_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008251 RID: 33361 RVA: 0x002300D8 File Offset: 0x0022E2D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248036, RefRangeEnd = 248039, XrefRangeStart = 248014, XrefRangeEnd = 248036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDiscovered(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008252 RID: 33362 RVA: 0x0023011C File Offset: 0x0022E31C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008253 RID: 33363 RVA: 0x00230158 File Offset: 0x0022E358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248039, XrefRangeEnd = 248041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__18_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x0003D7C3 File Offset: 0x0003B9C3
		public ProductEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x06008255 RID: 33365 RVA: 0x0023019C File Offset: 0x0022E39C
		// (set) Token: 0x06008256 RID: 33366 RVA: 0x0003D7CC File Offset: 0x0003B9CC
		public unsafe ProductDefinition _Definition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x06008257 RID: 33367 RVA: 0x002301CC File Offset: 0x0022E3CC
		// (set) Token: 0x06008258 RID: 33368 RVA: 0x0003D7EB File Offset: 0x0003B9EB
		public unsafe Color SelectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_SelectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_SelectedColor)) = value;
			}
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x06008259 RID: 33369 RVA: 0x002301F4 File Offset: 0x0022E3F4
		// (set) Token: 0x0600825A RID: 33370 RVA: 0x0003D806 File Offset: 0x0003BA06
		public unsafe Color DeselectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_DeselectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_DeselectedColor)) = value;
			}
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x0600825B RID: 33371 RVA: 0x0023021C File Offset: 0x0022E41C
		// (set) Token: 0x0600825C RID: 33372 RVA: 0x0003D821 File Offset: 0x0003BA21
		public unsafe Color FavouritedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouritedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouritedColor)) = value;
			}
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x0600825D RID: 33373 RVA: 0x00230244 File Offset: 0x0022E444
		// (set) Token: 0x0600825E RID: 33374 RVA: 0x0003D83C File Offset: 0x0003BA3C
		public unsafe Color UnfavouritedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_UnfavouritedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_UnfavouritedColor)) = value;
			}
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x0600825F RID: 33375 RVA: 0x0023026C File Offset: 0x0022E46C
		// (set) Token: 0x06008260 RID: 33376 RVA: 0x0003D857 File Offset: 0x0003BA57
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x06008261 RID: 33377 RVA: 0x0023029C File Offset: 0x0022E49C
		// (set) Token: 0x06008262 RID: 33378 RVA: 0x0003D876 File Offset: 0x0003BA76
		public unsafe Image Frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Frame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Frame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x06008263 RID: 33379 RVA: 0x002302CC File Offset: 0x0022E4CC
		// (set) Token: 0x06008264 RID: 33380 RVA: 0x0003D895 File Offset: 0x0003BA95
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x06008265 RID: 33381 RVA: 0x002302FC File Offset: 0x0022E4FC
		// (set) Token: 0x06008266 RID: 33382 RVA: 0x0003D8B4 File Offset: 0x0003BAB4
		public unsafe RectTransform Tick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Tick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Tick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x06008267 RID: 33383 RVA: 0x0023032C File Offset: 0x0022E52C
		// (set) Token: 0x06008268 RID: 33384 RVA: 0x0003D8D3 File Offset: 0x0003BAD3
		public unsafe RectTransform Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x06008269 RID: 33385 RVA: 0x0023035C File Offset: 0x0022E55C
		// (set) Token: 0x0600826A RID: 33386 RVA: 0x0003D8F2 File Offset: 0x0003BAF2
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x0600826B RID: 33387 RVA: 0x0023038C File Offset: 0x0022E58C
		// (set) Token: 0x0600826C RID: 33388 RVA: 0x0003D911 File Offset: 0x0003BB11
		public unsafe Button FavouriteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x0600826D RID: 33389 RVA: 0x002303BC File Offset: 0x0022E5BC
		// (set) Token: 0x0600826E RID: 33390 RVA: 0x0003D930 File Offset: 0x0003BB30
		public unsafe Image FavouriteIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x0600826F RID: 33391 RVA: 0x002303EC File Offset: 0x0022E5EC
		// (set) Token: 0x06008270 RID: 33392 RVA: 0x0003D94F File Offset: 0x0003BB4F
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x06008271 RID: 33393 RVA: 0x0023041C File Offset: 0x0022E61C
		// (set) Token: 0x06008272 RID: 33394 RVA: 0x0003D96E File Offset: 0x0003BB6E
		public unsafe bool destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_destroyed)) = value;
			}
		}

		// Token: 0x040058C7 RID: 22727
		private static readonly IntPtr NativeFieldInfoPtr__Definition_k__BackingField;

		// Token: 0x040058C8 RID: 22728
		private static readonly IntPtr NativeFieldInfoPtr_SelectedColor;

		// Token: 0x040058C9 RID: 22729
		private static readonly IntPtr NativeFieldInfoPtr_DeselectedColor;

		// Token: 0x040058CA RID: 22730
		private static readonly IntPtr NativeFieldInfoPtr_FavouritedColor;

		// Token: 0x040058CB RID: 22731
		private static readonly IntPtr NativeFieldInfoPtr_UnfavouritedColor;

		// Token: 0x040058CC RID: 22732
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040058CD RID: 22733
		private static readonly IntPtr NativeFieldInfoPtr_Frame;

		// Token: 0x040058CE RID: 22734
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x040058CF RID: 22735
		private static readonly IntPtr NativeFieldInfoPtr_Tick;

		// Token: 0x040058D0 RID: 22736
		private static readonly IntPtr NativeFieldInfoPtr_Cross;

		// Token: 0x040058D1 RID: 22737
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x040058D2 RID: 22738
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteButton;

		// Token: 0x040058D3 RID: 22739
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteIcon;

		// Token: 0x040058D4 RID: 22740
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x040058D5 RID: 22741
		private static readonly IntPtr NativeFieldInfoPtr_destroyed;

		// Token: 0x040058D6 RID: 22742
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0;

		// Token: 0x040058D7 RID: 22743
		private static readonly IntPtr NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0;

		// Token: 0x040058D8 RID: 22744
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0;

		// Token: 0x040058D9 RID: 22745
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040058DA RID: 22746
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040058DB RID: 22747
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x040058DC RID: 22748
		private static readonly IntPtr NativeMethodInfoPtr_FavouriteClicked_Private_Void_0;

		// Token: 0x040058DD RID: 22749
		private static readonly IntPtr NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0;

		// Token: 0x040058DE RID: 22750
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListed_Public_Void_0;

		// Token: 0x040058DF RID: 22751
		private static readonly IntPtr NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0;

		// Token: 0x040058E0 RID: 22752
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFavourited_Public_Void_0;

		// Token: 0x040058E1 RID: 22753
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0;

		// Token: 0x040058E2 RID: 22754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040058E3 RID: 22755
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_BaseEventData_0;
	}
}
