using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000479 RID: 1145
	public static class JsonHelper : Il2CppSystem.Object
	{
		// Token: 0x0600628F RID: 25231 RVA: 0x001C43D4 File Offset: 0x001C25D4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonHelper()
		{
			Il2CppClassPointerStore<JsonHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "JsonHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr);
			JsonHelper.NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675929);
			JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675930);
			JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675931);
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x001C4440 File Offset: 0x001C2640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203958, XrefRangeEnd = 203959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FromJson<T>(string json)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			System.IntPtr returnedException;
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x001C447C File Offset: 0x001C267C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203959, XrefRangeEnd = 203975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson<T>(Il2CppArrayBase<T> array)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x001C44B8 File Offset: 0x001C26B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203975, XrefRangeEnd = 203981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson<T>(Il2CppArrayBase<T> array, bool prettyPrint)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref prettyPrint;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x0002E5F7 File Offset: 0x0002C7F7
		public JsonHelper(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400434A RID: 17226
		private static readonly System.IntPtr NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0;

		// Token: 0x0400434B RID: 17227
		private static readonly System.IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0;

		// Token: 0x0400434C RID: 17228
		private static readonly System.IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x02000A5E RID: 2654
		[System.Serializable]
		public class Wrapper<T> : Il2CppSystem.Object
		{
			// Token: 0x0600D3EA RID: 54250 RVA: 0x0033133C File Offset: 0x0032F53C
			// Note: this type is marked as 'beforefieldinit'.
			static Wrapper()
			{
				Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, "Wrapper`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
				{
					Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr);
				JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr, "Items");
				JsonHelper.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr, 100675932);
			}

			// Token: 0x0600D3EB RID: 54251 RVA: 0x003313CC File Offset: 0x0032F5CC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Wrapper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3EC RID: 54252 RVA: 0x00066BFA File Offset: 0x00064DFA
			public Wrapper(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004195 RID: 16789
			// (get) Token: 0x0600D3ED RID: 54253 RVA: 0x00331408 File Offset: 0x0032F608
			// (set) Token: 0x0600D3EE RID: 54254 RVA: 0x00066C03 File Offset: 0x00064E03
			public unsafe Il2CppArrayBase<T> Items
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F09 RID: 36617
			private static readonly System.IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x04008F0A RID: 36618
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A5F RID: 2655
		private sealed class MethodInfoStoreGeneric_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0<T>
		{
			// Token: 0x04008F0B RID: 36619
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A60 RID: 2656
		private sealed class MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04008F0C RID: 36620
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A61 RID: 2657
		private sealed class MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04008F0D RID: 36621
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
