using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000196 RID: 406
	public class SnakeTile : MonoBehaviour
	{
		// Token: 0x06002092 RID: 8338 RVA: 0x000D8D08 File Offset: 0x000D6F08
		// Note: this type is marked as 'beforefieldinit'.
		static SnakeTile()
		{
			Il2CppClassPointerStore<SnakeTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "SnakeTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr);
			SnakeTile.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "<Type>k__BackingField");
			SnakeTile.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "Position");
			SnakeTile.NativeFieldInfoPtr_SnakeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "SnakeColor");
			SnakeTile.NativeFieldInfoPtr_FoodColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "FoodColor");
			SnakeTile.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "RectTransform");
			SnakeTile.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "Image");
			SnakeTile.NativeMethodInfoPtr_get_Type_Public_get_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666974);
			SnakeTile.NativeMethodInfoPtr_set_Type_Private_set_Void_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666975);
			SnakeTile.NativeMethodInfoPtr_SetType_Public_Void_TileType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666976);
			SnakeTile.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666977);
			SnakeTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666978);
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x000D8E14 File Offset: 0x000D7014
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x000D8E50 File Offset: 0x000D7050
		public unsafe SnakeTile.TileType Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21913, RefRangeEnd = 21914, XrefRangeStart = 21913, XrefRangeEnd = 21914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_get_Type_Public_get_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31411, RefRangeEnd = 31412, XrefRangeStart = 31411, XrefRangeEnd = 31412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_set_Type_Private_set_Void_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x000D8E90 File Offset: 0x000D7090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112172, XrefRangeEnd = 112177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType(SnakeTile.TileType type, int index = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_SetType_Public_Void_TileType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x000D8EDC File Offset: 0x000D70DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112189, RefRangeEnd = 112190, XrefRangeStart = 112177, XrefRangeEnd = 112189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector2 position, float tileSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileSize;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x000D8F28 File Offset: 0x000D7128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112190, XrefRangeEnd = 112193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnakeTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x000123DE File Offset: 0x000105DE
		public SnakeTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x000D8F64 File Offset: 0x000D7164
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x000123E7 File Offset: 0x000105E7
		public unsafe SnakeTile.TileType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x000D8F8C File Offset: 0x000D718C
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x00012402 File Offset: 0x00010602
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x000D8FB4 File Offset: 0x000D71B4
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x0001241D File Offset: 0x0001061D
		public unsafe Color SnakeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_SnakeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_SnakeColor)) = value;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x000D8FDC File Offset: 0x000D71DC
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00012438 File Offset: 0x00010638
		public unsafe Color FoodColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_FoodColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_FoodColor)) = value;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000D9004 File Offset: 0x000D7204
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00012453 File Offset: 0x00010653
		public unsafe RectTransform RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000D9034 File Offset: 0x000D7234
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x00012472 File Offset: 0x00010672
		public unsafe Image Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeFieldInfoPtr_SnakeColor;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeFieldInfoPtr_FoodColor;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeFieldInfoPtr_RectTransform;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_TileType_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_TileType_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Public_Void_TileType_Int32_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Single_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008E7 RID: 2279
		[OriginalName("Assembly-CSharp.dll", "", "TileType")]
		public enum TileType
		{
			// Token: 0x0400875E RID: 34654
			Empty,
			// Token: 0x0400875F RID: 34655
			Snake,
			// Token: 0x04008760 RID: 34656
			Food
		}
	}
}
