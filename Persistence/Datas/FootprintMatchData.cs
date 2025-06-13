using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000277 RID: 631
	[System.Serializable]
	public class FootprintMatchData : Il2CppSystem.Object
	{
		// Token: 0x06003024 RID: 12324 RVA: 0x0010DA20 File Offset: 0x0010BC20
		// Note: this type is marked as 'beforefieldinit'.
		static FootprintMatchData()
		{
			Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "FootprintMatchData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr);
			FootprintMatchData.NativeFieldInfoPtr_TileOwnerGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, "TileOwnerGUID");
			FootprintMatchData.NativeFieldInfoPtr_TileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, "TileIndex");
			FootprintMatchData.NativeFieldInfoPtr_FootprintCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, "FootprintCoordinate");
			FootprintMatchData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, 100668973);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x0010DAA0 File Offset: 0x0010BCA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136476, RefRangeEnd = 136477, XrefRangeStart = 136474, XrefRangeEnd = 136476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintMatchData(string tileOwnerGUID, int tileIndex, Vector2 footprintCoordinate) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tileOwnerGUID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref tileIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref footprintCoordinate;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintMatchData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x00019309 File Offset: 0x00017509
		public FootprintMatchData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x0010DB08 File Offset: 0x0010BD08
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x00019312 File Offset: 0x00017512
		public unsafe string TileOwnerGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileOwnerGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileOwnerGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x0010DB30 File Offset: 0x0010BD30
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x00019331 File Offset: 0x00017531
		public unsafe int TileIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileIndex)) = value;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x0010DB58 File Offset: 0x0010BD58
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x0001934C File Offset: 0x0001754C
		public unsafe Vector2 FootprintCoordinate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_FootprintCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_FootprintCoordinate)) = value;
			}
		}

		// Token: 0x04001FDA RID: 8154
		private static readonly System.IntPtr NativeFieldInfoPtr_TileOwnerGUID;

		// Token: 0x04001FDB RID: 8155
		private static readonly System.IntPtr NativeFieldInfoPtr_TileIndex;

		// Token: 0x04001FDC RID: 8156
		private static readonly System.IntPtr NativeFieldInfoPtr_FootprintCoordinate;

		// Token: 0x04001FDD RID: 8157
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Vector2_0;
	}
}
