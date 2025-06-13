using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x02000316 RID: 790
	public class SmokeCigarette : MonoBehaviour
	{
		// Token: 0x06003AB3 RID: 15027 RVA: 0x00132EA4 File Offset: 0x001310A4
		// Note: this type is marked as 'beforefieldinit'.
		static SmokeCigarette()
		{
			Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "SmokeCigarette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr);
			SmokeCigarette.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "Npc");
			SmokeCigarette.NativeFieldInfoPtr_CigarettePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "CigarettePrefab");
			SmokeCigarette.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "Anim");
			SmokeCigarette.NativeFieldInfoPtr_cigarette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "cigarette");
			SmokeCigarette.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100670215);
			SmokeCigarette.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100670216);
			SmokeCigarette.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100670217);
			SmokeCigarette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100670218);
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x00132F74 File Offset: 0x00131174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147396, XrefRangeEnd = 147404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x00132FA8 File Offset: 0x001311A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147404, XrefRangeEnd = 147416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x00132FDC File Offset: 0x001311DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147416, XrefRangeEnd = 147430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x00133010 File Offset: 0x00131210
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmokeCigarette() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x0001DF0E File Offset: 0x0001C10E
		public SmokeCigarette(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x0013304C File Offset: 0x0013124C
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x0001DF17 File Offset: 0x0001C117
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x0013307C File Offset: 0x0013127C
		// (set) Token: 0x06003ABC RID: 15036 RVA: 0x0001DF36 File Offset: 0x0001C136
		public unsafe GameObject CigarettePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_CigarettePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_CigarettePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06003ABD RID: 15037 RVA: 0x001330AC File Offset: 0x001312AC
		// (set) Token: 0x06003ABE RID: 15038 RVA: 0x0001DF55 File Offset: 0x0001C155
		public unsafe AvatarAnimation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x001330DC File Offset: 0x001312DC
		// (set) Token: 0x06003AC0 RID: 15040 RVA: 0x0001DF74 File Offset: 0x0001C174
		public unsafe GameObject cigarette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_cigarette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_cigarette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026BD RID: 9917
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040026BE RID: 9918
		private static readonly IntPtr NativeFieldInfoPtr_CigarettePrefab;

		// Token: 0x040026BF RID: 9919
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040026C0 RID: 9920
		private static readonly IntPtr NativeFieldInfoPtr_cigarette;

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
