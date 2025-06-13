using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000736 RID: 1846
	public class ShopColorPicker : MonoBehaviour
	{
		// Token: 0x0600A4E3 RID: 42211 RVA: 0x00298FC8 File Offset: 0x002971C8
		// Note: this type is marked as 'beforefieldinit'.
		static ShopColorPicker()
		{
			Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr);
			ShopColorPicker.NativeFieldInfoPtr_AssetIconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "AssetIconImage");
			ShopColorPicker.NativeFieldInfoPtr_ColorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorLabel");
			ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorButtonParent");
			ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorButtonPrefab");
			ShopColorPicker.NativeFieldInfoPtr_onColorPicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "onColorPicked");
			ShopColorPicker.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683554);
			ShopColorPicker.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683555);
			ShopColorPicker.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683556);
			ShopColorPicker.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683557);
			ShopColorPicker.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683558);
			ShopColorPicker.NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683559);
			ShopColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683560);
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600A4E4 RID: 42212 RVA: 0x002990E8 File Offset: 0x002972E8
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289011, XrefRangeEnd = 289014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x00299124 File Offset: 0x00297324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289014, XrefRangeEnd = 289093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x00299158 File Offset: 0x00297358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289099, RefRangeEnd = 289100, XrefRangeStart = 289093, XrefRangeEnd = 289099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorPicked(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4E7 RID: 42215 RVA: 0x00299198 File Offset: 0x00297398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289100, XrefRangeEnd = 289106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x002991DC File Offset: 0x002973DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199161, RefRangeEnd = 199164, XrefRangeStart = 199161, XrefRangeEnd = 199164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x00299210 File Offset: 0x00297410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289109, RefRangeEnd = 289110, XrefRangeStart = 289106, XrefRangeEnd = 289109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorHovered(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x00299250 File Offset: 0x00297450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289110, XrefRangeEnd = 289118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x00050E96 File Offset: 0x0004F096
		public ShopColorPicker(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600A4EC RID: 42220 RVA: 0x0029928C File Offset: 0x0029748C
		// (set) Token: 0x0600A4ED RID: 42221 RVA: 0x00050E9F File Offset: 0x0004F09F
		public unsafe Image AssetIconImage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_AssetIconImage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_AssetIconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600A4EE RID: 42222 RVA: 0x002992BC File Offset: 0x002974BC
		// (set) Token: 0x0600A4EF RID: 42223 RVA: 0x00050EBE File Offset: 0x0004F0BE
		public unsafe TextMeshProUGUI ColorLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600A4F0 RID: 42224 RVA: 0x002992EC File Offset: 0x002974EC
		// (set) Token: 0x0600A4F1 RID: 42225 RVA: 0x00050EDD File Offset: 0x0004F0DD
		public unsafe RectTransform ColorButtonParent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600A4F2 RID: 42226 RVA: 0x0029931C File Offset: 0x0029751C
		// (set) Token: 0x0600A4F3 RID: 42227 RVA: 0x00050EFC File Offset: 0x0004F0FC
		public unsafe GameObject ColorButtonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600A4F4 RID: 42228 RVA: 0x0029934C File Offset: 0x0029754C
		// (set) Token: 0x0600A4F5 RID: 42229 RVA: 0x00050F1B File Offset: 0x0004F11B
		public unsafe UnityEvent<EClothingColor> onColorPicked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_onColorPicked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EClothingColor>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_onColorPicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E9D RID: 28317
		private static readonly System.IntPtr NativeFieldInfoPtr_AssetIconImage;

		// Token: 0x04006E9E RID: 28318
		private static readonly System.IntPtr NativeFieldInfoPtr_ColorLabel;

		// Token: 0x04006E9F RID: 28319
		private static readonly System.IntPtr NativeFieldInfoPtr_ColorButtonParent;

		// Token: 0x04006EA0 RID: 28320
		private static readonly System.IntPtr NativeFieldInfoPtr_ColorButtonPrefab;

		// Token: 0x04006EA1 RID: 28321
		private static readonly System.IntPtr NativeFieldInfoPtr_onColorPicked;

		// Token: 0x04006EA2 RID: 28322
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006EA3 RID: 28323
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006EA4 RID: 28324
		private static readonly System.IntPtr NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0;

		// Token: 0x04006EA5 RID: 28325
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0;

		// Token: 0x04006EA6 RID: 28326
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006EA7 RID: 28327
		private static readonly System.IntPtr NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0;

		// Token: 0x04006EA8 RID: 28328
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C06 RID: 3078
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopColorPicker+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E280 RID: 57984 RVA: 0x0035A43C File Offset: 0x0035863C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr);
				ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, "color");
				ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, 100683561);
				ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, 100683562);
				ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, 100683563);
			}

			// Token: 0x0600E281 RID: 57985 RVA: 0x0035A4CC File Offset: 0x003586CC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E282 RID: 57986 RVA: 0x0035A508 File Offset: 0x00358708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289007, XrefRangeEnd = 289009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E283 RID: 57987 RVA: 0x0035A53C File Offset: 0x0035873C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289009, XrefRangeEnd = 289011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E284 RID: 57988 RVA: 0x0006E107 File Offset: 0x0006C307
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E3 RID: 17891
			// (get) Token: 0x0600E285 RID: 57989 RVA: 0x0035A580 File Offset: 0x00358780
			// (set) Token: 0x0600E286 RID: 57990 RVA: 0x0006E110 File Offset: 0x0006C310
			public unsafe EClothingColor color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x170045E4 RID: 17892
			// (get) Token: 0x0600E287 RID: 57991 RVA: 0x0035A5A8 File Offset: 0x003587A8
			// (set) Token: 0x0600E288 RID: 57992 RVA: 0x0006E12B File Offset: 0x0006C32B
			public unsafe ShopColorPicker __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopColorPicker>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097CF RID: 38863
			private static readonly System.IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040097D0 RID: 38864
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097D1 RID: 38865
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097D2 RID: 38866
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x040097D3 RID: 38867
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_BaseEventData_0;
		}
	}
}
