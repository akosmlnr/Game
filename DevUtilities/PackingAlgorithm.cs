using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000484 RID: 1156
	public class PackingAlgorithm : Singleton<PackingAlgorithm>
	{
		// Token: 0x0600636C RID: 25452 RVA: 0x001C6FE0 File Offset: 0x001C51E0
		// Note: this type is marked as 'beforefieldinit'.
		static PackingAlgorithm()
		{
			Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PackingAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr);
			PackingAlgorithm.NativeFieldInfoPtr_rectsToPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "rectsToPack");
			PackingAlgorithm.NativeMethodInfoPtr_PackItems_Public_List_1_StoredItemData_List_1_ItemInstance_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100676018);
			PackingAlgorithm.NativeMethodInfoPtr_AttemptPack_Public_List_1_StoredItemData_List_1_StoredItemData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100676019);
			PackingAlgorithm.NativeMethodInfoPtr_DoesCoordinateHaveOccupiedAdjacent_Private_Boolean_Il2CppObjectBase_Coordinate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100676020);
			PackingAlgorithm.NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Coordinate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100676021);
			PackingAlgorithm.NativeMethodInfoPtr_PrintGrid_Private_Void_Il2CppObjectBase_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100676022);
			PackingAlgorithm.NativeMethodInfoPtr_GetRegionSize_Private_Int32_Il2CppObjectBase_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100676023);
			PackingAlgorithm.NativeMethodInfoPtr_TransformCoordinatePoint_Private_Coordinate_Il2CppObjectBase_Coordinate_Coordinate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100676024);
			PackingAlgorithm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100676025);
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x001C70C4 File Offset: 0x001C52C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205287, XrefRangeEnd = 205317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PackingAlgorithm.StoredItemData> PackItems(List<ItemInstance> datas, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(datas);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridX;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridY;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_PackItems_Public_List_1_StoredItemData_List_1_ItemInstance_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackingAlgorithm.StoredItemData>>(intPtr2) : null;
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x001C7130 File Offset: 0x001C5330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205491, RefRangeEnd = 205492, XrefRangeStart = 205317, XrefRangeEnd = 205491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PackingAlgorithm.StoredItemData> AttemptPack(List<PackingAlgorithm.StoredItemData> rects, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rects);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridX;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridY;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_AttemptPack_Public_List_1_StoredItemData_List_1_StoredItemData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackingAlgorithm.StoredItemData>>(intPtr2) : null;
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x001C719C File Offset: 0x001C539C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205505, RefRangeEnd = 205506, XrefRangeStart = 205492, XrefRangeEnd = 205505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesCoordinateHaveOccupiedAdjacent(Il2CppObjectBase grid, PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridX;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridY;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_DoesCoordinateHaveOccupiedAdjacent_Private_Boolean_Il2CppObjectBase_Coordinate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x001C7218 File Offset: 0x001C5418
		[CallerCount(0)]
		public unsafe bool IsCoordinateInBounds(PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridX;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridY;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Coordinate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x001C7284 File Offset: 0x001C5484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205506, XrefRangeEnd = 205524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintGrid(Il2CppObjectBase grid, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridX;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridY;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_PrintGrid_Private_Void_Il2CppObjectBase_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x001C72E4 File Offset: 0x001C54E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205524, RefRangeEnd = 205526, XrefRangeStart = 205524, XrefRangeEnd = 205524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRegionSize(Il2CppObjectBase grid, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridX;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridY;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_GetRegionSize_Private_Int32_Il2CppObjectBase_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x001C7350 File Offset: 0x001C5550
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 205530, RefRangeEnd = 205537, XrefRangeStart = 205526, XrefRangeEnd = 205530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackingAlgorithm.Coordinate TransformCoordinatePoint(Il2CppObjectBase grid, PackingAlgorithm.Coordinate baseCoordinate, PackingAlgorithm.Coordinate offset, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseCoordinate);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offset);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridX;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridY;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_TransformCoordinatePoint_Private_Coordinate_Il2CppObjectBase_Coordinate_Coordinate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackingAlgorithm.Coordinate>(intPtr2) : null;
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x001C73E0 File Offset: 0x001C55E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205537, XrefRangeEnd = 205547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackingAlgorithm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x0002EC51 File Offset: 0x0002CE51
		public PackingAlgorithm(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06006376 RID: 25462 RVA: 0x001C741C File Offset: 0x001C561C
		// (set) Token: 0x06006377 RID: 25463 RVA: 0x0002EC5A File Offset: 0x0002CE5A
		public unsafe List<PackingAlgorithm.Rectangle> rectsToPack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.NativeFieldInfoPtr_rectsToPack);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackingAlgorithm.Rectangle>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.NativeFieldInfoPtr_rectsToPack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043D8 RID: 17368
		private static readonly System.IntPtr NativeFieldInfoPtr_rectsToPack;

		// Token: 0x040043D9 RID: 17369
		private static readonly System.IntPtr NativeMethodInfoPtr_PackItems_Public_List_1_StoredItemData_List_1_ItemInstance_Int32_Int32_0;

		// Token: 0x040043DA RID: 17370
		private static readonly System.IntPtr NativeMethodInfoPtr_AttemptPack_Public_List_1_StoredItemData_List_1_StoredItemData_Int32_Int32_0;

		// Token: 0x040043DB RID: 17371
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesCoordinateHaveOccupiedAdjacent_Private_Boolean_Il2CppObjectBase_Coordinate_Int32_Int32_0;

		// Token: 0x040043DC RID: 17372
		private static readonly System.IntPtr NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Coordinate_Int32_Int32_0;

		// Token: 0x040043DD RID: 17373
		private static readonly System.IntPtr NativeMethodInfoPtr_PrintGrid_Private_Void_Il2CppObjectBase_Int32_Int32_0;

		// Token: 0x040043DE RID: 17374
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRegionSize_Private_Int32_Il2CppObjectBase_Int32_Int32_0;

		// Token: 0x040043DF RID: 17375
		private static readonly System.IntPtr NativeMethodInfoPtr_TransformCoordinatePoint_Private_Coordinate_Il2CppObjectBase_Coordinate_Coordinate_Int32_Int32_0;

		// Token: 0x040043E0 RID: 17376
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A62 RID: 2658
		[System.Serializable]
		public class Rectangle : Il2CppSystem.Object
		{
			// Token: 0x0600D3F2 RID: 54258 RVA: 0x0033152C File Offset: 0x0032F72C
			// Note: this type is marked as 'beforefieldinit'.
			static Rectangle()
			{
				Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "Rectangle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr);
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "name");
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "sizeX");
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "sizeY");
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "flipped");
				PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, 100676026);
				PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, 100676027);
				PackingAlgorithm.Rectangle.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, 100676028);
			}

			// Token: 0x1700419A RID: 16794
			// (get) Token: 0x0600D3F3 RID: 54259 RVA: 0x003315E4 File Offset: 0x0032F7E4
			public unsafe int actualSizeX
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x1700419B RID: 16795
			// (get) Token: 0x0600D3F4 RID: 54260 RVA: 0x00331620 File Offset: 0x0032F820
			public unsafe int actualSizeY
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x0600D3F5 RID: 54261 RVA: 0x0033165C File Offset: 0x0032F85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205281, XrefRangeEnd = 205283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rectangle(string _name, int x, int y) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref x;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref y;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Rectangle.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3F6 RID: 54262 RVA: 0x00066C22 File Offset: 0x00064E22
			public Rectangle(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004196 RID: 16790
			// (get) Token: 0x0600D3F7 RID: 54263 RVA: 0x003316C4 File Offset: 0x0032F8C4
			// (set) Token: 0x0600D3F8 RID: 54264 RVA: 0x00066C2B File Offset: 0x00064E2B
			public unsafe string name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004197 RID: 16791
			// (get) Token: 0x0600D3F9 RID: 54265 RVA: 0x003316EC File Offset: 0x0032F8EC
			// (set) Token: 0x0600D3FA RID: 54266 RVA: 0x00066C4A File Offset: 0x00064E4A
			public unsafe int sizeX
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeX)) = value;
				}
			}

			// Token: 0x17004198 RID: 16792
			// (get) Token: 0x0600D3FB RID: 54267 RVA: 0x00331714 File Offset: 0x0032F914
			// (set) Token: 0x0600D3FC RID: 54268 RVA: 0x00066C65 File Offset: 0x00064E65
			public unsafe int sizeY
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeY)) = value;
				}
			}

			// Token: 0x17004199 RID: 16793
			// (get) Token: 0x0600D3FD RID: 54269 RVA: 0x0033173C File Offset: 0x0032F93C
			// (set) Token: 0x0600D3FE RID: 54270 RVA: 0x00066C80 File Offset: 0x00064E80
			public unsafe bool flipped
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_flipped);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_flipped)) = value;
				}
			}

			// Token: 0x04008F0E RID: 36622
			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008F0F RID: 36623
			private static readonly System.IntPtr NativeFieldInfoPtr_sizeX;

			// Token: 0x04008F10 RID: 36624
			private static readonly System.IntPtr NativeFieldInfoPtr_sizeY;

			// Token: 0x04008F11 RID: 36625
			private static readonly System.IntPtr NativeFieldInfoPtr_flipped;

			// Token: 0x04008F12 RID: 36626
			private static readonly System.IntPtr NativeMethodInfoPtr_get_actualSizeX_Public_get_Int32_0;

			// Token: 0x04008F13 RID: 36627
			private static readonly System.IntPtr NativeMethodInfoPtr_get_actualSizeY_Public_get_Int32_0;

			// Token: 0x04008F14 RID: 36628
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
		}

		// Token: 0x02000A63 RID: 2659
		public class StoredItemData : PackingAlgorithm.Rectangle
		{
			// Token: 0x0600D3FF RID: 54271 RVA: 0x00331764 File Offset: 0x0032F964
			// Note: this type is marked as 'beforefieldinit'.
			static StoredItemData()
			{
				Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "StoredItemData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr);
				PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, "item");
				PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_xPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, "xPos");
				PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, "yPos");
				PackingAlgorithm.StoredItemData.NativeMethodInfoPtr_get_rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, 100676029);
				PackingAlgorithm.StoredItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, 100676030);
			}

			// Token: 0x1700419F RID: 16799
			// (get) Token: 0x0600D400 RID: 54272 RVA: 0x003317F4 File Offset: 0x0032F9F4
			public unsafe float rotation
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.StoredItemData.NativeMethodInfoPtr_get_rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x0600D401 RID: 54273 RVA: 0x00331830 File Offset: 0x0032FA30
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 205286, RefRangeEnd = 205287, XrefRangeStart = 205283, XrefRangeEnd = 205286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StoredItemData(string _name, int x, int y, ItemInstance _item) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref x;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref y;
				ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_item);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.StoredItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D402 RID: 54274 RVA: 0x00066C9B File Offset: 0x00064E9B
			public StoredItemData(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700419C RID: 16796
			// (get) Token: 0x0600D403 RID: 54275 RVA: 0x003318AC File Offset: 0x0032FAAC
			// (set) Token: 0x0600D404 RID: 54276 RVA: 0x00066CA4 File Offset: 0x00064EA4
			public unsafe ItemInstance item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700419D RID: 16797
			// (get) Token: 0x0600D405 RID: 54277 RVA: 0x003318DC File Offset: 0x0032FADC
			// (set) Token: 0x0600D406 RID: 54278 RVA: 0x00066CC3 File Offset: 0x00064EC3
			public unsafe int xPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_xPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_xPos)) = value;
				}
			}

			// Token: 0x1700419E RID: 16798
			// (get) Token: 0x0600D407 RID: 54279 RVA: 0x00331904 File Offset: 0x0032FB04
			// (set) Token: 0x0600D408 RID: 54280 RVA: 0x00066CDE File Offset: 0x00064EDE
			public unsafe int yPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x04008F15 RID: 36629
			private static readonly System.IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008F16 RID: 36630
			private static readonly System.IntPtr NativeFieldInfoPtr_xPos;

			// Token: 0x04008F17 RID: 36631
			private static readonly System.IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x04008F18 RID: 36632
			private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Single_0;

			// Token: 0x04008F19 RID: 36633
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_ItemInstance_0;
		}

		// Token: 0x02000A64 RID: 2660
		public class Coordinate : Il2CppSystem.Object
		{
			// Token: 0x0600D409 RID: 54281 RVA: 0x0033192C File Offset: 0x0032FB2C
			// Note: this type is marked as 'beforefieldinit'.
			static Coordinate()
			{
				Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "Coordinate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr);
				PackingAlgorithm.Coordinate.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, "x");
				PackingAlgorithm.Coordinate.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, "y");
				PackingAlgorithm.Coordinate.NativeFieldInfoPtr_occupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, "occupant");
				PackingAlgorithm.Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, 100676031);
			}

			// Token: 0x0600D40A RID: 54282 RVA: 0x003319A8 File Offset: 0x0032FBA8
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 114005, RefRangeEnd = 114023, XrefRangeStart = 114005, XrefRangeEnd = 114023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Coordinate(int _x, int _y) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref _x;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _y;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D40B RID: 54283 RVA: 0x00066CF9 File Offset: 0x00064EF9
			public Coordinate(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A0 RID: 16800
			// (get) Token: 0x0600D40C RID: 54284 RVA: 0x00331A00 File Offset: 0x0032FC00
			// (set) Token: 0x0600D40D RID: 54285 RVA: 0x00066D02 File Offset: 0x00064F02
			public unsafe int x
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x170041A1 RID: 16801
			// (get) Token: 0x0600D40E RID: 54286 RVA: 0x00331A28 File Offset: 0x0032FC28
			// (set) Token: 0x0600D40F RID: 54287 RVA: 0x00066D1D File Offset: 0x00064F1D
			public unsafe int y
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x170041A2 RID: 16802
			// (get) Token: 0x0600D410 RID: 54288 RVA: 0x00331A50 File Offset: 0x0032FC50
			// (set) Token: 0x0600D411 RID: 54289 RVA: 0x00066D38 File Offset: 0x00064F38
			public unsafe PackingAlgorithm.Rectangle occupant
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_occupant);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackingAlgorithm.Rectangle>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_occupant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F1A RID: 36634
			private static readonly System.IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008F1B RID: 36635
			private static readonly System.IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04008F1C RID: 36636
			private static readonly System.IntPtr NativeFieldInfoPtr_occupant;

			// Token: 0x04008F1D RID: 36637
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
		}

		// Token: 0x02000A65 RID: 2661
		[ObfuscatedName("ScheduleOne.DevUtilities.PackingAlgorithm+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D412 RID: 54290 RVA: 0x00331A80 File Offset: 0x0032FC80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr);
				PackingAlgorithm.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, "<>9");
				PackingAlgorithm.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, "<>9__5_0");
				PackingAlgorithm.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, 100676033);
				PackingAlgorithm.__c.NativeMethodInfoPtr__AttemptPack_b__5_0_Internal_Int32_StoredItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, 100676034);
			}

			// Token: 0x0600D413 RID: 54291 RVA: 0x00331AFC File Offset: 0x0032FCFC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D414 RID: 54292 RVA: 0x00331B38 File Offset: 0x0032FD38
			[CallerCount(0)]
			public unsafe int _AttemptPack_b__5_0(PackingAlgorithm.StoredItemData o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.__c.NativeMethodInfoPtr__AttemptPack_b__5_0_Internal_Int32_StoredItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D415 RID: 54293 RVA: 0x00066D57 File Offset: 0x00064F57
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A3 RID: 16803
			// (get) Token: 0x0600D416 RID: 54294 RVA: 0x00331B88 File Offset: 0x0032FD88
			// (set) Token: 0x0600D417 RID: 54295 RVA: 0x00066D60 File Offset: 0x00064F60
			public unsafe static PackingAlgorithm.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackingAlgorithm.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A4 RID: 16804
			// (get) Token: 0x0600D418 RID: 54296 RVA: 0x00331BB0 File Offset: 0x0032FDB0
			// (set) Token: 0x0600D419 RID: 54297 RVA: 0x00066D72 File Offset: 0x00064F72
			public unsafe static Il2CppSystem.Func<PackingAlgorithm.StoredItemData, int> __9__5_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<PackingAlgorithm.StoredItemData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F1E RID: 36638
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F1F RID: 36639
			private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04008F20 RID: 36640
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F21 RID: 36641
			private static readonly System.IntPtr NativeMethodInfoPtr__AttemptPack_b__5_0_Internal_Int32_StoredItemData_0;
		}
	}
}
