using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001AB RID: 427
	public class TileAppearance : MonoBehaviour
	{
		// Token: 0x0600229A RID: 8858 RVA: 0x000DFAFC File Offset: 0x000DDCFC
		// Note: this type is marked as 'beforefieldinit'.
		static TileAppearance()
		{
			Il2CppClassPointerStore<TileAppearance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "TileAppearance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr);
			TileAppearance.NativeFieldInfoPtr_tileMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "tileMesh");
			TileAppearance.NativeFieldInfoPtr_mat_White = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "mat_White");
			TileAppearance.NativeFieldInfoPtr_mat_Blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "mat_Blue");
			TileAppearance.NativeFieldInfoPtr_mat_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "mat_Red");
			TileAppearance.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100667242);
			TileAppearance.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100667243);
			TileAppearance.NativeMethodInfoPtr_SetColor_Public_Void_ETileColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100667244);
			TileAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100667245);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000DFBCC File Offset: 0x000DDDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114711, XrefRangeEnd = 114713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000DFC00 File Offset: 0x000DDE00
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 85797, RefRangeEnd = 85805, XrefRangeStart = 85797, XrefRangeEnd = 85805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000DFC40 File Offset: 0x000DDE40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 114723, RefRangeEnd = 114730, XrefRangeStart = 114713, XrefRangeEnd = 114723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(ETileColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr_SetColor_Public_Void_ETileColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000DFC80 File Offset: 0x000DDE80
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileAppearance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00013312 File Offset: 0x00011512
		public TileAppearance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x000DFCBC File Offset: 0x000DDEBC
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x0001331B File Offset: 0x0001151B
		public unsafe MeshRenderer tileMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_tileMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_tileMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x000DFCEC File Offset: 0x000DDEEC
		// (set) Token: 0x060022A3 RID: 8867 RVA: 0x0001333A File Offset: 0x0001153A
		public unsafe Material mat_White
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_White);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_White), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x000DFD1C File Offset: 0x000DDF1C
		// (set) Token: 0x060022A5 RID: 8869 RVA: 0x00013359 File Offset: 0x00011559
		public unsafe Material mat_Blue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Blue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Blue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x000DFD4C File Offset: 0x000DDF4C
		// (set) Token: 0x060022A7 RID: 8871 RVA: 0x00013378 File Offset: 0x00011578
		public unsafe Material mat_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Red);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Red), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr_tileMesh;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_mat_White;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_mat_Blue;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr_mat_Red;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_ETileColor_0;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
