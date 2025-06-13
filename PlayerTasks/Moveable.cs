using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020E RID: 526
	public class Moveable : Clickable
	{
		// Token: 0x06002B01 RID: 11009 RVA: 0x000FBB4C File Offset: 0x000F9D4C
		// Note: this type is marked as 'beforefieldinit'.
		static Moveable()
		{
			Il2CppClassPointerStore<Moveable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Moveable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Moveable>.NativeClassPtr);
			Moveable.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "clickOffset");
			Moveable.NativeFieldInfoPtr_clickDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "clickDist");
			Moveable.NativeFieldInfoPtr_yMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "yMax");
			Moveable.NativeFieldInfoPtr_yMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "yMin");
			Moveable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668182);
			Moveable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668183);
			Moveable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668184);
			Moveable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668185);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000FBC1C File Offset: 0x000F9E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124102, XrefRangeEnd = 124126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Moveable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000FBC68 File Offset: 0x000F9E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124126, XrefRangeEnd = 124147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Moveable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000FBCA4 File Offset: 0x000F9EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Moveable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000FBCE0 File Offset: 0x000F9EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124147, XrefRangeEnd = 124152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Moveable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Moveable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Moveable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x000172BA File Offset: 0x000154BA
		public Moveable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x000FBD1C File Offset: 0x000F9F1C
		// (set) Token: 0x06002B08 RID: 11016 RVA: 0x000172C3 File Offset: 0x000154C3
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000FBD44 File Offset: 0x000F9F44
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x000172DE File Offset: 0x000154DE
		public unsafe float clickDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickDist)) = value;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000FBD6C File Offset: 0x000F9F6C
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x000172F9 File Offset: 0x000154F9
		public unsafe float yMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMax)) = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x000FBD94 File Offset: 0x000F9F94
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x00017314 File Offset: 0x00015514
		public unsafe float yMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMin)) = value;
			}
		}

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeFieldInfoPtr_clickDist;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeFieldInfoPtr_yMax;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeFieldInfoPtr_yMin;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
